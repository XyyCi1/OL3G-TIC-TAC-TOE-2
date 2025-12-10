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

       
            var topAccounts = conn.Table<UserAccount>()
                                  .OrderByDescending(u => u.Wins)
                                  .ToList();

        
            dataGridLeaderboard.DataSource = topAccounts;

            dataGridLeaderboard.Columns["Id"].Visible = false;        
            dataGridLeaderboard.Columns["Password"].Visible = false;  
            dataGridLeaderboard.Columns["Username"].HeaderText = "Player";
            dataGridLeaderboard.Columns["Wins"].HeaderText = "Wins";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
