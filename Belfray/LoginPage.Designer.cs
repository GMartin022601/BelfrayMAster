namespace Belfray
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.picUsernameIcon = new System.Windows.Forms.PictureBox();
            this.picPasswordIcon = new System.Windows.Forms.PictureBox();
            this.lblForgotPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.pnlMainWindow = new System.Windows.Forms.Panel();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.picUsernameIcon);
            this.pnlLogin.Controls.Add(this.picPasswordIcon);
            this.pnlLogin.Controls.Add(this.lblForgotPW);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.picHeader);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1220, 607);
            this.pnlLogin.TabIndex = 20;
            // 
            // picUsernameIcon
            // 
            this.picUsernameIcon.BackColor = System.Drawing.Color.Transparent;
            this.picUsernameIcon.Image = global::Belfray.Properties.Resources.edit;
            this.picUsernameIcon.Location = new System.Drawing.Point(460, 236);
            this.picUsernameIcon.Name = "picUsernameIcon";
            this.picUsernameIcon.Size = new System.Drawing.Size(35, 30);
            this.picUsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsernameIcon.TabIndex = 24;
            this.picUsernameIcon.TabStop = false;
            // 
            // picPasswordIcon
            // 
            this.picPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.picPasswordIcon.Image = global::Belfray.Properties.Resources.edit;
            this.picPasswordIcon.Location = new System.Drawing.Point(460, 276);
            this.picPasswordIcon.Name = "picPasswordIcon";
            this.picPasswordIcon.Size = new System.Drawing.Size(35, 30);
            this.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPasswordIcon.TabIndex = 23;
            this.picPasswordIcon.TabStop = false;
            // 
            // lblForgotPW
            // 
            this.lblForgotPW.AutoSize = true;
            this.lblForgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblForgotPW.Location = new System.Drawing.Point(579, 356);
            this.lblForgotPW.Name = "lblForgotPW";
            this.lblForgotPW.Size = new System.Drawing.Size(106, 15);
            this.lblForgotPW.TabIndex = 22;
            this.lblForgotPW.Text = "Forgot Password?";
            this.lblForgotPW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(531, 316);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 30);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPassword.Location = new System.Drawing.Point(501, 276);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 30);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsername.Location = new System.Drawing.Point(501, 236);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(260, 30);
            this.txtUsername.TabIndex = 19;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // picHeader
            // 
            this.picHeader.Image = global::Belfray.Properties.Resources.HeaderImageTemplate__1_;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(1220, 114);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 1;
            this.picHeader.TabStop = false;
            // 
            // pnlMainWindow
            // 
            this.pnlMainWindow.Location = new System.Drawing.Point(0, -1);
            this.pnlMainWindow.Name = "pnlMainWindow";
            this.pnlMainWindow.Size = new System.Drawing.Size(1220, 606);
            this.pnlMainWindow.TabIndex = 26;
            this.pnlMainWindow.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 605);
            this.Controls.Add(this.pnlMainWindow);
            this.Controls.Add(this.pnlLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login : Welcome to The Belfray Country Inn";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picUsernameIcon;
        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.Label lblForgotPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Panel pnlMainWindow;
    }
}