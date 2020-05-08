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
    public partial class TableSearch : Form
    {
        //SQL links
        DataRow drBookingDetails, drCustomer, drBookingItem, drPaymentType, drBooking, drItem;
        String connStr, sqlBookingDetails, sqlCustomer, sqlBookingItem, sqlPaymentType, sqlBooking, sqlBill, sqlItem;
        SqlDataAdapter daBookingDetails, daCustomer, daBookingItem, daPaymentType, daBooking, daBill, daItem;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBookingDetails, cmdBCustomer, cmdBBookingItem, cmdBPaymentType, cmdBBooking, cmdBItem;
        private int searchOption = 0;
        private string selected = "";
        string bDate = "";

        private void txtSurname_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSurname.Text.Length > 16)
            {
                MessageBox.Show("Surname must not exceed 16 characters.", "Search error", MessageBoxButtons.OK);
                txtSurname.Text = "";
            }
            txtBookingNumber.Enabled = false;
            txtBookingNumber.BackColor = Color.LightCoral;
            dtpSearch.Enabled = false;

            DataView surnameSearch = new DataView(dsBelfray.Tables["Booking"], "customerSurname LIKE '%" + txtSurname.Text.ToString() + "%'", "customerSurname", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = surnameSearch;

            if (txtSurname.Text.Length == 0)
            {
                txtSurname.Text = "";
                txtBookingNumber.Enabled = true;
                txtBookingNumber.BackColor = Color.White;
                dtpSearch.Enabled = true;
            }
        }

        private void dtpSearch_ValueChanged(object sender, EventArgs e)
        {
            searchOption = 3;
            bDate = dtpSearch.Value.ToShortDateString();
            DataView dateSearch = new DataView(dsBelfray.Tables["Booking"], "checkInDate = '" + Convert.ToDateTime(bDate) + "'", "checkInDate", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = dateSearch;

            //txtBookingNumber.Enabled = false;
            //txtBookingNumber.BackColor = Color.LightCoral;
            //txtSurname.Enabled = false;
            //txtSurname.BackColor = Color.LightCoral;
        }
        private void picClear_Click(object sender, EventArgs e)
        {
            dgvSearch.DataSource = dsBelfray.Tables["Booking"];
            txtSurname.Text = "";
            txtBookingNumber.Text = "";
        }

        private void dgvSearch_Click(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nothing selected.", "Error", MessageBoxButtons.OK);
            }
            else if (dgvSearch.SelectedRows.Count == 1)
            {
                Globals.bookSel = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
                selected = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
                lblBookingNo.Text = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();
                DateTime checkIn = Convert.ToDateTime(dgvSearch.SelectedRows[0].Cells[1].Value);
                dateBooking.Value = Convert.ToDateTime(checkIn.ToShortDateString());
                txtTime.Text = dgvSearch.SelectedRows[0].Cells[3].Value.ToString();
                txtPartySize.Text = dgvSearch.SelectedRows[0].Cells[8].Value.ToString();
                txtPaymentType.Text = dgvSearch.SelectedRows[0].Cells[7].Value.ToString();
                lblCustNo.Text = dgvSearch.SelectedRows[0].Cells[4].Value.ToString();
                txtFirstName.Text = dgvSearch.SelectedRows[0].Cells[5].Value.ToString();
                txtLastName.Text = dgvSearch.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        public void CreateBill()
        {
            //dgvTableBill.DataSource = dsBelfray.Tables["Book"];

            //DGV Populate
            foreach (DataRow drDetails in dsBelfray.Tables["BookingDetails"].Rows)
            {
                foreach (DataRow drItem in dsBelfray.Tables["Item"].Rows)
                {
                    string tableNo = "";
                    string bookingItemNo = "";
                    string bookingItemQTY = "";
                    string itemPrice = "";
                    string desc = "";

                    if (drDetails["bookingNo"].Equals(lblBookingNo.Text))
                    {
                        //if (drItem)
                        tableNo = drDetails["itemNo"].ToString();
                        //itemPrice = drItem["itemPrice"].ToString();
                        bookingItemQTY = drDetails["bookingItemQty"].ToString();
                        bookingItemNo = drDetails["bookingItemNo"].ToString();
                        desc = drItem["itemDesc"].ToString();


                        dgvTableBill.ColumnCount = 4;
                        dgvTableBill.Columns[0].Name = "Table Number";
                        dgvTableBill.Columns[0].Width = 100;
                        dgvTableBill.Columns[0].Name = "Item Number";
                        dgvTableBill.Columns[0].Width = 100;
                        dgvTableBill.Columns[1].Name = "Item Desc";
                        dgvTableBill.Columns[1].Width = 100;
                        dgvTableBill.Columns[2].Name = "Qty";
                        dgvTableBill.Columns[2].Width = 100;
                        //dgvTableBill.Columns[4].Name = "Price";
                        //dgvTableBill.Columns[4].Width = 100;
                    dgvTableBill.Rows.Add(tableNo, bookingItemNo, desc, bookingItemQTY);
                   // dgvTableBill.Rows.Add(bookingNo, bookingItemNo, desc, bookingItemQTY, itemPrice);
                    }
                }
            }
        }
        private void picShowBill_Click(object sender, EventArgs e)
        {
            dgvTableBill.Visible = true;
            pnlBill.Visible = true;
            pnlBill.BringToFront();
            CreateBill();
            //dgvTableBill.DataSource = dsBelfray.Tables["Book"];
        }
        private void txtBookingNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtBookingNumber.Text.Length > 10)
            {
                MessageBox.Show("Booking number must be 10 characters beginnin BK.", "Search error", MessageBoxButtons.OK);
                txtBookingNumber.Text = "";
            }
            txtSurname.BackColor = Color.LightCoral;
            txtSurname.Enabled = false;
            dtpSearch.Enabled = false;

            DataView bkSearch = new DataView(dsBelfray.Tables["Booking"], "bookingNo LIKE '%" + txtBookingNumber.Text.ToString() + "%'", "bookingNo", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = bkSearch;

            if (txtBookingNumber.Text.Length == 0)
            {
                txtBookingNumber.Text = "";
                txtSurname.Enabled = true;
                txtSurname.BackColor = Color.White;
                dtpSearch.Enabled = true;
            }

        }

        //private void picSearch_Click(object sender, EventArgs e)
        //{
        //    switch (searchOption)
        //    {
        //        case 0:
        //            MessageBox.Show("Please us the options below to search.", "Search error", MessageBoxButtons.OK);
        //            break;
        //        case 1:
        //                DataView bookingSearch = new DataView(dsBelfray.Tables["Booking"], "bookingNo = '" + txtBookingNumber.Text.ToString() + "'", "bookingNo", DataViewRowState.CurrentRows);
        //                dgvSearch.DataSource = bookingSearch;

        //                dgvSearch.Columns[0].HeaderText = "Booking Number";
        //                dgvSearch.Columns[1].HeaderText = "Booking Date";
        //                dgvSearch.Columns[6].HeaderText = "Surname";

        //                dgvSearch.Columns[0].Width = 115;
        //                dgvSearch.Columns[1].Width = 100;
        //                dgvSearch.Columns[2].Width = 81;
        //                dgvSearch.Columns[3].Width = 81;
        //                dgvSearch.Columns[4].Width = 100;
        //                dgvSearch.Columns[5].Width = 100;
        //                dgvSearch.Columns[6].Width = 100;
        //                dgvSearch.Columns[7].Width = 71;
        //                dgvSearch.Columns[8].Width = 61;
        //                dgvSearch.Columns[9].Width = 61;
        //            break;
        //        case 2:
        //            DataView surnameSearch = new DataView(dsBelfray.Tables["Booking"], "customerSurname = '" + txtSurname.Text.ToString() + "'", "customerSurname", DataViewRowState.CurrentRows);
        //            dgvSearch.DataSource = surnameSearch;

        //            dgvSearch.Columns[0].HeaderText = "Booking Number";
        //            dgvSearch.Columns[1].HeaderText = "Booking Date";
        //            dgvSearch.Columns[6].HeaderText = "Surname";

        //            dgvSearch.Columns[0].Width = 115;
        //            dgvSearch.Columns[1].Width = 100;
        //            dgvSearch.Columns[2].Width = 81;
        //            dgvSearch.Columns[3].Width = 81;
        //            dgvSearch.Columns[4].Width = 100;
        //            dgvSearch.Columns[5].Width = 100;
        //            dgvSearch.Columns[6].Width = 100;
        //            dgvSearch.Columns[7].Width = 71;
        //            dgvSearch.Columns[8].Width = 61;
        //            dgvSearch.Columns[9].Width = 61;
        //            break;
        //        case 3:
        //            bDate = dtpSearch.Value.ToShortDateString();

        //            DataView dateSearch = new DataView(dsBelfray.Tables["Booking"], "checkInDate = '" + Convert.ToDateTime(bDate) + "'", "checkInDate", DataViewRowState.CurrentRows);
        //            dgvSearch.DataSource = dateSearch;

        //            dgvSearch.Columns[0].HeaderText = "Booking Number";
        //            dgvSearch.Columns[1].HeaderText = "Booking Date";
        //            dgvSearch.Columns[6].HeaderText = "Surname";

        //            dgvSearch.Columns[0].Width = 115;
        //            dgvSearch.Columns[1].Width = 100;
        //            dgvSearch.Columns[2].Width = 81;
        //            dgvSearch.Columns[3].Width = 81;
        //            dgvSearch.Columns[4].Width = 100;
        //            dgvSearch.Columns[5].Width = 100;
        //            dgvSearch.Columns[6].Width = 100;
        //            dgvSearch.Columns[7].Width = 71;
        //            dgvSearch.Columns[8].Width = 61;
        //            dgvSearch.Columns[9].Width = 61;
        //            break;
        //    }
        //}

        public TableSearch()
        {
            InitializeComponent();
        }

        public void FormatDGV()
        {
            dgvSearch.Columns[0].HeaderText = "Booking Number";
            dgvSearch.Columns[1].HeaderText = "Booking Date";
            dgvSearch.Columns[6].HeaderText = "Surname";
            //dgvSearch.Columns[0].Width = 100;
            //dgvSearch.Columns[1].Width = 100;
            //dgvSearch.Columns[2].Width = 81;
            //dgvSearch.Columns[3].Width = 81;
            //dgvSearch.Columns[4].Width = 100;
            //dgvSearch.Columns[5].Width = 100;
            //dgvSearch.Columns[6].Width = 100;
            //dgvSearch.Columns[7].Width = 71;
            //dgvSearch.Columns[8].Width = 61;
            //dgvSearch.Columns[9].Width = 61;
        }
        private void TableSearch_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");
            //SQL For BookingDtails
            sqlBookingDetails = @"select * from BookingDetails";
            daBookingDetails = new SqlDataAdapter(sqlBookingDetails, connStr);
            cmdBBookingDetails = new SqlCommandBuilder(daBookingDetails);
            daBookingDetails.FillSchema(dsBelfray, SchemaType.Source, "BookingDetails");
            daBookingDetails.Fill(dsBelfray, "BookingDetails");
            //SQL for Item
            sqlItem = @"select * from Item";
            daItem = new SqlDataAdapter(sqlItem, connStr);
            cmdBItem = new SqlCommandBuilder(daItem);
            daItem.FillSchema(dsBelfray, SchemaType.Source, "Item");
            daItem.Fill(dsBelfray, "Item");

            //sql for bookings bill
            sqlBill = @"SELECT Booking.bookingNo, BookingDetails.bookingItemNo, BookingDetails.bookingItemQty, Item.itemPrice, Item.itemDesc FROM Booking
                        LEFT JOIN BookingDetails on BookingDetails.bookingNo = Booking.bookingNo
                        LEFT JOIN Item on Item.itemNo = BookingDetails.itemNo";
                        //WHERE BookingDetails.itemNo LIKE '%TB%'";
            daBill = new SqlDataAdapter(sqlBill, connStr);
            daBill.FillSchema(dsBelfray, SchemaType.Source, "Book");
            daBill.Fill(dsBelfray, "Book");
            //dgvTableBill.DataSource = dsBelfray.Tables["Book"];


            //SQL for Booking
            sqlBooking = @"SELECT Booking.bookingNo, Booking.checkInDate, BType.typeDesc AS 'Booking Type', CONVERT(char(5), Booking.bookingTime, 108) AS 'Arrival', 
                            Booking.customerNo AS 'Customer No', Customer.customerForename As 'Forename', Customer.customerSurname, Payment.paymentTypeDesc AS 'Payment', 
                            Booking.partySize AS 'Party Size', Count(BookingItem.itemNo) AS 'Tables Booked' FROM Booking                            
                            LEFT JOIN Customer on Customer.customerNo = Booking.customerNo
                            LEFT JOIN Payment on Payment.paymentTypeID = Booking.paymentTypeID
                            LEFT JOIN BookingItem on BookingItem.bookingNo = Booking.bookingNo
                            LEFT JOIN Item ON  Item.itemNo = BookingItem.itemNo
                            LEFT JOIN BType ON  BType.typeID = Item.typeID
                            WHERE BType.typeID = 'TYP100002'
                            GROUP BY Booking.bookingNo, Booking.checkInDate, Booking.checkOutDate,  BType.typeDesc, 
							Booking.bookingTime, Booking.customerNo, Customer.customerForename, Customer.customerSurname,
							Payment.paymentTypeDesc, Booking.partySize";
            //sqlBooking = @"select * from BookingItem WHERE itemNo LIKE 'TB%'";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            dgvSearch.Visible = true;
            dgvSearch.DataSource = dsBelfray.Tables["Booking"];
            //Resize
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FormatDGV();

        }
    }
}
