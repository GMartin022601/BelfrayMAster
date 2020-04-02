namespace Belfray
{
    partial class RestaurantStockDelete
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
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblProdCode = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblProdNumber = new System.Windows.Forms.Label();
            this.lblProdDesc = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnCancelDel = new System.Windows.Forms.PictureBox();
            this.pnlProdType = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPTC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPTD = new System.Windows.Forms.Label();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSuName = new System.Windows.Forms.Label();
            this.lblSuID = new System.Windows.Forms.Label();
            this.lblSuAdd = new System.Windows.Forms.Label();
            this.lblSuTown = new System.Windows.Forms.Label();
            this.lblSuPC = new System.Windows.Forms.Label();
            this.lblSuTel = new System.Windows.Forms.Label();
            this.lblSuEma = new System.Windows.Forms.Label();
            this.pnlDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            this.pnlProduct.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelDel)).BeginInit();
            this.pnlProdType.SuspendLayout();
            this.pnlSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.pnlProduct);
            this.pnlDelete.Controls.Add(this.gbOptions);
            this.pnlDelete.Controls.Add(this.lblDescription);
            this.pnlDelete.Controls.Add(this.dgvOptions);
            this.pnlDelete.Controls.Add(this.cbSelect);
            this.pnlDelete.Location = new System.Drawing.Point(2, 2);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(1213, 341);
            this.pnlDelete.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 50);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(276, 16);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Please choose an option from the drop down:";
            // 
            // dgvOptions
            // 
            this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOptions.Location = new System.Drawing.Point(10, 74);
            this.dgvOptions.Name = "dgvOptions";
            this.dgvOptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOptions.Size = new System.Drawing.Size(682, 264);
            this.dgvOptions.TabIndex = 1;
            this.dgvOptions.Click += new System.EventHandler(this.DgvOptions_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Product",
            "Product Type",
            "Supplier"});
            this.cbSelect.Location = new System.Drawing.Point(292, 47);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(121, 21);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.CbSelect_SelectedIndexChanged);
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Controls.Add(this.label2);
            this.pnlProduct.Controls.Add(this.label3);
            this.pnlProduct.Controls.Add(this.label4);
            this.pnlProduct.Controls.Add(this.label5);
            this.pnlProduct.Controls.Add(this.label6);
            this.pnlProduct.Controls.Add(this.lblProdCode);
            this.pnlProduct.Controls.Add(this.lblSuppName);
            this.pnlProduct.Controls.Add(this.lblSupplierID);
            this.pnlProduct.Controls.Add(this.lblQty);
            this.pnlProduct.Controls.Add(this.lblProdNumber);
            this.pnlProduct.Controls.Add(this.lblProdDesc);
            this.pnlProduct.Location = new System.Drawing.Point(703, 83);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(348, 248);
            this.pnlProduct.TabIndex = 43;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnCancelDel);
            this.gbOptions.Controls.Add(this.btnDelete);
            this.gbOptions.Controls.Add(this.pnlSupplier);
            this.gbOptions.Controls.Add(this.pnlProdType);
            this.gbOptions.Location = new System.Drawing.Point(697, 67);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(516, 271);
            this.gbOptions.TabIndex = 42;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 67;
            this.label1.Text = "PRODUCT CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "SUPPLIER NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "SUPPLIER ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "QTY IN STOCK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "PRODUCT NUMBER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "PRODUCT NAME";
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCode.Location = new System.Drawing.Point(157, 36);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(15, 18);
            this.lblProdCode.TabIndex = 61;
            this.lblProdCode.Text = "x";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppName.Location = new System.Drawing.Point(157, 142);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(15, 18);
            this.lblSuppName.TabIndex = 60;
            this.lblSuppName.Text = "x";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(157, 115);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(15, 18);
            this.lblSupplierID.TabIndex = 59;
            this.lblSupplierID.Text = "x";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(157, 88);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(15, 18);
            this.lblQty.TabIndex = 58;
            this.lblQty.Text = "x";
            // 
            // lblProdNumber
            // 
            this.lblProdNumber.AutoSize = true;
            this.lblProdNumber.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdNumber.Location = new System.Drawing.Point(157, 61);
            this.lblProdNumber.Name = "lblProdNumber";
            this.lblProdNumber.Size = new System.Drawing.Size(15, 18);
            this.lblProdNumber.TabIndex = 57;
            this.lblProdNumber.Text = "x";
            // 
            // lblProdDesc
            // 
            this.lblProdDesc.AutoSize = true;
            this.lblProdDesc.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdDesc.Location = new System.Drawing.Point(157, 12);
            this.lblProdDesc.Name = "lblProdDesc";
            this.lblProdDesc.Size = new System.Drawing.Size(15, 18);
            this.lblProdDesc.TabIndex = 56;
            this.lblProdDesc.Text = "x";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Belfray.Properties.Resources.DeleteButton;
            this.btnDelete.Location = new System.Drawing.Point(360, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 48);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 55;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnCancelDel
            // 
            this.btnCancelDel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.btnCancelDel.Location = new System.Drawing.Point(425, 216);
            this.btnCancelDel.Name = "btnCancelDel";
            this.btnCancelDel.Size = new System.Drawing.Size(59, 48);
            this.btnCancelDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelDel.TabIndex = 54;
            this.btnCancelDel.TabStop = false;
            // 
            // pnlProdType
            // 
            this.pnlProdType.Controls.Add(this.lblPTD);
            this.pnlProdType.Controls.Add(this.label8);
            this.pnlProdType.Controls.Add(this.lblPTC);
            this.pnlProdType.Controls.Add(this.label7);
            this.pnlProdType.Location = new System.Drawing.Point(6, 17);
            this.pnlProdType.Name = "pnlProdType";
            this.pnlProdType.Size = new System.Drawing.Size(348, 248);
            this.pnlProdType.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "PRODUCT TYPE CODE";
            // 
            // lblPTC
            // 
            this.lblPTC.AutoSize = true;
            this.lblPTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTC.Location = new System.Drawing.Point(215, 30);
            this.lblPTC.Name = "lblPTC";
            this.lblPTC.Size = new System.Drawing.Size(16, 16);
            this.lblPTC.TabIndex = 1;
            this.lblPTC.Text = "X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "PRODUCT TYPE DESCRIPTION";
            // 
            // lblPTD
            // 
            this.lblPTD.AutoSize = true;
            this.lblPTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTD.Location = new System.Drawing.Point(215, 70);
            this.lblPTD.Name = "lblPTD";
            this.lblPTD.Size = new System.Drawing.Size(16, 16);
            this.lblPTD.TabIndex = 3;
            this.lblPTD.Text = "X";
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Controls.Add(this.lblSuEma);
            this.pnlSupplier.Controls.Add(this.lblSuTel);
            this.pnlSupplier.Controls.Add(this.lblSuPC);
            this.pnlSupplier.Controls.Add(this.lblSuTown);
            this.pnlSupplier.Controls.Add(this.lblSuAdd);
            this.pnlSupplier.Controls.Add(this.lblSuID);
            this.pnlSupplier.Controls.Add(this.lblSuName);
            this.pnlSupplier.Controls.Add(this.label15);
            this.pnlSupplier.Controls.Add(this.label14);
            this.pnlSupplier.Controls.Add(this.label13);
            this.pnlSupplier.Controls.Add(this.label12);
            this.pnlSupplier.Controls.Add(this.label11);
            this.pnlSupplier.Controls.Add(this.label10);
            this.pnlSupplier.Controls.Add(this.label9);
            this.pnlSupplier.Location = new System.Drawing.Point(6, 16);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(348, 248);
            this.pnlSupplier.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "SUPPLIER NAME";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "SUPPLIER ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "ADDRESS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "TOWN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "POSTCODE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "PHONE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 6;
            this.label15.Text = "EMAIL";
            // 
            // lblSuName
            // 
            this.lblSuName.AutoSize = true;
            this.lblSuName.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuName.Location = new System.Drawing.Point(146, 20);
            this.lblSuName.Name = "lblSuName";
            this.lblSuName.Size = new System.Drawing.Size(16, 18);
            this.lblSuName.TabIndex = 7;
            this.lblSuName.Text = "X";
            // 
            // lblSuID
            // 
            this.lblSuID.AutoSize = true;
            this.lblSuID.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuID.Location = new System.Drawing.Point(146, 50);
            this.lblSuID.Name = "lblSuID";
            this.lblSuID.Size = new System.Drawing.Size(16, 18);
            this.lblSuID.TabIndex = 8;
            this.lblSuID.Text = "X";
            // 
            // lblSuAdd
            // 
            this.lblSuAdd.AutoSize = true;
            this.lblSuAdd.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuAdd.Location = new System.Drawing.Point(146, 79);
            this.lblSuAdd.Name = "lblSuAdd";
            this.lblSuAdd.Size = new System.Drawing.Size(16, 18);
            this.lblSuAdd.TabIndex = 9;
            this.lblSuAdd.Text = "X";
            // 
            // lblSuTown
            // 
            this.lblSuTown.AutoSize = true;
            this.lblSuTown.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuTown.Location = new System.Drawing.Point(146, 106);
            this.lblSuTown.Name = "lblSuTown";
            this.lblSuTown.Size = new System.Drawing.Size(16, 18);
            this.lblSuTown.TabIndex = 10;
            this.lblSuTown.Text = "X";
            // 
            // lblSuPC
            // 
            this.lblSuPC.AutoSize = true;
            this.lblSuPC.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuPC.Location = new System.Drawing.Point(146, 133);
            this.lblSuPC.Name = "lblSuPC";
            this.lblSuPC.Size = new System.Drawing.Size(16, 18);
            this.lblSuPC.TabIndex = 11;
            this.lblSuPC.Text = "X";
            // 
            // lblSuTel
            // 
            this.lblSuTel.AutoSize = true;
            this.lblSuTel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuTel.Location = new System.Drawing.Point(146, 160);
            this.lblSuTel.Name = "lblSuTel";
            this.lblSuTel.Size = new System.Drawing.Size(16, 18);
            this.lblSuTel.TabIndex = 12;
            this.lblSuTel.Text = "X";
            // 
            // lblSuEma
            // 
            this.lblSuEma.AutoSize = true;
            this.lblSuEma.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuEma.Location = new System.Drawing.Point(146, 191);
            this.lblSuEma.Name = "lblSuEma";
            this.lblSuEma.Size = new System.Drawing.Size(16, 18);
            this.lblSuEma.TabIndex = 13;
            this.lblSuEma.Text = "X";
            // 
            // RestaurantStockDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 345);
            this.Controls.Add(this.pnlDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestaurantStockDelete";
            this.Text = "RestaurantStockDelete";
            this.Load += new System.EventHandler(this.RestaurantStockDelete_Load);
            this.pnlDelete.ResumeLayout(false);
            this.pnlDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelDel)).EndInit();
            this.pnlProdType.ResumeLayout(false);
            this.pnlProdType.PerformLayout();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.DataGridView dgvOptions;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblProdCode;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblProdNumber;
        private System.Windows.Forms.Label lblProdDesc;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnCancelDel;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Panel pnlProdType;
        private System.Windows.Forms.Label lblPTD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSuEma;
        private System.Windows.Forms.Label lblSuTel;
        private System.Windows.Forms.Label lblSuPC;
        private System.Windows.Forms.Label lblSuTown;
        private System.Windows.Forms.Label lblSuAdd;
        private System.Windows.Forms.Label lblSuID;
        private System.Windows.Forms.Label lblSuName;
        private System.Windows.Forms.Label label15;
    }
}