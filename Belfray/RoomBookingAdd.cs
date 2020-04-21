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
    public partial class RoomBookingAdd : Form
    {
        SqlDataAdapter daBooking, daCustomer, daPayType, daBookingItem;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer, cmdBPayType, cmdBBookingItem;
        DataRow drBooking, drCustomer, drPayType, drBookingItem;
        String connStr, sqlBooking, sqlCustomer, sqlPayType, sqlBookingItem;
        
        private bool userActivated = false;
        private bool custEnabled = false;
        private bool bookEnabled = true;
        private bool roomSel = false;

        //Edit Cancelled
        public static bool cancelled = false;

        private void cmbCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userActivated)
            {
                int noRows = dsBelfray.Tables["Customer"].Rows.Count;

                foreach (DataRow drCustomer in dsBelfray.Tables["Customer"].Rows)
                {
                    string customer = drCustomer["customerNo"].ToString();

                    if (customer.Equals(cmbCustomerNo.Text))
                    {
                        lblCustNo.Text = customer;

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
                        break;
                    }
                }
            }
        }

        public RoomBookingAdd()
        {
            InitializeComponent();
        }

        //Get Booking Number
        private void getBookingNum(int noRows)
        {
            drBooking = dsBelfray.Tables["Booking"].Rows[noRows - 1];
        }

        private void RoomBookingAdd_Load(object sender, EventArgs e)
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
            sqlBooking = @"SELECT * FROM Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            //SQL for Booking Item
            sqlBookingItem = @"SELECT * FROM BookingItem";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookingItem");
            daBookingItem.Fill(dsBelfray, "BookingItem");

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

            int noRows = dsBelfray.Tables["Booking"].Rows.Count;

            if (noRows == 0)
            {
                bookingNo = "BK10000001";
            }
            else
            {
                getBookingNum(noRows);

                string code = drBooking["bookingNo"].ToString();
                string letters = "BK";
                string numStr = code.Split('K').Last();
                int num = int.Parse(numStr) + 1;

                bookingNo = letters + num.ToString(); 
            }

            lblBookingNo.Text = bookingNo;

            for (int x = 0; x < 19; x++)
            {
                if (Globals.rooms[x].Contains(" "))
                {
                    break;
                }
                else
                {
                    dgvRooms.Rows.Add(lblBookingNo.Text, Globals.rooms[x].ToString());
                }
            }            

            dtpBookingCheckIn.Value = RoomSelect.checkInDate;
            dtpBookingCheckOut.Value = RoomSelect.checkOutDate;

            userActivated = true;
        }

        //Get Row Number
        private void getRowNum(int noRows)
        {
            drCustomer = dsBelfray.Tables["Customer"].Rows[noRows - 1];
        }

        //Add Customer Button Functions
        private void picAddNewCust_MouseEnter(object sender, EventArgs e)
        {
            picAddNewCust.BackColor = Color.FromArgb(57, 181, 74);
        }

        //Enabling and Disabling Customer
        private void custPanelCont()
        {
            if (custEnabled)
            {
                //Disable Customer
                gbCustomerDets.Enabled = false;

                //Customer Buttons Invisble
                picCustomerSave.Visible = false;
                picCustomerCancel.Visible = false;

                custEnabled = false;
            }
            else
            {
                //Enable Customer
                gbCustomerDets.Enabled = true;

                //Customer Buttons Visble
                picCustomerSave.Visible = true;
                picCustomerCancel.Visible = true;

                custEnabled = true;
            }
        }

        //Enabling and Disabling Booking
        private void bookPanelCont()
        {
            if (bookEnabled)
            {
                //Disable Booking
                gbBookingDetails.Enabled = false;

                //Booking Buttons Invisble
                picBookingSave.Visible = false;
                picBookingCancel.Visible = false;

                bookEnabled = false;
            }
            else
            {
                //Enable Booking
                gbBookingDetails.Enabled = true;

                //Booking Buttons Visble
                picBookingSave.Visible = true;
                picBookingCancel.Visible = true;

                bookEnabled = true;
            }
        }

        private void picAddNewCust_Click(object sender, EventArgs e)
        {
            int noRows = dsBelfray.Tables["Customer"].Rows.Count;

            if (noRows == 0)
            {
                lblCustNo.Text = "CUS100001";
            }
            else
            {
                getRowNum(noRows);
            }

            clearCustomerPanel();

            string s = drCustomer["customerNo"].ToString();
            string s1 = "CUS" + (Convert.ToInt32(s.Replace("CUS", "")) + 1).ToString().PadLeft(5, '0');

            lblCustNo.Text = s1;

            cmbCustomerNo.SelectedIndex = -1;

            custPanelCont();
            bookPanelCont();
        }

        private void picAddNewCust_MouseLeave(object sender, EventArgs e)
        {
            picAddNewCust.BackColor = Color.Transparent;
        }

        //Save Booking Button Functions
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
                myBook.BookingTime = "13:00";
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
                for (int x = 0; x < 19; x++)
                {
                    MainWindow.maxCap += Globals.capacity[x];
                }
                
                if(int.Parse(txtPartySize.Text.Trim()) <=  MainWindow.maxCap && int.Parse(txtPartySize.Text.Trim()) > 0)
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
                    drBooking = dsBelfray.Tables["Booking"].NewRow();
                    drBooking["bookingNo"] = myBook.BookingNumber;
                    drBooking["checkInDate"] = myBook.CheckInDate;
                    drBooking["checkOutDate"] = myBook.CheckOutDate;
                    drBooking["bookingTime"] = myBook.BookingTime;
                    drBooking["paymentTypeID"] = myBook.PaymentTypeID;
                    drBooking["partySize"] = myBook.PartySize;
                    drBooking["customerNo"] = myBook.CustomerNumber;
                    dsBelfray.Tables["Booking"].Rows.Add(drBooking);
                    daBooking.Update(dsBelfray, "Booking");

                    int roomRows = dgvRooms.RowCount - 1;

                    for(int x = 0; x < roomRows; x++)
                    {
                        drBookingItem = dsBelfray.Tables["BookingItem"].NewRow();
                        drBookingItem["bookingNo"] = dgvRooms.Rows[x].Cells[0].Value.ToString();
                        drBookingItem["itemNo"] = "RM" + dgvRooms.Rows[x].Cells[1].Value.ToString();
                        drBookingItem["itemQty"] = DBNull.Value;
                        dsBelfray.Tables["BookingItem"].Rows.Add(drBookingItem);
                    }

                    daBookingItem.Update(dsBelfray, "BookingItem");

                    MessageBox.Show("Booking Added");

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

        //Cancel Booking Button Functions
        private void picBookingCancel_MouseEnter(object sender, EventArgs e)
        {
            picBookingCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picBookingCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the Addition of Booking Number: " + lblBookingNo.Text + "?", "Make a Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                cancelled = true;
                this.Close();
            }
        }

        private void picBookingCancel_MouseLeave(object sender, EventArgs e)
        {
            picBookingCancel.BackColor = Color.Transparent;
        }

        //Data Grid View Controls
        private void dgvRooms_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                roomSel = false;
                Globals.roomNoSel = 0;
                //prdSel = null;
            }
            else if (dgvRooms.SelectedRows.Count == 1)
            {
                roomSel = true;
                lblRoomNo.Text = dgvRooms.SelectedRows[0].Cells[1].Value.ToString();
                Globals.roomNoSel = dgvRooms.SelectedRows[0].Index;
                //prdSel = Globals.prdNoSel;
            }
        }

        //Save Customer Button Functions
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
                    drCustomer = dsBelfray.Tables["Customer"].NewRow();
                    drCustomer["customerNo"] = myCust.CustomerNumber;
                    drCustomer["customerTitle"] = myCust.Title;
                    drCustomer["customerForename"] = myCust.Forename;
                    drCustomer["customerSurname"] = myCust.Surname;
                    drCustomer["customerStreet"] = myCust.Street;
                    drCustomer["customerCity"] = myCust.City;
                    drCustomer["customerCounty"] = myCust.County;
                    drCustomer["customerPostcode"] = myCust.Postcode;
                    drCustomer["customerTel"] = myCust.TelNo;
                    dsBelfray.Tables["Customer"].Rows.Add(drCustomer);
                    daCustomer.Update(dsBelfray, "Customer");

                    MessageBox.Show("Customer Added");

                    clearCustomerPanel();

                    custPanelCont();
                    bookPanelCont();                    

                    int noRows = dsBelfray.Tables["Customer"].Rows.Count;                    

                    //cb ProductType
                    cmbCustomerNo.DataSource = dsBelfray.Tables["Customer"];
                    cmbCustomerNo.ValueMember = "customerNo";
                    cmbCustomerNo.DisplayMember = "customerNo";
                    cmbCustomerNo.SelectedIndex = noRows - 1;                    
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

        //Cancel Customer Button Functions
        private void picCustomerCancel_MouseEnter(object sender, EventArgs e)
        {
            picCustomerCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picCustomerCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the Addition of Customer Number: " + lblCustNo.Text + "?", "Add a Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                clearCustomerPanel();

                custPanelCont();
                bookPanelCont();
            }
        }

        private void picCustomerCancel_MouseLeave(object sender, EventArgs e)
        {
            picCustomerCancel.BackColor = Color.Transparent;
        }

        private void clearCustomerPanel()
        {
            lblCustNo.Text = "-";

            cmbTitle.SelectedIndex = -1;

            txtForename.Text = "";
            txtSurname.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            txtPhoneNo.Text = "";
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

        //Remove Room Button Function
        private void picRemoveRoom_MouseEnter(object sender, EventArgs e)
        {
            picRemoveRoom.BackColor = Color.FromArgb(205, 36, 36);

            pnlRed.Visible = true;
            pnlRed.Location = new Point(553, 157);
        }

        private void picRemoveRoom_Click(object sender, EventArgs e)
        {
            if (!roomSel)
            {
                MessageBox.Show("Please select a room from the table on the right to remove it from the booking", "Remove a room", MessageBoxButtons.OK);
            }
            else
            {
                for(int x = 0; x < 19; x++)
                {
                    if(Globals.rooms[x].Equals(dgvRooms.Rows[Globals.roomNoSel].Cells[1].Value.ToString()))
                    {
                        Globals.rooms[x] = " ";
                        break;
                    }
                }

                dgvRooms.Rows.Remove(dgvRooms.Rows[Globals.roomNoSel]);
                lblRoomNo.Text = "-";
                dgvRooms.ClearSelection();

                roomSel = false;

                for (int x = 0; x < 18; x++)
                {
                    if (Globals.rooms[x].Equals(" ") && !Globals.rooms[x+1].Equals(" "))
                    {
                        Globals.rooms[x] = Globals.rooms[x+1];
                        Globals.rooms[x + 1] = " ";
                    }
                }
            }
        }

        private void picRemoveRoom_MouseLeave(object sender, EventArgs e)
        {
            picRemoveRoom.BackColor = Color.Transparent;
            pnlRed.Visible = false;
        }
    }
}
