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

namespace Belfray
{
    public partial class RoomBookingEdit : Form
    {
        SqlDataAdapter daBooking, daCustomer, daPayType, daRoom;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer, cmdBPayType, cmdBRoom;
        DataRow drBooking, drCustomer, drPayType, drRoom;
        String connStr, sqlBooking, sqlCustomer, sqlPayType, sqlRoom;

        //Edit Cancelled
        public static bool cancelled = false;

        //Check if user Changes the Combobox
        private bool userActivated = false;

        public RoomBookingEdit()
        {
            InitializeComponent();
        }

        private void RoomBookingEdit_Load(object sender, EventArgs e)
        {
            //Current User
            string bookingNo = "";

            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
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

            //SQL For Payment Type
            sqlPayType = @"select * from Payment";
            daPayType = new SqlDataAdapter(sqlPayType, connStr);
            cmdBPayType = new SqlCommandBuilder(daPayType);
            daPayType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPayType.Fill(dsBelfray, "Payment");

            //SQL For Room
            sqlRoom = @"select * from BookingItem WHERE itemNo LIKE 'RM%'";
            daRoom = new SqlDataAdapter(sqlRoom, connStr);
            cmdBRoom = new SqlCommandBuilder(daRoom);
            daRoom.FillSchema(dsBelfray, SchemaType.Source, "BookingItem");
            daRoom.Fill(dsBelfray, "BookingItem");

            

            //CB Details Customer
            cmbCustomerNo.DataSource = dsBelfray.Tables["Customer"];
            cmbCustomerNo.ValueMember = "customerNo";
            cmbCustomerNo.DisplayMember = "customerNo";
            cmbCustomerNo.SelectedIndex = -1;

            //CB Details Title
            cmbTitle.ValueMember = "customerTitle";
            cmbTitle.DisplayMember = "customerTitle";
            cmbTitle.SelectedIndex = -1;

            //CB Details Payment type
            cmbPayType.DataSource = dsBelfray.Tables["Payment"];
            cmbPayType.ValueMember = "paymentTypeID";
            cmbPayType.DisplayMember = "paymentTypeDesc";
            cmbPayType.SelectedIndex = -1;
            
            //Fill Form
            lblBookingNo.Text = Globals.bookNoSel.ToString();

            //Booking Dets
            drBooking = dsBelfray.Tables["Booking"].Rows.Find(lblBookingNo.Text);

            if (Globals.firstLoad)
            {
                foreach (DataRow drRoom in dsBelfray.Tables["BookingItem"].Rows)
                {
                    string bookNumber = "";
                    string itemNumber = "";
                    if (drRoom["bookingNo"].Equals(lblBookingNo.Text))
                    {
                        bookNumber = drRoom["bookingNo"].ToString();
                        itemNumber = drRoom["itemNo"].ToString();
                        dgvRooms.ColumnCount = 2;
                        dgvRooms.Columns[0].Name = "Booking Number";
                        dgvRooms.Columns[0].Width = 288;
                        dgvRooms.Columns[1].Name = "Room Number";
                        dgvRooms.Columns[1].Width = 188;
                        dgvRooms.Rows.Add(bookNumber, itemNumber);
                        //dgvRooms.DataSource = dsBelfray.Tables["bookingItem"].Rows;
                    }
                }
                dtpBookingCheckIn.Value = Convert.ToDateTime(drBooking["checkInDate"]);
                dtpBookingCheckOut.Value = Convert.ToDateTime(drBooking["checkOutDate"]);

                Globals.firstLoad = false;
            }
            else
            {
                drRoom["bookingNo"] = lblBookingNo.Text;
                drRoom["itemNo"] = "RM" + RoomSelect.roomSelected;
                dtpBookingCheckIn.Value = RoomSelect.checkInDate;
                dtpBookingCheckOut.Value = RoomSelect.checkOutDate;

                daRoom.Update(dsBelfray, "BookingItem");

                foreach (DataRow drRoom in dsBelfray.Tables["BookingItem"].Rows)
                {
                    if (drRoom["bookingNo"].Equals(lblBookingNo.Text))
                    {
                        dgvRooms.DataSource = dsBelfray.Tables["bookingItem"];
                    }
                }

                Globals.firstLoad = false;

                picBookingEdit_Click(sender, e);
            }


            int payNoRows = dsBelfray.Tables["Payment"].Rows.Count;

            for(int x = 0; x < (payNoRows-1); x++)
            {
                cmbPayType.SelectedIndex = x;
                if(drBooking["paymentTypeID"].Equals(cmbPayType.SelectedValue))
                {
                    break;
                }
            }

            int cusNoRows = dsBelfray.Tables["Customer"].Rows.Count;

            for(int x = 0; x < (cusNoRows - 1); x++)
            {
                cmbCustomerNo.SelectedIndex = x;
                if (drBooking["CustomerNo"].Equals(cmbCustomerNo.SelectedValue))
                {
                    break;
                }
            }
            
            lblCheckInTime.Text = drBooking["bookingTime"].ToString();
            txtPartySize.Text = drBooking["partySize"].ToString();

            //Customer Dets
            drCustomer = dsBelfray.Tables["Customer"].Rows.Find(cmbCustomerNo.SelectedValue);
            lblCustNo.Text = cmbCustomerNo.SelectedValue.ToString();

            if (drCustomer["customerTitle"].ToString() == "MR")
            {
                cmbTitle.SelectedIndex = 0;
            }
            if (drCustomer["customerTitle"].ToString() == "MISS")
            {
                cmbTitle.SelectedIndex = 1;
            }
            if (drCustomer["customerTitle"].ToString() == "MRS")
            {
                cmbTitle.SelectedIndex = 2;
            }
            if (drCustomer["customerTitle"].ToString() == "MS")
            {
                cmbTitle.SelectedIndex = 3;
            }
            if (drCustomer["customerTitle"].ToString() == "DR")
            {
                cmbTitle.SelectedIndex = 4;
            }

            txtForename.Text = drCustomer["customerForename"].ToString();
            txtSurname.Text = drCustomer["customerSurname"].ToString();
            txtStreet.Text = drCustomer["customerStreet"].ToString();
            txtCity.Text = drCustomer["customerCity"].ToString();
            txtCounty.Text = drCustomer["customerCounty"].ToString();
            txtPostcode.Text = drCustomer["customerPostcode"].ToString();
            txtPhoneNo.Text = drCustomer["customerTel"].ToString();

            userActivated = true;

            //for (int x = 0; x < 19; x++)
            //{
            //    if (Globals.rooms[x].Contains(" "))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        dgvRooms.Rows.Add(lblBookingNo.Text, Globals.rooms[x].ToString());
            //    }
            //}

            ////Capacity
            //drRoom = dsBelfray.Tables["Rooms"].Rows.Find(lblRoomNo.Text);
            //MainWindow.maxCap = Convert.ToInt32(drRoom["capacity"]);

        }

        //Enables Booking Fields
        private void enableBookingEdit()
        {
            //chkEditDates.Enabled = true;
            chkEditCustomer.Enabled = true;
            txtPartySize.Enabled = true;
            cmbCustomerNo.Enabled = true;
            cmbPayType.Enabled = true;

            picBookingEdit.Visible = false;
            picBookingCancel.Visible = false;
            picBookingSave.Visible = true;
            picBookingSaveCancel.Visible = true;

            picAddRoom.Enabled = true;
            picRemoveRoom.Enabled = true;
        }

        //Disables Booking Fields
        private void disableBookingEdit()
        {
            //chkEditDates.Enabled = false;
            chkEditCustomer.Enabled = false;
            txtPartySize.Enabled = false;
            cmbCustomerNo.Enabled = false;
            cmbPayType.Enabled = false;

            picBookingEdit.Visible = true;
            picBookingCancel.Visible = true;
            picBookingSave.Visible = false;
            picBookingSaveCancel.Visible = false;

            picAddRoom.Enabled = false;
            picRemoveRoom.Enabled = false;
        }

        //Enables Customer Fields
        private void enableCustomerEdit()
        {
            gbBookingDetails.Enabled = false;
            picBookingSave.Visible = false;
            picBookingSaveCancel.Visible = false;
            gbCustomerDets.Enabled = true;

            picCustomerSave.Visible = true;
            picCustomerCancel.Visible = true;
        }

        //Disables Customer Fields
        private void disableCustomerEdit()
        {
            gbBookingDetails.Enabled = true;
            picBookingSave.Visible = true;
            picBookingSaveCancel.Visible = true;
            gbCustomerDets.Enabled = false;

            picCustomerSave.Visible = false;
            picCustomerCancel.Visible = false;

            chkEditCustomer.Checked = false;
        }

        //Edit Dates Function
        private void chkEditDates_CheckedChanged(object sender, EventArgs e)
        {
            cancelled = false;
            this.Close();
        }

        //Edit Customer Function
        private void chkEditCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditCustomer.Checked == true)
            {
                enableCustomerEdit();
            }
        }

        //Booking Edit Button Functions
        private void picBookingEdit_MouseEnter(object sender, EventArgs e)
        {
            picBookingEdit.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picBookingEdit_Click(object sender, EventArgs e)
        {
            enableBookingEdit();
            gbRoomsAdded.Enabled = true;
        }

        private void picBookingEdit_MouseLeave(object sender, EventArgs e)
        {
            picBookingEdit.BackColor = Color.Transparent;
        }

        //Booking Save Button Functions
        private void picBookingSave_MouseEnter(object sender, EventArgs e)
        {
            picBookingSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picBookingSave_Click(object sender, EventArgs e)
        {
            MyBooking myBook = new MyBooking();
            bool ok = true;
            errP.Clear();

            //Booking Number
            try
            {
                myBook.BookingNumber = lblBookingNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblBookingNo, MyEx.toString());
            }

            //Booking Type
            try
            {
                myBook.TypeID = "TYP100001";
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblBookingType, MyEx.toString());
            }

            //Check In Date
            try
            {
                myBook.CheckInDate = dtpBookingCheckIn.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpBookingCheckIn, MyEx.toString());
            }

            //Check Out Date
            try
            {
                myBook.CheckOutDate = dtpBookingCheckOut.Value;
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(dtpBookingCheckOut, MyEx.toString());
            }

            //Check In Time
            try
            {
                myBook.BookingTime = "13:00:00";
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblCheckInTime, MyEx.toString());
            }

            //Customer Number
            try
            {
                myBook.CustomerNumber = cmbCustomerNo.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbCustomerNo, MyEx.toString());
            }

            //Payment Type
            try
            {
                myBook.PaymentTypeID = cmbPayType.SelectedValue.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbPayType, MyEx.toString());
            }

            //Party Size
            try
            {
                if (int.Parse(txtPartySize.Text.Trim()) <= MainWindow.maxCap && int.Parse(txtPartySize.Text.Trim()) > 0)
                {
                    myBook.PartySize = int.Parse(txtPartySize.Text.Trim());
                }
                else
                {
                    ok = false;
                    errP.SetError(txtPartySize, "Party size must not exceed the capacity of the room, please enter a value of " + (MainWindow.maxCap) + " or less. Alternatively cancel and select a larger room.");
                }
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPartySize, MyEx.toString());
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    drBooking.BeginEdit();
                    drBooking["checkInDate"] = myBook.CheckInDate;
                    drBooking["checkOutDate"] = myBook.CheckOutDate;
                    drBooking["bookingTime"] = myBook.BookingTime;
                    drBooking["typeID"] = myBook.TypeID;
                    drBooking["paymentTypeID"] = myBook.PaymentTypeID;
                    drBooking["roomNo"] = myBook.RoomNo;
                    drBooking["tableNo"] = myBook.TableNo;
                    drBooking["partySize"] = myBook.PartySize;
                    drBooking["customerNo"] = myBook.CustomerNumber;
                    drBooking.EndEdit();
                    daBooking.Update(dsBelfray, "Booking");

                    MessageBox.Show("Booking Updated");

                    cancelled = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }            
        }

        private void picBookingSave_MouseLeave(object sender, EventArgs e)
        {
            picBookingSave.BackColor = Color.Transparent;
        }

        //Booking Save Cancel Button Functions
        private void picBookingSaveCancel_MouseEnter(object sender, EventArgs e)
        {
            picBookingSaveCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picBookingSaveCancel_Click(object sender, EventArgs e)
        {
            //Booking Dets
            drBooking = dsBelfray.Tables["Booking"].Rows.Find(lblBookingNo.Text);

            
            dtpBookingCheckIn.Value = Convert.ToDateTime(drBooking["checkInDate"]);
            dtpBookingCheckOut.Value = Convert.ToDateTime(drBooking["checkOutDate"]);
            
            int payNoRows = dsBelfray.Tables["Payment"].Rows.Count;

            for (int x = 0; x < (payNoRows - 1); x++)
            {
                cmbPayType.SelectedIndex = x;
                if (drBooking["paymentTypeID"].Equals(cmbPayType.SelectedValue))
                {
                    break;
                }
            }

            int cusNoRows = dsBelfray.Tables["Customer"].Rows.Count;

            for (int x = 0; x < (cusNoRows - 1); x++)
            {
                cmbCustomerNo.SelectedIndex = x;
                if (drBooking["CustomerNo"].Equals(cmbCustomerNo.SelectedValue))
                {
                    break;
                }
            }

            lblCheckInTime.Text = drBooking["bookingTime"].ToString();
            txtPartySize.Text = drBooking["partySize"].ToString();

            disableBookingEdit();
        }

        private void picBookingSaveCancel_MouseLeave(object sender, EventArgs e)
        {
            picBookingSaveCancel.BackColor = Color.Transparent;
        }

        //Customer Number Changed
        private void cmbCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userActivated)
            {
                drCustomer = dsBelfray.Tables["Customer"].Rows.Find(cmbCustomerNo.SelectedValue);
                lblCustNo.Text = cmbCustomerNo.SelectedValue.ToString();

                if (drCustomer["customerTitle"].ToString() == "MR")
                {
                    cmbTitle.SelectedIndex = 0;
                }
                if (drCustomer["customerTitle"].ToString() == "MISS")
                {
                    cmbTitle.SelectedIndex = 1;
                }
                if (drCustomer["customerTitle"].ToString() == "MRS")
                {
                    cmbTitle.SelectedIndex = 2;
                }
                if (drCustomer["customerTitle"].ToString() == "MS")
                {
                    cmbTitle.SelectedIndex = 3;
                }
                if (drCustomer["customerTitle"].ToString() == "DR")
                {
                    cmbTitle.SelectedIndex = 4;
                }

                txtForename.Text = drCustomer["customerForename"].ToString();
                txtSurname.Text = drCustomer["customerSurname"].ToString();
                txtStreet.Text = drCustomer["customerStreet"].ToString();
                txtCity.Text = drCustomer["customerCity"].ToString();
                txtCounty.Text = drCustomer["customerCounty"].ToString();
                txtPostcode.Text = drCustomer["customerPostcode"].ToString();
                txtPhoneNo.Text = drCustomer["customerTel"].ToString();
            }
        }

        //Booking Edit Cancel Button Functions
        private void picBookingCancel_MouseEnter(object sender, EventArgs e)
        {
            picBookingCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picBookingCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the update of Booking Number: " + lblBookingNo.Text + "?", "Edit Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                cancelled = true;
                this.Close();
            }
        }

        private void picBookingCancel_MouseLeave(object sender, EventArgs e)
        {
            picBookingCancel.BackColor = Color.Transparent;
        }

        //Customer Save Functions
        private void picCustomerSave_MouseEnter(object sender, EventArgs e)
        {
            picCustomerSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picCustomerSave_Click(object sender, EventArgs e)
        {
            MyCustomer myCust = new MyCustomer();
            bool ok = true;
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
                myCust.Title = cmbTitle.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cmbTitle, MyEx.toString());
            }

            //Customer Forename
            try
            {
                myCust.Forename = txtForename.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtForename, MyEx.toString());
            }

            //Customer Surname
            try
            {
                myCust.Surname = txtSurname.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSurname, MyEx.toString());
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
                myCust.Postcode = txtPostcode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPostcode, MyEx.toString());
            }

            //Customer TelNo
            try
            {
                myCust.TelNo = txtPhoneNo.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPhoneNo, MyEx.toString());
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    drCustomer.BeginEdit();
                    drCustomer["customerForename"] = myCust.Title;
                    drCustomer["customerForename"] = myCust.Forename;
                    drCustomer["customerSurname"] = myCust.Surname;
                    drCustomer["customerStreet"] = myCust.Street;
                    drCustomer["customerCity"] = myCust.City;
                    drCustomer["customerCounty"] = myCust.County;
                    drCustomer["customerPostcode"] = myCust.Postcode;
                    drCustomer["customerTel"] = myCust.TelNo;
                    drCustomer.EndEdit();
                    daCustomer.Update(dsBelfray, "Customer");

                    MessageBox.Show("Customer Updated");

                    disableCustomerEdit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void picCustomerSave_MouseLeave(object sender, EventArgs e)
        {
            picCustomerSave.BackColor = Color.Transparent;
        }

        //Customer Cancel Functions
        private void picCustomerCancel_MouseEnter(object sender, EventArgs e)
        {
            picCustomerCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picCustomerCancel_Click(object sender, EventArgs e)
        {            
            //Customer Dets
            drCustomer = dsBelfray.Tables["Customer"].Rows.Find(cmbCustomerNo.SelectedValue);
            lblCustNo.Text = cmbCustomerNo.SelectedValue.ToString();

            if (drCustomer["customerTitle"].ToString() == "MR")
            {
                cmbTitle.SelectedIndex = 0;
            }
            if (drCustomer["customerTitle"].ToString() == "MISS")
            {
                cmbTitle.SelectedIndex = 1;
            }
            if (drCustomer["customerTitle"].ToString() == "MRS")
            {
                cmbTitle.SelectedIndex = 2;
            }
            if (drCustomer["customerTitle"].ToString() == "MS")
            {
                cmbTitle.SelectedIndex = 3;
            }
            if (drCustomer["customerTitle"].ToString() == "DR")
            {
                cmbTitle.SelectedIndex = 4;
            }

            txtForename.Text = drCustomer["customerForename"].ToString();
            txtSurname.Text = drCustomer["customerSurname"].ToString();
            txtStreet.Text = drCustomer["customerStreet"].ToString();
            txtCity.Text = drCustomer["customerCity"].ToString();
            txtCounty.Text = drCustomer["customerCounty"].ToString();
            txtPostcode.Text = drCustomer["customerPostcode"].ToString();
            txtPhoneNo.Text = drCustomer["customerTel"].ToString();

            disableCustomerEdit();
        }

        private void picCustomerCancel_MouseLeave(object sender, EventArgs e)
        {
            picCustomerCancel.BackColor = Color.Transparent;
        }

        //Add Room Button Functions
        private void picAddRoom_MouseEnter(object sender, EventArgs e)
        {
            picAddRoom.BackColor = Color.FromArgb(57, 181, 74);

            pnlGreen.Visible = true;
            pnlGreen.Location = new Point(523, 157);
        }

        private void picAddRoom_Click(object sender, EventArgs e)
        {
            cancelled = false;
            this.Close();
        }

        private void picAddRoom_MouseLeave(object sender, EventArgs e)
        {
            picAddRoom.BackColor = Color.Transparent;
            pnlGreen.Visible = false;
        }

        //remove Room Button Functions
        private void picRemoveRoom_MouseEnter(object sender, EventArgs e)
        {
            picRemoveRoom.BackColor = Color.FromArgb(205, 36, 36);

            pnlRed.Visible = true;
            pnlRed.Location = new Point(553, 157);
        }

        private void picRemoveRoom_Click(object sender, EventArgs e)
        {

        }

        private void picRemoveRoom_MouseLeave(object sender, EventArgs e)
        {
            picRemoveRoom.BackColor = Color.Transparent;
            pnlRed.Visible = false;
        }
    }
}
