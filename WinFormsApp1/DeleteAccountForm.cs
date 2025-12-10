using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DeleteAccountForm : Form
    {
        private readonly string _username;

        public DeleteAccountForm(string username)
        {
            InitializeComponent();
            _username = username;
            labelInfo.Text = $"Enter password for '{_username}' to confirm deletion.";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var entered = textBoxPassword.Text ?? string.Empty;

            if (string.IsNullOrEmpty(entered))
            {
                MessageBox.Show("Please enter your password.", "Missing password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conn = Database.GetConnection();

            var account = conn.Table<UserAccount>().FirstOrDefault(u => u.Username == _username);
            if (account == null)
            {
                MessageBox.Show("Account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            if (account.Password != entered)
            {
                MessageBox.Show("Incorrect password. Account not deleted.", "Authentication failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Delete related match records where the user is either the player or opponent (parameterized)
            conn.Execute("DELETE FROM MatchRecord WHERE Username = ? OR Opponent = ?", _username, _username);

            // Delete the user account
            conn.Delete(account);

            // Success
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}