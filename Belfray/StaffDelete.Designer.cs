namespace Belfray
{
    partial class StaffDelete
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
            this.dgvStaffSearch = new System.Windows.Forms.DataGridView();
            this.pnlSearchDetails = new System.Windows.Forms.Panel();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.pnlStaffDets = new System.Windows.Forms.Panel();
            this.lblStaffPcode = new System.Windows.Forms.Label();
            this.lblStaffCounty = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblStaffStreet = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblStaffTel = new System.Windows.Forms.Label();
            this.lblStaffCity = new System.Windows.Forms.Label();
            this.lblStaffSurname = new System.Windows.Forms.Label();
            this.lblStaffForename = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).BeginInit();
            this.pnlSearchDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.pnlStaffDets.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStaffSearch
            // 
            this.dgvStaffSearch.AllowUserToAddRows = false;
            this.dgvStaffSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSearch.Location = new System.Drawing.Point(2, 1);
            this.dgvStaffSearch.Name = "dgvStaffSearch";
            this.dgvStaffSearch.ReadOnly = true;
            this.dgvStaffSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffSearch.Size = new System.Drawing.Size(755, 347);
            this.dgvStaffSearch.TabIndex = 12;
            this.dgvStaffSearch.Click += new System.EventHandler(this.dgvStaffSearch_Click);
            // 
            // pnlSearchDetails
            // 
            this.pnlSearchDetails.BackColor = System.Drawing.Color.White;
            this.pnlSearchDetails.Controls.Add(this.picDelete);
            this.pnlSearchDetails.Controls.Add(this.pnlStaffDets);
            this.pnlSearchDetails.Location = new System.Drawing.Point(763, 1);
            this.pnlSearchDetails.Name = "pnlSearchDetails";
            this.pnlSearchDetails.Size = new System.Drawing.Size(455, 347);
            this.pnlSearchDetails.TabIndex = 11;
            // 
            // picDelete
            // 
            this.picDelete.Image = global::Belfray.Properties.Resources.FinalDeleteButton;
            this.picDelete.Location = new System.Drawing.Point(392, 284);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(60, 60);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDelete.TabIndex = 123;
            this.picDelete.TabStop = false;
            this.picDelete.Visible = false;
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            this.picDelete.MouseEnter += new System.EventHandler(this.picDelete_MouseEnter);
            this.picDelete.MouseLeave += new System.EventHandler(this.picDelete_MouseLeave);
            // 
            // pnlStaffDets
            // 
            this.pnlStaffDets.Controls.Add(this.lblStaffPcode);
            this.pnlStaffDets.Controls.Add(this.lblStaffCounty);
            this.pnlStaffDets.Controls.Add(this.lblPostcode);
            this.pnlStaffDets.Controls.Add(this.lblCounty);
            this.pnlStaffDets.Controls.Add(this.lblStaffStreet);
            this.pnlStaffDets.Controls.Add(this.lblStreet);
            this.pnlStaffDets.Controls.Add(this.lblStaffTel);
            this.pnlStaffDets.Controls.Add(this.lblStaffCity);
            this.pnlStaffDets.Controls.Add(this.lblStaffSurname);
            this.pnlStaffDets.Controls.Add(this.lblStaffForename);
            this.pnlStaffDets.Controls.Add(this.lblTelNo);
            this.pnlStaffDets.Controls.Add(this.lblCity);
            this.pnlStaffDets.Controls.Add(this.lblSurname);
            this.pnlStaffDets.Controls.Add(this.lblForename);
            this.pnlStaffDets.Controls.Add(this.lblStaffID);
            this.pnlStaffDets.Controls.Add(this.lblStaffNo);
            this.pnlStaffDets.Location = new System.Drawing.Point(6, 3);
            this.pnlStaffDets.Name = "pnlStaffDets";
            this.pnlStaffDets.Size = new System.Drawing.Size(270, 341);
            this.pnlStaffDets.TabIndex = 122;
            this.pnlStaffDets.Visible = false;
            // 
            // lblStaffPcode
            // 
            this.lblStaffPcode.AutoSize = true;
            this.lblStaffPcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffPcode.Location = new System.Drawing.Point(128, 188);
            this.lblStaffPcode.Name = "lblStaffPcode";
            this.lblStaffPcode.Size = new System.Drawing.Size(15, 15);
            this.lblStaffPcode.TabIndex = 115;
            this.lblStaffPcode.Text = "X";
            // 
            // lblStaffCounty
            // 
            this.lblStaffCounty.AutoSize = true;
            this.lblStaffCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCounty.Location = new System.Drawing.Point(128, 158);
            this.lblStaffCounty.Name = "lblStaffCounty";
            this.lblStaffCounty.Size = new System.Drawing.Size(15, 15);
            this.lblStaffCounty.TabIndex = 114;
            this.lblStaffCounty.Text = "X";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(10, 188);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(76, 15);
            this.lblPostcode.TabIndex = 113;
            this.lblPostcode.Text = "POSTCODE:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(10, 158);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(59, 15);
            this.lblCounty.TabIndex = 112;
            this.lblCounty.Text = "COUNTY:";
            // 
            // lblStaffStreet
            // 
            this.lblStaffStreet.AutoSize = true;
            this.lblStaffStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffStreet.Location = new System.Drawing.Point(128, 97);
            this.lblStaffStreet.Name = "lblStaffStreet";
            this.lblStaffStreet.Size = new System.Drawing.Size(15, 15);
            this.lblStaffStreet.TabIndex = 111;
            this.lblStaffStreet.Text = "X";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(10, 97);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 15);
            this.lblStreet.TabIndex = 110;
            this.lblStreet.Text = "STREET:";
            // 
            // lblStaffTel
            // 
            this.lblStaffTel.AutoSize = true;
            this.lblStaffTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffTel.Location = new System.Drawing.Point(128, 217);
            this.lblStaffTel.Name = "lblStaffTel";
            this.lblStaffTel.Size = new System.Drawing.Size(15, 15);
            this.lblStaffTel.TabIndex = 108;
            this.lblStaffTel.Text = "X";
            // 
            // lblStaffCity
            // 
            this.lblStaffCity.AutoSize = true;
            this.lblStaffCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCity.Location = new System.Drawing.Point(128, 129);
            this.lblStaffCity.Name = "lblStaffCity";
            this.lblStaffCity.Size = new System.Drawing.Size(15, 15);
            this.lblStaffCity.TabIndex = 107;
            this.lblStaffCity.Text = "X";
            // 
            // lblStaffSurname
            // 
            this.lblStaffSurname.AutoSize = true;
            this.lblStaffSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffSurname.Location = new System.Drawing.Point(128, 67);
            this.lblStaffSurname.Name = "lblStaffSurname";
            this.lblStaffSurname.Size = new System.Drawing.Size(15, 15);
            this.lblStaffSurname.TabIndex = 105;
            this.lblStaffSurname.Text = "X";
            // 
            // lblStaffForename
            // 
            this.lblStaffForename.AutoSize = true;
            this.lblStaffForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffForename.Location = new System.Drawing.Point(128, 37);
            this.lblStaffForename.Name = "lblStaffForename";
            this.lblStaffForename.Size = new System.Drawing.Size(15, 15);
            this.lblStaffForename.TabIndex = 104;
            this.lblStaffForename.Text = "X";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelNo.Location = new System.Drawing.Point(10, 217);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(104, 15);
            this.lblTelNo.TabIndex = 93;
            this.lblTelNo.Text = "TELEPHONE NO:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(10, 129);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 15);
            this.lblCity.TabIndex = 92;
            this.lblCity.Text = "CITY:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(10, 67);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(71, 15);
            this.lblSurname.TabIndex = 90;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(10, 37);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(78, 15);
            this.lblForename.TabIndex = 89;
            this.lblForename.Text = "FORENAME:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.Location = new System.Drawing.Point(128, 7);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(15, 15);
            this.lblStaffID.TabIndex = 87;
            this.lblStaffID.Text = "X";
            // 
            // lblStaffNo
            // 
            this.lblStaffNo.AutoSize = true;
            this.lblStaffNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNo.Location = new System.Drawing.Point(10, 5);
            this.lblStaffNo.Name = "lblStaffNo";
            this.lblStaffNo.Size = new System.Drawing.Size(61, 15);
            this.lblStaffNo.TabIndex = 86;
            this.lblStaffNo.Text = "STAFF ID:";
            // 
            // StaffDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.dgvStaffSearch);
            this.Controls.Add(this.pnlSearchDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDelete";
            this.Text = "StaffDelete";
            this.Load += new System.EventHandler(this.StaffDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSearch)).EndInit();
            this.pnlSearchDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.pnlStaffDets.ResumeLayout(false);
            this.pnlStaffDets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaffSearch;
        private System.Windows.Forms.Panel pnlSearchDetails;
        private System.Windows.Forms.Panel pnlStaffDets;
        private System.Windows.Forms.Label lblStaffPcode;
        private System.Windows.Forms.Label lblStaffCounty;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblStaffStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblStaffTel;
        private System.Windows.Forms.Label lblStaffCity;
        private System.Windows.Forms.Label lblStaffSurname;
        private System.Windows.Forms.Label lblStaffForename;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffNo;
        private System.Windows.Forms.PictureBox picDelete;
    }
}