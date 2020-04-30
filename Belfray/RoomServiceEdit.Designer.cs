namespace Belfray
{
    partial class RoomServiceEdit
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
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.BookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchDetails = new System.Windows.Forms.Panel();
            this.gbBookingInfo = new System.Windows.Forms.GroupBox();
            this.lblBookingNo = new System.Windows.Forms.Label();
            this.lblBookingNum = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.gbItemInfo = new System.Windows.Forms.GroupBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.picRemove = new System.Windows.Forms.PictureBox();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.lblItemTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.gbCustomerDets = new System.Windows.Forms.GroupBox();
            this.lblCustSurname = new System.Windows.Forms.Label();
            this.lblCustForename = new System.Windows.Forms.Label();
            this.lblCustTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblCustomerNum = new System.Windows.Forms.Label();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            this.pnlSearchDetails.SuspendLayout();
            this.gbBookingInfo.SuspendLayout();
            this.gbItemInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            this.gbCustomerDets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingNumber,
            this.RoomNumber,
            this.ItemNumber,
            this.Price,
            this.Qty});
            this.dgvCurrentOrder.Location = new System.Drawing.Point(604, 223);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentOrder.Size = new System.Drawing.Size(615, 125);
            this.dgvCurrentOrder.TabIndex = 15;
            this.dgvCurrentOrder.Click += new System.EventHandler(this.dgvCurrentOrder_Click);
            // 
            // BookingNumber
            // 
            this.BookingNumber.HeaderText = "Booking Number";
            this.BookingNumber.Name = "BookingNumber";
            this.BookingNumber.Width = 120;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Width = 120;
            // 
            // ItemNumber
            // 
            this.ItemNumber.HeaderText = "Item";
            this.ItemNumber.Name = "ItemNumber";
            this.ItemNumber.Width = 120;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.Width = 110;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            // 
            // pnlSearchDetails
            // 
            this.pnlSearchDetails.BackColor = System.Drawing.Color.White;
            this.pnlSearchDetails.Controls.Add(this.gbBookingInfo);
            this.pnlSearchDetails.Controls.Add(this.gbItemInfo);
            this.pnlSearchDetails.Controls.Add(this.gbCustomerDets);
            this.pnlSearchDetails.Location = new System.Drawing.Point(604, 1);
            this.pnlSearchDetails.Name = "pnlSearchDetails";
            this.pnlSearchDetails.Size = new System.Drawing.Size(615, 219);
            this.pnlSearchDetails.TabIndex = 14;
            // 
            // gbBookingInfo
            // 
            this.gbBookingInfo.Controls.Add(this.lblBookingNo);
            this.gbBookingInfo.Controls.Add(this.lblBookingNum);
            this.gbBookingInfo.Controls.Add(this.cmbItemType);
            this.gbBookingInfo.Controls.Add(this.lblItemType);
            this.gbBookingInfo.Controls.Add(this.lblRoomNo);
            this.gbBookingInfo.Controls.Add(this.lblRoomNum);
            this.gbBookingInfo.Location = new System.Drawing.Point(3, 3);
            this.gbBookingInfo.Name = "gbBookingInfo";
            this.gbBookingInfo.Size = new System.Drawing.Size(332, 80);
            this.gbBookingInfo.TabIndex = 2;
            this.gbBookingInfo.TabStop = false;
            this.gbBookingInfo.Text = "Booking Info";
            // 
            // lblBookingNo
            // 
            this.lblBookingNo.AutoSize = true;
            this.lblBookingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNo.Location = new System.Drawing.Point(116, 21);
            this.lblBookingNo.Name = "lblBookingNo";
            this.lblBookingNo.Size = new System.Drawing.Size(11, 15);
            this.lblBookingNo.TabIndex = 84;
            this.lblBookingNo.Text = "-";
            // 
            // lblBookingNum
            // 
            this.lblBookingNum.AutoSize = true;
            this.lblBookingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingNum.Location = new System.Drawing.Point(6, 21);
            this.lblBookingNum.Name = "lblBookingNum";
            this.lblBookingNum.Size = new System.Drawing.Size(86, 15);
            this.lblBookingNum.TabIndex = 83;
            this.lblBookingNum.Text = "BOOKING NO:";
            // 
            // cmbItemType
            // 
            this.cmbItemType.Enabled = false;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(119, 49);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(207, 21);
            this.cmbItemType.TabIndex = 82;
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.Location = new System.Drawing.Point(6, 50);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(72, 15);
            this.lblItemType.TabIndex = 81;
            this.lblItemType.Text = "ITEM TYPE:";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(275, 21);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(11, 15);
            this.lblRoomNo.TabIndex = 80;
            this.lblRoomNo.Text = "-";
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.Location = new System.Drawing.Point(204, 21);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(48, 15);
            this.lblRoomNum.TabIndex = 79;
            this.lblRoomNum.Text = "ROOM:";
            // 
            // gbItemInfo
            // 
            this.gbItemInfo.Controls.Add(this.picAdd);
            this.gbItemInfo.Controls.Add(this.picRemove);
            this.gbItemInfo.Controls.Add(this.picCancel);
            this.gbItemInfo.Controls.Add(this.picSave);
            this.gbItemInfo.Controls.Add(this.lblItemTotal);
            this.gbItemInfo.Controls.Add(this.lblTotal);
            this.gbItemInfo.Controls.Add(this.txtQty);
            this.gbItemInfo.Controls.Add(this.lblQty);
            this.gbItemInfo.Controls.Add(this.lblItemPrice);
            this.gbItemInfo.Controls.Add(this.lblPrice);
            this.gbItemInfo.Controls.Add(this.lblItemDescription);
            this.gbItemInfo.Controls.Add(this.lblItemDesc);
            this.gbItemInfo.Controls.Add(this.lblItemNo);
            this.gbItemInfo.Controls.Add(this.lblItemNum);
            this.gbItemInfo.Location = new System.Drawing.Point(341, 3);
            this.gbItemInfo.Name = "gbItemInfo";
            this.gbItemInfo.Size = new System.Drawing.Size(271, 213);
            this.gbItemInfo.TabIndex = 1;
            this.gbItemInfo.TabStop = false;
            this.gbItemInfo.Text = "Item Info";
            // 
            // picAdd
            // 
            this.picAdd.Image = global::Belfray.Properties.Resources.Add;
            this.picAdd.Location = new System.Drawing.Point(44, 177);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(30, 30);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 100;
            this.picAdd.TabStop = false;
            this.picAdd.Visible = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            this.picAdd.MouseEnter += new System.EventHandler(this.picAdd_MouseEnter);
            this.picAdd.MouseLeave += new System.EventHandler(this.picAdd_MouseLeave);
            // 
            // picRemove
            // 
            this.picRemove.Image = global::Belfray.Properties.Resources.Remove;
            this.picRemove.Location = new System.Drawing.Point(6, 177);
            this.picRemove.Name = "picRemove";
            this.picRemove.Size = new System.Drawing.Size(30, 30);
            this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemove.TabIndex = 99;
            this.picRemove.TabStop = false;
            this.picRemove.Visible = false;
            this.picRemove.Click += new System.EventHandler(this.picRemove_Click);
            this.picRemove.MouseEnter += new System.EventHandler(this.picRemove_MouseEnter);
            this.picRemove.MouseLeave += new System.EventHandler(this.picRemove_MouseLeave);
            // 
            // picCancel
            // 
            this.picCancel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.picCancel.Location = new System.Drawing.Point(235, 177);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(30, 30);
            this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancel.TabIndex = 98;
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
            this.picCancel.MouseEnter += new System.EventHandler(this.picCancel_MouseEnter);
            this.picCancel.MouseLeave += new System.EventHandler(this.picCancel_MouseLeave);
            // 
            // picSave
            // 
            this.picSave.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picSave.Location = new System.Drawing.Point(199, 177);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(30, 30);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 97;
            this.picSave.TabStop = false;
            this.picSave.Visible = false;
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            this.picSave.MouseEnter += new System.EventHandler(this.picSave_MouseEnter);
            this.picSave.MouseLeave += new System.EventHandler(this.picSave_MouseLeave);
            // 
            // lblItemTotal
            // 
            this.lblItemTotal.AutoSize = true;
            this.lblItemTotal.Enabled = false;
            this.lblItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTotal.Location = new System.Drawing.Point(116, 152);
            this.lblItemTotal.Name = "lblItemTotal";
            this.lblItemTotal.Size = new System.Drawing.Size(11, 15);
            this.lblItemTotal.TabIndex = 96;
            this.lblItemTotal.Text = "-";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(6, 152);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 95;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(119, 129);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(57, 20);
            this.txtQty.TabIndex = 94;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 130);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(68, 15);
            this.lblQty.TabIndex = 93;
            this.lblQty.Text = "QUANTITY:";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Enabled = false;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(116, 107);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(11, 15);
            this.lblItemPrice.TabIndex = 92;
            this.lblItemPrice.Text = "-";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 108);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 15);
            this.lblPrice.TabIndex = 91;
            this.lblPrice.Text = "PRICE:";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Enabled = false;
            this.lblItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDescription.Location = new System.Drawing.Point(116, 42);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(11, 15);
            this.lblItemDescription.TabIndex = 90;
            this.lblItemDescription.Text = "-";
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDesc.Location = new System.Drawing.Point(6, 42);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(91, 15);
            this.lblItemDesc.TabIndex = 89;
            this.lblItemDesc.Text = "DESCRIPTION:";
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Enabled = false;
            this.lblItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.Location = new System.Drawing.Point(116, 20);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(11, 15);
            this.lblItemNo.TabIndex = 88;
            this.lblItemNo.Text = "-";
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNum.Location = new System.Drawing.Point(6, 20);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(96, 15);
            this.lblItemNum.TabIndex = 87;
            this.lblItemNum.Text = "ITEM NUMBER:";
            // 
            // gbCustomerDets
            // 
            this.gbCustomerDets.Controls.Add(this.lblCustSurname);
            this.gbCustomerDets.Controls.Add(this.lblCustForename);
            this.gbCustomerDets.Controls.Add(this.lblCustTitle);
            this.gbCustomerDets.Controls.Add(this.lblSurname);
            this.gbCustomerDets.Controls.Add(this.lblForename);
            this.gbCustomerDets.Controls.Add(this.lblCustomerTitle);
            this.gbCustomerDets.Controls.Add(this.lblCustomerNo);
            this.gbCustomerDets.Controls.Add(this.lblCustomerNum);
            this.gbCustomerDets.Enabled = false;
            this.gbCustomerDets.Location = new System.Drawing.Point(3, 89);
            this.gbCustomerDets.Name = "gbCustomerDets";
            this.gbCustomerDets.Size = new System.Drawing.Size(332, 127);
            this.gbCustomerDets.TabIndex = 0;
            this.gbCustomerDets.TabStop = false;
            this.gbCustomerDets.Text = "Customer Info";
            // 
            // lblCustSurname
            // 
            this.lblCustSurname.AutoSize = true;
            this.lblCustSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustSurname.Location = new System.Drawing.Point(116, 96);
            this.lblCustSurname.Name = "lblCustSurname";
            this.lblCustSurname.Size = new System.Drawing.Size(11, 15);
            this.lblCustSurname.TabIndex = 92;
            this.lblCustSurname.Text = "-";
            // 
            // lblCustForename
            // 
            this.lblCustForename.AutoSize = true;
            this.lblCustForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustForename.Location = new System.Drawing.Point(116, 71);
            this.lblCustForename.Name = "lblCustForename";
            this.lblCustForename.Size = new System.Drawing.Size(11, 15);
            this.lblCustForename.TabIndex = 91;
            this.lblCustForename.Text = "-";
            // 
            // lblCustTitle
            // 
            this.lblCustTitle.AutoSize = true;
            this.lblCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTitle.Location = new System.Drawing.Point(116, 46);
            this.lblCustTitle.Name = "lblCustTitle";
            this.lblCustTitle.Size = new System.Drawing.Size(11, 15);
            this.lblCustTitle.TabIndex = 90;
            this.lblCustTitle.Text = "-";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(6, 96);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(71, 15);
            this.lblSurname.TabIndex = 89;
            this.lblSurname.Text = "SURNAME:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(6, 71);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(78, 15);
            this.lblForename.TabIndex = 88;
            this.lblForename.Text = "FORENAME:";
            // 
            // lblCustomerTitle
            // 
            this.lblCustomerTitle.AutoSize = true;
            this.lblCustomerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTitle.Location = new System.Drawing.Point(6, 46);
            this.lblCustomerTitle.Name = "lblCustomerTitle";
            this.lblCustomerTitle.Size = new System.Drawing.Size(42, 15);
            this.lblCustomerTitle.TabIndex = 87;
            this.lblCustomerTitle.Text = "TITLE:";
            // 
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNo.Location = new System.Drawing.Point(116, 21);
            this.lblCustomerNo.Name = "lblCustomerNo";
            this.lblCustomerNo.Size = new System.Drawing.Size(11, 15);
            this.lblCustomerNo.TabIndex = 86;
            this.lblCustomerNo.Text = "-";
            // 
            // lblCustomerNum
            // 
            this.lblCustomerNum.AutoSize = true;
            this.lblCustomerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNum.Location = new System.Drawing.Point(6, 21);
            this.lblCustomerNum.Name = "lblCustomerNum";
            this.lblCustomerNum.Size = new System.Drawing.Size(100, 15);
            this.lblCustomerNum.TabIndex = 85;
            this.lblCustomerNum.Text = "CUSTOMER NO:";
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(2, 1);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(596, 347);
            this.dgvRooms.TabIndex = 13;
            this.dgvRooms.Click += new System.EventHandler(this.dgvRooms_Click);
            // 
            // dgvItemList
            // 
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(2, 1);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(596, 347);
            this.dgvItemList.TabIndex = 16;
            this.dgvItemList.Visible = false;
            this.dgvItemList.Click += new System.EventHandler(this.dgvItemList_Click);
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // RoomServiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.pnlSearchDetails);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.dgvItemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomServiceEdit";
            this.Text = "RoomServiceEdit";
            this.Load += new System.EventHandler(this.RoomServiceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            this.pnlSearchDetails.ResumeLayout(false);
            this.gbBookingInfo.ResumeLayout(false);
            this.gbBookingInfo.PerformLayout();
            this.gbItemInfo.ResumeLayout(false);
            this.gbItemInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            this.gbCustomerDets.ResumeLayout(false);
            this.gbCustomerDets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Panel pnlSearchDetails;
        private System.Windows.Forms.GroupBox gbBookingInfo;
        private System.Windows.Forms.Label lblBookingNo;
        private System.Windows.Forms.Label lblBookingNum;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.GroupBox gbItemInfo;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picRemove;
        private System.Windows.Forms.PictureBox picCancel;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.Label lblItemTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.GroupBox gbCustomerDets;
        private System.Windows.Forms.Label lblCustSurname;
        private System.Windows.Forms.Label lblCustForename;
        private System.Windows.Forms.Label lblCustTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblCustomerNum;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.ErrorProvider errP;
    }
}