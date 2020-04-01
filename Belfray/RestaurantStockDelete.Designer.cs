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
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnCancelDel = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.pnlDelete.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDelete
            // 
            this.pnlDelete.Controls.Add(this.gbOptions);
            this.pnlDelete.Controls.Add(this.lblDescription);
            this.pnlDelete.Controls.Add(this.dgvOptions);
            this.pnlDelete.Controls.Add(this.cbSelect);
            this.pnlDelete.Location = new System.Drawing.Point(2, 2);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(1213, 341);
            this.pnlDelete.TabIndex = 0;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnDelete);
            this.gbOptions.Controls.Add(this.btnCancelDel);
            this.gbOptions.Location = new System.Drawing.Point(1014, 240);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(172, 80);
            this.gbOptions.TabIndex = 42;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Belfray.Properties.Resources.DeleteButton;
            this.btnDelete.Location = new System.Drawing.Point(6, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 48);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 41;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnCancelDel
            // 
            this.btnCancelDel.Image = global::Belfray.Properties.Resources.Cancel3;
            this.btnCancelDel.Location = new System.Drawing.Point(107, 19);
            this.btnCancelDel.Name = "btnCancelDel";
            this.btnCancelDel.Size = new System.Drawing.Size(59, 48);
            this.btnCancelDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancelDel.TabIndex = 40;
            this.btnCancelDel.TabStop = false;
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
            this.dgvOptions.Size = new System.Drawing.Size(878, 264);
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
            this.gbOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.DataGridView dgvOptions;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox btnCancelDel;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.PictureBox btnDelete;
    }
}