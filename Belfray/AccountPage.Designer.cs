namespace Belfray
{
    partial class AccountPage
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
            this.pnlProfilePic = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.pnlAccountSettings = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlProfilePic
            // 
            this.pnlProfilePic.BackColor = System.Drawing.Color.White;
            this.pnlProfilePic.Location = new System.Drawing.Point(4, 1);
            this.pnlProfilePic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProfilePic.Name = "pnlProfilePic";
            this.pnlProfilePic.Size = new System.Drawing.Size(510, 534);
            this.pnlProfilePic.TabIndex = 10;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.White;
            this.pnlUserInfo.Location = new System.Drawing.Point(524, 1);
            this.pnlUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(774, 534);
            this.pnlUserInfo.TabIndex = 9;
            // 
            // pnlAccountSettings
            // 
            this.pnlAccountSettings.BackColor = System.Drawing.Color.White;
            this.pnlAccountSettings.Location = new System.Drawing.Point(1306, 1);
            this.pnlAccountSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAccountSettings.Name = "pnlAccountSettings";
            this.pnlAccountSettings.Size = new System.Drawing.Size(520, 533);
            this.pnlAccountSettings.TabIndex = 8;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 537);
            this.Controls.Add(this.pnlProfilePic);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.pnlAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfilePic;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlAccountSettings;
    }
}