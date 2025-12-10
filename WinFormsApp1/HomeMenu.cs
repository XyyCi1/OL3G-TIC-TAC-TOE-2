using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class HomeMenu : Form
    {
        private int _accountId;
        private string _username;
        private string _password;

        public HomeMenu(int accountId, string username)
        {
            InitializeComponent();
            _accountId = accountId;
            _username = username;
        }

        public void HomeMenu_Load(object sender, EventArgs e)
        {


            labelUsername.Text = _username + "!";
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Play playForm = new Play(_username);
            playForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchHistory historyForm = new MatchHistory(_username);
            historyForm.Show();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            ChangeDetails changeForm = new ChangeDetails(_accountId);
            changeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (var dlg = new DeleteAccountForm(_username))
            {
                var result = dlg.ShowDialog(this);
                if (result == DialogResult.OK)
                {

                    MessageBox.Show("Your account has been deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var login = new LogInMenu();
                    login.Show();
                    this.Close();
                }
            }
        }

        // Logout button handler: show login form and close this one
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            var login = new LogInMenu();
            login.Show();
            this.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            var conn = Database.GetConnection();

            // ✅ Query by accountId to get latest info
            var account = conn.Table<UserAccount>()
                              .FirstOrDefault(u => u.Id == _accountId);

            if (account != null)
            {
                _username = account.Username;         // update local copy
                labelUsername.Text = _username + "!";       // update label

                // Optional: if you show wins or other stats
                // labelWins.Text = $"Wins: {account.Wins}";
            }
            else
            {
                MessageBox.Show("Account not found.");
            }

        }
    }
}