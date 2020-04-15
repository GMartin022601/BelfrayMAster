namespace Belfray
{
    partial class AppDisplay
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlMainWindow = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1220, 606);
            this.pnlLogin.TabIndex = 0;
            // 
            // pnlMainWindow
            // 
            this.pnlMainWindow.Location = new System.Drawing.Point(0, 0);
            this.pnlMainWindow.Name = "pnlMainWindow";
            this.pnlMainWindow.Size = new System.Drawing.Size(1220, 606);
            this.pnlMainWindow.TabIndex = 1;
            this.pnlMainWindow.Visible = false;
            // 
            // AppDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 606);
            this.Controls.Add(this.pnlMainWindow);
            this.Controls.Add(this.pnlLogin);
            this.Name = "AppDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Belfray Country Inn";
            this.Load += new System.EventHandler(this.AppDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlMainWindow;
    }
}