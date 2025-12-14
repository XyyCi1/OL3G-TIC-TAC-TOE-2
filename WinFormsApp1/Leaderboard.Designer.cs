namespace WinFormsApp1
{
    partial class Leaderboard
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dataGridLeaderboard = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridLeaderboard).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(25, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 458);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(46, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(397, 409);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // dataGridLeaderboard
            // 
            dataGridLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLeaderboard.Location = new Point(57, 107);
            dataGridLeaderboard.Name = "dataGridLeaderboard";
            dataGridLeaderboard.Size = new Size(373, 337);
            dataGridLeaderboard.TabIndex = 3;
            dataGridLeaderboard.CellContentClick += dataGridLeaderboard_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 466);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 66);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 5;
            label1.Text = "LEADERBOARD";
            // 
            // Leaderboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 524);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridLeaderboard);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Leaderboard";
            Text = "Leaderboard";
            Load += Leaderboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridLeaderboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dataGridLeaderboard;
        private Button button1;
        private Label label1;
    }
}