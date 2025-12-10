namespace WinFormsApp1
{
    partial class ChangeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNewUsername = new TextBox();
            textBoxNewPassword = new TextBox();
            btnChange = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxConfirmPassword = new TextBox();
            lblpw = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxNewUsername
            // 
            textBoxNewUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNewUsername.Location = new Point(53, 37);
            textBoxNewUsername.Margin = new Padding(3, 2, 3, 2);
            textBoxNewUsername.Name = "textBoxNewUsername";
            textBoxNewUsername.PlaceholderText = "New Username...";
            textBoxNewUsername.Size = new Size(204, 30);
            textBoxNewUsername.TabIndex = 1;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNewPassword.Location = new Point(53, 99);
            textBoxNewPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.PasswordChar = '•';
            textBoxNewPassword.PlaceholderText = "New Password...";
            textBoxNewPassword.Size = new Size(204, 30);
            textBoxNewPassword.TabIndex = 2;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(27, 242);
            btnChange.Margin = new Padding(3, 2, 3, 2);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(101, 41);
            btnChange.TabIndex = 3;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 242);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 41);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 20);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "New Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 82);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 5;
            label2.Text = "New Password:";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(53, 163);
            textBoxConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '•';
            textBoxConfirmPassword.PlaceholderText = "Confirm Password...";
            textBoxConfirmPassword.Size = new Size(204, 30);
            textBoxConfirmPassword.TabIndex = 2;
            // 
            // lblpw
            // 
            lblpw.AutoSize = true;
            lblpw.Location = new Point(56, 146);
            lblpw.Name = "lblpw";
            lblpw.Size = new Size(107, 15);
            lblpw.TabIndex = 5;
            lblpw.Text = "Confirm Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Location = new Point(0, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 84);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ChangeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 304);
            Controls.Add(lblpw);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnChange);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxNewPassword);
            Controls.Add(textBoxNewUsername);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChangeDetails";
            Text = "ChangeDetails";
            Load += ChangeDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewUsername;
        private TextBox textBoxNewPassword;
        private Button btnChange;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private TextBox textBoxConfirmPassword;
        private Label lblpw;
        private PictureBox pictureBox1;
    }
}