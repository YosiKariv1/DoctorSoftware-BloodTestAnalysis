namespace DoctorSoftware
{
    partial class Login
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
            this.login_pic = new System.Windows.Forms.PictureBox();
            this.register_bt = new System.Windows.Forms.Button();
            this.exit_bt = new System.Windows.Forms.Button();
            this.user_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // login_pic
            // 
            this.login_pic.Image = global::DoctorSoftware___Final_Project.Properties.Resources.Login;
            this.login_pic.Location = new System.Drawing.Point(0, 0);
            this.login_pic.Name = "login_pic";
            this.login_pic.Size = new System.Drawing.Size(850, 450);
            this.login_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_pic.TabIndex = 7;
            this.login_pic.TabStop = false;
            this.login_pic.Click += new System.EventHandler(this.login_pic_Click);
            // 
            // register_bt
            // 
            this.register_bt.BackColor = System.Drawing.Color.Transparent;
            this.register_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_bt.FlatAppearance.BorderSize = 0;
            this.register_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.register_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.register_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_bt.Location = new System.Drawing.Point(539, 341);
            this.register_bt.Name = "register_bt";
            this.register_bt.Size = new System.Drawing.Size(75, 18);
            this.register_bt.TabIndex = 12;
            this.register_bt.UseVisualStyleBackColor = true;
            this.register_bt.Click += new System.EventHandler(this.register_bt_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Location = new System.Drawing.Point(800, 12);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(38, 38);
            this.exit_bt.TabIndex = 13;
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // user_tb
            // 
            this.user_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.user_tb.Location = new System.Drawing.Point(593, 153);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(204, 19);
            this.user_tb.TabIndex = 8;
            // 
            // id_tb
            // 
            this.id_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.id_tb.Location = new System.Drawing.Point(593, 213);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(204, 19);
            this.id_tb.TabIndex = 9;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_tb.ForeColor = System.Drawing.SystemColors.Desktop;
            this.password_tb.Location = new System.Drawing.Point(593, 270);
            this.password_tb.Name = "password_tb";
            this.password_tb.PasswordChar = '*';
            this.password_tb.Size = new System.Drawing.Size(204, 19);
            this.password_tb.TabIndex = 10;
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.Transparent;
            this.login_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_bt.FlatAppearance.BorderSize = 0;
            this.login_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bt.ForeColor = System.Drawing.Color.Coral;
            this.login_bt.Location = new System.Drawing.Point(670, 319);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(127, 40);
            this.login_bt.TabIndex = 11;
            this.login_bt.UseVisualStyleBackColor = true;
            this.login_bt.Click += new System.EventHandler(this.login_bt_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.register_bt);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.login_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocSoftware - Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox login_pic;
        private Button register_bt;
        private Button exit_bt;
        private TextBox user_tb;
        private TextBox id_tb;
        private TextBox password_tb;
        private Button login_bt;
    }
}