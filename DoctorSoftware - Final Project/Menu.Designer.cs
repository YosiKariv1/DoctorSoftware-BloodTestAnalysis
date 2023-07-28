namespace DoctorSoftware
{
    partial class Menu
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
            this.menu_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_bt = new System.Windows.Forms.Button();
            this.np_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.mh_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menu_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_pic
            // 
            this.menu_pic.Image = global::DoctorSoftware___Final_Project.Properties.Resources.menu;
            this.menu_pic.Location = new System.Drawing.Point(0, 0);
            this.menu_pic.Name = "menu_pic";
            this.menu_pic.Size = new System.Drawing.Size(850, 450);
            this.menu_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu_pic.TabIndex = 13;
            this.menu_pic.TabStop = false;
            this.menu_pic.Click += new System.EventHandler(this.menu_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(858, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "exemple";
            // 
            // logout_bt
            // 
            this.logout_bt.BackColor = System.Drawing.Color.Transparent;
            this.logout_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_bt.FlatAppearance.BorderSize = 0;
            this.logout_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logout_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logout_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_bt.Location = new System.Drawing.Point(381, 411);
            this.logout_bt.Name = "logout_bt";
            this.logout_bt.Size = new System.Drawing.Size(88, 27);
            this.logout_bt.TabIndex = 14;
            this.logout_bt.UseVisualStyleBackColor = false;
            this.logout_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // np_bt
            // 
            this.np_bt.BackColor = System.Drawing.Color.Transparent;
            this.np_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.np_bt.FlatAppearance.BorderSize = 0;
            this.np_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.np_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.np_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.np_bt.Location = new System.Drawing.Point(259, 193);
            this.np_bt.Name = "np_bt";
            this.np_bt.Size = new System.Drawing.Size(148, 136);
            this.np_bt.TabIndex = 15;
            this.np_bt.UseVisualStyleBackColor = false;
            this.np_bt.Click += new System.EventHandler(this.np_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Location = new System.Drawing.Point(799, 24);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(39, 31);
            this.exit_bt.TabIndex = 16;
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // mh_bt
            // 
            this.mh_bt.BackColor = System.Drawing.Color.Transparent;
            this.mh_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mh_bt.FlatAppearance.BorderSize = 0;
            this.mh_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mh_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mh_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mh_bt.Location = new System.Drawing.Point(446, 193);
            this.mh_bt.Name = "mh_bt";
            this.mh_bt.Size = new System.Drawing.Size(143, 136);
            this.mh_bt.TabIndex = 17;
            this.mh_bt.UseVisualStyleBackColor = false;
            this.mh_bt.Click += new System.EventHandler(this.mh_bt_Click);
            // 
            // Menu
            //
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_bt);
            this.Controls.Add(this.np_bt);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.mh_bt);
            this.Controls.Add(this.menu_pic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox menu_pic;
        private Label label1;
        private Button logout_bt;
        private Button np_bt;
        private Button exit_bt;
        private Button mh_bt;
    }
}