using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;


namespace Belfray
{
    public partial class TableSelectEdit : Form
    {
        String connStr, sqlBooking, sqlCustomer, sqlBookingType, sqlPaymentType, sqlBookingDGV, sqlBookingItem, sqlItem, sqlBreakfast, sqlBookingDetails, sqlBill;
        String tableNumber = "", test = "", addTable = "";
        bool formLoad = true;
        bool getInfo, bookingInfo, avail, itemSelected;
        bool newCustomer, newBooking, tableSelected;
        int tableNoSelected, partySize, partySize2, tableSize, itemNoSelected;
        SqlDataAdapter daCustomer, daBooking, daBookingType, daPaymentType, daBookingDGV, daBookingItem, daItem, daBreakfast, daBDetails, daBill;// daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingType, cmdBPaymentType, cmdBBookingItem, cmdBItem, cmdBBDetails;
        DataRow drCustomer, drBooking, drBookingType, drPaymentType, drBookingItem, drItem, drBookingDetails;

        //GetProductNumber
        private void getCustNum(int noRows)
        {
            drCustomer = dsBelfray.Tables["Customer"].Rows[noRows - 1];

        }
        private void getBookingNum(int noRows)
        {
            drBooking = dsBelfray.Tables["Booking"].Rows[noRows - 1];
        }

        private void tbl2_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl2.BackColor = colour;
        }

        private void tbl2_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 2;
            lblTableNumDisplay.Text = "TB002";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl3_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 3;
            lblTableNumDisplay.Text = "TB003";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl3_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 135);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 135);
                pnlRed.Visible = true;
            }

            tbl3.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "3";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "3";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl3_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl3.BackColor = colour;
        }

        private void tbl4_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 4;
            lblTableNumDisplay.Text = "TB004";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl4_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 135);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 135);
                pnlRed.Visible = true;
            }

            tbl4.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "4";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "4";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl4_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl4.BackColor = colour;
        }

        private void tbl5_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 5;
            lblTableNumDisplay.Text = "TB005";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl5_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 135);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 135);
                pnlRed.Visible = true;
            }

            tbl5.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "5";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "5";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl5_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl5.BackColor = colour;
        }

        private void tbl6_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 6;
            lblTableNumDisplay.Text = "TB006";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl6_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(455, 135);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(455, 135);
                pnlRed.Visible = true;
            }

            tbl6.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "6";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "6";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl6_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl6.BackColor = colour;
        }

        private void tbl7_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 7;
            lblTableNumDisplay.Text = "TB007";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl7_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(470, 135);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(470, 135);
                pnlRed.Visible = true;
            }

            tbl7.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "7";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "7";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl7_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl7.BackColor = colour;
        }

        private void tbl8_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 8;
            lblTableNumDisplay.Text = "TB008";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl8_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 225);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 225);
                pnlRed.Visible = true;
            }

            tbl8.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "8";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "8";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl8_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl8.BackColor = colour;
        }

        private void tbl9_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 9;
            lblTableNumDisplay.Text = "TB009";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl9_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 225);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 225);
                pnlRed.Visible = true;
            }

            tbl9.BackColor = colour;
            //Set Pop-up box values (Green)
            lblGreenNo.Text = "9";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "9";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl9_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl9.BackColor = colour;
        }

        private void tbl10_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 10;
            lblTableNumDisplay.Text = "TB010";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl10_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 225);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 225);
                pnlRed.Visible = true;
            }

            tbl10.BackColor = colour;
            //Set Pop-up box values (Green)
            lblGreenNo.Text = "10";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "10";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl10_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl10.BackColor = colour;
        }

        private void tbl11_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 11;
            lblTableNumDisplay.Text = "TB011";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl11_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 225);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 225);
                pnlRed.Visible = true;
            }

            tbl11.BackColor = colour;
            //Set Pop-up box values (Green)
            lblGreenNo.Text = "11";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "11";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl11_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl11.BackColor = colour;
        }

        private void tbl12_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 12;
            lblTableNumDisplay.Text = "TB012";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl12_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 315);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 315);
                pnlRed.Visible = true;
            }

            tbl12.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "12";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "12";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl12_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl12.BackColor = colour;
        }

        private void tbl13_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 13;
            lblTableNumDisplay.Text = "TB013";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl13_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 315);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 315);
                pnlRed.Visible = true;
            }

            tbl13.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "13";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "13";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl13_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl13.BackColor = colour;
        }

        private void tbl14_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 14;
            lblTableNumDisplay.Text = "TB014";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl14_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 315);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 315);
                pnlRed.Visible = true;
            }

            tbl14.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "14";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "14";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl14_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl14.BackColor = colour;
        }

        private void tbl15_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 15;
            lblTableNumDisplay.Text = "TB015";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl15_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 315);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 315);
                pnlRed.Visible = true;
            }

            tbl15.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "15";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "15";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl15_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl15.BackColor = colour;
        }

        private void tbl16_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 16;
            lblTableNumDisplay.Text = "TB016";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl16_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            //string s = "4\n(6 add T6)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(442, 235);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(442, 235);
                pnlRed.Visible = true;
            }

            tbl16.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "16";
            lblGreenCapacityValue.Text = "4"; //s;

            //Set Pop-up box values (Red)
            lblRedNo.Text = "16";
            lblRedCapacityValue.Text = "4"; //s;
        }

        private void tbl16_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl16.BackColor = colour;
        }

        public void LoadMenu()
        {
            gbMenu.Visible = true;
            gbItems.Visible = true;
            cbMenuSelect.Visible = true;
            label2.Visible = true;
        }

        private void picFood_Click(object sender, EventArgs e)
        {

            if (tableSelected == false)
            {
                MessageBox.Show("Please select a table.");
            }

            foreach (DataRow drBook in dsBelfray.Tables["Book"].Rows)
            {
                string split = "";
                double price = 0.0;
                double qty = 0.0;
                double total = 0.0;
                
                if (drBook["bookingNo"].Equals(lblBookingNo.Text) && drBook["itemNo"].Equals(lblTblNoSelDisplay.Text))
                {
                    dgvTableItems.Rows.Add(drBook["bookingItemNo"].ToString(), drBook["itemDesc"].ToString(), drBook["bookingItemQty"].ToString(), drBook["itemPrice"].ToString());

                    //dgvTableItems.Columns[3].DefaultCellStyle.Format = "c2";
                    //dgvTableItems.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");

                    for (int i = 0; i < dgvTableItems.Rows.Count - 1; ++i)
                    {
                        qty = Convert.ToDouble(dgvTableItems.Rows[i].Cells[2].Value);
                        split = dgvTableItems.Rows[i].Cells[3].Value.ToString().Split('£').Last();
                        price = Convert.ToDouble(split);
                        total += price * qty;
                    }

                    lblCurrentBillDisplay.Text = "£" + total.ToString();

                }
                else
                {
                    pnlTableSelect.SendToBack();
                    pnlFloorPlan.Visible = false;
                    pnlFloorPlan.SendToBack();
                    pnlMenuItems.Visible = true;
                    pnlMenuItems.BringToFront();
                    LoadMenu();
                }
            }
            dgvTableItems.Columns[3].DefaultCellStyle.Format = "c2";
            dgvTableItems.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
        }

        private void dgvMenuItems_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count == 0)
            {
                Globals.itemSel = null;
            }
            else if (dgvBooking.SelectedRows.Count == 1)
            {
                //Format
                dgvMenuItems.Columns[2].DefaultCellStyle.Format = "c2";
                dgvMenuItems.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");

                Globals.itemSel = dgvMenuItems.SelectedRows[0].Cells[0].Value.ToString();
                lblItemSelected.Text = dgvMenuItems.SelectedRows[0].Cells[1].Value.ToString();
                lblPriceSelItem.Text = "£" + Math.Round(Convert.ToDecimal(dgvMenuItems.SelectedRows[0].Cells[2].Value.ToString()), 2);
                //Math.Round(Convert.ToDecimal(dgvMenuItems.SelectedRows[0].Cells[2].Value.ToString()), 2);
                lblItemNoDIsplay.Text = dgvMenuItems.SelectedRows[0].Cells[0].Value.ToString();
                //prdSel = Globals.prdNoSel;
            }
        }

        public void ClearLabels()
        {
            lblItemSelected.Text = "";
            lblPriceSelItem.Text = "";
            lblItemNoDIsplay.Text = "";

        }

        private bool checkAvailibility(string tableNo)
        {
            bool available = true;

            foreach (DataRow drVal in dsBelfray.Tables["Val"].Rows)
            {
                DateTime checkIn = Convert.ToDateTime(drVal["checkInDate"]);
                string bookingTime = drVal["bookingTime"].ToString().Substring(0, 5);

                if (tableNo.Equals(drVal["itemNo"].ToString()))
                {
                    if (dateBooking.Value.Year.CompareTo(checkIn.Year) == 0)
                    {
                        if (dateBooking.Value.Month.CompareTo(checkIn.Month) == 0)
                        {
                            if (dateBooking.Value.Day.CompareTo(checkIn.Day) == 0)
                            {
                                if (txtTime.Text.ToString().Equals(bookingTime))
                                {
                                    available = false;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            return available;
        }
        private void picEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow drBookingDetails in dsBelfray.Tables["BookingDetails"].Rows)
                {
                    if (drBookingDetails["bookingNo"].ToString().Equals(lblBookingNo.Text) && drBookingDetails["itemNo"].ToString().Equals(lblTblNoSelDisplay.Text))
                    {
                        drBookingDetails.Delete();
                    }
                }
                daBDetails.Update(dsBelfray, "BookingDetails");

                int rowCount = dgvTableItems.RowCount;

                for (int x = 0; x < rowCount - 1; x++)
                {
                    drBookingDetails = dsBelfray.Tables["BookingDetails"].NewRow();
                    drBookingDetails["bookingNo"] = lblBookingNo.Text;
                    drBookingDetails["itemNo"] = lblTableSelected.Text;
                    drBookingDetails["bookingItemNo"] = dgvTableItems.Rows[x].Cells[0].Value.ToString();
                    drBookingDetails["bookingItemQty"] = Convert.ToInt32(dgvTableItems.Rows[x].Cells[2].Value.ToString());
                    dsBelfray.Tables["BookingDetails"].Rows.Add(drBookingDetails);
                }

                daBDetails.Update(dsBelfray, "BookingDetails");

                MessageBox.Show("Table Items Edited");

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void picEditSave_MouseEnter(object sender, EventArgs e)
        {
            ToolTip editSave = new ToolTip();
            editSave.ShowAlways = true;
            editSave.ToolTipTitle = "Save Changes";
            editSave.ToolTipIcon = ToolTipIcon.Info;
            editSave.SetToolTip(picEditSave, "Please save if changes have been made to order");
        }

        private void picAddtoTable_MouseEnter(object sender, EventArgs e)
        {
            ToolTip addToTable = new ToolTip();
            addToTable.ShowAlways = true;
            addToTable.ToolTipTitle = "Add";
            addToTable.ToolTipIcon = ToolTipIcon.Info;
            addToTable.SetToolTip(picAddtoTable, "Add the selected item to the bill");
        }

        private void picAddToBill_MouseEnter(object sender, EventArgs e)
        {
            ToolTip addtoBill = new ToolTip();
            addtoBill.ShowAlways = true;
            addtoBill.ToolTipTitle = "Add";
            addtoBill.ToolTipIcon = ToolTipIcon.Info;
            addtoBill.SetToolTip(picAddToBill, "Add the selected items to the Table");
        }

        private void picRemoveItem_MouseEnter(object sender, EventArgs e)
        {
            ToolTip removeFromBill = new ToolTip();
            removeFromBill.ShowAlways = true;
            removeFromBill.ToolTipTitle = "Remove";
            removeFromBill.ToolTipIcon = ToolTipIcon.Info;
            removeFromBill.SetToolTip(picRemoveItem, "Remove the selected item from the Table");
        }

        private void picSaveBooking_MouseEnter(object sender, EventArgs e)
        {
            ToolTip saveEdit = new ToolTip();
            saveEdit.ShowAlways = true;
            saveEdit.ToolTipTitle = "Save";
            saveEdit.ToolTipIcon = ToolTipIcon.Info;
            saveEdit.SetToolTip(picSaveBooking, "Save any changes made to the booking.");
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            ToolTip cancelEdit = new ToolTip();
            cancelEdit.ShowAlways = true;
            cancelEdit.ToolTipTitle = "Cancel";
            cancelEdit.ToolTipIcon = ToolTipIcon.Info;
            cancelEdit.SetToolTip(picExit, "Exit without saving any changes.");
        }

        private void picAddtoTable_Click(object sender, EventArgs e)
        {
            bool ok = true;
            int rows = dgvTableItems.RowCount;
            bool newItem = false, firstline = false;
            double qty = 0.0;

            if (rows > 1)
            {
                firstline = false;

                for (int x = 0; x < rows - 1; x++)
                {
                    if (!lblItemNoDIsplay.Text.ToString().Equals(dgvTableItems.Rows[x].Cells[0].Value.ToString()))
                    {
                        newItem = true;

                    }
                    else
                    {
                        newItem = false;
                        break;
                    }
                }
            }
            else
            {
                newItem = true;
                firstline = true;
            }

            if (newItem)
            {
                try
                {
                    qty = Convert.ToInt32(numQTY.Value);
                    if (qty < 1 || qty > 9)
                    {
                        throw new MyException("Quantity must be a number between 1 and 9.");
                    }
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(numQTY, MyEx.toString());
                }
                //Try Adding
                try
                {
                    if (ok)
                    {
                                dgvTableItems.Rows.Add(lblItemNoDIsplay.Text, lblItemSelected.Text, numQTY.Value, lblPriceSelItem.Text);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Item Number " + lblItemNoDIsplay.Text + " has already been added, choose a new item or remove current Item from the order and add with correct quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Sum of party size
            double price = 0.0;
            double total = 0.0;
            string split = "";

            if (firstline)
            {
                split = lblPriceSelItem.Text.ToString().Split('£').Last();

                price = Convert.ToDouble(split);
                qty = Convert.ToDouble(numQTY.Value.ToString());
                lblCurrentBillDisplay.Text = Convert.ToString(qty * price);
            }
            else
            {
                for (int i = 0; i < dgvTableItems.Rows.Count -1; ++i)
                {
                    qty = Convert.ToDouble(dgvTableItems.Rows[i].Cells[2].Value);
                    split = dgvTableItems.Rows[i].Cells[3].Value.ToString().Split('£').Last();
                    price = Convert.ToDouble(split);
                    total += price * qty;
                }

                lblCurrentBillDisplay.Text = "£" + total.ToString();
            }
        }

        private void dgvAddNewTables_Click(object sender, EventArgs e)
        {
            if (dgvAddNewTables.SelectedRows.Count == 0)
            {
                itemSelected = false;
                itemNoSelected = 0;
                //prdSel = null;
            }
            else if (dgvAddNewTables.SelectedRows.Count == 1)
            {
                itemSelected = true;
                lblItemNoSel.Text = dgvAddNewTables.SelectedRows[0].Cells[0].Value.ToString();
                itemNoSelected = dgvAddNewTables.SelectedRows[0].Index;
                addTable = dgvAddNewTables.SelectedRows[0].Cells[1].Value.ToString();
                //prdSel = Globals.prdNoSel;
            }
        }

        private void picRemoveNewTables_Click(object sender, EventArgs e)
        {
            if (!itemSelected)
            {
                MessageBox.Show("Please select a table to remove it from the booking", "Remove a table", MessageBoxButtons.OK);
            }
            else
            {
                dgvAddNewTables.Rows.Remove(dgvAddNewTables.Rows[itemNoSelected]);
                lblItemNoSel.Text = "-";
                dgvAddNewTables.ClearSelection();
                //Sum of party size
                int currentTableSize = partySize2; //Convert.ToInt32(numPartySize.Value);
                numPartySize.Value = currentTableSize - tableSize;

                if (numPartySize.Value == 0)
                {
                    MessageBox.Show("Unable to remove all tables, Please delete booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void picSaveBooking_Click(object sender, EventArgs e)
        {
            MyCustomer myCust = new MyCustomer();
            MyBooking myBook = new MyBooking();
            bool ok = true;
            bool available = checkAvailibility(lblTableNo.Text.ToString());
            errP.Clear();

            //Customer Number
            try
            {
                myCust.CustomerNumber = lblCustNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblCustNo, MyEx.toString());
            }

            //Customer Title
            try
            {
                myCust.Title = cbTitle.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cbTitle, MyEx.toString());
            }

            //Customer Forename
            try
            {
                myCust.Forename = txtFname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtFname, MyEx.toString());
            }

            //Customer Surname
            try
            {
                myCust.Surname = txtLName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtLName, MyEx.toString());
            }

            //Customer Street
            try
            {
                myCust.Street = txtStreet.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtStreet, MyEx.toString());
            }

            //Customer City
            try
            {
                myCust.City = txtCity.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCity, MyEx.toString());
            }

            //Customer County
            try
            {
                myCust.County = txtCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCounty, MyEx.toString());
            }

            //Customer PostCode
            try
            {
                myCust.Postcode = txtPC.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPC, MyEx.toString());
            }

            //Customer TelNo
            try
            {
                myCust.TelNo = txtTelNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTelNo, MyEx.toString());
            }

            //Try Booking
            try
            {
                myBook.BookingNumber = lblBookingNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblBookingNo, MyEx.toString());
            }
            try
            {
                myBook.PartySize = Convert.ToInt32(numPartySize.Value);
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(numPartySize, MyEx.toString());
            }
            try
            {
                myBook.CheckInDate = dateBooking.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dateBooking, MyEx.toString());
            }
            try
            {
                myBook.BookingTime = txtTime.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtTime, MyEx.toString());
            }
            try
            {
                myBook.PaymentTypeID = cbPaymentTyp.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cbPaymentTyp, MyEx.toString());
            }
            //Val
            if (available)
            {
                ok = true;
            }
            else
            {
                string s1 = "Sorry\nTable already booked at this time.\n";
                string s2 = "Please try another table, or change time.";
                MessageBox.Show(s1 + s2, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ok = false;
            }
            //try editing now
            //Try Adding
            try
            {
                if (ok)
                {
                    drCustomer.BeginEdit();
                    drCustomer["customerNo"] = myCust.CustomerNumber;
                    drCustomer["customerTitle"] = myCust.Title;
                    drCustomer["customerForename"] = myCust.Forename;
                    drCustomer["customerSurname"] = myCust.Surname;
                    drCustomer["customerStreet"] = myCust.Street;
                    drCustomer["customerCity"] = myCust.City;
                    drCustomer["customerCounty"] = myCust.County;
                    drCustomer["customerPostcode"] = myCust.Postcode;
                    drCustomer["customerTel"] = myCust.TelNo;
                    drCustomer.EndEdit();
                    daCustomer.Update(dsBelfray, "Customer");

                }
                if (ok)
                {
                    drBooking.BeginEdit();
                    drBooking["bookingNo"] = myBook.BookingNumber;
                    drBooking["checkInDate"] = myBook.CheckInDate;
                    drBooking["bookingTime"] = myBook.BookingTime;
                    drBooking["customerNo"] = myCust.CustomerNumber;
                    drBooking["paymentTypeID"] = myBook.PaymentTypeID;
                    drBooking["partySize"] = myBook.PartySize;
                    drBooking.EndEdit();
                    daBooking.Update(dsBelfray, "Booking");
                }
                if (ok)
                {
                        int tableRows = dgvAddNewTables.RowCount - 1;

                        for (int x = 0; x < tableRows; x++)
                        {
                            drBookingItem = dsBelfray.Tables["BookingItem"].NewRow();
                            drBookingItem["bookingNo"] = dgvAddNewTables.Rows[x].Cells[0].Value.ToString();
                            drBookingItem["itemNo"] = dgvAddNewTables.Rows[x].Cells[1].Value.ToString();
                            drBookingItem["itemQty"] = DBNull.Value;
                            dsBelfray.Tables["BookingItem"].Rows.Add(drBookingItem);
                        }
                    daBookingItem.Update(dsBelfray, "BookingItem");
                    MessageBox.Show("Booking has been edited.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }

        private void picAddToBill_Click(object sender, EventArgs e)
        {
            //Try Adding
            try
            {
                int rowCount = dgvTableItems.RowCount;

                for (int x = 0; x < rowCount - 1; x++)
                {
                    drBookingDetails = dsBelfray.Tables["BookingDetails"].NewRow();
                    drBookingDetails["bookingNo"] = lblBookingNo.Text;
                    drBookingDetails["itemNo"] = lblTableSelected.Text;    
                    drBookingDetails["bookingItemNo"] = dgvTableItems.Rows[x].Cells[0].Value.ToString();
                    drBookingDetails["bookingItemQty"] = Convert.ToInt32(dgvTableItems.Rows[x].Cells[2].Value.ToString());
                    dsBelfray.Tables["BookingDetails"].Rows.Add(drBookingDetails);
                }

                daBDetails.Update(dsBelfray, "BookingDetails");

                MessageBox.Show("Items added to table.");
                dgvTableItems.Rows.Clear();
                dgvTableItems.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void picTables_Click(object sender, EventArgs e)
        {
            pnlTableSelect.BringToFront();
            pnlFloorPlan.Visible = true;
            pnlFloorPlan.BringToFront();
            pnlMenuItems.Visible = false;
            pnlMenuItems.SendToBack();
            LoadMenu();
        }

        private void picRemoveItem_Click(object sender, EventArgs e)
        {
            if (!itemSelected)
            {
                MessageBox.Show("Please select an Item to remove it from the table", "Remove an Item", MessageBoxButtons.OK);
            }
            else
            {
                dgvTableItems.Rows.Remove(dgvTableItems.Rows[itemNoSelected]);
                lblItemNoSel.Text = "-";
                dgvTableItems.ClearSelection();
            }
        }

        private void dgvTableItems_Click(object sender, EventArgs e)
        {
            if (dgvTableItems.SelectedRows.Count == 0)
            {
                itemSelected = false;
                itemNoSelected = 0;
                //prdSel = null;
            }
            else if (dgvTableItems.SelectedRows.Count == 1)
            {
                itemSelected = true;
                lblItemNoSel.Text = dgvTableItems.SelectedRows[0].Cells[0].Value.ToString();
                itemNoSelected = dgvTableItems.SelectedRows[0].Index;
                //prdSel = Globals.prdNoSel;
            }
        }

        private void picDrinks_Click(object sender, EventArgs e)
        {
            {

                if (tableSelected == false)
                {
                    MessageBox.Show("Please select a table.");
                }

                foreach (DataRow drDetails in dsBelfray.Tables["BookingDetails"].Rows)
                {
                    string split = "";
                    double price = 0.0;
                    double qty = 0.0;
                    double total = 0.0;

                    if (drDetails["bookingNo"].Equals(lblBookingNo.Text) && drDetails["itemNo"].Equals(lblTblNoSelDisplay.Text))
                    {
                        dgvTableItems.Columns.Clear();
                        DataView existingSearch = new DataView(dsBelfray.Tables["Book"], "bookingNo = '" + lblBookingNo.Text.ToString() + "' ", "bookingNo", DataViewRowState.CurrentRows);
                        dgvTableItems.DataSource = existingSearch;
                        //for each dr row in existingsearch 
                        //in the dog house check foreach dr in table whatever new row for dgv append into 0-1-2 add row to dgv
                        dgvTableItems.Columns[0].Visible = false;
                        dgvTableItems.Columns[2].Width = 250;
                        dgvTableItems.Columns[4].DefaultCellStyle.Format = "c2";
                        dgvTableItems.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");

                        for (int i = 0; i < dgvTableItems.Rows.Count - 1; ++i)
                        {
                            qty = Convert.ToDouble(dgvTableItems.Rows[i].Cells[3].Value);
                            split = dgvTableItems.Rows[i].Cells[4].Value.ToString().Split('£').Last();
                            price = Convert.ToDouble(split);
                            total += price * qty;
                        }

                        lblCurrentBillDisplay.Text = "£" + total.ToString();

                    }
                    else
                    {
                        pnlTableSelect.SendToBack();
                        pnlFloorPlan.Visible = false;
                        pnlFloorPlan.SendToBack();
                        pnlMenuItems.Visible = true;
                        pnlMenuItems.BringToFront();
                        LoadMenu();
                    }
                }
            }
        }

        private void cbMenuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMenuSelect.SelectedIndex == 0)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100003'";
                //sqlItem = @"SELECT Item.itemNo, Item.itemDesc, Item.typeID FROM Item
                //LEFT JOIN BType ON BType.typeID = Item.typeID
                //WHERE Item.typeID = 'TYP100003'";
                daItem = new SqlDataAdapter(sqlItem, connStr);
                //@"SELECT Item.itemNo AS 'Item No', Item.itemDesc AS 'Item Description', Item.itemPrice AS 'Price', BType.typeID AS 'Type ID' FROM Item

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Breakfast");
                daItem.Fill(dsBelfray, "Breakfast");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Breakfast"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }
            if (cbMenuSelect.SelectedIndex == 1)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100004'";
                daItem = new SqlDataAdapter(sqlItem, connStr);

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Lunch");
                daItem.Fill(dsBelfray, "Lunch");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Lunch"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }
            if (cbMenuSelect.SelectedIndex == 2)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100005'";
                daItem = new SqlDataAdapter(sqlItem, connStr);

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Starter");
                daItem.Fill(dsBelfray, "Starter");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Starter"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }
            if (cbMenuSelect.SelectedIndex == 3)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100006'";
                daItem = new SqlDataAdapter(sqlItem, connStr);

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Main");
                daItem.Fill(dsBelfray, "Main");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Main"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }
            if (cbMenuSelect.SelectedIndex == 4)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100007'";
                daItem = new SqlDataAdapter(sqlItem, connStr);

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Desert");
                daItem.Fill(dsBelfray, "Desert");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Desert"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }
            if (cbMenuSelect.SelectedIndex == 5)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100008'";
                daItem = new SqlDataAdapter(sqlItem, connStr);

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Drinks");
                daItem.Fill(dsBelfray, "Drinks");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Drinks"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }
            if (cbMenuSelect.SelectedIndex == 6)
            {
                //Load Menu DGV
                sqlItem = @"select itemNo AS 'Item No', itemDesc AS 'Item Desc', itemPrice AS 'Price' FROM Item WHERE typeID = 'TYP100010'";
                daItem = new SqlDataAdapter(sqlItem, connStr);

                daItem.FillSchema(dsBelfray, SchemaType.Source, "Kids");
                daItem.Fill(dsBelfray, "Kids");

                dgvMenuItems.Visible = true;
                dgvMenuItems.DataSource = dsBelfray.Tables["Kids"];
                //Resize
                //dgvMenuItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMenuItemFormat();
            }

        }
        public void dgvMenuItemFormat()
        {
            dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuItems.Columns[2].DefaultCellStyle.Format = "c2";
            dgvMenuItems.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
        }
        private void tbl17_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 17;
            lblTableNumDisplay.Text = "TB017";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl17_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            //string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(442, 325);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(442, 325);
                pnlRed.Visible = true;
            }

            tbl17.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "17";
            lblGreenCapacityValue.Text = "4";  //s;

            //Set Pop-up box values (Red)
            lblRedNo.Text = "17";
            lblRedCapacityValue.Text = "4";   //s;
        }

        private void tbl17_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl17.BackColor = colour;
        }

        private void picRemoveTable_Click(object sender, EventArgs e)
        {
            if (!tableSelected)
            {
                MessageBox.Show("Please select a table to remove it from the booking", "Remove a Table", MessageBoxButtons.OK);
                dgvBooking.Refresh();
            }
            else
            {
                if (MessageBox.Show("Deleting table " + lblTblNoSelDisplay.Text + ": Are you sure you wish to delete this from the booking?", "Delete Table", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string key1 = lblBookingNo.Text;
                    string key2 = lblTblNoSelDisplay.Text;

                    drBookingItem = dsBelfray.Tables["BookingItem"].Rows.Find(new object[] { key1, key2 });

                    if (drBookingItem["bookingNo"].Equals(key1) && drBookingItem["itemNo"].Equals(key2));                                                                                                            
                        {
                            drBookingItem.Delete();
                        }
                    MessageBox.Show("Table has been removed from this booking.");
                    daBookingItem.Update(dsBelfray, "BookingItem");

                    dgvBooking.Rows.Remove(dgvBooking.Rows[tableNoSelected]);
                    lblTblNoSelDisplay.Text = "";
                    lblTableNumDisplay.Text = "";
                    dgvBooking.ClearSelection();

                    //Sum of party size
                    int currentTableSize = Convert.ToInt32(numPartySize.Value);
                    string search = "TB00";
                    string search2 = "TB01";
                    string search3 = "TB02";

                    if (lblTblNoSelDisplay.Text.Contains(search) )
                    {
                        tableSize = 2;
                    }
                    if (lblTblNoSelDisplay.Text.Contains(search2) || lblTblNoSelDisplay.Text.Contains(search3) || lblTblNoSelDisplay.Text == "TB008" || lblTblNoSelDisplay.Text == "TB009")
                    {
                        tableSize = 4;
                    }
                    //Update Numparty Size
                    numPartySize.Value = currentTableSize - tableSize;

                    if (numPartySize.Value == 0)
                    {
                        MessageBox.Show("Unable to remove all tables, Please delete booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbl18_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 18;
            lblTableNumDisplay.Text = "TB018";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                tableSelected = false;
                tableNoSelected = 0;
                MessageBox.Show("Unable to remove all tables, Please delete booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvBooking.SelectedRows.Count == 1)
            {
                tableSelected = true;
                Globals.tableSel = dgvBooking.SelectedRows[0].Cells[0].Value.ToString();
                lblTblNoSelDisplay.Text = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();
                tableNoSelected = dgvBooking.SelectedRows[0].Index;
                lblTableNumDisplay.Text = lblTblNoSelDisplay.Text;
                lblTableSelected.Text = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();
                tableNumber = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();

                string search = "TB00";
                string search2 = "TB01";
                string search3 = "TB02";

                if (lblTblNoSelDisplay.Text.Contains(search))
                {
                    tableSize = 2;
                }
                if (lblTblNoSelDisplay.Text.Contains(search2))
                {
                    tableSize = 4;
                }
                if (lblTblNoSelDisplay.Text.Contains(search3))
                {
                    tableSize = 4;
                }
                else if (lblTblNoSelDisplay.Text == "TB008" || lblTblNoSelDisplay.Text == "TB009")
                {
                    tableSize = 4;
                }
            }
        }

        private void picAddTable_Click(object sender, EventArgs e)
        {
            try
            {
                    dgvAddNewTables.Rows.Add(lblBookingNo.Text, lblTableNumDisplay.Text);
                    int currentTableSize = Convert.ToInt32(numPartySize.Value);
                    numPartySize.Value = currentTableSize + partySize;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void tbl18_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            //string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(445, 405);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(445, 405);
                pnlRed.Visible = true;
            }

            tbl18.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "18";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "18";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl18_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl18.BackColor = colour;
        }

        private void tbl19_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 19;
            lblTableNumDisplay.Text = "TB019";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl19_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            //string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(440, 405);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(440, 405);
                pnlRed.Visible = true;
            }

            tbl19.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "19";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "19";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl19_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl19.BackColor = colour;
        }

        private void tbl20_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 20;
            lblTableNumDisplay.Text = "TB020";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl20_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 405);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 405);
                pnlRed.Visible = true;
            }

            tbl20.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "20";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "20";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl20_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl20.BackColor = colour;
        }

        private void tbl21_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 21;
            lblTableNumDisplay.Text = "TB021";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl21_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 405);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 405);
                pnlRed.Visible = true;
            }

            tbl21.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "21";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "21";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl21_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl21.BackColor = colour;
        }

        private void tbl22_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 22;
            lblTableNumDisplay.Text = "TB022";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl22_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 405);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 405);
                pnlRed.Visible = true;
            }

            tbl22.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "22";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "22";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl22_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl22.BackColor = colour;
        }

        private void tbl23_Click(object sender, EventArgs e)
        {
            partySize = 4;
            tableNoSelected = 23;
            lblTableNumDisplay.Text = "TB023";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl23_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 405);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 405);
                pnlRed.Visible = true;
            }

            tbl23.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "23";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "17";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl23_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl23.BackColor = colour;
        }

        private void tbl2_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 135);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 135);
                pnlRed.Visible = true;
            }

            tbl2.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "2";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "2";
            lblRedCapacityValue.Text = "2";
        }

        private void TableSelectEdit_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            formLoad = false;

            //SQL For Booking
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");
            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");
            //SQL for booking Type
            sqlBookingType = @"select * from BType";
            daBookingType = new SqlDataAdapter(sqlBookingType, connStr);
            cmdBBookingType = new SqlCommandBuilder(daBookingType);
            daBookingType.FillSchema(dsBelfray, SchemaType.Source, "BType");
            daBookingType.Fill(dsBelfray, "BType");
            //SQL for Payment Type
            sqlPaymentType = @"select * from Payment";
            daPaymentType = new SqlDataAdapter(sqlPaymentType, connStr);
            cmdBPaymentType = new SqlCommandBuilder(daPaymentType);
            daPaymentType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPaymentType.Fill(dsBelfray, "Payment");
            //SQL for bookingItem Type
            sqlBookingItem = @"select * from BookingItem WHERE itemNo LIKE 'TB%'";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookingItem");
            daBookingItem.Fill(dsBelfray, "BookingItem");
            //SQL for Item
            sqlItem = @"select * from Item";
            daItem = new SqlDataAdapter(sqlItem, connStr);
            cmdBItem = new SqlCommandBuilder(daItem);
            daItem.FillSchema(dsBelfray, SchemaType.Source, "Item");
            daItem.Fill(dsBelfray, "Item");
            //SQL for BookingDetails
            sqlBookingDetails = @"select * from BookingDetails";
            daBDetails = new SqlDataAdapter(sqlBookingDetails, connStr);
            cmdBBDetails = new SqlCommandBuilder(daBDetails);
            daBDetails.FillSchema(dsBelfray, SchemaType.Source, "BookingDetails");
            daBDetails.Fill(dsBelfray, "BookingDetails");
            //sql for bookings bill
            sqlBill = @"SELECT BookingDetails.bookingNo, BookingDetails.itemNo, BookingDetails.bookingItemNo, Item.itemDesc, BookingDetails.bookingItemQty, Item.itemPrice FROM BookingDetails       
                        LEFT JOIN Item on Item.itemNo = BookingDetails.bookingItemNo";
            daBill = new SqlDataAdapter(sqlBill, connStr);
            daBill.FillSchema(dsBelfray, SchemaType.Source, "Book");
            daBill.Fill(dsBelfray, "Book");
            //cbPayment type
            cbPaymentTyp.DataSource = dsBelfray.Tables["Payment"];
            cbPaymentTyp.ValueMember = "paymentTypeID";
            cbPaymentTyp.DisplayMember = "paymentTypeDesc";
            cbPaymentTyp.SelectedIndex = -1;
            //cb title
            cbTitle.DataSource = dsBelfray.Tables["Customer"];
            cbTitle.ValueMember = "customerTitle";
            cbTitle.DisplayMember = "customerTitle";
            cbTitle.SelectedIndex = -1;

            //Fill booking Details
            lblBookingNo.Text = Globals.bookSel.ToString();
            drBooking = dsBelfray.Tables["Booking"].Rows.Find(lblBookingNo.Text);

            foreach (DataRow drBooking in dsBelfray.Tables["Booking"].Rows)
            {
                foreach (DataRow drBookingType in dsBelfray.Tables["BType"].Rows)
                {
                        string bDate = drBooking["checkInDate"].ToString();
                        string bTime = drBooking["bookingTime"].ToString();
                        partySize2 = Convert.ToInt32(drBooking["partySize"].ToString());

                        dateBooking.Value = Convert.ToDateTime(bDate);
                        txtTime.Text = bTime;
                        numPartySize.Value = partySize2;
                        lblCustNo.Text = drBooking["customerNo"].ToString();
                        cbPaymentTyp.SelectedValue = drBooking["paymentTypeID"].ToString();
                }
            }
            //DGV Populate
            foreach (DataRow drTable in dsBelfray.Tables["BookingItem"].Rows)
            {
                string bookingNo = "";
                string itemNo = "";
                //string tableSize = "";

                if (drTable["bookingNo"].Equals(lblBookingNo.Text))
                {
                    bookingNo = drTable["bookingNo"].ToString();
                    itemNo = drTable["itemNo"].ToString();

                    dgvBooking.ColumnCount = 2;
                    dgvBooking.Columns[0].Name = "Booking Number";
                    //dgvBooking.Columns[0].Width = 150;
                    dgvBooking.Columns[1].Name = "Table Number";
                    //dgvBooking.Columns[1].Width = 130;
                    dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvBooking.Rows.Add(bookingNo, itemNo);
                }
            }
            //Fill Customer details
            drCustomer = dsBelfray.Tables["Customer"].Rows.Find(lblCustNo.Text);
            txtFname.Text = drCustomer["customerForename"].ToString();
            txtLName.Text = drCustomer["customerSurname"].ToString();
            txtStreet.Text = drCustomer["customerStreet"].ToString();
            txtCity.Text = drCustomer["customerCity"].ToString();
            txtCounty.Text = drCustomer["customerCounty"].ToString();
            txtPC.Text = drCustomer["customerPostcode"].ToString();
            txtTelNo.Text = drCustomer["customerTel"].ToString();
            cbTitle.SelectedValue = drCustomer["customerTitle"].ToString();

            dgvAddNewTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void tbl1_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();

            //foreach (DataGridViewRow row in dgvBooking.Rows)
            //{
            //    if (row.Cells[1].Value.ToString().Equals(tableNumber.ToString()))
            //    {
            //        avail = false;
            //    }
            //}
            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(8, 135);
                pnlGreen.Visible = true;
                pnlGreen.BringToFront();
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(8, 135);
                pnlRed.Visible = true;
            }

            tbl1.BackColor = colour;

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "1";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "1";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl1_MouseLeave(object sender, EventArgs e)
        {
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl1.BackColor = colour;
        }

        private void tbl1_Click(object sender, EventArgs e)
        {
            partySize = 2;
            tableNoSelected = 1;
            tableNumber = "001";
            test = tableNumber;
            lblTableNumDisplay.Text = "TB001";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        public TableSelectEdit()
        {
            InitializeComponent();
        }
    }
}
