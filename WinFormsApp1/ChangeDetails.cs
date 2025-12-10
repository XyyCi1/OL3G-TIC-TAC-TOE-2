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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class ChangeDetails : Form
    {
        private int _accountId;

        private void ChangeDetails_Load(object sender, EventArgs e)
        {

        }

        public ChangeDetails(int accountId)
        {
            InitializeComponent();
            _accountId = accountId;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string newUsername = textBoxNewUsername.Text.Trim();
            string newPassword = textBoxNewPassword.Text;
            string confirmPassword = textBoxConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show( "Username and password cannot be empty.");
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show( "Passwords do not match.");
                return;
            }

            var conn = Database.GetConnection();

        
            var account = conn.Table<UserAccount>()
                              .FirstOrDefault(u => u.Id == _accountId);
            if (account == null)
            {
                MessageBox.Show("Account not found.");
                return;
            }

         
            var existing = conn.Table<UserAccount>()
                               .FirstOrDefault(u => u.Username == newUsername && u.Id != _accountId);
            if (existing != null)
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            string oldUsername = account.Username;

     
            account.Username = newUsername;
            account.Password = newPassword;
            conn.Update(account);

            var history = conn.Table<MatchRecord>()
                              .Where(m => m.Username == oldUsername)
                              .ToList();
            foreach (var record in history)
            {
                record.Username = newUsername;
                conn.Update(record);
            }

            MessageBox.Show( "Account details updated successfully.");
        }




       

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
          
            this.Close();
        }
    }
}
