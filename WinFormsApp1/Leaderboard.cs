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

            // Get all accounts sorted by Wins descending
            var topAccounts = conn.Table<UserAccount>()
                                  .OrderByDescending(u => u.Wins)
                                  .ToList();

            // Bind directly to DataGridView
            dataGridLeaderboard.DataSource = topAccounts;

            // Optional: adjust columns
            dataGridLeaderboard.Columns["Id"].Visible = false;        // hide internal ID
            dataGridLeaderboard.Columns["Password"].Visible = false;  // hide password
            dataGridLeaderboard.Columns["Username"].HeaderText = "Player";
            dataGridLeaderboard.Columns["Wins"].HeaderText = "Wins";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
