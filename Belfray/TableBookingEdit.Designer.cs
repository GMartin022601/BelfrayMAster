namespace Belfray
{
    partial class TableBookingEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableBookingEdit));
            this.gbDGV = new System.Windows.Forms.GroupBox();
            this.picAddNewTable = new System.Windows.Forms.PictureBox();
            this.picRemoveTable = new System.Windows.Forms.PictureBox();
            this.dgvBooking = new System.Windows.Forms.DataGridView();
            this.BookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.picSaveBooking = new System.Windows.Forms.PictureBox();
            this.picCancelBooking = new System.Windows.Forms.PictureBox();
            this.gbBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbPaymentTyp = new System.Windows.Forms.ComboBox();
            this.dateBooking = new System.Windows.Forms.DateTimePicker();
            this.lblPaymenType = new System.Windows.Forms.Label();
            this.numPartySize = new System.Windows.Forms.NumericUpDown();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBNoTag = new System.Windows.Forms.Label();
            this.lblPartySize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTablNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemoveTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).BeginInit();
            this.gbCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelBooking)).BeginInit();
            this.gbBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartySize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDGV
            // 
            this.gbDGV.Controls.Add(this.lblTablNo);
            this.gbDGV.Controls.Add(this.label1);
            this.gbDGV.Controls.Add(this.picAddNewTable);
            this.gbDGV.Controls.Add(this.picRemoveTable);
            this.gbDGV.Controls.Add(this.dgvBooking);
            this.gbDGV.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDGV.Location = new System.Drawing.Point(12, 165);
            this.gbDGV.Name = "gbDGV";
            this.gbDGV.Size = new System.Drawing.Size(535, 171);
            this.gbDGV.TabIndex = 2;
            this.gbDGV.TabStop = false;
            this.gbDGV.Text = "Tables Booked";
            // 
            // picAddNewTable
            // 
            this.picAddNewTable.Image = ((System.Drawing.Image)(resources.GetObject("picAddNewTable.Image")));
            this.picAddNewTable.Location = new System.Drawing.Point(475, 140);
            this.picAddNewTable.Name = "picAddNewTable";
            this.picAddNewTable.Size = new System.Drawing.Size(24, 24);
            this.picAddNewTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddNewTable.TabIndex = 83;
            this.picAddNewTable.TabStop = false;
            this.picAddNewTable.Click += new System.EventHandler(this.picAddNewTable_Click);
            // 
            // picRemoveTable
            // 
            this.picRemoveTable.Image = ((System.Drawing.Image)(resources.GetObject("picRemoveTable.Image")));
            this.picRemoveTable.Location = new System.Drawing.Point(505, 140);
            this.picRemoveTable.Name = "picRemoveTable";
            this.picRemoveTable.Size = new System.Drawing.Size(24, 24);
            this.picRemoveTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemoveTable.TabIndex = 82;
            this.picRemoveTable.TabStop = false;
            this.picRemoveTable.Click += new System.EventHandler(this.picRemoveTable_Click);
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
            this.dgvBooking.Size = new System.Drawing.Size(523, 115);
            this.dgvBooking.TabIndex = 2;
            this.dgvBooking.Click += new System.EventHandler(this.dgvBooking_Click);
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
            // gbCustomerDetails
            // 
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
            this.gbCustomerDetails.Location = new System.Drawing.Point(553, 18);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(427, 318);
            this.gbCustomerDetails.TabIndex = 1;
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
            this.txtFname.Size = new System.Drawing.Size(129, 25);
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
            // picSaveBooking
            // 
            this.picSaveBooking.Image = ((System.Drawing.Image)(resources.GetObject("picSaveBooking.Image")));
            this.picSaveBooking.Location = new System.Drawing.Point(1141, 289);
            this.picSaveBooking.Name = "picSaveBooking";
            this.picSaveBooking.Size = new System.Drawing.Size(40, 40);
            this.picSaveBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaveBooking.TabIndex = 62;
            this.picSaveBooking.TabStop = false;
            // 
            // picCancelBooking
            // 
            this.picCancelBooking.Image = ((System.Drawing.Image)(resources.GetObject("picCancelBooking.Image")));
            this.picCancelBooking.Location = new System.Drawing.Point(1095, 289);
            this.picCancelBooking.Name = "picCancelBooking";
            this.picCancelBooking.Size = new System.Drawing.Size(40, 40);
            this.picCancelBooking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancelBooking.TabIndex = 68;
            this.picCancelBooking.TabStop = false;
            // 
            // gbBookingDetails
            // 
            this.gbBookingDetails.Controls.Add(this.lblBookingNo);
            this.gbBookingDetails.Controls.Add(this.txtTime);
            this.gbBookingDetails.Controls.Add(this.cbPaymentTyp);
            this.gbBookingDetails.Controls.Add(this.dateBooking);
            this.gbBookingDetails.Controls.Add(this.lblPaymenType);
            this.gbBookingDetails.Controls.Add(this.numPartySize);
            this.gbBookingDetails.Controls.Add(this.lblDate);
            this.gbBookingDetails.Controls.Add(this.lblTime);
            this.gbBookingDetails.Controls.Add(this.lblBNoTag);
            this.gbBookingDetails.Controls.Add(this.lblPartySize);
            this.gbBookingDetails.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookingDetails.Location = new System.Drawing.Point(12, 18);
            this.gbBookingDetails.Name = "gbBookingDetails";
            this.gbBookingDetails.Size = new System.Drawing.Size(535, 141);
            this.gbBookingDetails.TabIndex = 0;
            this.gbBookingDetails.TabStop = false;
            this.gbBookingDetails.Text = "Booking Details";
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Location = new System.Drawing.Point(92, 23);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(28, 18);
            this.lblBookingNo.TabIndex = 82;
            this.lblBookingNo.Text = "-----";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(51, 77);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 25);
            this.txtTime.TabIndex = 36;
            // 
            // cbPaymentTyp
            // 
            this.cbPaymentTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentTyp.FormattingEnabled = true;
            this.cbPaymentTyp.Location = new System.Drawing.Point(298, 106);
            this.cbPaymentTyp.Name = "cbPaymentTyp";
            this.cbPaymentTyp.Size = new System.Drawing.Size(121, 24);
            this.cbPaymentTyp.TabIndex = 31;
            // 
            // dateBooking
            // 
            this.dateBooking.Enabled = false;
            this.dateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBooking.Location = new System.Drawing.Point(51, 48);
            this.dateBooking.Name = "dateBooking";
            this.dateBooking.Size = new System.Drawing.Size(153, 22);
            this.dateBooking.TabIndex = 21;
            // 
            // lblPaymenType
            // 
            this.lblPaymenType.AutoSize = true;
            this.lblPaymenType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymenType.Location = new System.Drawing.Point(210, 112);
            this.lblPaymenType.Name = "lblPaymenType";
            this.lblPaymenType.Size = new System.Drawing.Size(82, 18);
            this.lblPaymenType.TabIndex = 30;
            this.lblPaymenType.Text = "Paying With:";
            // 
            // numPartySize
            // 
            this.numPartySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPartySize.Location = new System.Drawing.Point(84, 108);
            this.numPartySize.Name = "numPartySize";
            this.numPartySize.Size = new System.Drawing.Size(120, 22);
            this.numPartySize.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 53);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 78);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 18);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time:";
            // 
            // lblBNoTag
            // 
            this.lblBNoTag.AutoSize = true;
            this.lblBNoTag.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNoTag.Location = new System.Drawing.Point(6, 23);
            this.lblBNoTag.Name = "lblBNoTag";
            this.lblBNoTag.Size = new System.Drawing.Size(81, 18);
            this.lblBNoTag.TabIndex = 22;
            this.lblBNoTag.Text = "Booking No:";
            // 
            // lblPartySize
            // 
            this.lblPartySize.AutoSize = true;
            this.lblPartySize.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartySize.Location = new System.Drawing.Point(6, 112);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(69, 18);
            this.lblPartySize.TabIndex = 25;
            this.lblPartySize.Text = "Party Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Table No Selected:";
            // 
            // lblTablNo
            // 
            this.lblTablNo.AutoSize = true;
            this.lblTablNo.Location = new System.Drawing.Point(127, 142);
            this.lblTablNo.Name = "lblTablNo";
            this.lblTablNo.Size = new System.Drawing.Size(24, 18);
            this.lblTablNo.TabIndex = 85;
            this.lblTablNo.Text = "----";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(987, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 265);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Items";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // TableBookingEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 339);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picSaveBooking);
            this.Controls.Add(this.gbDGV);
            this.Controls.Add(this.gbBookingDetails);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.picCancelBooking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableBookingEdit";
            this.Text = "TableBookingEdit";
            this.Load += new System.EventHandler(this.TableBookingEdit_Load);
            this.gbDGV.ResumeLayout(false);
            this.gbDGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemoveTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking)).EndInit();
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancelBooking)).EndInit();
            this.gbBookingDetails.ResumeLayout(false);
            this.gbBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPartySize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDGV;
        private System.Windows.Forms.PictureBox picRemoveTable;
        private System.Windows.Forms.DataGridView dgvBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableSize;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.PictureBox picSaveBooking;
        private System.Windows.Forms.ComboBox cbCustNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.PictureBox picCancelBooking;
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
        private System.Windows.Forms.GroupBox gbBookingDetails;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox cbPaymentTyp;
        private System.Windows.Forms.DateTimePicker dateBooking;
        private System.Windows.Forms.Label lblPaymenType;
        private System.Windows.Forms.NumericUpDown numPartySize;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBNoTag;
        private System.Windows.Forms.Label lblPartySize;
        private System.Windows.Forms.PictureBox picAddNewTable;
        private System.Windows.Forms.Label lblTablNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}