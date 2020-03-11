namespace Belfray
{
    partial class RoomBookingSearch
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
            this.dgvBookingSearch = new System.Windows.Forms.DataGridView();
            this.pnlSearchDets = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingSearch
            // 
            this.dgvBookingSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingSearch.Location = new System.Drawing.Point(2, 1);
            this.dgvBookingSearch.Name = "dgvBookingSearch";
            this.dgvBookingSearch.Size = new System.Drawing.Size(755, 347);
            this.dgvBookingSearch.TabIndex = 1;
            // 
            // pnlSearchDets
            // 
            this.pnlSearchDets.BackColor = System.Drawing.Color.White;
            this.pnlSearchDets.Location = new System.Drawing.Point(763, 1);
            this.pnlSearchDets.Name = "pnlSearchDets";
            this.pnlSearchDets.Size = new System.Drawing.Size(455, 347);
            this.pnlSearchDets.TabIndex = 2;
            // 
            // RoomBookingSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.pnlSearchDets);
            this.Controls.Add(this.dgvBookingSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomBookingSearch";
            this.Text = "BookingSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookingSearch;
        private System.Windows.Forms.Panel pnlSearchDets;
    }
}