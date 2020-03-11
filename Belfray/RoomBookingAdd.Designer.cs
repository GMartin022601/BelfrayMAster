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
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.pnlBookingDets = new System.Windows.Forms.Panel();
            this.pnlRoomPics = new System.Windows.Forms.Panel();
            this.pnlType = new System.Windows.Forms.Panel();
            this.pnlPaymentType = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.White;
            this.pnlCustomer.Location = new System.Drawing.Point(641, 95);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(576, 253);
            this.pnlCustomer.TabIndex = 3;
            // 
            // pnlBookingDets
            // 
            this.pnlBookingDets.BackColor = System.Drawing.Color.White;
            this.pnlBookingDets.Location = new System.Drawing.Point(349, 1);
            this.pnlBookingDets.Name = "pnlBookingDets";
            this.pnlBookingDets.Size = new System.Drawing.Size(286, 347);
            this.pnlBookingDets.TabIndex = 4;
            // 
            // pnlRoomPics
            // 
            this.pnlRoomPics.BackColor = System.Drawing.Color.White;
            this.pnlRoomPics.Location = new System.Drawing.Point(3, 1);
            this.pnlRoomPics.Name = "pnlRoomPics";
            this.pnlRoomPics.Size = new System.Drawing.Size(340, 347);
            this.pnlRoomPics.TabIndex = 5;
            // 
            // pnlType
            // 
            this.pnlType.BackColor = System.Drawing.Color.White;
            this.pnlType.Location = new System.Drawing.Point(641, 1);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(285, 88);
            this.pnlType.TabIndex = 6;
            // 
            // pnlPaymentType
            // 
            this.pnlPaymentType.BackColor = System.Drawing.Color.White;
            this.pnlPaymentType.Location = new System.Drawing.Point(932, 1);
            this.pnlPaymentType.Name = "pnlPaymentType";
            this.pnlPaymentType.Size = new System.Drawing.Size(285, 88);
            this.pnlPaymentType.TabIndex = 7;
            // 
            // RoomBookingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 349);
            this.Controls.Add(this.pnlPaymentType);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.pnlRoomPics);
            this.Controls.Add(this.pnlBookingDets);
            this.Controls.Add(this.pnlCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomBookingAdd";
            this.Text = "BookingAdd";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel pnlBookingDets;
        private System.Windows.Forms.Panel pnlRoomPics;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.Panel pnlPaymentType;
    }
}