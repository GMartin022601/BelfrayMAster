namespace Belfray
{
    partial class RoomServiceDelete
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
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.pnlDelete.SuspendLayout();
            this.gbDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.gbDetails);
            this.pnlDelete.Controls.Add(this.lblDescription);
            this.pnlDelete.Controls.Add(this.dgvDisplay);
            this.pnlDelete.Controls.Add(this.cmbSelect);
            this.pnlDelete.Location = new System.Drawing.Point(0, 1);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(1213, 341);
            this.pnlDelete.TabIndex = 2;
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.picDelete);
            this.gbDetails.Location = new System.Drawing.Point(809, 38);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(395, 300);
            this.gbDetails.TabIndex = 42;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Details";
            // 
            // picDelete
            // 
            this.picDelete.Image = global::Belfray.Properties.Resources.FinalDeleteButton;
            this.picDelete.Location = new System.Drawing.Point(329, 235);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(60, 60);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 55;
            this.picDelete.TabStop = false;
            this.picDelete.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(8, 14);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(276, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Please choose an option from the drop down:";
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(10, 38);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(793, 300);
            this.dgvDisplay.TabIndex = 1;
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "Bookings",
            "Customers"});
            this.cmbSelect.Location = new System.Drawing.Point(290, 11);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(141, 21);
            this.cmbSelect.TabIndex = 0;
            // 
            // RoomServiceDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 343);
            this.Controls.Add(this.pnlDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomServiceDelete";
            this.Text = "RoomServiceDelete";
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.ComboBox cmbSelect;
    }
}