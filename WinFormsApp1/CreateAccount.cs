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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }



        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string user = textBoxUname.Text.Trim();
            string pass = textBoxPass.Text;
            string confirm = textBoxCPass.Text;

            if (string.IsNullOrWhiteSpace(user) ||
                string.IsNullOrWhiteSpace(pass) ||
                string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var db = Database.GetConnection();

            var existing = db.Table<UserAccount>()
                             .FirstOrDefault(u => u.Username == user);

            if (existing != null)
            {
                MessageBox.Show("Username already taken.");
                return;
            }

            var account = new UserAccount
            {
                Username = user,
                Password = pass   
            };


            int success = db.Insert(account);


            if (success > 0)
            {
             
                MessageBox.Show("Account created! You can log in now.");

                LogInMenu login = new LogInMenu();   
                login.Show();
                this.Close(); 
            }
            else
            {
               
                MessageBox.Show("Could not create account. Please try again.");
            }


        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
