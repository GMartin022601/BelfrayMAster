namespace Belfray
{
    partial class TableSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableSearch));
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picShowBill = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.txtPartySize = new System.Windows.Forms.TextBox();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.dateBooking = new System.Windows.Forms.DateTimePicker();
            this.lblPaymenType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBNoTag = new System.Windows.Forms.Label();
            this.lblPartySize = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTableBill = new System.Windows.Forms.DataGridView();
            this.gbBill = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowBill)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableBill)).BeginInit();
            this.gbBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(2, 2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(924, 184);
            this.dgvSearch.TabIndex = 0;
            this.dgvSearch.Click += new System.EventHandler(this.dgvSearch_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.txtFirstName);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.picShowBill);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.lblCustNo);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.txtPaymentType);
            this.pnlDetails.Controls.Add(this.txtPartySize);
            this.pnlDetails.Controls.Add(this.lblBookingNo);
            this.pnlDetails.Controls.Add(this.txtTime);
            this.pnlDetails.Controls.Add(this.dateBooking);
            this.pnlDetails.Controls.Add(this.lblPaymenType);
            this.pnlDetails.Controls.Add(this.lblDate);
            this.pnlDetails.Controls.Add(this.lblTime);
            this.pnlDetails.Controls.Add(this.lblBNoTag);
            this.pnlDetails.Controls.Add(this.lblPartySize);
            this.pnlDetails.Controls.Add(this.txtLastName);
            this.pnlDetails.Location = new System.Drawing.Point(932, 2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(285, 343);
            this.pnlDetails.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(107, 266);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 25);
            this.txtFirstName.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 57;
            this.label7.Text = "Last Name:";
            // 
            // picShowBill
            // 
            this.picShowBill.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picShowBill.Location = new System.Drawing.Point(235, 284);
            this.picShowBill.Name = "picShowBill";
            this.picShowBill.Size = new System.Drawing.Size(40, 40);
            this.picShowBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowBill.TabIndex = 71;
            this.picShowBill.TabStop = false;
            this.picShowBill.Visible = false;
            this.picShowBill.Click += new System.EventHandler(this.picShowBill_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "First Name:";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Enabled = false;
            this.lblCustNo.Location = new System.Drawing.Point(104, 238);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(16, 18);
            this.lblCustNo.TabIndex = 55;
            this.lblCustNo.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Customer No:";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Enabled = false;
            this.txtPaymentType.Location = new System.Drawing.Point(107, 163);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(100, 25);
            this.txtPaymentType.TabIndex = 53;
            // 
            // txtPartySize
            // 
            this.txtPartySize.Enabled = false;
            this.txtPartySize.Location = new System.Drawing.Point(107, 122);
            this.txtPartySize.Name = "txtPartySize";
            this.txtPartySize.Size = new System.Drawing.Size(100, 25);
            this.txtPartySize.TabIndex = 51;
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Enabled = false;
            this.lblBookingNo.Location = new System.Drawing.Point(104, 19);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(16, 18);
            this.lblBookingNo.TabIndex = 50;
            this.lblBookingNo.Text = "--";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(107, 81);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 25);
            this.txtTime.TabIndex = 49;
            // 
            // dateBooking
            // 
            this.dateBooking.Enabled = false;
            this.dateBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBooking.Location = new System.Drawing.Point(107, 48);
            this.dateBooking.Name = "dateBooking";
            this.dateBooking.Size = new System.Drawing.Size(153, 22);
            this.dateBooking.TabIndex = 42;
            // 
            // lblPaymenType
            // 
            this.lblPaymenType.AutoSize = true;
            this.lblPaymenType.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymenType.Location = new System.Drawing.Point(6, 166);
            this.lblPaymenType.Name = "lblPaymenType";
            this.lblPaymenType.Size = new System.Drawing.Size(82, 18);
            this.lblPaymenType.TabIndex = 47;
            this.lblPaymenType.Text = "Paying With:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 88);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 18);
            this.lblTime.TabIndex = 46;
            this.lblTime.Text = "Time:";
            // 
            // lblBNoTag
            // 
            this.lblBNoTag.AutoSize = true;
            this.lblBNoTag.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBNoTag.Location = new System.Drawing.Point(6, 19);
            this.lblBNoTag.Name = "lblBNoTag";
            this.lblBNoTag.Size = new System.Drawing.Size(81, 18);
            this.lblBNoTag.TabIndex = 43;
            this.lblBNoTag.Text = "Booking No:";
            // 
            // lblPartySize
            // 
            this.lblPartySize.AutoSize = true;
            this.lblPartySize.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartySize.Location = new System.Drawing.Point(6, 129);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(69, 18);
            this.lblPartySize.TabIndex = 45;
            this.lblPartySize.Text = "Party Size:";
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(107, 299);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 25);
            this.txtLastName.TabIndex = 59;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.picClear);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.txtSurname);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.dtpSearch);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtBookingNumber);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Location = new System.Drawing.Point(2, 192);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(423, 153);
            this.pnlSearch.TabIndex = 2;
            // 
            // picClear
            // 
            this.picClear.Image = global::Belfray.Properties.Resources.Cancel3;
            this.picClear.Location = new System.Drawing.Point(332, 107);
            this.picClear.Name = "picClear";
            this.picClear.Size = new System.Drawing.Size(40, 40);
            this.picClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClear.TabIndex = 70;
            this.picClear.TabStop = false;
            this.picClear.Visible = false;
            this.picClear.Click += new System.EventHandler(this.picClear_Click);
            // 
            // picSearch
            // 
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(378, 107);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 64;
            this.picSearch.TabStop = false;
            this.picSearch.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(201, 80);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(171, 25);
            this.txtSurname.TabIndex = 45;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Search by Customer Surname:";
            // 
            // dtpSearch
            // 
            this.dtpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch.Location = new System.Drawing.Point(201, 45);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(153, 22);
            this.dtpSearch.TabIndex = 43;
            this.dtpSearch.ValueChanged += new System.EventHandler(this.dtpSearch_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Date:";
            // 
            // txtBookingNumber
            // 
            this.txtBookingNumber.Location = new System.Drawing.Point(201, 7);
            this.txtBookingNumber.Name = "txtBookingNumber";
            this.txtBookingNumber.Size = new System.Drawing.Size(171, 25);
            this.txtBookingNumber.TabIndex = 1;
            this.txtBookingNumber.TextChanged += new System.EventHandler(this.txtBookingNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Booking Number:";
            // 
            // pnlBill
            // 
            this.pnlBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBill.Controls.Add(this.lblTotalCost);
            this.pnlBill.Controls.Add(this.lblTotalItems);
            this.pnlBill.Controls.Add(this.label8);
            this.pnlBill.Controls.Add(this.label5);
            this.pnlBill.Controls.Add(this.comboBox1);
            this.pnlBill.Controls.Add(this.lblTables);
            this.pnlBill.Controls.Add(this.label9);
            this.pnlBill.Controls.Add(this.label10);
            this.pnlBill.Controls.Add(this.label11);
            this.pnlBill.Controls.Add(this.label15);
            this.pnlBill.Location = new System.Drawing.Point(932, 2);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(285, 343);
            this.pnlBill.TabIndex = 60;
            this.pnlBill.Visible = false;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Enabled = false;
            this.lblTotalCost.Location = new System.Drawing.Point(104, 184);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(16, 18);
            this.lblTotalCost.TabIndex = 61;
            this.lblTotalCost.Text = "--";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Enabled = false;
            this.lblTotalItems.Location = new System.Drawing.Point(104, 148);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(16, 18);
            this.lblTotalItems.TabIndex = 60;
            this.lblTotalItems.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 58;
            this.label5.Text = "Total Items:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 57;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTables.Location = new System.Drawing.Point(7, 86);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(57, 18);
            this.lblTables.TabIndex = 56;
            this.lblTables.Text = "Table(s):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(104, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 18);
            this.label9.TabIndex = 55;
            this.label9.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 54;
            this.label10.Text = "Customer No:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(104, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 18);
            this.label11.TabIndex = 50;
            this.label11.Text = "--";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 18);
            this.label15.TabIndex = 43;
            this.label15.Text = "Booking No:";
            // 
            // dgvTableBill
            // 
            this.dgvTableBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableBill.Location = new System.Drawing.Point(6, 24);
            this.dgvTableBill.Name = "dgvTableBill";
            this.dgvTableBill.Size = new System.Drawing.Size(483, 126);
            this.dgvTableBill.TabIndex = 72;
            this.dgvTableBill.Visible = false;
            // 
            // gbBill
            // 
            this.gbBill.Controls.Add(this.dgvTableBill);
            this.gbBill.Location = new System.Drawing.Point(431, 187);
            this.gbBill.Name = "gbBill";
            this.gbBill.Size = new System.Drawing.Size(495, 158);
            this.gbBill.TabIndex = 73;
            this.gbBill.TabStop = false;
            this.gbBill.Text = "Table Items";
            this.gbBill.Visible = false;
            // 
            // TableSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.gbBill);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlBill);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableSearch";
            this.Text = "TableSearch";
            this.Load += new System.EventHandler(this.TableSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowBill)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableBill)).EndInit();
            this.gbBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.DateTimePicker dateBooking;
        private System.Windows.Forms.Label lblPaymenType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBNoTag;
        private System.Windows.Forms.Label lblPartySize;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookingNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.TextBox txtPartySize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picClear;
        private System.Windows.Forms.PictureBox picShowBill;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvTableBill;
        private System.Windows.Forms.GroupBox gbBill;
    }
}