using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            var conn = Database.GetConnection();
            var users = conn.Table<UserAccount>().ToList();
            var leaderboard = new List<LeadboardWR>();

            foreach (var user in users)
            {
                int matchCount = conn.Table<MatchRecord>()
                                     .Count(m => m.Username == user.Username);

                leaderboard.Add(new LeadboardWR
                {
                    Username = user.Username,
                    Wins = user.Wins,
                    MatchCount = matchCount
                });
            }

       
            leaderboard = leaderboard.OrderByDescending(e => e.Wins).ToList();

            dataGridLeaderboard.DataSource = leaderboard;


            dataGridLeaderboard.Columns["Username"].HeaderText = "Player";
            dataGridLeaderboard.Columns["Wins"].HeaderText = "Wins";
            dataGridLeaderboard.Columns["MatchCount"].HeaderText = "Matches";
            dataGridLeaderboard.Columns["WinRate"].HeaderText = "Win Rate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridLeaderboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
