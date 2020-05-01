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
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookingNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
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
            this.pnlDetails.Controls.Add(this.txtLastName);
            this.pnlDetails.Controls.Add(this.txtFirstName);
            this.pnlDetails.Controls.Add(this.label7);
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
            this.pnlDetails.Location = new System.Drawing.Point(932, 2);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(285, 343);
            this.pnlDetails.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(107, 299);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 25);
            this.txtLastName.TabIndex = 59;
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
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.txtSurname);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.dtpSearch);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtBookingNumber);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Location = new System.Drawing.Point(2, 192);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(423, 147);
            this.pnlSearch.TabIndex = 2;
            // 
            // picSearch
            // 
            this.picSearch.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picSearch.Location = new System.Drawing.Point(378, 104);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 64;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(201, 80);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(171, 25);
            this.txtSurname.TabIndex = 45;
            this.txtSurname.TextChanged += new System.EventHandler(this.TableSearch_TextChanged);
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
            this.dtpSearch.Enabled = false;
            this.dtpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch.Location = new System.Drawing.Point(201, 45);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(153, 22);
            this.dtpSearch.TabIndex = 43;
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
            // TableSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableSearch";
            this.Text = "TableSearch";
            this.Load += new System.EventHandler(this.TableSearch_Load);
            this.TextChanged += new System.EventHandler(this.TableSearch_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
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
    }
}