using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Play : Form
    {
        private string currentUsername;
        private Button[] cells;
        private char[] board;
        private char playerSymbol = 'X';
        private char cpuSymbol = 'O';
        private bool playerStartsThisRound = true;
        private bool roundActive = true;

        private int playerWins = 0;
        private int cpuWins = 0;
        private int draws = 0;

        public Play(string username)
        {
            InitializeComponent();
            currentUsername = username;
            SetupBoardArray();
            StartNewRound();

        }

        private void SetupBoardArray()
        {
          
            cells = new Button[]
            {
                button0, button1, button2,
                button3, button4, button5,
                button6, button7, button8
            };

            foreach (var btn in cells)
                btn.Click += OnCellClick;
        }


        private void StartNewRound()
        {
            board = Enumerable.Repeat(' ', 9).ToArray();
            foreach (var b in cells)
            {
                b.Enabled = true;
                b.Text = "";
                b.BackgroundImage = null; 
            }
            roundActive = true;

            lblStatus.Text = playerStartsThisRound
                ? "Player starts. Your move."
                : "CPU starts. Thinking...";

            btnNextRound.Enabled = false;
            if (!playerStartsThisRound)
            {
                this.BeginInvoke(new Action(() =>
                {
                    CpuMove();
                    lblStatus.Text = "Your move.";
                }));
            }
        }


        private async void OnCellClick(object sender, EventArgs e)
        {
            if (!roundActive) return;
            var btn = (Button)sender;
            int idx = Array.IndexOf(cells, btn);

            if (board[idx] != ' ') return;

         
            board[idx] = playerSymbol;
            btn.BackgroundImage = Properties.Resources.X;

         
            foreach (var b in cells) b.Enabled = false;

            if (CheckWin(playerSymbol)) { EndRound(playerSymbol); return; }
            if (IsBoardFull()) { EndRound('D'); return; }

           
            lblStatus.Text = "CPU is thinking...";
            await Task.Delay(500); 

          
            CpuMove();

            if (CheckWin(cpuSymbol)) { EndRound(cpuSymbol); return; }
            if (IsBoardFull()) { EndRound('D'); return; }

         
            if (roundActive)
            {
                for (int i = 0; i < cells.Length; i++)
                {
                    if (board[i] == ' ') cells[i].Enabled = true;
                }
                lblStatus.Text = "Your move.";
            }
        }


        private void EndRound(char winner)
        {
            roundActive = false;
            foreach (var b in cells) b.Enabled = false;

            var conn = Database.GetConnection();
            if (winner == playerSymbol)
            {
                playerWins++;
                lblStatus.Text = "You won!";
                MessageBox.Show("Congratulations! You won this round.", "Victory", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var account = conn.Table<UserAccount>()
                                  .FirstOrDefault(u => u.Username == currentUsername);
                if (account != null)
                {
                    account.Wins += 1;
                    conn.Update(account);
                }
            }
            else if (winner == cpuSymbol)
            {
                cpuWins++;
                lblStatus.Text = "CPU won.";
                MessageBox.Show("CPU wins this round. Better luck next time!", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                draws++;
                lblStatus.Text = "Draw.";
                MessageBox.Show("This round ended in a draw.", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            var record = new MatchRecord
            {
                Username = currentUsername,
                Opponent = "CPU", 
                Result = winner == playerSymbol ? "Win" :
                         winner == cpuSymbol ? "Loss" : "Draw",
                DatePlayed = DateTime.Now
            };
            conn.Insert(record);

            UpdateScoreLabels();
            btnNextRound.Enabled = true;
        }

        private void UpdateScoreLabels()
        {
            lblPlayerScore.Text = $"Player: {playerWins}";
            lblCpuScore.Text = $"CPU: {cpuWins}";
            lblDraws.Text = $"Draws: {draws}";
        }

        private bool IsBoardFull() => board.All(c => c != ' ');

        private bool CheckWin(char symbol)
        {
            int[][] lines = {
                new[]{0,1,2}, new[]{3,4,5}, new[]{6,7,8},
                new[]{0,3,6}, new[]{1,4,7}, new[]{2,5,8},
                new[]{0,4,8}, new[]{2,4,6}
            };
            return lines.Any(line => line.All(i => board[i] == symbol));
        }

        private void CpuMove()
        {
            if (!roundActive) return;
            int move = ChooseCpuMove();
            if (move >= 0)
            {
                board[move] = cpuSymbol;
                cells[move].BackgroundImage = Properties.Resources.O; 
            }
        }

        private int ChooseCpuMove()
        {
            Random rnd = new Random();
            if (rnd.Next(100) < 12)
            {

                var empty = Enumerable.Range(0, 9).Where(i => board[i] == ' ').ToList();
                return empty[rnd.Next(empty.Count)];
            }


            int win = FindWinningMove(cpuSymbol);
            if (win >= 0) return win;

            int block = FindWinningMove(playerSymbol);
            if (block >= 0) return block;

            if (board[4] == ' ') return 4;

            int[] corners = { 0, 2, 6, 8 };
            foreach (var c in corners) if (board[c] == ' ') return c;

            int[] sides = { 1, 3, 5, 7 };
            foreach (var s in sides) if (board[s] == ' ') return s;

            return Array.FindIndex(board, c => c == ' ');
        }

        private int FindWinningMove(char symbol)
        {
            int[][] lines = {
                new[]{0,1,2}, new[]{3,4,5}, new[]{6,7,8},
                new[]{0,3,6}, new[]{1,4,7}, new[]{2,5,8},
                new[]{0,4,8}, new[]{2,4,6}
            };
            foreach (var line in lines)
            {
                int a = line[0], b = line[1], c = line[2];
                if (board[a] == symbol && board[b] == symbol && board[c] == ' ') return c;
                if (board[a] == symbol && board[c] == symbol && board[b] == ' ') return b;
                if (board[b] == symbol && board[c] == symbol && board[a] == ' ') return a;
            }
            return -1;
        }

        private void btnNextRound_Click(object sender, EventArgs e)
        {
            playerStartsThisRound = !playerStartsThisRound;
            StartNewRound();
        }







      
        private void btnNextRound_Click_1(object sender, EventArgs e)
        {
            playerStartsThisRound = !playerStartsThisRound;
            StartNewRound();
        }

     
    }
}
