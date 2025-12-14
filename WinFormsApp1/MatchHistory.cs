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
    public partial class MatchHistory : Form
    {

        private string currentUsername;
        public MatchHistory(string username)
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void MatchHistory_Load(object sender, EventArgs e)
        {
            var conn = Database.GetConnection();

            var history = conn.Table<MatchRecord>()
                              .Where(m => m.Username == currentUsername)
                              .OrderByDescending(m => m.DatePlayed)
                              .ToList();

            dataGridHistory.DataSource = history;


            dataGridHistory.Columns["Id"].Visible = false;
            dataGridHistory.Columns["Username"].HeaderText = "Player";
            dataGridHistory.Columns["Opponent"].HeaderText = "Opponent";
            dataGridHistory.Columns["Result"].HeaderText = "Result";
            dataGridHistory.Columns["DatePlayed"].HeaderText = "Date";
        }

        private void dataGridHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
