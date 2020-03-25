namespace Belfray
{
    partial class RestaurantStockDisplay
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
            this.dgvRestStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRestStock
            // 
            this.dgvRestStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestStock.Location = new System.Drawing.Point(1, 1);
            this.dgvRestStock.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRestStock.Name = "dgvRestStock";
            this.dgvRestStock.RowTemplate.Height = 28;
            this.dgvRestStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestStock.Size = new System.Drawing.Size(1211, 342);
            this.dgvRestStock.TabIndex = 1;
            this.dgvRestStock.Click += new System.EventHandler(this.DgvRestStock_Click);
            // 
            // RestaurantStockDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 343);
            this.Controls.Add(this.dgvRestStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestaurantStockDisplay";
            this.Text = "RestDisp";
            this.Load += new System.EventHandler(this.RestaurantStockDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRestStock;
    }
}