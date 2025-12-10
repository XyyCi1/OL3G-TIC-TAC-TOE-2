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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxUname
            // 
            textBoxUname.Location = new Point(47, 66);
            textBoxUname.Name = "textBoxUname";
            textBoxUname.PlaceholderText = "Username....";
            textBoxUname.Size = new Size(155, 23);
            textBoxUname.TabIndex = 0;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(47, 113);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '•';
            textBoxPass.PlaceholderText = "Password....";
            textBoxPass.Size = new Size(155, 23);
            textBoxPass.TabIndex = 0;
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // textBoxCPass
            // 
            textBoxCPass.Location = new Point(47, 167);
            textBoxCPass.Name = "textBoxCPass";
            textBoxCPass.PasswordChar = '•';
            textBoxCPass.PlaceholderText = "Confirm Password....";
            textBoxCPass.Size = new Size(155, 23);
            textBoxCPass.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(89, 214);
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
            label1.Location = new Point(83, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 48);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 95);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Password:";
        
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 149);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password:";
      
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(246, 264);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
    }
}