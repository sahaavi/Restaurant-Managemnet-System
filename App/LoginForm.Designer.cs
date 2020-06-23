namespace App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.l_login = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.BackColor = System.Drawing.Color.Transparent;
            this.l_login.Font = new System.Drawing.Font("League Spartan", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_login.Location = new System.Drawing.Point(148, 81);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(189, 60);
            this.l_login.TabIndex = 0;
            this.l_login.Text = "LOGIN";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.BackColor = System.Drawing.Color.Transparent;
            this.l_username.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_username.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_username.Location = new System.Drawing.Point(44, 206);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(140, 37);
            this.l_username.TabIndex = 1;
            this.l_username.Text = "Username";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.BackColor = System.Drawing.Color.Transparent;
            this.l_password.Font = new System.Drawing.Font("Bebas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_password.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_password.Location = new System.Drawing.Point(44, 258);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(143, 37);
            this.l_password.TabIndex = 2;
            this.l_password.Text = "Password";
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(196, 214);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(187, 22);
            this.t_username.TabIndex = 3;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(196, 266);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(187, 22);
            this.t_password.TabIndex = 4;
            this.t_password.UseSystemPasswordChar = true;
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.MistyRose;
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.b_login.Location = new System.Drawing.Point(167, 377);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(120, 44);
            this.b_login.TabIndex = 5;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 491);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Controls.Add(this.l_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox t_username;
        private System.Windows.Forms.TextBox t_password;
        private System.Windows.Forms.Button b_login;
    }
}

