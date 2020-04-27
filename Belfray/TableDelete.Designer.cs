namespace Belfray
{
    partial class TableDelete
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
            this.pnlTableDelete = new System.Windows.Forms.Panel();
            this.cbBookingNo = new System.Windows.Forms.ComboBox();
            this.gbDGV = new System.Windows.Forms.GroupBox();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.BookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBookingDetails = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbPaymentTyp = new System.Windows.Forms.ComboBox();
            this.dateBooking = new System.Windows.Forms.DateTimePicker();
            this.lblPaymenType = new System.Windows.Forms.Label();
            this.numPartySize = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBNoTag = new System.Windows.Forms.Label();
            this.lblPartySize = new System.Windows.Forms.Label();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.cbCustNo = new System.Windows.Forms.ComboBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.lblPC = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lbCounty = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnCancelDel = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.pnlTableDelete.SuspendLayout();
            this.gbDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.gbBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartySize)).BeginInit();
            this.gbCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTableDelete
            // 
            this.pnlTableDelete.Controls.Add(this.cbBookingNo);
            this.pnlTableDelete.Controls.Add(this.gbDGV);
            this.pnlTableDelete.Controls.Add(this.gbBookingDetails);
            this.pnlTableDelete.Controls.Add(this.gbCustomerDetails);
            this.pnlTableDelete.Controls.Add(this.lblBNoTag);
            this.pnlTableDelete.Location = new System.Drawing.Point(2, 3);
            this.pnlTableDelete.Name = "pnlTableDelete";
            this.pnlTableDelete.Size = new System.Drawing.Size(1204, 334);
            this.pnlTableDelete.TabIndex = 0;
            // 
            // cbBookingNo
            // 
            this.cbBookingNo.FormattingEnabled = true;
            this.cbBookingNo.Location = new System.Drawing.Point(13, 44);
            this.cbBookingNo.Name = "cbBookingNo";
            this.cbBookingNo.Size = new System.Drawing.Size(143, 21);
            this.cbBookingNo.TabIndex = 0;
            // 
            // gbDGV
            // 
            this.gbDGV.Controls.Add(this.dgvBooking);
            this.gbDGV.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDGV.Location = new System.Drawing.Point(124, 187);
            this.gbDGV.Name = "gbDGV";
            this.gbDGV.Size = new System.Drawing.Size(535, 140);
            this.gbDGV.TabIndex = 71;
            this.gbDGV.TabStop = false;
            this.gbDGV.Text = "Tables Booked";
            // 
            // dgvBooking
            // 
            this.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingNumber,
            this.TableNumber,
            this.TableSize});
            this.dgvBooking.Location = new System.Drawing.Point(6, 19);
            this.dgvBooking.Name = "dgvBooking";
            this.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooking.Size = new System.Drawing.Size(523, 110);
            this.dgvBooking.TabIndex = 2;
            // 
            // BookingNumber
            // 
            this.BookingNumber.HeaderText = "Booking Number";
            this.BookingNumber.Name = "BookingNumber";
            this.BookingNumber.Width = 190;
            // 
            // TableNumber
            // 
            this.TableNumber.HeaderText = "Table Number(s)";
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.Width = 190;
            // 
            // TableSize
            // 
            this.TableSize.HeaderText = "Seats";
            this.TableSize.Name = "TableSize";
            // 
            // gbBookingDetails
            // 
            this.gbBookingDetails.Controls.Add(this.lblTime);
            this.gbBookingDetails.Controls.Add(this.txtTime);
            this.gbBookingDetails.Controls.Add(this.lblDate);
            this.gbBookingDetails.Controls.Add(this.lblPaymenType);
            this.gbBookingDetails.Controls.Add(this.lblPartySize);
            this.gbBookingDetails.Controls.Add(this.cbPaymentTyp);
            this.gbBookingDetails.Controls.Add(this.numPartySize);
            this.gbBookingDetails.Controls.Add(this.dateBooking);
            this.gbBookingDetails.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookingDetails.Location = new System.Drawing.Point(254, 9);
            this.gbBookingDetails.Name = "gbBookingDetails";
            this.gbBookingDetails.Size = new System.Drawing.Size(405, 179);
            this.gbBookingDetails.TabIndex = 69;
            this.gbBookingDetails.TabStop = false;
            this.gbBookingDetails.Text = "Booking Details";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(95, 63);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 25);
            this.txtTime.TabIndex = 36;
            // 
            // cbPaymentTyp
            // 
            this.cbPaymentTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentTyp.FormattingEnabled = true;
            this.cbPaymentTyp.Location = new System.Drawing.Point(95, 129);
            this.cbPaymentTyp.Name = "cbPaymentTyp";
            this.cbPaymentTyp.Size = new System.Drawing.Size(121, 24);
            this.cbPaymentTyp.TabIndex = 31;
            // 
            // dateBooking
            // 
            this.dateBooking.Enabled = false;
            this.dateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBooking.Location = new System.Drawing.Point(95, 31);
            this.dateBooking.Name = "dateBooking";
            this.dateBooking.Size = new System.Drawing.Size(153, 22);
            this.dateBooking.TabIndex = 21;
            // 
            // lblPaymenType
            // 
            this.lblPaymenType.AutoSize = true;
            this.lblPaymenType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymenType.Location = new System.Drawing.Point(6, 135);
            this.lblPaymenType.Name = "lblPaymenType";
            this.lblPaymenType.Size = new System.Drawing.Size(82, 18);
            this.lblPaymenType.TabIndex = 30;
            this.lblPaymenType.Text = "Paying With:";
            // 
            // numPartySize
            // 
            this.numPartySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPartySize.Location = new System.Drawing.Point(95, 98);
            this.numPartySize.Name = "numPartySize";
            this.numPartySize.Size = new System.Drawing.Size(120, 22);
            this.numPartySize.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(7, 70);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 18);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time:";
            // 
            // lblBNoTag
            // 
            this.lblBNoTag.AutoSize = true;
            this.lblBNoTag.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNoTag.Location = new System.Drawing.Point(10, 23);
            this.lblBNoTag.Name = "lblBNoTag";
            this.lblBNoTag.Size = new System.Drawing.Size(183, 18);
            this.lblBNoTag.TabIndex = 22;
            this.lblBNoTag.Text = "Select a booking from the list:";
            // 
            // lblPartySize
            // 
            this.lblPartySize.AutoSize = true;
            this.lblPartySize.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartySize.Location = new System.Drawing.Point(7, 102);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(69, 18);
            this.lblPartySize.TabIndex = 25;
            this.lblPartySize.Text = "Party Size:";
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.btnCancelDel);
            this.gbCustomerDetails.Controls.Add(this.btnDelete);
            this.gbCustomerDetails.Controls.Add(this.cbCustNo);
            this.gbCustomerDetails.Controls.Add(this.txtTelNo);
            this.gbCustomerDetails.Controls.Add(this.lblTelNo);
            this.gbCustomerDetails.Controls.Add(this.txtPC);
            this.gbCustomerDetails.Controls.Add(this.lblPC);
            this.gbCustomerDetails.Controls.Add(this.txtCounty);
            this.gbCustomerDetails.Controls.Add(this.lbCounty);
            this.gbCustomerDetails.Controls.Add(this.txtCity);
            this.gbCustomerDetails.Controls.Add(this.lblCity);
            this.gbCustomerDetails.Controls.Add(this.txtStreet);
            this.gbCustomerDetails.Controls.Add(this.lblStreet);
            this.gbCustomerDetails.Controls.Add(this.txtLName);
            this.gbCustomerDetails.Controls.Add(this.lblLname);
            this.gbCustomerDetails.Controls.Add(this.txtFname);
            this.gbCustomerDetails.Controls.Add(this.lblFName);
            this.gbCustomerDetails.Controls.Add(this.cbTitle);
            this.gbCustomerDetails.Controls.Add(this.lblTitle);
            this.gbCustomerDetails.Controls.Add(this.lblCustID);
            this.gbCustomerDetails.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDetails.Location = new System.Drawing.Point(665, 9);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(529, 318);
            this.gbCustomerDetails.TabIndex = 70;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            // 
            // cbCustNo
            // 
            this.cbCustNo.FormattingEnabled = true;
            this.cbCustNo.Location = new System.Drawing.Point(99, 24);
            this.cbCustNo.Name = "cbCustNo";
            this.cbCustNo.Size = new System.Drawing.Size(121, 26);
            this.cbCustNo.TabIndex = 20;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(89, 282);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(167, 25);
            this.txtTelNo.TabIndex = 19;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(7, 287);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(49, 18);
            this.lblTelNo.TabIndex = 18;
            this.lblTelNo.Text = "Tel No:";
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(90, 251);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(100, 25);
            this.txtPC.TabIndex = 17;
            // 
            // lblPC
            // 
            this.lblPC.AutoSize = true;
            this.lblPC.Location = new System.Drawing.Point(8, 251);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(67, 18);
            this.lblPC.TabIndex = 16;
            this.lblPC.Text = "Postcode:";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(90, 214);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(100, 25);
            this.txtCounty.TabIndex = 15;
            // 
            // lbCounty
            // 
            this.lbCounty.AutoSize = true;
            this.lbCounty.Location = new System.Drawing.Point(8, 217);
            this.lbCounty.Name = "lbCounty";
            this.lbCounty.Size = new System.Drawing.Size(55, 18);
            this.lbCounty.TabIndex = 14;
            this.lbCounty.Text = "County:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(89, 183);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 25);
            this.txtCity.TabIndex = 13;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(8, 183);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 18);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(89, 144);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(159, 25);
            this.txtStreet.TabIndex = 11;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(8, 147);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(47, 18);
            this.lblStreet.TabIndex = 10;
            this.lblStreet.Text = "Street:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(89, 106);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(182, 25);
            this.txtLName.TabIndex = 9;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(8, 109);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(75, 18);
            this.lblLname.TabIndex = 8;
            this.lblLname.Text = "Last Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(276, 70);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(173, 25);
            this.txtFname.TabIndex = 7;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(184, 73);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(76, 18);
            this.lblFName.TabIndex = 6;
            this.lblFName.Text = "First Name:";
            // 
            // cbTitle
            // 
            this.cbTitle.AutoCompleteCustomSource.AddRange(new string[] {
            "Mr",
            "Ms",
            "Miss",
            "Mrs"});
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Items.AddRange(new object[] {
            "MR",
            "MISS",
            "MRS",
            "MS",
            "DR"});
            this.cbTitle.Location = new System.Drawing.Point(90, 70);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(72, 26);
            this.cbTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(8, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 18);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(7, 28);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(86, 18);
            this.lblCustID.TabIndex = 1;
            this.lblCustID.Text = "Customer ID:";
            // 
            // btnCancelDel
            // 
            this.btnCancelDel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.btnCancelDel.Location = new System.Drawing.Point(483, 265);
            this.btnCancelDel.Name = "btnCancelDel";
            this.btnCancelDel.Size = new System.Drawing.Size(40, 47);
            this.btnCancelDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelDel.TabIndex = 56;
            this.btnCancelDel.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Belfray.Properties.Resources.FinalDeleteButton;
            this.btnDelete.Location = new System.Drawing.Point(437, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 47);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 57;
            this.btnDelete.TabStop = false;
            // 
            // TableDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 339);
            this.Controls.Add(this.pnlTableDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableDelete";
            this.Text = "TableDelete";
            this.Load += new System.EventHandler(this.TableDelete_Load);
            this.pnlTableDelete.ResumeLayout(false);
            this.pnlTableDelete.PerformLayout();
            this.gbDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.gbBookingDetails.ResumeLayout(false);
            this.gbBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartySize)).EndInit();
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTableDelete;
        private System.Windows.Forms.ComboBox cbBookingNo;
        private System.Windows.Forms.GroupBox gbDGV;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableSize;
        private System.Windows.Forms.GroupBox gbBookingDetails;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cbPaymentTyp;
        private System.Windows.Forms.DateTimePicker dateBooking;
        private System.Windows.Forms.Label lblPaymenType;
        private System.Windows.Forms.NumericUpDown numPartySize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBNoTag;
        private System.Windows.Forms.Label lblPartySize;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.ComboBox cbCustNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lbCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.PictureBox btnCancelDel;
        private System.Windows.Forms.PictureBox btnDelete;
    }
}