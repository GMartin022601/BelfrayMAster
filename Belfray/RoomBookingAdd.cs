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
        SqlDataAdapter daBooking, daCustomer;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer;
        DataRow drBooking, drCustomer;
        String connStr, sqlBooking, sqlCustomer;
        
        private bool userActivated = false; 

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

            //CB Details Supplier
            cmbCustomerNo.DataSource = dsBelfray.Tables["Customer"];
            cmbCustomerNo.ValueMember = "customerNo";
            cmbCustomerNo.DisplayMember = "customerNo";
            cmbCustomerNo.SelectedIndex = -1;

            //CB Details Title
            cmbTitle.ValueMember = "customerTitle";
            cmbTitle.DisplayMember = "customerTitle";
            cmbTitle.SelectedIndex = -1;

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

            lblRoomNo.Text = RoomSelect.roomSelceted;
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

            string s = drCustomer["customerNo"].ToString();
            string s1 = "CUS" + (Convert.ToInt32(s.Replace("CUS", "")) + 1).ToString().PadLeft(5, '0');

            lblCustNo.Text = s1;

            cmbTitle.SelectedIndex = -1;           

            txtForename.Text = "";
            txtSurname.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtCounty.Text = "";
            txtPostcode.Text = "";
            txtPhoneNo.Text = "";

            //Disable Booking and Enable Customer
            gbBookingDetails.Enabled = false;
            gbCustomerDets.Enabled = true;

            //Customer Buttons Visble
            picCustomerSave.Visible = true;
            picCustomerCancel.Visible = true;

            //Booking Buttons Invisble
            picBookingSave.Visible = false;
            picBookingCancel.Visible = false;
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
                this.Close();
            }
        }

        private void picBookingCancel_MouseLeave(object sender, EventArgs e)
        {
            picBookingCancel.BackColor = Color.Transparent;
        }

        //Save Customer Button Functions
        private void picCustomerSave_MouseEnter(object sender, EventArgs e)
        {
            picCustomerSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picCustomerSave_Click(object sender, EventArgs e)
        {

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
                lblCustNo.Text = "";

                cmbTitle.SelectedIndex = -1;

                txtForename.Text = "";
                txtSurname.Text = "";
                txtStreet.Text = "";
                txtCity.Text = "";
                txtCounty.Text = "";
                txtPostcode.Text = "";
                txtPhoneNo.Text = "";

                //Disable Customer and Enable Booking
                gbBookingDetails.Enabled = true;
                gbCustomerDets.Enabled = false;

                //Customer Buttons Invisble
                picCustomerSave.Visible = false;
                picCustomerCancel.Visible = false;

                //Booking Buttons Visble
                picBookingSave.Visible = true;
                picBookingCancel.Visible = true;
            }
        }

        private void picCustomerCancel_MouseLeave(object sender, EventArgs e)
        {
            picCustomerCancel.BackColor = Color.Transparent;
        }

    }
}
