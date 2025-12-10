namespace WinFormsApp1
{
    partial class DeleteAccountForm
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo = new Label();
            textBoxPassword = new TextBox();
            buttonCancel = new Button();
            buttonDelete = new Button();
            labelPassword = new Label();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfo.Location = new Point(18, 18);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(195, 20);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Enter your password to delete.";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(22, 73);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '•';
            textBoxPassword.Size = new Size(360, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(22, 116);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 32);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(267, 116);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(115, 32);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(22, 50);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // DeleteAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 166);
            Controls.Add(labelPassword);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxPassword);
            Controls.Add(labelInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteAccountForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Confirm Account Deletion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private TextBox textBoxPassword;
        private Button buttonCancel;
        private Button buttonDelete;
        private Label labelPassword;
    }
}