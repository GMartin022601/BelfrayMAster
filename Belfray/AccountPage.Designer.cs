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
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.gbEmergency = new System.Windows.Forms.GroupBox();
            this.gbAccountInfo = new System.Windows.Forms.GroupBox();
            this.pnlUserInfo.SuspendLayout();
            this.pnlAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfilePic
            // 
            this.pnlProfilePic.BackColor = System.Drawing.Color.White;
            this.pnlProfilePic.Location = new System.Drawing.Point(3, 1);
            this.pnlProfilePic.Name = "pnlProfilePic";
            this.pnlProfilePic.Size = new System.Drawing.Size(340, 347);
            this.pnlProfilePic.TabIndex = 10;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.White;
            this.pnlUserInfo.Controls.Add(this.gbEmergency);
            this.pnlUserInfo.Controls.Add(this.gbUserInfo);
            this.pnlUserInfo.Location = new System.Drawing.Point(349, 1);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(516, 347);
            this.pnlUserInfo.TabIndex = 9;
            // 
            // pnlAccountSettings
            // 
            this.pnlAccountSettings.BackColor = System.Drawing.Color.White;
            this.pnlAccountSettings.Controls.Add(this.gbAccountInfo);
            this.pnlAccountSettings.Location = new System.Drawing.Point(871, 1);
            this.pnlAccountSettings.Name = "pnlAccountSettings";
            this.pnlAccountSettings.Size = new System.Drawing.Size(347, 346);
            this.pnlAccountSettings.TabIndex = 8;
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Location = new System.Drawing.Point(3, 3);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(510, 198);
            this.gbUserInfo.TabIndex = 0;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info";
            // 
            // gbEmergency
            // 
            this.gbEmergency.Location = new System.Drawing.Point(3, 207);
            this.gbEmergency.Name = "gbEmergency";
            this.gbEmergency.Size = new System.Drawing.Size(510, 136);
            this.gbEmergency.TabIndex = 1;
            this.gbEmergency.TabStop = false;
            this.gbEmergency.Text = "Emergency Contact";
            // 
            // gbAccountInfo
            // 
            this.gbAccountInfo.Location = new System.Drawing.Point(3, 3);
            this.gbAccountInfo.Name = "gbAccountInfo";
            this.gbAccountInfo.Size = new System.Drawing.Size(341, 340);
            this.gbAccountInfo.TabIndex = 2;
            this.gbAccountInfo.TabStop = false;
            this.gbAccountInfo.Text = "Account Info";
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.pnlProfilePic);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.pnlAccountSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountPage";
            this.Text = "AccountPage";
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlAccountSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProfilePic;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlAccountSettings;
        private System.Windows.Forms.GroupBox gbEmergency;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.GroupBox gbAccountInfo;
    }
}