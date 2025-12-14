
namespace WinFormsApp1
{
    partial class LogInMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInMenu));
            pictureBox5 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            button1 = new Button();
            buttonCreateAcc = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaption;
            pictureBox5.Location = new Point(-47, 227);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(550, 199);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(148, 237);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username....";
            textBoxUsername.Size = new Size(178, 27);
            textBoxUsername.TabIndex = 7;
            textBoxUsername.TextChanged += textBox3_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(148, 270);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.PlaceholderText = "Password...";
            textBoxPassword.Size = new Size(178, 27);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(195, 303);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // buttonCreateAcc
            // 
            buttonCreateAcc.BackColor = SystemColors.Control;
            buttonCreateAcc.BackgroundImageLayout = ImageLayout.Center;
            buttonCreateAcc.FlatStyle = FlatStyle.Popup;
            buttonCreateAcc.Location = new Point(174, 357);
            buttonCreateAcc.Name = "buttonCreateAcc";
            buttonCreateAcc.Size = new Size(121, 23);
            buttonCreateAcc.TabIndex = 9;
            buttonCreateAcc.Text = "Create Account";
            buttonCreateAcc.UseVisualStyleBackColor = false;
            buttonCreateAcc.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(164, 339);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 10;
            label1.Text = "No Account? Create Here:";
            // 
            // LogInMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 399);
            Controls.Add(label1);
            Controls.Add(buttonCreateAcc);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(button1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            Name = "LogInMenu";
            Text = "Form1";
            Load += LogInMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button button1;
        private Button buttonCreateAcc;
        private Label label1;
    }
}
