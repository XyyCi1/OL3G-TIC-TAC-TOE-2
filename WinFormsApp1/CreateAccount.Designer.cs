namespace WinFormsApp1
{
    partial class CreateAccount
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
            textBoxUname = new TextBox();
            textBoxPass = new TextBox();
            textBoxCPass = new TextBox();
            buttonCreate = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxUname
            // 
            textBoxUname.Location = new Point(127, 68);
            textBoxUname.Name = "textBoxUname";
            textBoxUname.PlaceholderText = "Username....";
            textBoxUname.Size = new Size(155, 23);
            textBoxUname.TabIndex = 0;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(127, 106);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '•';
            textBoxPass.PlaceholderText = "Password....";
            textBoxPass.Size = new Size(155, 23);
            textBoxPass.TabIndex = 0;
            // 
            // textBoxCPass
            // 
            textBoxCPass.Location = new Point(127, 147);
            textBoxCPass.Name = "textBoxCPass";
            textBoxCPass.PasswordChar = '•';
            textBoxCPass.PlaceholderText = "Confirm Password....";
            textBoxCPass.Size = new Size(155, 23);
            textBoxCPass.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(163, 193);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(387, 264);
            Controls.Add(label1);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxCPass);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUname);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBoxUname;
        private TextBox textBoxPass;
        private TextBox textBoxCPass;
        private Button buttonCreate;
        private Label label1;
    }
}