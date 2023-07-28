namespace DoctorSoftware
{
    partial class DiagnosticForm
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
            this.diagnostic_pic = new System.Windows.Forms.PictureBox();
            this.exit_bt = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnostic_pic
            // 
            this.diagnostic_pic.Image = global::DoctorSoftware___Final_Project.Properties.Resources.diagnosticform;
            this.diagnostic_pic.Location = new System.Drawing.Point(0, 0);
            this.diagnostic_pic.Name = "diagnostic_pic";
            this.diagnostic_pic.Size = new System.Drawing.Size(850, 450);
            this.diagnostic_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diagnostic_pic.TabIndex = 0;
            this.diagnostic_pic.TabStop = false;
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Location = new System.Drawing.Point(811, 26);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(27, 27);
            this.exit_bt.TabIndex = 16;
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(54, 308);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(732, 104);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(54, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(732, 104);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // DiagnosticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.diagnostic_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DiagnosticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiagnosticForm";
            this.Load += new System.EventHandler(this.DiagnosticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnostic_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox diagnostic_pic;
        private Button exit_bt;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
    }
}