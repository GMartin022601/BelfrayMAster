namespace Belfray
{
    partial class RoomServiceSearch
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
            this.lblSearchCustomerName = new System.Windows.Forms.Label();
            this.lblSearchRoomNo = new System.Windows.Forms.Label();
            this.txtSearchRoomNo = new System.Windows.Forms.TextBox();
            this.pnlSearchDetails = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.lblItemTypeDescription = new System.Windows.Forms.Label();
            this.lblItemTypeDesc = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblItemBookNo = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.lblItemBookNum = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.pnlRoom = new System.Windows.Forms.Panel();
            this.lblCusSurname = new System.Windows.Forms.Label();
            this.lblCusForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
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
            this.txtSearchItemNo = new System.Windows.Forms.TextBox();
            this.lblSearchItemNo = new System.Windows.Forms.Label();
            this.txtSearchItemName = new System.Windows.Forms.TextBox();
            this.dgvRoomSearch = new System.Windows.Forms.DataGridView();
            this.dgvItemSearch = new System.Windows.Forms.DataGridView();
            this.pnlSearchDetails.SuspendLayout();
            this.pnlItem.SuspendLayout();
            this.pnlRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchCustomerName
            // 
            this.lblSearchCustomerName.AutoSize = true;
            this.lblSearchCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCustomerName.Location = new System.Drawing.Point(279, 123);
            this.lblSearchCustomerName.Name = "lblSearchCustomerName";
            this.lblSearchCustomerName.Size = new System.Drawing.Size(129, 15);
            this.lblSearchCustomerName.TabIndex = 118;
            this.lblSearchCustomerName.Text = "SEARCH ITEM NAME:";
            // 
            // lblSearchRoomNo
            // 
            this.lblSearchRoomNo.AutoSize = true;
            this.lblSearchRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRoomNo.Location = new System.Drawing.Point(279, 8);
            this.lblSearchRoomNo.Name = "lblSearchRoomNo";
            this.lblSearchRoomNo.Size = new System.Drawing.Size(121, 15);
            this.lblSearchRoomNo.TabIndex = 116;
            this.lblSearchRoomNo.Text = "SEARCH ROOM NO:";
            // 
            // txtSearchRoomNo
            // 
            this.txtSearchRoomNo.Location = new System.Drawing.Point(282, 26);
            this.txtSearchRoomNo.Name = "txtSearchRoomNo";
            this.txtSearchRoomNo.Size = new System.Drawing.Size(166, 20);
            this.txtSearchRoomNo.TabIndex = 117;
            this.txtSearchRoomNo.TextChanged += new System.EventHandler(this.txtSearchRoomNo_TextChanged);
            // 
            // pnlSearchDetails
            // 
            this.pnlSearchDetails.BackColor = System.Drawing.Color.White;
            this.pnlSearchDetails.Controls.Add(this.pnlItem);
            this.pnlSearchDetails.Controls.Add(this.pnlRoom);
            this.pnlSearchDetails.Controls.Add(this.txtSearchItemNo);
            this.pnlSearchDetails.Controls.Add(this.lblSearchItemNo);
            this.pnlSearchDetails.Controls.Add(this.txtSearchItemName);
            this.pnlSearchDetails.Controls.Add(this.lblSearchCustomerName);
            this.pnlSearchDetails.Controls.Add(this.lblSearchRoomNo);
            this.pnlSearchDetails.Controls.Add(this.txtSearchRoomNo);
            this.pnlSearchDetails.Location = new System.Drawing.Point(763, 1);
            this.pnlSearchDetails.Name = "pnlSearchDetails";
            this.pnlSearchDetails.Size = new System.Drawing.Size(455, 347);
            this.pnlSearchDetails.TabIndex = 6;
            // 
            // pnlItem
            // 
            this.pnlItem.Controls.Add(this.lblItemTypeDescription);
            this.pnlItem.Controls.Add(this.lblItemTypeDesc);
            this.pnlItem.Controls.Add(this.lblQty);
            this.pnlItem.Controls.Add(this.lblPrice);
            this.pnlItem.Controls.Add(this.lblDescription);
            this.pnlItem.Controls.Add(this.lblItemNo);
            this.pnlItem.Controls.Add(this.lblItemBookNo);
            this.pnlItem.Controls.Add(this.lblQuantity);
            this.pnlItem.Controls.Add(this.lblCost);
            this.pnlItem.Controls.Add(this.lblDesc);
            this.pnlItem.Controls.Add(this.lblItemNum);
            this.pnlItem.Controls.Add(this.lblItemBookNum);
            this.pnlItem.Controls.Add(this.lblRoomNo);
            this.pnlItem.Controls.Add(this.lblRoomNum);
            this.pnlItem.Location = new System.Drawing.Point(6, 3);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(270, 341);
            this.pnlItem.TabIndex = 123;
            this.pnlItem.Visible = false;
            // 
            // lblItemTypeDescription
            // 
            this.lblItemTypeDescription.AutoSize = true;
            this.lblItemTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTypeDescription.Location = new System.Drawing.Point(128, 154);
            this.lblItemTypeDescription.Name = "lblItemTypeDescription";
            this.lblItemTypeDescription.Size = new System.Drawing.Size(15, 15);
            this.lblItemTypeDescription.TabIndex = 111;
            this.lblItemTypeDescription.Text = "X";
            // 
            // lblItemTypeDesc
            // 
            this.lblItemTypeDesc.AutoSize = true;
            this.lblItemTypeDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTypeDesc.Location = new System.Drawing.Point(10, 154);
            this.lblItemTypeDesc.Name = "lblItemTypeDesc";
            this.lblItemTypeDesc.Size = new System.Drawing.Size(40, 15);
            this.lblItemTypeDesc.TabIndex = 110;
            this.lblItemTypeDesc.Text = "TYPE:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(128, 214);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(15, 15);
            this.lblQty.TabIndex = 107;
            this.lblQty.Text = "X";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(128, 184);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(15, 15);
            this.lblPrice.TabIndex = 106;
            this.lblPrice.Text = "X";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(128, 95);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(15, 15);
            this.lblDescription.TabIndex = 105;
            this.lblDescription.Text = "X";
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.Location = new System.Drawing.Point(128, 65);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(15, 15);
            this.lblItemNo.TabIndex = 104;
            this.lblItemNo.Text = "X";
            // 
            // lblItemBookNo
            // 
            this.lblItemBookNo.AutoSize = true;
            this.lblItemBookNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemBookNo.Location = new System.Drawing.Point(128, 35);
            this.lblItemBookNo.Name = "lblItemBookNo";
            this.lblItemBookNo.Size = new System.Drawing.Size(15, 15);
            this.lblItemBookNo.TabIndex = 103;
            this.lblItemBookNo.Text = "X";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(10, 214);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 15);
            this.lblQuantity.TabIndex = 92;
            this.lblQuantity.Text = "QUANTITY:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(10, 184);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 15);
            this.lblCost.TabIndex = 91;
            this.lblCost.Text = "PRICE:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(10, 95);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(91, 15);
            this.lblDesc.TabIndex = 90;
            this.lblDesc.Text = "DESCRIPTION:";
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNum.Location = new System.Drawing.Point(10, 65);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(96, 15);
            this.lblItemNum.TabIndex = 89;
            this.lblItemNum.Text = "ITEM NUMBER:";
            // 
            // lblItemBookNum
            // 
            this.lblItemBookNum.AutoSize = true;
            this.lblItemBookNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemBookNum.Location = new System.Drawing.Point(10, 35);
            this.lblItemBookNum.Name = "lblItemBookNum";
            this.lblItemBookNum.Size = new System.Drawing.Size(86, 15);
            this.lblItemBookNum.TabIndex = 88;
            this.lblItemBookNum.Text = "BOOKING NO:";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(128, 7);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(15, 15);
            this.lblRoomNo.TabIndex = 87;
            this.lblRoomNo.Text = "X";
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.Location = new System.Drawing.Point(10, 5);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(69, 15);
            this.lblRoomNum.TabIndex = 86;
            this.lblRoomNum.Text = "ROOM NO:";
            // 
            // pnlRoom
            // 
            this.pnlRoom.Controls.Add(this.lblCusSurname);
            this.pnlRoom.Controls.Add(this.lblCusForename);
            this.pnlRoom.Controls.Add(this.lblSurname);
            this.pnlRoom.Controls.Add(this.lblForename);
            this.pnlRoom.Controls.Add(this.lblRooms);
            this.pnlRoom.Controls.Add(this.lblRoom);
            this.pnlRoom.Controls.Add(this.lblBookingPartySize);
            this.pnlRoom.Controls.Add(this.lblBookingPayment);
            this.pnlRoom.Controls.Add(this.lblBookingCustomer);
            this.pnlRoom.Controls.Add(this.lblCheckInTime);
            this.pnlRoom.Controls.Add(this.lblBookingType);
            this.pnlRoom.Controls.Add(this.lblCheckOut);
            this.pnlRoom.Controls.Add(this.lblCheckIn);
            this.pnlRoom.Controls.Add(this.lblPartySize);
            this.pnlRoom.Controls.Add(this.lblPaymentType);
            this.pnlRoom.Controls.Add(this.lblCustomerNo);
            this.pnlRoom.Controls.Add(this.lblArriveTime);
            this.pnlRoom.Controls.Add(this.lblType);
            this.pnlRoom.Controls.Add(this.lblLeave);
            this.pnlRoom.Controls.Add(this.lblArrive);
            this.pnlRoom.Controls.Add(this.lblBookingNo);
            this.pnlRoom.Controls.Add(this.lblBookingNum);
            this.pnlRoom.Location = new System.Drawing.Point(6, 3);
            this.pnlRoom.Name = "pnlRoom";
            this.pnlRoom.Size = new System.Drawing.Size(270, 341);
            this.pnlRoom.TabIndex = 122;
            this.pnlRoom.Visible = false;
            // 
            // lblCusSurname
            // 
            this.lblCusSurname.AutoSize = true;
            this.lblCusSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusSurname.Location = new System.Drawing.Point(128, 244);
            this.lblCusSurname.Name = "lblCusSurname";
            this.lblCusSurname.Size = new System.Drawing.Size(15, 15);
            this.lblCusSurname.TabIndex = 115;
            this.lblCusSurname.Text = "X";
            // 
            // lblCusForename
            // 
            this.lblCusForename.AutoSize = true;
            this.lblCusForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusForename.Location = new System.Drawing.Point(128, 214);
            this.lblCusForename.Name = "lblCusForename";
            this.lblCusForename.Size = new System.Drawing.Size(15, 15);
            this.lblCusForename.TabIndex = 114;
            this.lblCusForename.Text = "X";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(10, 244);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(71, 15);
            this.lblSurname.TabIndex = 113;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(10, 214);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(78, 15);
            this.lblForename.TabIndex = 112;
            this.lblForename.Text = "FORENAME:";
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
            this.lblBookingPartySize.Location = new System.Drawing.Point(128, 303);
            this.lblBookingPartySize.Name = "lblBookingPartySize";
            this.lblBookingPartySize.Size = new System.Drawing.Size(15, 15);
            this.lblBookingPartySize.TabIndex = 109;
            this.lblBookingPartySize.Text = "X";
            // 
            // lblBookingPayment
            // 
            this.lblBookingPayment.AutoSize = true;
            this.lblBookingPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingPayment.Location = new System.Drawing.Point(128, 273);
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
            this.lblPartySize.Location = new System.Drawing.Point(10, 303);
            this.lblPartySize.Name = "lblPartySize";
            this.lblPartySize.Size = new System.Drawing.Size(77, 15);
            this.lblPartySize.TabIndex = 102;
            this.lblPartySize.Text = "PARTY SIZE:";
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.Location = new System.Drawing.Point(10, 273);
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
            // txtSearchItemNo
            // 
            this.txtSearchItemNo.Location = new System.Drawing.Point(282, 83);
            this.txtSearchItemNo.Name = "txtSearchItemNo";
            this.txtSearchItemNo.Size = new System.Drawing.Size(166, 20);
            this.txtSearchItemNo.TabIndex = 121;
            this.txtSearchItemNo.TextChanged += new System.EventHandler(this.txtSearchItemNo_TextChanged);
            // 
            // lblSearchItemNo
            // 
            this.lblSearchItemNo.AutoSize = true;
            this.lblSearchItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchItemNo.Location = new System.Drawing.Point(279, 65);
            this.lblSearchItemNo.Name = "lblSearchItemNo";
            this.lblSearchItemNo.Size = new System.Drawing.Size(148, 15);
            this.lblSearchItemNo.TabIndex = 120;
            this.lblSearchItemNo.Text = "SEARCH ITEM NUMBER:";
            // 
            // txtSearchItemName
            // 
            this.txtSearchItemName.Location = new System.Drawing.Point(282, 141);
            this.txtSearchItemName.Name = "txtSearchItemName";
            this.txtSearchItemName.Size = new System.Drawing.Size(166, 20);
            this.txtSearchItemName.TabIndex = 119;
            this.txtSearchItemName.TextChanged += new System.EventHandler(this.txtSearchItemName_TextChanged);
            // 
            // dgvRoomSearch
            // 
            this.dgvRoomSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomSearch.Location = new System.Drawing.Point(2, 1);
            this.dgvRoomSearch.Name = "dgvRoomSearch";
            this.dgvRoomSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomSearch.Size = new System.Drawing.Size(755, 347);
            this.dgvRoomSearch.TabIndex = 7;
            this.dgvRoomSearch.Click += new System.EventHandler(this.dgvRoomServiceSearch_Click);
            // 
            // dgvItemSearch
            // 
            this.dgvItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemSearch.Location = new System.Drawing.Point(2, 1);
            this.dgvItemSearch.Name = "dgvItemSearch";
            this.dgvItemSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemSearch.Size = new System.Drawing.Size(755, 347);
            this.dgvItemSearch.TabIndex = 8;
            this.dgvItemSearch.Visible = false;
            this.dgvItemSearch.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemSearch_CellFormatting);
            this.dgvItemSearch.Click += new System.EventHandler(this.dgvItemSearch_Click);
            // 
            // RoomServiceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.dgvItemSearch);
            this.Controls.Add(this.dgvRoomSearch);
            this.Controls.Add(this.pnlSearchDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomServiceSearch";
            this.Text = "RoomServiceSearch";
            this.Load += new System.EventHandler(this.RoomServiceSearch_Load);
            this.pnlSearchDetails.ResumeLayout(false);
            this.pnlSearchDetails.PerformLayout();
            this.pnlItem.ResumeLayout(false);
            this.pnlItem.PerformLayout();
            this.pnlRoom.ResumeLayout(false);
            this.pnlRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSearchCustomerName;
        private System.Windows.Forms.Label lblSearchRoomNo;
        private System.Windows.Forms.TextBox txtSearchRoomNo;
        private System.Windows.Forms.Panel pnlSearchDetails;
        private System.Windows.Forms.TextBox txtSearchItemName;
        private System.Windows.Forms.TextBox txtSearchItemNo;
        private System.Windows.Forms.Label lblSearchItemNo;
        private System.Windows.Forms.DataGridView dgvRoomSearch;
        private System.Windows.Forms.DataGridView dgvItemSearch;
        private System.Windows.Forms.Panel pnlRoom;
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
        private System.Windows.Forms.Label lblCusSurname;
        private System.Windows.Forms.Label lblCusForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Label lblItemTypeDescription;
        private System.Windows.Forms.Label lblItemTypeDesc;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblItemBookNo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Label lblItemBookNum;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomNum;
    }
}