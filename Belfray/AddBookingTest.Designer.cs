namespace Belfray
{
    partial class AddBookingTest
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
            this.pnlMenuItems = new System.Windows.Forms.Panel();
            this.cbMenuSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.dgvTableItems = new System.Windows.Forms.DataGridView();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.picRemoveItem = new System.Windows.Forms.PictureBox();
            this.picAddToBill = new System.Windows.Forms.PictureBox();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.picAddtoTable = new System.Windows.Forms.PictureBox();
            this.pnlMenuItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableItems)).BeginInit();
            this.gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRemoveItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddToBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddtoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuItems
            // 
            this.pnlMenuItems.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenuItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuItems.Controls.Add(this.gbMenu);
            this.pnlMenuItems.Controls.Add(this.gbItems);
            this.pnlMenuItems.Controls.Add(this.cbMenuSelect);
            this.pnlMenuItems.Controls.Add(this.label1);
            this.pnlMenuItems.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMenuItems.Location = new System.Drawing.Point(23, 33);
            this.pnlMenuItems.Name = "pnlMenuItems";
            this.pnlMenuItems.Size = new System.Drawing.Size(629, 493);
            this.pnlMenuItems.TabIndex = 87;
            this.pnlMenuItems.Visible = false;
            // 
            // cbMenuSelect
            // 
            this.cbMenuSelect.FormattingEnabled = true;
            this.cbMenuSelect.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Kids Meals",
            "Drinks"});
            this.cbMenuSelect.Location = new System.Drawing.Point(272, 16);
            this.cbMenuSelect.Name = "cbMenuSelect";
            this.cbMenuSelect.Size = new System.Drawing.Size(121, 26);
            this.cbMenuSelect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please use the drop down to choose items:";
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrinks.Location = new System.Drawing.Point(689, 33);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(629, 515);
            this.pnlDrinks.TabIndex = 87;
            this.pnlDrinks.Visible = false;
            // 
            // dgvTableItems
            // 
            this.dgvTableItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableItems.Location = new System.Drawing.Point(6, 24);
            this.dgvTableItems.Name = "dgvTableItems";
            this.dgvTableItems.Size = new System.Drawing.Size(594, 130);
            this.dgvTableItems.TabIndex = 2;
            // 
            // gbItems
            // 
            this.gbItems.Controls.Add(this.picAddToBill);
            this.gbItems.Controls.Add(this.picRemoveItem);
            this.gbItems.Controls.Add(this.dgvTableItems);
            this.gbItems.Location = new System.Drawing.Point(12, 262);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(606, 190);
            this.gbItems.TabIndex = 3;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Items Added";
            // 
            // picRemoveItem
            // 
            this.picRemoveItem.Image = global::Belfray.Properties.Resources.Remove__2_;
            this.picRemoveItem.Location = new System.Drawing.Point(546, 160);
            this.picRemoveItem.Name = "picRemoveItem";
            this.picRemoveItem.Size = new System.Drawing.Size(24, 24);
            this.picRemoveItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRemoveItem.TabIndex = 83;
            this.picRemoveItem.TabStop = false;
            // 
            // picAddToBill
            // 
            this.picAddToBill.Enabled = false;
            this.picAddToBill.Image = global::Belfray.Properties.Resources.AddNew;
            this.picAddToBill.Location = new System.Drawing.Point(576, 160);
            this.picAddToBill.Name = "picAddToBill";
            this.picAddToBill.Size = new System.Drawing.Size(24, 24);
            this.picAddToBill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddToBill.TabIndex = 84;
            this.picAddToBill.TabStop = false;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(6, 24);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.Size = new System.Drawing.Size(594, 140);
            this.dgvMenuItems.TabIndex = 4;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.picAddtoTable);
            this.gbMenu.Controls.Add(this.dgvMenuItems);
            this.gbMenu.Location = new System.Drawing.Point(12, 59);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(606, 197);
            this.gbMenu.TabIndex = 5;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // picAddtoTable
            // 
            this.picAddtoTable.Enabled = false;
            this.picAddtoTable.Image = global::Belfray.Properties.Resources.AddNew;
            this.picAddtoTable.Location = new System.Drawing.Point(576, 167);
            this.picAddtoTable.Name = "picAddtoTable";
            this.picAddtoTable.Size = new System.Drawing.Size(24, 24);
            this.picAddtoTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddtoTable.TabIndex = 86;
            this.picAddtoTable.TabStop = false;
            // 
            // AddBookingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 605);
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.pnlMenuItems);
            this.Name = "AddBookingTest";
            this.Text = "AddBookingTest";
            this.pnlMenuItems.ResumeLayout(false);
            this.pnlMenuItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableItems)).EndInit();
            this.gbItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRemoveItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddToBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.gbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAddtoTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuItems;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.ComboBox cbMenuSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.DataGridView dgvTableItems;
        private System.Windows.Forms.PictureBox picRemoveItem;
        private System.Windows.Forms.PictureBox picAddToBill;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.PictureBox picAddtoTable;
        private System.Windows.Forms.DataGridView dgvMenuItems;
    }
}