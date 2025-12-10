namespace WinFormsApp1
{
    public partial class LogInMenu : Form
    {
        public LogInMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PlaceholderText = "Enter text here";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //login button
        {
            string user = textBoxUsername.Text.Trim();
            string pass = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            var db = Database.GetConnection();

            // Look for a user with matching username and password
            var account = db.Table<UserAccount>()
                            .FirstOrDefault(u => u.Username == user && u.Password == pass);

            if (account != null)
            {
                // ? Pass both Id and Username into HomeMenu
                HomeMenu home = new HomeMenu(account.Id, account.Username);
                home.Show();
                this.Hide(); // hide login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e) //create account button
        {
            CreateAccount main = new CreateAccount();
            main.Show();
            this.Hide();
        }

        private void LogInMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
