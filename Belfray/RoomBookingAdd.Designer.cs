using System;

namespace Belfray
{
    partial class RoomBookingAdd
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
            this.components = new System.ComponentModel.Container();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.gbCustomerDets = new System.Windows.Forms.GroupBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCustNo = new System.Windows.Forms.Label();
            this.lblCustNum = new System.Windows.Forms.Label();
            this.pnlBookingDets = new System.Windows.Forms.Panel();
            this.gbBookingDetails = new System.Windows.Forms.GroupBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.txtPartySize = new System.Windows.Forms.TextBox();
            this.cmbPayType = new System.Windows.Forms.ComboBox();
            this.cmbCustomerNo = new System.Windows.Forms.ComboBox();
            this.lblCheckInTime = new System.Windows.Forms.Label();
            this.lblPartySize = new System.Windows.Forms.Label();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblBookingType = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.dtpBookingCheckOut = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dtpBookingCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.lblBookingNum = new System.Windows.Forms.Label();
            this.pnlRoomPics = new System.Windows.Forms.Panel();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.gbRoomsAdded = new System.Windows.Forms.GroupBox();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.BookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picRemoveRoom = new System.Windows.Forms.PictureBox();
            this.picAddRoom = new System.Windows.Forms.PictureBox();
            this.picAddNewCust = new System.Windows.Forms.PictureBox();
            this.picBookingCancel = new System.Windows.Forms.PictureBox();
            this.picBookingSave = new System.Windows.Forms.PictureBox();
            this.picCustomerCancel = new System.Windows.Forms.PictureBox();
            this.picCustomerSave = new System.Windows.Forms.PictureBox();
            this.pnlCustomer.SuspendLayout();
            this.gbCustomerDets.SuspendLayout();
            this.pnlBookingDets.SuspendLayout();
            this.gbBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.pnlRooms.SuspendLayout();
            this.gbRoomsAdded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemoveRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewCust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookingCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookingSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerSave)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.Controls.Add(this.gbCustomerDets);
            this.pnlCustomer.Location = new System.Drawing.Point(660, 100);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(557, 248);
            this.pnlCustomer.TabIndex = 3;
            // 
            // gbCustomerDets
            // 
            this.gbCustomerDets.Controls.Add(this.txtPhoneNo);
            this.gbCustomerDets.Controls.Add(this.lblPhoneNo);
            this.gbCustomerDets.Controls.Add(this.txtPostcode);
            this.gbCustomerDets.Controls.Add(this.txtCounty);
            this.gbCustomerDets.Controls.Add(this.txtCity);
            this.gbCustomerDets.Controls.Add(this.txtStreet);
            this.gbCustomerDets.Controls.Add(this.txtSurname);
            this.gbCustomerDets.Controls.Add(this.txtForename);
            this.gbCustomerDets.Controls.Add(this.cmbTitle);
            this.gbCustomerDets.Controls.Add(this.lblPostcode);
            this.gbCustomerDets.Controls.Add(this.lblCounty);
            this.gbCustomerDets.Controls.Add(this.lblTown);
            this.gbCustomerDets.Controls.Add(this.lblStreet);
            this.gbCustomerDets.Controls.Add(this.lblSurname);
            this.gbCustomerDets.Controls.Add(this.lblForename);
            this.gbCustomerDets.Controls.Add(this.picCustomerCancel);
            this.gbCustomerDets.Controls.Add(this.picCustomerSave);
            this.gbCustomerDets.Controls.Add(this.lblTitle);
            this.gbCustomerDets.Controls.Add(this.lblCustNo);
            this.gbCustomerDets.Controls.Add(this.lblCustNum);
            this.gbCustomerDets.Enabled = false;
            this.gbCustomerDets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDets.Location = new System.Drawing.Point(3, 3);
            this.gbCustomerDets.Name = "gbCustomerDets";
            this.gbCustomerDets.Size = new System.Drawing.Size(551, 242);
            this.gbCustomerDets.TabIndex = 78;
            this.gbCustomerDets.TabStop = false;
            this.gbCustomerDets.Text = "Customer Details";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(115, 171);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(136, 21);
            this.txtPhoneNo.TabIndex = 85;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(6, 174);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(74, 15);
            this.lblPhoneNo.TabIndex = 84;
            this.lblPhoneNo.Text = "PHONE NO:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(374, 172);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(126, 21);
            this.txtPostcode.TabIndex = 83;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(374, 141);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(126, 21);
            this.txtCounty.TabIndex = 82;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(115, 141);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 21);
            this.txtCity.TabIndex = 81;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(115, 111);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(196, 21);
            this.txtStreet.TabIndex = 80;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(115, 81);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(196, 21);
            this.txtSurname.TabIndex = 79;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(374, 51);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(158, 21);
            this.txtForename.TabIndex = 78;
            // 
            // cmbTitle
            // 
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Items.AddRange(new object[] {
            "MR",
            "MISS",
            "MRS",
            "MS",
            "DR"});
            this.cmbTitle.Location = new System.Drawing.Point(115, 51);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(108, 23);
            this.cmbTitle.TabIndex = 78;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(265, 174);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(76, 15);
            this.lblPostcode.TabIndex = 71;
            this.lblPostcode.Text = "POSTCODE:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(265, 144);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(59, 15);
            this.lblCounty.TabIndex = 70;
            this.lblCounty.Text = "COUNTY:";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Location = new System.Drawing.Point(6, 144);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(35, 15);
            this.lblTown.TabIndex = 69;
            this.lblTown.Text = "CITY:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(6, 114);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 15);
            this.lblStreet.TabIndex = 68;
            this.lblStreet.Text = "STREET:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(6, 84);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(71, 15);
            this.lblSurname.TabIndex = 66;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(263, 54);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(78, 15);
            this.lblForename.TabIndex = 64;
            this.lblForename.Text = "FORENAME:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 15);
            this.lblTitle.TabIndex = 60;
            this.lblTitle.Text = "TITLE:";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNo.Location = new System.Drawing.Point(112, 24);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(11, 15);
            this.lblCustNo.TabIndex = 59;
            this.lblCustNo.Text = "-";
            // 
            // lblCustNum
            // 
            this.lblCustNum.AutoSize = true;
            this.lblCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNum.Location = new System.Drawing.Point(6, 24);
            this.lblCustNum.Name = "lblCustNum";
            this.lblCustNum.Size = new System.Drawing.Size(100, 15);
            this.lblCustNum.TabIndex = 58;
            this.lblCustNum.Text = "CUSTOMER NO:";
            // 
            // pnlBookingDets
            // 
            this.pnlBookingDets.BackColor = System.Drawing.Color.White;
            this.pnlBookingDets.Controls.Add(this.gbBookingDetails);
            this.pnlBookingDets.Location = new System.Drawing.Point(339, 1);
            this.pnlBookingDets.Name = "pnlBookingDets";
            this.pnlBookingDets.Size = new System.Drawing.Size(315, 347);
            this.pnlBookingDets.TabIndex = 4;
            // 
            // gbBookingDetails
            // 
            this.gbBookingDetails.Controls.Add(this.picRemoveRoom);
            this.gbBookingDetails.Controls.Add(this.picAddRoom);
            this.gbBookingDetails.Controls.Add(this.lblRoomNo);
            this.gbBookingDetails.Controls.Add(this.txtPartySize);
            this.gbBookingDetails.Controls.Add(this.cmbPayType);
            this.gbBookingDetails.Controls.Add(this.picAddNewCust);
            this.gbBookingDetails.Controls.Add(this.cmbCustomerNo);
            this.gbBookingDetails.Controls.Add(this.lblCheckInTime);
            this.gbBookingDetails.Controls.Add(this.lblPartySize);
            this.gbBookingDetails.Controls.Add(this.lblPaymentType);
            this.gbBookingDetails.Controls.Add(this.lblCustomerNo);
            this.gbBookingDetails.Controls.Add(this.lblArrivalTime);
            this.gbBookingDetails.Controls.Add(this.lblBookingType);
            this.gbBookingDetails.Controls.Add(this.lblRoomNum);
            this.gbBookingDetails.Controls.Add(this.dtpBookingCheckOut);
            this.gbBookingDetails.Controls.Add(this.lblCheckOutDate);
            this.gbBookingDetails.Controls.Add(this.dtpBookingCheckIn);
            this.gbBookingDetails.Controls.Add(this.picBookingCancel);
            this.gbBookingDetails.Controls.Add(this.picBookingSave);
            this.gbBookingDetails.Controls.Add(this.lblCheckInDate);
            this.gbBookingDetails.Controls.Add(this.lblBookingNo);
            this.gbBookingDetails.Controls.Add(this.lblBookingNum);
            this.gbBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookingDetails.Location = new System.Drawing.Point(3, 3);
            this.gbBookingDetails.Name = "gbBookingDetails";
            this.gbBookingDetails.Size = new System.Drawing.Size(309, 341);
            this.gbBookingDetails.TabIndex = 0;
            this.gbBookingDetails.TabStop = false;
            this.gbBookingDetails.Text = "Booking Details";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Enabled = false;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(134, 134);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(11, 15);
            this.lblRoomNo.TabIndex = 78;
            this.lblRoomNo.Text = "-";
            // 
            // txtPartySize
            // 
            this.txtPartySize.Location = new System.Drawing.Point(137, 267);
            this.txtPartySize.Name = "txtPartySize";
            this.txtPartySize.Size = new System.Drawing.Size(133, 21);
            this.txtPartySize.TabIndex = 77;
            // 
            // cmbPayType
            // 
            this.cmbPayType.FormattingEnabled = true;
            this.cmbPayType.Location = new System.Drawing.Point(137, 230);
            this.cmbPayType.Name = "cmbPayType";
            this.cmbPayType.Size = new System.Drawing.Size(133, 23);
            this.cmbPayType.TabIndex = 75;
            // 
            // cmbCustomerNo
            // 
            this.cmbCustomerNo.FormattingEnabled = true;
            this.cmbCustomerNo.Location = new System.Drawing.Point(137, 197);
            this.cmbCustomerNo.Name = "cmbCustomerNo";
            this.cmbCustomerNo.Size = new System.Drawing.Size(133, 23);
            this.cmbCustomerNo.TabIndex = 73;
            this.cmbCustomerNo.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerNo_SelectedIndexChanged);
            // 
            // lblCheckInTime
            // 
            this.lblCheckInTime.AutoSize = true;
            this.lblCheckInTime.Enabled = false;
            this.lblCheckInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInTime.Location = new System.Drawing.Point(134, 167);
            this.lblCheckInTime.Name = "lblCheckInTime";
            this.lblCheckInTime.Size = new System.Drawing.Size(38, 15);
            this.lblCheckInTime.TabIndex = 72;
            this.lblCheckInTime.Text = "13:00";
            // 
            // lblPartySize
            // 
            this.lblPartySize.AutoSize = true;
            this.lblPartySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartySize.Location = new System.Drawing.Point(6, 270);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(77, 15);
            this.lblPartySize.TabIndex = 71;
            this.lblPartySize.Text = "PARTY SIZE:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(6, 233);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(100, 15);
            this.lblPaymentType.TabIndex = 70;
            this.lblPaymentType.Text = "PAYMENT TYPE:";
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNo.Location = new System.Drawing.Point(6, 200);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(100, 15);
            this.lblCustomerNo.TabIndex = 69;
            this.lblCustomerNo.Text = "CUSTOMER NO:";
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivalTime.Location = new System.Drawing.Point(6, 167);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(98, 15);
            this.lblArrivalTime.TabIndex = 68;
            this.lblArrivalTime.Text = "CHECK IN TIME:";
            // 
            // lblBookingType
            // 
            this.lblBookingType.AutoSize = true;
            this.lblBookingType.Enabled = false;
            this.lblBookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingType.Location = new System.Drawing.Point(134, 134);
            this.lblBookingType.Name = "lblBookingType";
            this.lblBookingType.Size = new System.Drawing.Size(41, 15);
            this.lblBookingType.TabIndex = 67;
            this.lblBookingType.Text = "Room";
            this.lblBookingType.Visible = false;
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.Location = new System.Drawing.Point(6, 134);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(105, 15);
            this.lblRoomNum.TabIndex = 66;
            this.lblRoomNum.Text = "ROOM NUMBER:";
            // 
            // dtpBookingCheckOut
            // 
            this.dtpBookingCheckOut.Enabled = false;
            this.dtpBookingCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingCheckOut.Location = new System.Drawing.Point(137, 96);
            this.dtpBookingCheckOut.Name = "dtpBookingCheckOut";
            this.dtpBookingCheckOut.Size = new System.Drawing.Size(161, 21);
            this.dtpBookingCheckOut.TabIndex = 65;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckOutDate.Location = new System.Drawing.Point(6, 101);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(113, 15);
            this.lblCheckOutDate.TabIndex = 64;
            this.lblCheckOutDate.Text = "CHECK OUT DATE:";
            // 
            // dtpBookingCheckIn
            // 
            this.dtpBookingCheckIn.Enabled = false;
            this.dtpBookingCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingCheckIn.Location = new System.Drawing.Point(137, 64);
            this.dtpBookingCheckIn.Name = "dtpBookingCheckIn";
            this.dtpBookingCheckIn.Size = new System.Drawing.Size(161, 21);
            this.dtpBookingCheckIn.TabIndex = 63;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckInDate.Location = new System.Drawing.Point(6, 68);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(100, 15);
            this.lblCheckInDate.TabIndex = 60;
            this.lblCheckInDate.Text = "CHECK IN DATE:";
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNo.Location = new System.Drawing.Point(134, 35);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(11, 15);
            this.lblBookingNo.TabIndex = 59;
            this.lblBookingNo.Text = "-";
            // 
            // lblBookingNum
            // 
            this.lblBookingNum.AutoSize = true;
            this.lblBookingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNum.Location = new System.Drawing.Point(6, 35);
            this.lblBookingNum.Name = "lblBookingNum";
            this.lblBookingNum.Size = new System.Drawing.Size(122, 15);
            this.lblBookingNum.TabIndex = 58;
            this.lblBookingNum.Text = "BOOKING NUMBER:";
            // 
            // pnlRoomPics
            // 
            this.pnlRoomPics.BackColor = System.Drawing.Color.White;
            this.pnlRoomPics.Location = new System.Drawing.Point(3, 1);
            this.pnlRoomPics.Name = "pnlRoomPics";
            this.pnlRoomPics.Size = new System.Drawing.Size(330, 347);
            this.pnlRoomPics.TabIndex = 5;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // pnlRooms
            // 
            this.pnlRooms.BackColor = System.Drawing.Color.White;
            this.pnlRooms.Controls.Add(this.gbRoomsAdded);
            this.pnlRooms.Location = new System.Drawing.Point(660, 1);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(557, 96);
            this.pnlRooms.TabIndex = 6;
            // 
            // gbRoomsAdded
            // 
            this.gbRoomsAdded.Controls.Add(this.dgvRooms);
            this.gbRoomsAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoomsAdded.Location = new System.Drawing.Point(3, 3);
            this.gbRoomsAdded.Name = "gbRoomsAdded";
            this.gbRoomsAdded.Size = new System.Drawing.Size(551, 90);
            this.gbRoomsAdded.TabIndex = 78;
            this.gbRoomsAdded.TabStop = false;
            this.gbRoomsAdded.Text = "Rooms Added to Booking";
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingNumber,
            this.RoomNum});
            this.dgvRooms.Location = new System.Drawing.Point(6, 16);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(539, 67);
            this.dgvRooms.TabIndex = 0;
            // 
            // BookingNumber
            // 
            this.BookingNumber.Frozen = true;
            this.BookingNumber.HeaderText = "Booking Number";
            this.BookingNumber.Name = "BookingNumber";
            this.BookingNumber.Width = 300;
            // 
            // RoomNum
            // 
            this.RoomNum.Frozen = true;
            this.RoomNum.HeaderText = "Room Number";
            this.RoomNum.Name = "RoomNum";
            this.RoomNum.Width = 200;
            // 
            // picRemoveRoom
            // 
            this.picRemoveRoom.Image = global::Belfray.Properties.Resources.Remove__2_;
            this.picRemoveRoom.Location = new System.Drawing.Point(211, 129);
            this.picRemoveRoom.Name = "picRemoveRoom";
            this.picRemoveRoom.Size = new System.Drawing.Size(24, 24);
            this.picRemoveRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemoveRoom.TabIndex = 80;
            this.picRemoveRoom.TabStop = false;
            this.picRemoveRoom.Click += new System.EventHandler(this.picRemoveRoom_Click);
            this.picRemoveRoom.MouseEnter += new System.EventHandler(this.picRemoveRoom_MouseEnter);
            this.picRemoveRoom.MouseLeave += new System.EventHandler(this.picRemoveRoom_MouseLeave);
            // 
            // picAddRoom
            // 
            this.picAddRoom.Image = global::Belfray.Properties.Resources.AddNew;
            this.picAddRoom.Location = new System.Drawing.Point(181, 129);
            this.picAddRoom.Name = "picAddRoom";
            this.picAddRoom.Size = new System.Drawing.Size(24, 24);
            this.picAddRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddRoom.TabIndex = 79;
            this.picAddRoom.TabStop = false;
            this.picAddRoom.Click += new System.EventHandler(this.picAddRoom_Click);
            this.picAddRoom.MouseEnter += new System.EventHandler(this.picAddRoom_MouseEnter);
            this.picAddRoom.MouseLeave += new System.EventHandler(this.picAddRoom_MouseLeave);
            // 
            // picAddNewCust
            // 
            this.picAddNewCust.Image = global::Belfray.Properties.Resources.AddNew;
            this.picAddNewCust.Location = new System.Drawing.Point(276, 197);
            this.picAddNewCust.Name = "picAddNewCust";
            this.picAddNewCust.Size = new System.Drawing.Size(24, 24);
            this.picAddNewCust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddNewCust.TabIndex = 74;
            this.picAddNewCust.TabStop = false;
            this.picAddNewCust.Click += new System.EventHandler(this.picAddNewCust_Click);
            this.picAddNewCust.MouseEnter += new System.EventHandler(this.picAddNewCust_MouseEnter);
            this.picAddNewCust.MouseLeave += new System.EventHandler(this.picAddNewCust_MouseLeave);
            // 
            // picBookingCancel
            // 
            this.picBookingCancel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.picBookingCancel.Location = new System.Drawing.Point(113, 295);
            this.picBookingCancel.Name = "picBookingCancel";
            this.picBookingCancel.Size = new System.Drawing.Size(40, 40);
            this.picBookingCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookingCancel.TabIndex = 62;
            this.picBookingCancel.TabStop = false;
            this.picBookingCancel.Click += new System.EventHandler(this.picBookingCancel_Click);
            this.picBookingCancel.MouseEnter += new System.EventHandler(this.picBookingCancel_MouseEnter);
            this.picBookingCancel.MouseLeave += new System.EventHandler(this.picBookingCancel_MouseLeave);
            // 
            // picBookingSave
            // 
            this.picBookingSave.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picBookingSave.Location = new System.Drawing.Point(156, 295);
            this.picBookingSave.Name = "picBookingSave";
            this.picBookingSave.Size = new System.Drawing.Size(40, 40);
            this.picBookingSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookingSave.TabIndex = 61;
            this.picBookingSave.TabStop = false;
            this.picBookingSave.Click += new System.EventHandler(this.picBookingSave_Click);
            this.picBookingSave.MouseEnter += new System.EventHandler(this.picBookingSave_MouseEnter);
            this.picBookingSave.MouseLeave += new System.EventHandler(this.picBookingSave_MouseLeave);
            // 
            // picCustomerCancel
            // 
            this.picCustomerCancel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.picCustomerCancel.Location = new System.Drawing.Point(234, 196);
            this.picCustomerCancel.Name = "picCustomerCancel";
            this.picCustomerCancel.Size = new System.Drawing.Size(40, 40);
            this.picCustomerCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomerCancel.TabIndex = 62;
            this.picCustomerCancel.TabStop = false;
            this.picCustomerCancel.Visible = false;
            this.picCustomerCancel.Click += new System.EventHandler(this.picCustomerCancel_Click);
            this.picCustomerCancel.MouseEnter += new System.EventHandler(this.picCustomerCancel_MouseEnter);
            this.picCustomerCancel.MouseLeave += new System.EventHandler(this.picCustomerCancel_MouseLeave);
            // 
            // picCustomerSave
            // 
            this.picCustomerSave.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picCustomerSave.Location = new System.Drawing.Point(277, 196);
            this.picCustomerSave.Name = "picCustomerSave";
            this.picCustomerSave.Size = new System.Drawing.Size(40, 40);
            this.picCustomerSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomerSave.TabIndex = 61;
            this.picCustomerSave.TabStop = false;
            this.picCustomerSave.Visible = false;
            this.picCustomerSave.Click += new System.EventHandler(this.picCustomerSave_Click);
            this.picCustomerSave.MouseEnter += new System.EventHandler(this.picCustomerSave_MouseEnter);
            this.picCustomerSave.MouseLeave += new System.EventHandler(this.picCustomerSave_MouseLeave);
            // 
            // RoomBookingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.pnlRooms);
            this.Controls.Add(this.pnlRoomPics);
            this.Controls.Add(this.pnlBookingDets);
            this.Controls.Add(this.pnlCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomBookingAdd";
            this.Text = "BookingAdd";
            this.Load += new System.EventHandler(this.RoomBookingAdd_Load);
            this.pnlCustomer.ResumeLayout(false);
            this.gbCustomerDets.ResumeLayout(false);
            this.gbCustomerDets.PerformLayout();
            this.pnlBookingDets.ResumeLayout(false);
            this.gbBookingDetails.ResumeLayout(false);
            this.gbBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.pnlRooms.ResumeLayout(false);
            this.gbRoomsAdded.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemoveRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddNewCust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookingCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookingSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomerSave)).EndInit();
            this.ResumeLayout(false);

        }
        

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel pnlBookingDets;
        private System.Windows.Forms.Panel pnlRoomPics;
        private System.Windows.Forms.GroupBox gbBookingDetails;
        private System.Windows.Forms.Label lblBookingNum;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.PictureBox picBookingCancel;
        private System.Windows.Forms.PictureBox picBookingSave;
        private System.Windows.Forms.DateTimePicker dtpBookingCheckIn;
        private System.Windows.Forms.DateTimePicker dtpBookingCheckOut;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label lblCheckInTime;
        private System.Windows.Forms.Label lblPartySize;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblBookingType;
        private System.Windows.Forms.PictureBox picAddNewCust;
        private System.Windows.Forms.ComboBox cmbCustomerNo;
        private System.Windows.Forms.ComboBox cmbPayType;
        private System.Windows.Forms.TextBox txtPartySize;
        private System.Windows.Forms.GroupBox gbCustomerDets;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.PictureBox picCustomerCancel;
        private System.Windows.Forms.PictureBox picCustomerSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustNo;
        private System.Windows.Forms.Label lblCustNum;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.GroupBox gbRoomsAdded;
        private System.Windows.Forms.PictureBox picAddRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNum;
        private System.Windows.Forms.PictureBox picRemoveRoom;
    }
}