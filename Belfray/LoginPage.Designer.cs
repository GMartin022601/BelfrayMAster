﻿namespace Belfray
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
            this.lblForgotPW = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.picPasswordIcon = new System.Windows.Forms.PictureBox();
            this.picUsernameIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForgotPW
            // 
            this.lblForgotPW.AutoSize = true;
            this.lblForgotPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblForgotPW.Location = new System.Drawing.Point(731, 418);
            this.lblForgotPW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgotPW.Name = "lblForgotPW";
            this.lblForgotPW.Size = new System.Drawing.Size(131, 18);
            this.lblForgotPW.TabIndex = 15;
            this.lblForgotPW.Text = "Forgot Password?";
            this.lblForgotPW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnLogin.Location = new System.Drawing.Point(667, 369);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(267, 37);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtPassword.Location = new System.Drawing.Point(627, 320);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(345, 36);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtUsername.Location = new System.Drawing.Point(627, 271);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(345, 36);
            this.txtUsername.TabIndex = 12;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // picHeader
            // 
            this.picHeader.Image = global::Belfray.Properties.Resources.HeaderImageTemplate__1_;
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(1627, 140);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 0;
            this.picHeader.TabStop = false;
            // 
            // picPasswordIcon
            // 
            this.picPasswordIcon.BackColor = System.Drawing.Color.Transparent;
            this.picPasswordIcon.Image = global::Belfray.Properties.Resources.edit;
            this.picPasswordIcon.Location = new System.Drawing.Point(572, 320);
            this.picPasswordIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPasswordIcon.Name = "picPasswordIcon";
            this.picPasswordIcon.Size = new System.Drawing.Size(47, 37);
            this.picPasswordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPasswordIcon.TabIndex = 17;
            this.picPasswordIcon.TabStop = false;
            // 
            // picUsernameIcon
            // 
            this.picUsernameIcon.BackColor = System.Drawing.Color.Transparent;
            this.picUsernameIcon.Image = global::Belfray.Properties.Resources.edit;
            this.picUsernameIcon.Location = new System.Drawing.Point(572, 271);
            this.picUsernameIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picUsernameIcon.Name = "picUsernameIcon";
            this.picUsernameIcon.Size = new System.Drawing.Size(47, 37);
            this.picUsernameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsernameIcon.TabIndex = 18;
            this.picUsernameIcon.TabStop = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1627, 745);
            this.Controls.Add(this.picUsernameIcon);
            this.Controls.Add(this.picPasswordIcon);
            this.Controls.Add(this.lblForgotPW);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login : Welcome to The Belfray Country Inn";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPasswordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsernameIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblForgotPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox picPasswordIcon;
        private System.Windows.Forms.PictureBox picUsernameIcon;
    }
}