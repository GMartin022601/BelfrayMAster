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
            this.pnlSearchMethod = new System.Windows.Forms.Panel();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pnlSearchDetails = new System.Windows.Forms.Panel();
            this.txtSearchCustomerName = new System.Windows.Forms.TextBox();
            this.lblSearchCustomerName = new System.Windows.Forms.Label();
            this.txtSearchBookingNo = new System.Windows.Forms.TextBox();
            this.lblSearchBookingNo = new System.Windows.Forms.Label();
            this.pnlBooking = new System.Windows.Forms.Panel();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblBookingPartySize = new System.Windows.Forms.Label();
            this.lblBookingPayment = new System.Windows.Forms.Label();
            this.lblBookingCustomer = new System.Windows.Forms.Label();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.lblBookingType = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblPartySize = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblArriveTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLeave = new System.Windows.Forms.Label();
            this.lblArrive = new System.Windows.Forms.Label();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.lblBookingNum = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.lblCustPostcode = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblCustCounty = new System.Windows.Forms.Label();
            this.lblCustCity = new System.Windows.Forms.Label();
            this.lblCustStreet = new System.Windows.Forms.Label();
            this.lblCustSurname = new System.Windows.Forms.Label();
            this.lblCustForename = new System.Windows.Forms.Label();
            this.lblCustTitle = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustNo = new System.Windows.Forms.Label();
            this.lblCustNum = new System.Windows.Forms.Label();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblSearchCustomerNo = new System.Windows.Forms.Label();
            this.txtSearchCustomerNo = new System.Windows.Forms.TextBox();
            this.dgvCustomerSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingSearch)).BeginInit();
            this.pnlSearchMethod.SuspendLayout();
            this.pnlSearchDetails.SuspendLayout();
            this.pnlBooking.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookingSearch
            // 
            this.dgvBookingSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingSearch.Location = new System.Drawing.Point(2, 1);
            this.dgvBookingSearch.Name = "dgvBookingSearch";
            this.dgvBookingSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingSearch.Size = new System.Drawing.Size(755, 347);
            this.dgvBookingSearch.TabIndex = 1;
            this.dgvBookingSearch.Visible = false;
            this.dgvBookingSearch.Click += new System.EventHandler(this.dgvBookingSearch_Click);
            // 
            // pnlSearchMethod
            // 
            this.pnlSearchMethod.BackColor = System.Drawing.Color.White;
            this.pnlSearchMethod.Controls.Add(this.btnBookings);
            this.pnlSearchMethod.Controls.Add(this.btnCustomers);
            this.pnlSearchMethod.Location = new System.Drawing.Point(763, 1);
            this.pnlSearchMethod.Name = "pnlSearchMethod";
            this.pnlSearchMethod.Size = new System.Drawing.Size(455, 52);
            this.pnlSearchMethod.TabIndex = 2;
            // 
            // btnBookings
            // 
            this.btnBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.Location = new System.Drawing.Point(16, 6);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(153, 40);
            this.btnBookings.TabIndex = 65;
            this.btnBookings.Text = "SEARCH BOOKINGS";
            this.btnBookings.UseVisualStyleBackColor = true;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(286, 6);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(153, 40);
            this.btnCustomers.TabIndex = 66;
            this.btnCustomers.Text = "SEARCH CUSTOMERS";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // pnlSearchDetails
            // 
            this.pnlSearchDetails.BackColor = System.Drawing.Color.White;
            this.pnlSearchDetails.Controls.Add(this.txtSearchCustomerName);
            this.pnlSearchDetails.Controls.Add(this.lblSearchCustomerName);
            this.pnlSearchDetails.Controls.Add(this.txtSearchBookingNo);
            this.pnlSearchDetails.Controls.Add(this.lblSearchBookingNo);
            this.pnlSearchDetails.Controls.Add(this.picSearch);
            this.pnlSearchDetails.Controls.Add(this.lblSearchCustomerNo);
            this.pnlSearchDetails.Controls.Add(this.txtSearchCustomerNo);
            this.pnlSearchDetails.Controls.Add(this.pnlBooking);
            this.pnlSearchDetails.Controls.Add(this.pnlCustomer);
            this.pnlSearchDetails.Location = new System.Drawing.Point(763, 70);
            this.pnlSearchDetails.Name = "pnlSearchDetails";
            this.pnlSearchDetails.Size = new System.Drawing.Size(455, 278);
            this.pnlSearchDetails.TabIndex = 3;
            // 
            // txtSearchCustomerName
            // 
            this.txtSearchCustomerName.Location = new System.Drawing.Point(282, 86);
            this.txtSearchCustomerName.Name = "txtSearchCustomerName";
            this.txtSearchCustomerName.Size = new System.Drawing.Size(166, 20);
            this.txtSearchCustomerName.TabIndex = 119;
            this.txtSearchCustomerName.Visible = false;
            this.txtSearchCustomerName.TextChanged += new System.EventHandler(this.txtSearchCustomerName_TextChanged);
            // 
            // lblSearchCustomerName
            // 
            this.lblSearchCustomerName.AutoSize = true;
            this.lblSearchCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomerName.Location = new System.Drawing.Point(279, 68);
            this.lblSearchCustomerName.Name = "lblSearchCustomerName";
            this.lblSearchCustomerName.Size = new System.Drawing.Size(123, 15);
            this.lblSearchCustomerName.TabIndex = 118;
            this.lblSearchCustomerName.Text = "SEARCH SURNAME:";
            this.lblSearchCustomerName.Visible = false;
            // 
            // txtSearchBookingNo
            // 
            this.txtSearchBookingNo.Location = new System.Drawing.Point(282, 26);
            this.txtSearchBookingNo.Name = "txtSearchBookingNo";
            this.txtSearchBookingNo.Size = new System.Drawing.Size(166, 20);
            this.txtSearchBookingNo.TabIndex = 115;
            this.txtSearchBookingNo.Visible = false;
            this.txtSearchBookingNo.TextChanged += new System.EventHandler(this.txtSearchBookingNo_TextChanged);
            // 
            // lblSearchBookingNo
            // 
            this.lblSearchBookingNo.AutoSize = true;
            this.lblSearchBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBookingNo.Location = new System.Drawing.Point(279, 8);
            this.lblSearchBookingNo.Name = "lblSearchBookingNo";
            this.lblSearchBookingNo.Size = new System.Drawing.Size(138, 15);
            this.lblSearchBookingNo.TabIndex = 114;
            this.lblSearchBookingNo.Text = "SEARCH BOOKING NO:";
            this.lblSearchBookingNo.Visible = false;
            // 
            // pnlBooking
            // 
            this.pnlBooking.Controls.Add(this.lblRooms);
            this.pnlBooking.Controls.Add(this.lblRoom);
            this.pnlBooking.Controls.Add(this.lblBookingPartySize);
            this.pnlBooking.Controls.Add(this.lblBookingPayment);
            this.pnlBooking.Controls.Add(this.lblBookingCustomer);
            this.pnlBooking.Controls.Add(this.lblCheckInTime);
            this.pnlBooking.Controls.Add(this.lblBookingType);
            this.pnlBooking.Controls.Add(this.lblCheckOut);
            this.pnlBooking.Controls.Add(this.lblCheckIn);
            this.pnlBooking.Controls.Add(this.lblPartySize);
            this.pnlBooking.Controls.Add(this.lblPaymentType);
            this.pnlBooking.Controls.Add(this.lblCustomerNo);
            this.pnlBooking.Controls.Add(this.lblArriveTime);
            this.pnlBooking.Controls.Add(this.lblType);
            this.pnlBooking.Controls.Add(this.lblLeave);
            this.pnlBooking.Controls.Add(this.lblArrive);
            this.pnlBooking.Controls.Add(this.lblBookingNo);
            this.pnlBooking.Controls.Add(this.lblBookingNum);
            this.pnlBooking.Location = new System.Drawing.Point(3, 3);
            this.pnlBooking.Name = "pnlBooking";
            this.pnlBooking.Size = new System.Drawing.Size(270, 272);
            this.pnlBooking.TabIndex = 112;
            this.pnlBooking.Visible = false;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(128, 125);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(15, 15);
            this.lblRooms.TabIndex = 111;
            this.lblRooms.Text = "X";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(10, 125);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(93, 15);
            this.lblRoom.TabIndex = 110;
            this.lblRoom.Text = "ROOM COUNT:";
            // 
            // lblBookingPartySize
            // 
            this.lblBookingPartySize.AutoSize = true;
            this.lblBookingPartySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingPartySize.Location = new System.Drawing.Point(128, 245);
            this.lblBookingPartySize.Name = "lblBookingPartySize";
            this.lblBookingPartySize.Size = new System.Drawing.Size(15, 15);
            this.lblBookingPartySize.TabIndex = 109;
            this.lblBookingPartySize.Text = "X";
            // 
            // lblBookingPayment
            // 
            this.lblBookingPayment.AutoSize = true;
            this.lblBookingPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingPayment.Location = new System.Drawing.Point(128, 215);
            this.lblBookingPayment.Name = "lblBookingPayment";
            this.lblBookingPayment.Size = new System.Drawing.Size(15, 15);
            this.lblBookingPayment.TabIndex = 108;
            this.lblBookingPayment.Text = "X";
            // 
            // lblBookingCustomer
            // 
            this.lblBookingCustomer.AutoSize = true;
            this.lblBookingCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingCustomer.Location = new System.Drawing.Point(128, 185);
            this.lblBookingCustomer.Name = "lblBookingCustomer";
            this.lblBookingCustomer.Size = new System.Drawing.Size(15, 15);
            this.lblBookingCustomer.TabIndex = 107;
            this.lblBookingCustomer.Text = "X";
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTime.Location = new System.Drawing.Point(128, 155);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(15, 15);
            this.lblCheckInTime.TabIndex = 106;
            this.lblCheckInTime.Text = "X";
            // 
            // lblBookingType
            // 
            this.lblBookingType.AutoSize = true;
            this.lblBookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingType.Location = new System.Drawing.Point(128, 95);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(15, 15);
            this.lblBookingType.TabIndex = 105;
            this.lblBookingType.Text = "X";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOut.Location = new System.Drawing.Point(128, 65);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(15, 15);
            this.lblCheckOut.TabIndex = 104;
            this.lblCheckOut.Text = "X";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckIn.Location = new System.Drawing.Point(128, 35);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(15, 15);
            this.lblCheckIn.TabIndex = 103;
            this.lblCheckIn.Text = "X";
            // 
            // lblPartySize
            // 
            this.lblPartySize.AutoSize = true;
            this.lblPartySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartySize.Location = new System.Drawing.Point(10, 245);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(77, 15);
            this.lblPartySize.TabIndex = 102;
            this.lblPartySize.Text = "PARTY SIZE:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(10, 215);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(100, 15);
            this.lblPaymentType.TabIndex = 93;
            this.lblPaymentType.Text = "PAYMENT TYPE:";
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNo.Location = new System.Drawing.Point(10, 185);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(100, 15);
            this.lblCustomerNo.TabIndex = 92;
            this.lblCustomerNo.Text = "CUSTOMER NO:";
            // 
            // lblArriveTime
            // 
            this.lblArriveTime.AutoSize = true;
            this.lblArriveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArriveTime.Location = new System.Drawing.Point(10, 155);
            this.lblArriveTime.Name = "lblArriveTime";
            this.lblArriveTime.Size = new System.Drawing.Size(98, 15);
            this.lblArriveTime.TabIndex = 91;
            this.lblArriveTime.Text = "CHECK IN TIME:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(10, 95);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 15);
            this.lblType.TabIndex = 90;
            this.lblType.Text = "TYPE:";
            // 
            // lblLeave
            // 
            this.lblLeave.AutoSize = true;
            this.lblLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeave.Location = new System.Drawing.Point(10, 65);
            this.lblLeave.Name = "lblLeave";
            this.lblLeave.Size = new System.Drawing.Size(113, 15);
            this.lblLeave.TabIndex = 89;
            this.lblLeave.Text = "CHECK OUT DATE:";
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrive.Location = new System.Drawing.Point(10, 35);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(100, 15);
            this.lblArrive.TabIndex = 88;
            this.lblArrive.Text = "CHECK IN DATE:";
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNo.Location = new System.Drawing.Point(128, 7);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(15, 15);
            this.lblBookingNo.TabIndex = 87;
            this.lblBookingNo.Text = "X";
            // 
            // lblBookingNum
            // 
            this.lblBookingNum.AutoSize = true;
            this.lblBookingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNum.Location = new System.Drawing.Point(10, 5);
            this.lblBookingNum.Name = "lblBookingNum";
            this.lblBookingNum.Size = new System.Drawing.Size(86, 15);
            this.lblBookingNum.TabIndex = 86;
            this.lblBookingNum.Text = "BOOKING NO:";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.lblCustPostcode);
            this.pnlCustomer.Controls.Add(this.lblCustPhone);
            this.pnlCustomer.Controls.Add(this.lblCustCounty);
            this.pnlCustomer.Controls.Add(this.lblCustCity);
            this.pnlCustomer.Controls.Add(this.lblCustStreet);
            this.pnlCustomer.Controls.Add(this.lblCustSurname);
            this.pnlCustomer.Controls.Add(this.lblCustForename);
            this.pnlCustomer.Controls.Add(this.lblCustTitle);
            this.pnlCustomer.Controls.Add(this.lblPhoneNo);
            this.pnlCustomer.Controls.Add(this.lblPostcode);
            this.pnlCustomer.Controls.Add(this.lblCounty);
            this.pnlCustomer.Controls.Add(this.lblCity);
            this.pnlCustomer.Controls.Add(this.lblStreet);
            this.pnlCustomer.Controls.Add(this.lblSurname);
            this.pnlCustomer.Controls.Add(this.lblForename);
            this.pnlCustomer.Controls.Add(this.lblTitle);
            this.pnlCustomer.Controls.Add(this.lblCustNo);
            this.pnlCustomer.Controls.Add(this.lblCustNum);
            this.pnlCustomer.Location = new System.Drawing.Point(3, 3);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(270, 271);
            this.pnlCustomer.TabIndex = 113;
            this.pnlCustomer.Visible = false;
            // 
            // lblCustPostcode
            // 
            this.lblCustPostcode.AutoSize = true;
            this.lblCustPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPostcode.Location = new System.Drawing.Point(117, 245);
            this.lblCustPostcode.Name = "lblCustPostcode";
            this.lblCustPostcode.Size = new System.Drawing.Size(15, 15);
            this.lblCustPostcode.TabIndex = 110;
            this.lblCustPostcode.Text = "X";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhone.Location = new System.Drawing.Point(117, 215);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(15, 15);
            this.lblCustPhone.TabIndex = 109;
            this.lblCustPhone.Text = "X";
            // 
            // lblCustCounty
            // 
            this.lblCustCounty.AutoSize = true;
            this.lblCustCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustCounty.Location = new System.Drawing.Point(117, 185);
            this.lblCustCounty.Name = "lblCustCounty";
            this.lblCustCounty.Size = new System.Drawing.Size(15, 15);
            this.lblCustCounty.TabIndex = 108;
            this.lblCustCounty.Text = "X";
            // 
            // lblCustCity
            // 
            this.lblCustCity.AutoSize = true;
            this.lblCustCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustCity.Location = new System.Drawing.Point(117, 155);
            this.lblCustCity.Name = "lblCustCity";
            this.lblCustCity.Size = new System.Drawing.Size(15, 15);
            this.lblCustCity.TabIndex = 107;
            this.lblCustCity.Text = "X";
            // 
            // lblCustStreet
            // 
            this.lblCustStreet.AutoSize = true;
            this.lblCustStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustStreet.Location = new System.Drawing.Point(117, 125);
            this.lblCustStreet.Name = "lblCustStreet";
            this.lblCustStreet.Size = new System.Drawing.Size(15, 15);
            this.lblCustStreet.TabIndex = 106;
            this.lblCustStreet.Text = "X";
            // 
            // lblCustSurname
            // 
            this.lblCustSurname.AutoSize = true;
            this.lblCustSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustSurname.Location = new System.Drawing.Point(117, 95);
            this.lblCustSurname.Name = "lblCustSurname";
            this.lblCustSurname.Size = new System.Drawing.Size(15, 15);
            this.lblCustSurname.TabIndex = 105;
            this.lblCustSurname.Text = "X";
            // 
            // lblCustForename
            // 
            this.lblCustForename.AutoSize = true;
            this.lblCustForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustForename.Location = new System.Drawing.Point(117, 65);
            this.lblCustForename.Name = "lblCustForename";
            this.lblCustForename.Size = new System.Drawing.Size(15, 15);
            this.lblCustForename.TabIndex = 104;
            this.lblCustForename.Text = "X";
            // 
            // lblCustTitle
            // 
            this.lblCustTitle.AutoSize = true;
            this.lblCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTitle.Location = new System.Drawing.Point(117, 35);
            this.lblCustTitle.Name = "lblCustTitle";
            this.lblCustTitle.Size = new System.Drawing.Size(15, 15);
            this.lblCustTitle.TabIndex = 103;
            this.lblCustTitle.Text = "X";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(10, 215);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(74, 15);
            this.lblPhoneNo.TabIndex = 102;
            this.lblPhoneNo.Text = "PHONE NO:";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(10, 245);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(76, 15);
            this.lblPostcode.TabIndex = 94;
            this.lblPostcode.Text = "POSTCODE:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(10, 185);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(59, 15);
            this.lblCounty.TabIndex = 93;
            this.lblCounty.Text = "COUNTY:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(10, 155);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 15);
            this.lblCity.TabIndex = 92;
            this.lblCity.Text = "CITY:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(10, 125);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 15);
            this.lblStreet.TabIndex = 91;
            this.lblStreet.Text = "STREET:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(10, 95);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(71, 15);
            this.lblSurname.TabIndex = 90;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(10, 65);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(78, 15);
            this.lblForename.TabIndex = 89;
            this.lblForename.Text = "FORENAME:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 15);
            this.lblTitle.TabIndex = 88;
            this.lblTitle.Text = "TITLE:";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNo.Location = new System.Drawing.Point(117, 7);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(15, 15);
            this.lblCustNo.TabIndex = 87;
            this.lblCustNo.Text = "X";
            // 
            // lblCustNum
            // 
            this.lblCustNum.AutoSize = true;
            this.lblCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNum.Location = new System.Drawing.Point(10, 5);
            this.lblCustNum.Name = "lblCustNum";
            this.lblCustNum.Size = new System.Drawing.Size(100, 15);
            this.lblCustNum.TabIndex = 86;
            this.lblCustNum.Text = "CUSTOMER NO:";
            // 
            // picSearch
            // 
            this.picSearch.Enabled = false;
            this.picSearch.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picSearch.Location = new System.Drawing.Point(349, 234);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 63;
            this.picSearch.TabStop = false;
            this.picSearch.Visible = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            this.picSearch.MouseEnter += new System.EventHandler(this.picSearch_MouseEnter);
            this.picSearch.MouseLeave += new System.EventHandler(this.picSearch_MouseLeave);
            // 
            // lblSearchCustomerNo
            // 
            this.lblSearchCustomerNo.AutoSize = true;
            this.lblSearchCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomerNo.Location = new System.Drawing.Point(279, 8);
            this.lblSearchCustomerNo.Name = "lblSearchCustomerNo";
            this.lblSearchCustomerNo.Size = new System.Drawing.Size(152, 15);
            this.lblSearchCustomerNo.TabIndex = 116;
            this.lblSearchCustomerNo.Text = "SEARCH CUSTOMER NO:";
            this.lblSearchCustomerNo.Visible = false;
            // 
            // txtSearchCustomerNo
            // 
            this.txtSearchCustomerNo.Location = new System.Drawing.Point(282, 26);
            this.txtSearchCustomerNo.Name = "txtSearchCustomerNo";
            this.txtSearchCustomerNo.Size = new System.Drawing.Size(166, 20);
            this.txtSearchCustomerNo.TabIndex = 117;
            this.txtSearchCustomerNo.Visible = false;
            this.txtSearchCustomerNo.TextChanged += new System.EventHandler(this.txtSearchCustomerNo_TextChanged);
            // 
            // dgvCustomerSearch
            // 
            this.dgvCustomerSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerSearch.Location = new System.Drawing.Point(2, 1);
            this.dgvCustomerSearch.Name = "dgvCustomerSearch";
            this.dgvCustomerSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerSearch.Size = new System.Drawing.Size(755, 347);
            this.dgvCustomerSearch.TabIndex = 4;
            this.dgvCustomerSearch.Visible = false;
            this.dgvCustomerSearch.Click += new System.EventHandler(this.dgvCustomerSearch_Click);
            // 
            // RoomBookingSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.dgvCustomerSearch);
            this.Controls.Add(this.pnlSearchDetails);
            this.Controls.Add(this.pnlSearchMethod);
            this.Controls.Add(this.dgvBookingSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomBookingSearch";
            this.Text = "BookingSearch";
            this.Load += new System.EventHandler(this.RoomBookingSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingSearch)).EndInit();
            this.pnlSearchMethod.ResumeLayout(false);
            this.pnlSearchDetails.ResumeLayout(false);
            this.pnlSearchDetails.PerformLayout();
            this.pnlBooking.ResumeLayout(false);
            this.pnlBooking.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookingSearch;
        private System.Windows.Forms.Panel pnlSearchMethod;
        private System.Windows.Forms.Panel pnlSearchDetails;
        private System.Windows.Forms.Panel pnlBooking;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblBookingPartySize;
        private System.Windows.Forms.Label lblBookingPayment;
        private System.Windows.Forms.Label lblBookingCustomer;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblBookingType;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblPartySize;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblArriveTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.Label lblBookingNum;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Label lblCustPostcode;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustCounty;
        private System.Windows.Forms.Label lblCustCity;
        private System.Windows.Forms.Label lblCustStreet;
        private System.Windows.Forms.Label lblCustSurname;
        private System.Windows.Forms.Label lblCustForename;
        private System.Windows.Forms.Label lblCustTitle;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.Label lblCustNum;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.DataGridView dgvCustomerSearch;
        private System.Windows.Forms.Label lblSearchBookingNo;
        private System.Windows.Forms.TextBox txtSearchCustomerName;
        private System.Windows.Forms.Label lblSearchCustomerName;
        private System.Windows.Forms.TextBox txtSearchBookingNo;
        private System.Windows.Forms.Label lblSearchCustomerNo;
        private System.Windows.Forms.TextBox txtSearchCustomerNo;
    }
}