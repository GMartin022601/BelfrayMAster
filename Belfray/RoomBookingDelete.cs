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
    public partial class RoomBookingDelete : Form
    {
        //SQL links
        SqlDataAdapter daBooking, daCustomer, daBookingItem, daPayType;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer, cmdBBookingItem, cmdBPayType;
        DataRow drBooking, drCustomer, drBookingItem, drPayType;
        String connStr, sqlBooking, sqlCustomer, sqlBookingItem, sqlPayType;

        //Row Selected
        private bool rowSelected = false; 

        //Form Loading
        private bool formLoad = true;

        private void RoomBookingDelete_Load(object sender, EventArgs e)
        {
            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlBooking = @"select bookingNo, checkInDate, checkOutDate, 
                            bookingTime, customerNo , paymentTypeID , 
                            partySize from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            //SQL for BookingItem
            sqlBookingItem = @"select * from BookingItem";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookiBookingItemng");
            daBookingItem.Fill(dsBelfray, "BookingItem");

            //SQL For Customer
            sqlCustomer = @"select customerNo, customerTitle, customerForename, 
                            customerSurname, customerStreet, customerCity, 
                            customerCounty, customerPostcode , customerTel from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");

            ////SQL For Customer
            //sqlCustomerFind = @"select customerNo, customerTitle, customerForename, 
            //                customerSurname, customerStreet, customerCity, 
            //                customerCounty, customerPostcode, customerTel from Customer";
            //daCustomerFind = new SqlDataAdapter(sqlCustomerFind, connStr);
            //cmdBCustomerFind = new SqlCommandBuilder(daCustomerFind);
            //daCustomerFind.FillSchema(dsBelfray, SchemaType.Source, "CustomerFind");
            //daCustomerFind.Fill(dsBelfray, "CustomerFind");

            //SQL For Payment Type
            sqlPayType = @"select * from Payment";
            daPayType = new SqlDataAdapter(sqlPayType, connStr);
            cmdBPayType = new SqlCommandBuilder(daPayType);
            daPayType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPayType.Fill(dsBelfray, "Payment");

            formLoad = false;
        }

        public RoomBookingDelete()
        {
            InitializeComponent();
        }

        //Setting Details
        private void dgvDisplay_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count == 0)
            {
                rowSelected = false;
                Globals.rowSel = null;
            }
            else if (dgvDisplay.SelectedRows.Count == 1)
            {
                rowSelected = true;
                Globals.rowSel = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();

                //Display info in groupbox
                //Product
                if (cmbSelect.SelectedIndex == 0)
                {
                    int roomCount = 0;

                    drBooking = dsBelfray.Tables["Booking"].Rows.Find(Globals.rowSel.ToString());
                    pnlBooking.BringToFront();
                    pnlBooking.Visible = true;

                    lblBookingNo.Text = drBooking["bookingNo"].ToString();

                    DateTime checkIn = Convert.ToDateTime(drBooking["checkInDate"]);
                    lblCheckIn.Text = checkIn.ToShortDateString();
                    DateTime checkOut = Convert.ToDateTime(drBooking["checkOutDate"]);
                    lblCheckOut.Text = checkOut.ToShortDateString();                    
                    lblCheckInTime.Text = "13:00";
                    lblBookingType.Text = "Room";

                    foreach (DataRow drPaymentType in dsBelfray.Tables["Payment"].Rows)
                    {
                        if (drPaymentType["paymentTypeID"].ToString().Equals(drBooking["paymentTypeID"].ToString()))
                        {
                            lblBookingPayment.Text = drPaymentType["paymentTypeDesc"].ToString();
                            break;
                        }
                    }
                    lblBookingPartySize.Text = drBooking["partySize"].ToString();
                    lblBookingCustomer.Text = drBooking["customerNo"].ToString();

                    foreach(DataRow drRoom in dsBelfray.Tables["BookingItem"].Rows)
                    {
                        if(drRoom["bookingNo"].ToString().Equals(lblBookingNo.Text))
                        {
                            roomCount++;
                        }
                    }

                    lblRooms.Text = roomCount.ToString();

                    picDelete.Visible = true;
                }
                if (cmbSelect.SelectedIndex == 1)
                {
                    int custCount = 0;

                    drCustomer = dsBelfray.Tables["Customer"].Rows.Find(Globals.rowSel.ToString());
                    pnlCustomer.BringToFront();
                    pnlCustomer.Visible = true;

                    lblCustNo.Text = drCustomer["customerNo"].ToString();
                    lblCustTitle.Text = drCustomer["customerTitle"].ToString();
                    lblCustForename.Text = drCustomer["customerForename"].ToString();
                    lblCustSurname.Text = drCustomer["customerSurname"].ToString();
                    lblCustStreet.Text = drCustomer["customerStreet"].ToString();
                    lblCustCity.Text = drCustomer["customerCity"].ToString();
                    lblCustCounty.Text = drCustomer["customerCounty"].ToString();
                    lblCustPostcode.Text = drCustomer["customerPostcode"].ToString();
                    lblCustPhone.Text = drCustomer["customerTel"].ToString();

                    picDelete.Visible = true;
                }
            }
        }

        //Determines what has been choosen in Combobox
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                if (cmbSelect.Text.Equals("Bookings"))
                {
                    pnlBooking.Visible = false;
                    pnlCustomer.Visible = false;
                    dgvDisplay.Visible = true;
                    dgvDisplay.DataSource = dsBelfray.Tables["Booking"];
                    //Resize
                    dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else if (cmbSelect.Text.Equals("Customers"))
                {
                    pnlBooking.Visible = false;
                    pnlCustomer.Visible = false;
                    dgvDisplay.Visible = true;
                    dgvDisplay.DataSource = dsBelfray.Tables["Customer"];
                    //Resize
                    dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }

        //Delete Button Functions
        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            picDelete.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            if(rowSelected)
            {
                if(cmbSelect.SelectedIndex == 0)
                {
                    if (MessageBox.Show("Deleting the booking: " + lblBookingNo.Text + " will delete any rooms and Items attached. Are you sure you wish to delete this booking?", "Delete Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        drBooking = dsBelfray.Tables["Booking"].Rows.Find(Globals.rowSel.ToString());

                        foreach (DataRow drBookingItem in dsBelfray.Tables["BookingItem"].Rows)
                        {
                            if (drBookingItem["bookingNo"].ToString().Equals(Globals.rowSel.ToString()))
                            {
                                drBookingItem.Delete();                                
                            }
                        }

                        daBookingItem.Update(dsBelfray, "BookingItem");

                        drBooking.Delete();
                        daBooking.Update(dsBelfray, "Booking");

                        picDelete.Visible = false;
                        pnlBooking.Visible = false;
                    }
                    else
                    {
                        daBooking.Update(dsBelfray, "Booking");
                        dgvDisplay.ClearSelection();
                        rowSelected = false;
                    }
                }
                else if (cmbSelect.SelectedIndex == 1)
                {
                    if (MessageBox.Show("Deleting the customer: " + lblCustNo.Text + " will delete any bookings and Items made by this customer. deleting the customer is not recommended, are you sure you wish to delete this Customer?", "Delete Customer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        foreach (DataRow drBooking in dsBelfray.Tables["Booking"].Rows)
                        {
                            if (drBooking["customerNo"].ToString().Equals(Globals.rowSel.ToString()))
                            {
                                foreach (DataRow drBookingItem in dsBelfray.Tables["BookingItem"].Rows)
                                {
                                    if (drBookingItem["bookingNo"].ToString().Equals(drBooking["bookingNo"].ToString()))
                                    {
                                        drBookingItem.Delete();                                        
                                    }
                                }                                

                                drBooking.Delete();                                
                            }
                        }
                        daBookingItem.Update(dsBelfray, "BookingItem");
                        daBooking.Update(dsBelfray, "Booking");

                        foreach (DataRow drCustomer in dsBelfray.Tables["Customer"].Rows)
                        {
                            if (drCustomer["customerNo"].ToString().Equals(Globals.rowSel.ToString()))
                            {
                                drCustomer.Delete();
                            }
                        }
                        daCustomer.Update(dsBelfray, "Customer");

                        picDelete.Visible = false;
                        pnlCustomer.Visible = false;
                    }
                    else
                    {
                        daCustomer.Update(dsBelfray, "Customer");
                        dgvDisplay.ClearSelection();
                        rowSelected = false;
                    }
                }
            }
            else
            {
                if (cmbSelect.SelectedIndex == 0)
                {
                    MessageBox.Show("Please select a Booking from the table on the left to delete.", "Delete a Booking", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Please select a Customer from the table on the left to delete.", "Delete a Customer", MessageBoxButtons.OK);
                }
            }

            clearBookingDets();
            clearCustomerDets();
        }

        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            picDelete.BackColor = Color.Transparent;
        }

        //Clear the booking panel
        private void clearBookingDets()
        {
            pnlBooking.Visible = false;

            lblBookingNo.Text = "X";           
            lblCheckIn.Text = "X";
            lblCheckOut.Text = "X";
            lblCheckInTime.Text = "X";
            lblBookingType.Text = "X";
            lblBookingPayment.Text = "X";
            lblBookingPartySize.Text = "X";
            lblBookingCustomer.Text = "X";
            lblRooms.Text = "X";
        }

        //Clear the customer panel
        private void clearCustomerDets()
        {
            pnlCustomer.Visible = false;

            lblCustNo.Text = "X";
            lblCustTitle.Text = "X";
            lblCustForename.Text = "X";
            lblCustSurname.Text = "X";
            lblCustStreet.Text = "X";
            lblCustCity.Text = "X";
            lblCustCounty.Text = "X";
            lblCustPostcode.Text = "X";
            lblCustPhone.Text = "X";
        }
    }
}
