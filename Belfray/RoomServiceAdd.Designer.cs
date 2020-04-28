namespace Belfray
{
    partial class RoomServiceAdd
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
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.pnlSearchDetails = new System.Windows.Forms.Panel();
            this.gbCustomerDets = new System.Windows.Forms.GroupBox();
            this.gbItemInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookingNum = new System.Windows.Forms.Label();
            this.lblCustomerNo = new System.Windows.Forms.Label();
            this.lblCustomerNum = new System.Windows.Forms.Label();
            this.lblCustomerTitle = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblCustTitle = new System.Windows.Forms.Label();
            this.lblCustForename = new System.Windows.Forms.Label();
            this.lblCustSurname = new System.Windows.Forms.Label();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.lblItemDescription = new System.Windows.Forms.Label();
            this.lblItemDesc = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picRemove = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlSearchDetails.SuspendLayout();
            this.gbCustomerDets.SuspendLayout();
            this.gbItemInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(1, 1);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(596, 347);
            this.dgvRooms.TabIndex = 9;
            // 
            // pnlSearchDetails
            // 
            this.pnlSearchDetails.BackColor = System.Drawing.Color.White;
            this.pnlSearchDetails.Controls.Add(this.groupBox1);
            this.pnlSearchDetails.Controls.Add(this.gbItemInfo);
            this.pnlSearchDetails.Controls.Add(this.gbCustomerDets);
            this.pnlSearchDetails.Location = new System.Drawing.Point(603, 1);
            this.pnlSearchDetails.Name = "pnlSearchDetails";
            this.pnlSearchDetails.Size = new System.Drawing.Size(615, 219);
            this.pnlSearchDetails.TabIndex = 10;
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
            // gbItemInfo
            // 
            this.gbItemInfo.Controls.Add(this.picAdd);
            this.gbItemInfo.Controls.Add(this.picRemove);
            this.gbItemInfo.Controls.Add(this.picCancel);
            this.gbItemInfo.Controls.Add(this.picSave);
            this.gbItemInfo.Controls.Add(this.label2);
            this.gbItemInfo.Controls.Add(this.label3);
            this.gbItemInfo.Controls.Add(this.txtQty);
            this.gbItemInfo.Controls.Add(this.lblQty);
            this.gbItemInfo.Controls.Add(this.lblItemPrice);
            this.gbItemInfo.Controls.Add(this.lblPrice);
            this.gbItemInfo.Controls.Add(this.lblItemDescription);
            this.gbItemInfo.Controls.Add(this.lblItemDesc);
            this.gbItemInfo.Controls.Add(this.lblItemNo);
            this.gbItemInfo.Controls.Add(this.lblItemNum);
            this.gbItemInfo.Enabled = false;
            this.gbItemInfo.Location = new System.Drawing.Point(341, 3);
            this.gbItemInfo.Name = "gbItemInfo";
            this.gbItemInfo.Size = new System.Drawing.Size(271, 213);
            this.gbItemInfo.TabIndex = 1;
            this.gbItemInfo.TabStop = false;
            this.gbItemInfo.Text = "Item Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBookingNum);
            this.groupBox1.Controls.Add(this.cmbItemType);
            this.groupBox1.Controls.Add(this.lblItemType);
            this.groupBox1.Controls.Add(this.lblRoomNo);
            this.groupBox1.Controls.Add(this.lblRoomNum);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Info";
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(603, 223);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentOrder.Size = new System.Drawing.Size(615, 125);
            this.dgvCurrentOrder.TabIndex = 11;
            // 
            // dgvItemList
            // 
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Location = new System.Drawing.Point(1, 1);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(596, 347);
            this.dgvItemList.TabIndex = 12;
            this.dgvItemList.Visible = false;
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Enabled = false;
            this.lblRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(289, 21);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(11, 15);
            this.lblRoomNo.TabIndex = 80;
            this.lblRoomNo.Text = "-";
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.AutoSize = true;
            this.lblRoomNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNum.Location = new System.Drawing.Point(218, 21);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(48, 15);
            this.lblRoomNum.TabIndex = 79;
            this.lblRoomNum.Text = "ROOM:";
            // 
            // cmbItemType
            // 
            this.cmbItemType.Enabled = false;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(119, 49);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(207, 21);
            this.cmbItemType.TabIndex = 82;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 15);
            this.label1.TabIndex = 84;
            this.label1.Text = "-";
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
            // lblCustomerNo
            // 
            this.lblCustomerNo.AutoSize = true;
            this.lblCustomerNo.Enabled = false;
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
            // lblCustTitle
            // 
            this.lblCustTitle.AutoSize = true;
            this.lblCustTitle.Enabled = false;
            this.lblCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTitle.Location = new System.Drawing.Point(116, 46);
            this.lblCustTitle.Name = "lblCustTitle";
            this.lblCustTitle.Size = new System.Drawing.Size(11, 15);
            this.lblCustTitle.TabIndex = 90;
            this.lblCustTitle.Text = "-";
            // 
            // lblCustForename
            // 
            this.lblCustForename.AutoSize = true;
            this.lblCustForename.Enabled = false;
            this.lblCustForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustForename.Location = new System.Drawing.Point(116, 71);
            this.lblCustForename.Name = "lblCustForename";
            this.lblCustForename.Size = new System.Drawing.Size(11, 15);
            this.lblCustForename.TabIndex = 91;
            this.lblCustForename.Text = "-";
            // 
            // lblCustSurname
            // 
            this.lblCustSurname.AutoSize = true;
            this.lblCustSurname.Enabled = false;
            this.lblCustSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustSurname.Location = new System.Drawing.Point(116, 96);
            this.lblCustSurname.Name = "lblCustSurname";
            this.lblCustSurname.Size = new System.Drawing.Size(11, 15);
            this.lblCustSurname.TabIndex = 92;
            this.lblCustSurname.Text = "-";
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Enabled = false;
            this.lblItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.Location = new System.Drawing.Point(116, 21);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(11, 15);
            this.lblItemNo.TabIndex = 88;
            this.lblItemNo.Text = "-";
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNum.Location = new System.Drawing.Point(6, 21);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(96, 15);
            this.lblItemNum.TabIndex = 87;
            this.lblItemNum.Text = "ITEM NUMBER:";
            // 
            // lblItemDescription
            // 
            this.lblItemDescription.AutoSize = true;
            this.lblItemDescription.Enabled = false;
            this.lblItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDescription.Location = new System.Drawing.Point(116, 46);
            this.lblItemDescription.Name = "lblItemDescription";
            this.lblItemDescription.Size = new System.Drawing.Size(11, 15);
            this.lblItemDescription.TabIndex = 90;
            this.lblItemDescription.Text = "-";
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDesc.Location = new System.Drawing.Point(6, 46);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(91, 15);
            this.lblItemDesc.TabIndex = 89;
            this.lblItemDesc.Text = "DESCRIPTION:";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Enabled = false;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPrice.Location = new System.Drawing.Point(116, 96);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(11, 15);
            this.lblItemPrice.TabIndex = 92;
            this.lblItemPrice.Text = "-";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 96);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 15);
            this.lblPrice.TabIndex = 91;
            this.lblPrice.Text = "PRICE:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(6, 121);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(68, 15);
            this.lblQty.TabIndex = 93;
            this.lblQty.Text = "QUANTITY:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(119, 120);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(57, 20);
            this.txtQty.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 95;
            this.label3.Text = "PRICE:";
            // 
            // picCancel
            // 
            this.picCancel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.picCancel.Location = new System.Drawing.Point(75, 167);
            this.picCancel.Name = "picCancel";
            this.picCancel.Size = new System.Drawing.Size(40, 40);
            this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCancel.TabIndex = 98;
            this.picCancel.TabStop = false;
            // 
            // picSave
            // 
            this.picSave.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picSave.Location = new System.Drawing.Point(213, 167);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(40, 40);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSave.TabIndex = 97;
            this.picSave.TabStop = false;
            this.picSave.Visible = false;
            // 
            // picRemove
            // 
            this.picRemove.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picRemove.Location = new System.Drawing.Point(121, 167);
            this.picRemove.Name = "picRemove";
            this.picRemove.Size = new System.Drawing.Size(40, 40);
            this.picRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemove.TabIndex = 99;
            this.picRemove.TabStop = false;
            this.picRemove.Visible = false;
            // 
            // picAdd
            // 
            this.picAdd.Image = global::Belfray.Properties.Resources.SaveButtonTest2;
            this.picAdd.Location = new System.Drawing.Point(167, 167);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(40, 40);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 100;
            this.picAdd.TabStop = false;
            this.picAdd.Visible = false;
            // 
            // RoomServiceAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.dgvCurrentOrder);
            this.Controls.Add(this.pnlSearchDetails);
            this.Controls.Add(this.dgvRooms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomServiceAdd";
            this.Text = "RoomServiceAdd";
            this.Load += new System.EventHandler(this.RoomServiceAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlSearchDetails.ResumeLayout(false);
            this.gbCustomerDets.ResumeLayout(false);
            this.gbCustomerDets.PerformLayout();
            this.gbItemInfo.ResumeLayout(false);
            this.gbItemInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Panel pnlSearchDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbItemInfo;
        private System.Windows.Forms.GroupBox gbCustomerDets;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookingNum;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItemDescription;
        private System.Windows.Forms.Label lblItemDesc;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Label lblCustSurname;
        private System.Windows.Forms.Label lblCustForename;
        private System.Windows.Forms.Label lblCustTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblCustomerTitle;
        private System.Windows.Forms.Label lblCustomerNo;
        private System.Windows.Forms.Label lblCustomerNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox picRemove;
        private System.Windows.Forms.PictureBox picCancel;
        private System.Windows.Forms.PictureBox picSave;
    }
}