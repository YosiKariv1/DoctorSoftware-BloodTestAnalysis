namespace DoctorSoftware
{
    partial class Register
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
            this.register_pic = new System.Windows.Forms.PictureBox();
            this.exit_bt = new System.Windows.Forms.Button();
            this.login_bt = new System.Windows.Forms.Button();
            this.register_bt = new System.Windows.Forms.Button();
            this.passwordAgain_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.user_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.register_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // register_pic
            // 
            this.register_pic.Image = global::DoctorSoftware___Final_Project.Properties.Resources.register;
            this.register_pic.Location = new System.Drawing.Point(0, 0);
            this.register_pic.Name = "register_pic";
            this.register_pic.Size = new System.Drawing.Size(850, 450);
            this.register_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.register_pic.TabIndex = 17;
            this.register_pic.TabStop = false;
            this.register_pic.Click += new System.EventHandler(this.register_pic_Click);
            // 
            // exit_bt
            // 
            this.exit_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_bt.FlatAppearance.BorderSize = 0;
            this.exit_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bt.Location = new System.Drawing.Point(803, 22);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(35, 27);
            this.exit_bt.TabIndex = 22;
            this.exit_bt.UseVisualStyleBackColor = false;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // login_bt
            // 
            this.login_bt.BackColor = System.Drawing.Color.Transparent;
            this.login_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_bt.FlatAppearance.BorderSize = 0;
            this.login_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bt.Location = new System.Drawing.Point(537, 371);
            this.login_bt.Name = "login_bt";
            this.login_bt.Size = new System.Drawing.Size(50, 12);
            this.login_bt.TabIndex = 24;
            this.login_bt.UseVisualStyleBackColor = false;
            this.login_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // register_bt
            // 
            this.register_bt.BackColor = System.Drawing.Color.Transparent;
            this.register_bt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_bt.FlatAppearance.BorderSize = 0;
            this.register_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.register_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.register_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_bt.Location = new System.Drawing.Point(666, 348);
            this.register_bt.Name = "register_bt";
            this.register_bt.Size = new System.Drawing.Size(138, 35);
            this.register_bt.TabIndex = 23;
            this.register_bt.UseVisualStyleBackColor = false;
            this.register_bt.Click += new System.EventHandler(this.register_bt_Click);
            // 
            // passwordAgain_tb
            // 
            this.passwordAgain_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordAgain_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordAgain_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordAgain_tb.ForeColor = System.Drawing.Color.Black;
            this.passwordAgain_tb.Location = new System.Drawing.Point(593, 298);
            this.passwordAgain_tb.Name = "passwordAgain_tb";
            this.passwordAgain_tb.Size = new System.Drawing.Size(199, 19);
            this.passwordAgain_tb.TabIndex = 21;
            // 
            // password_tb
            // 
            this.password_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_tb.ForeColor = System.Drawing.Color.Black;
            this.password_tb.Location = new System.Drawing.Point(593, 240);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(199, 19);
            this.password_tb.TabIndex = 20;
            // 
            // id_tb
            // 
            this.id_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_tb.ForeColor = System.Drawing.Color.Black;
            this.id_tb.Location = new System.Drawing.Point(593, 184);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(199, 19);
            this.id_tb.TabIndex = 19;
            // 
            // user_tb
            // 
            this.user_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.user_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user_tb.ForeColor = System.Drawing.Color.Black;
            this.user_tb.Location = new System.Drawing.Point(593, 122);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(199, 19);
            this.user_tb.TabIndex = 18;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.login_bt);
            this.Controls.Add(this.register_bt);
            this.Controls.Add(this.passwordAgain_tb);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.register_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Page";
            this.Load += new System.EventHandler(this.RegisterPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.register_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox register_pic;
        private Button exit_bt;
        private Button login_bt;
        private Button register_bt;
        private TextBox passwordAgain_tb;
        private TextBox password_tb;
        private TextBox id_tb;
        private TextBox user_tb;
    }
}