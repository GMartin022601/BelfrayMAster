namespace Belfray
{
    partial class RestaurantProdSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantProdSearch));
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picClear = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProdNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(3, 3);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearch.Size = new System.Drawing.Size(889, 179);
            this.dgvSearch.TabIndex = 3;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtProdDesc);
            this.pnlSearch.Controls.Add(this.label4);
            this.pnlSearch.Controls.Add(this.txtProdType);
            this.pnlSearch.Controls.Add(this.picClear);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.txtSupplier);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.txtProdNumber);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSearch.Location = new System.Drawing.Point(3, 188);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(738, 158);
            this.pnlSearch.TabIndex = 4;
            // 
            // picClear
            // 
            this.picClear.Image = global::Belfray.Properties.Resources.Cancel3;
            this.picClear.Location = new System.Drawing.Point(621, 73);
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
            this.picSearch.Location = new System.Drawing.Point(667, 73);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(40, 40);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 64;
            this.picSearch.TabStop = false;
            this.picSearch.Visible = false;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(536, 42);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(171, 25);
            this.txtSupplier.TabIndex = 45;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Search by Supplier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search by Product Type:";
            // 
            // txtProdNumber
            // 
            this.txtProdNumber.Location = new System.Drawing.Point(201, 7);
            this.txtProdNumber.Name = "txtProdNumber";
            this.txtProdNumber.Size = new System.Drawing.Size(171, 25);
            this.txtProdNumber.TabIndex = 1;
            this.txtProdNumber.TextChanged += new System.EventHandler(this.txtProdNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Product Number:";
            // 
            // txtProdType
            // 
            this.txtProdType.Location = new System.Drawing.Point(536, 7);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.Size = new System.Drawing.Size(171, 25);
            this.txtProdType.TabIndex = 71;
            this.txtProdType.TextChanged += new System.EventHandler(this.txtProdType_TextChanged);
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(201, 42);
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(171, 25);
            this.txtProdDesc.TabIndex = 73;
            this.txtProdDesc.TextChanged += new System.EventHandler(this.txtProdDesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Search by Product Description:";
            // 
            // RestaurantProdSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.pnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestaurantProdSearch";
            this.Text = "RestaurantProdSearch";
            this.Load += new System.EventHandler(this.RestaurantProdSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.PictureBox picClear;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProdNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label label4;
    }
}