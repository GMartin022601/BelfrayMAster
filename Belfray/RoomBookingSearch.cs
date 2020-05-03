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
    public partial class RoomBookingSearch : Form
    {
        //SQL links
        SqlDataAdapter daBooking, daCustomer, daBookingItem, daPayType;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer, cmdBBookingItem, cmdBPayType;
        DataRow drBooking, drCustomer, drBookingItem, drPayType;
        String connStr, sqlBooking, sqlCustomer, sqlBookingItem, sqlPayType;

        private bool bookSel = false;

        private bool cusSel = false;

        private bool butPress = false;

        private int searchSelected = 0;

        //Search option 0 = none, 1 = Booking No Search, 2 = Customer No search, 3 = Customer Name Search
        private int searchOption = 0;

        public RoomBookingSearch()
        {
            InitializeComponent();
        }

        private void RoomBookingSearch_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlBooking = @"SELECT * FROM Booking";
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

            //SQL for BookingItem
            sqlBookingItem = @"select * from BookingItem";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookingItem");
            daBookingItem.Fill(dsBelfray, "BookingItem");

            //SQL For Payment Type
            sqlPayType = @"select * from Payment";
            daPayType = new SqlDataAdapter(sqlPayType, connStr);
            cmdBPayType = new SqlCommandBuilder(daPayType);
            daPayType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPayType.Fill(dsBelfray, "Payment");


            //Resize
            dgvBookingSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //btnBooking Functions
        private void btnBookings_Click(object sender, EventArgs e)
        {
            butPress = true;

            dgvCustomerSearch.Visible = false;
            dgvBookingSearch.Visible = true;
            dgvBookingSearch.DataSource = dsBelfray.Tables["Booking"];

            //Buttons Visible
            picSearch.Visible = true;

            //Labels and text boxes visible
            lblSearchBookingNo.Visible = true;
            txtSearchBookingNo.Visible = true;

            //Labels and text boxes invisible
            lblSearchCustomerNo.Visible = false;
            txtSearchCustomerNo.Visible = false;
            lblSearchCustomerName.Visible = false;
            txtSearchCustomerName.Visible = false;

            //Panels Invisible
            pnlBooking.Visible = false;
            pnlCustomer.Visible = false;

            //Text box Clear
            txtSearchBookingNo.Text = "";
            txtSearchCustomerNo.Text = "";
            txtSearchCustomerName.Text = "";
        }

        //btnCustomer Functions
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            butPress = true;

            dgvCustomerSearch.Visible = true;
            dgvBookingSearch.Visible = false;
            dgvCustomerSearch.DataSource = dsBelfray.Tables["Customer"];

            //Buttons Visible
            picSearch.Visible = true;

            //Labels and text boxes visible
            lblSearchCustomerNo.Visible = true;
            txtSearchCustomerNo.Visible = true;
            lblSearchCustomerName.Visible = true;
            txtSearchCustomerName.Visible = true;

            //Labels and text boxes invisible
            lblSearchBookingNo.Visible = false;
            txtSearchBookingNo.Visible = false;

            //Panels Invisible
            pnlBooking.Visible = false;
            pnlCustomer.Visible = false;

            //Text box Clear
            txtSearchBookingNo.Text = "";
            txtSearchCustomerNo.Text = "";
            txtSearchCustomerName.Text = "";
        }

        //Search Button Functions
        private void picSearch_MouseEnter(object sender, EventArgs e)
        {
            picSearch.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            switch(searchOption)
            {
                case 0:
                    MessageBox.Show("Please in put your search Text in a Text box above to search.", "Search error", MessageBoxButtons.OK);
                    break;
                case 1:
                    DataView bookSearch = new DataView(dsBelfray.Tables["Booking"], "bookingNo = '" + txtSearchBookingNo.Text.ToString() + "'", "bookingNo", DataViewRowState.CurrentRows);
                    dgvBookingSearch.DataSource = bookSearch;
                    break;
                case 2:
                    DataView cusSearch = new DataView(dsBelfray.Tables["Customer"], "customerNo = '" + txtSearchCustomerNo.Text.ToString() + "'", "customerNo", DataViewRowState.CurrentRows);
                    dgvCustomerSearch.DataSource = cusSearch;
                    break;
                case 3:
                    DataView custSearch = new DataView(dsBelfray.Tables["Customer"], "customerSurname = '" + txtSearchCustomerName.Text.ToString() + "'", "customerSurname", DataViewRowState.CurrentRows);
                    dgvCustomerSearch.DataSource = custSearch;
                    break;
            }
        }

        private void picSearch_MouseLeave(object sender, EventArgs e)
        {
            picSearch.BackColor = Color.Transparent;
        }

        //Customer Name Text Changed
        private void txtSearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (!butPress)
            {
                if (txtSearchCustomerName.Text.Length != 0)
                {
                    searchOption = 3;
                    txtSearchCustomerNo.Text = "";
                    picSearch.Enabled = true;
                }
            }

            butPress = false;
        }

        //Customer Number Text Changed
        private void txtSearchCustomerNo_TextChanged(object sender, EventArgs e)
        {
            if (!butPress)
            {
                if (txtSearchCustomerNo.Text.Length == 9)
                {
                    searchOption = 2;
                    txtSearchCustomerNo.BackColor = Color.White;
                    picSearch.Enabled = true;
                }
                else if (txtSearchCustomerNo.Text.Length > 0)
                {
                    txtSearchCustomerNo.BackColor = Color.LightCoral;
                    txtSearchCustomerName.Text = "";
                    picSearch.Enabled = false;
                }
                else if (txtSearchCustomerNo.Text.Length == 0)
                {
                    txtSearchCustomerNo.BackColor = Color.LightCoral;
                    btnCustomers_Click(sender, e);
                    picSearch.Enabled = false;
                }
                else
                {
                    txtSearchCustomerNo.BackColor = Color.LightCoral;
                    picSearch.Enabled = false;
                }
            }

            butPress = false;
        }

        //Booking Number Text Changed
        private void txtSearchBookingNo_TextChanged(object sender, EventArgs e)
        {
            if (!butPress)
            {
                if (txtSearchBookingNo.Text.Length == 10)
                {
                    searchOption = 1;
                    txtSearchBookingNo.BackColor = Color.White;
                    picSearch.Enabled = true;
                }
                else if (txtSearchBookingNo.Text.Length == 0)
                {
                    btnBookings_Click(sender, e);
                    picSearch.Enabled = false;
                }
                else
                {
                    txtSearchBookingNo.BackColor = Color.LightCoral;
                    picSearch.Enabled = false;
                }
            }

            butPress = false;
        }

        //Customer Clicked
        private void dgvCustomerSearch_Click(object sender, EventArgs e)
        {
            if (dgvCustomerSearch.SelectedRows.Count == 0)
            {
                cusSel = false;
                searchSelected = 0;
            }
            else if (dgvCustomerSearch.SelectedRows.Count == 1)
            {
                cusSel = true;
                pnlCustomer.Visible = true;
                lblCustNo.Text = dgvCustomerSearch.SelectedRows[0].Cells[0].Value.ToString();
                lblCustTitle.Text = dgvCustomerSearch.SelectedRows[0].Cells[1].Value.ToString();
                lblCustSurname.Text = dgvCustomerSearch.SelectedRows[0].Cells[2].Value.ToString();
                lblCustForename.Text = dgvCustomerSearch.SelectedRows[0].Cells[3].Value.ToString();
                lblCustStreet.Text = dgvCustomerSearch.SelectedRows[0].Cells[4].Value.ToString();
                lblCustCity.Text = dgvCustomerSearch.SelectedRows[0].Cells[5].Value.ToString();
                lblCustCounty.Text = dgvCustomerSearch.SelectedRows[0].Cells[6].Value.ToString();
                lblCustPostcode.Text = dgvCustomerSearch.SelectedRows[0].Cells[7].Value.ToString();
                lblCustPhone.Text = dgvCustomerSearch.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        //Booking Clicked
        private void dgvBookingSearch_Click(object sender, EventArgs e)
        {
            searchOption = 1;
            if (dgvBookingSearch.SelectedRows.Count == 0)
            {
                bookSel = false;
                searchSelected = 0;
            }
            else if (dgvBookingSearch.SelectedRows.Count == 1)
            {
                bookSel = true;
                pnlBooking.Visible = true;
                lblBookingNo.Text = dgvBookingSearch.SelectedRows[0].Cells[0].Value.ToString();
                DateTime checkIn = Convert.ToDateTime(dgvBookingSearch.SelectedRows[0].Cells[1].Value);
                lblCheckIn.Text = checkIn.ToShortDateString();
                DateTime checkOut = Convert.ToDateTime(dgvBookingSearch.SelectedRows[0].Cells[2].Value);
                lblCheckOut.Text = checkOut.ToShortDateString();
                lblBookingType.Text = "Room";

                int roomCount = 0;

                foreach (DataRow drRoom in dsBelfray.Tables["BookingItem"].Rows)
                {
                    if (drRoom["bookingNo"].ToString().Equals(lblBookingNo.Text))
                    {
                        roomCount++;
                    }
                }

                lblRooms.Text = roomCount.ToString();
                lblCheckInTime.Text = "13:00";
                lblBookingCustomer.Text = dgvBookingSearch.SelectedRows[0].Cells[4].Value.ToString();

                foreach (DataRow drPaymentType in dsBelfray.Tables["Payment"].Rows)
                {
                    if (drPaymentType["paymentTypeID"].ToString().Equals(dgvBookingSearch.SelectedRows[0].Cells[5].Value.ToString()))
                    {
                        lblBookingPayment.Text = drPaymentType["paymentTypeDesc"].ToString();
                        break;
                    }
                }

                lblBookingPartySize.Text = dgvBookingSearch.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
    }
}
