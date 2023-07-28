namespace DoctorSoftware
{
    partial class MadicalHistory
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
            this.medicalHistory_pic = new System.Windows.Forms.PictureBox();
            this.historyshow = new System.Windows.Forms.RichTextBox();
            this.search_bt = new System.Windows.Forms.Button();
            this.searce_tb = new System.Windows.Forms.TextBox();
            this.exit_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistory_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalHistory_pic
            // 
            this.medicalHistory_pic.Image = global::DoctorSoftware___Final_Project.Properties.Resources.medicalHistory;
            this.medicalHistory_pic.Location = new System.Drawing.Point(0, 0);
            this.medicalHistory_pic.Name = "medicalHistory_pic";
            this.medicalHistory_pic.Size = new System.Drawing.Size(850, 450);
            this.medicalHistory_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicalHistory_pic.TabIndex = 11;
            this.medicalHistory_pic.TabStop = false;
            this.medicalHistory_pic.Click += new System.EventHandler(this.medicalHistory_pic_Click);
            // 
            // historyshow
            // 
            this.historyshow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.historyshow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyshow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyshow.Location = new System.Drawing.Point(64, 194);
            this.historyshow.Margin = new System.Windows.Forms.Padding(1);
            this.historyshow.Name = "historyshow";
            this.historyshow.Size = new System.Drawing.Size(721, 203);
            this.historyshow.TabIndex = 14;
            this.historyshow.Text = "";
            // 
            // search_bt
            // 
            this.search_bt.BackColor = System.Drawing.Color.Transparent;
            this.search_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_bt.FlatAppearance.BorderSize = 0;
            this.search_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.search_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_bt.Location = new System.Drawing.Point(498, 116);
            this.search_bt.Margin = new System.Windows.Forms.Padding(1);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(36, 40);
            this.search_bt.TabIndex = 13;
            this.search_bt.UseVisualStyleBackColor = false;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // searce_tb
            // 
            this.searce_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searce_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searce_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searce_tb.Location = new System.Drawing.Point(325, 126);
            this.searce_tb.Margin = new System.Windows.Forms.Padding(1);
            this.searce_tb.Name = "searce_tb";
            this.searce_tb.Size = new System.Drawing.Size(150, 19);
            this.searce_tb.TabIndex = 12;
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Location = new System.Drawing.Point(809, 23);
            this.exit_bt.Margin = new System.Windows.Forms.Padding(1);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(31, 30);
            this.exit_bt.TabIndex = 15;
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // MadicalHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.historyshow);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.searce_tb);
            this.Controls.Add(this.medicalHistory_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MadicalHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MadicalHistory";
            this.Load += new System.EventHandler(this.MadicalHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistory_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox medicalHistory_pic;
        private RichTextBox historyshow;
        private Button search_bt;
        private TextBox searce_tb;
        private Button exit_bt;
    }
}