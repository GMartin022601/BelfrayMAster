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
        DataRow drBookingDetails, drCustomer, drBookingItem, drPaymentType, drBooking;
        String connStr, sqlBookingDetails, sqlCustomer, sqlBookingItem, sqlPaymentType, sqlBooking;
        SqlDataAdapter daBookingDetails, daCustomer, daBookingItem, daPaymentType, daBooking;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBookingDetails, cmdBCustomer, cmdBBookingItem, cmdBPaymentType, cmdBBooking;
        private int searchOption = 0;
        private string selected = "";
       
        
        private void dgvSearch_Click(object sender, EventArgs e)
        {
            if (dgvSearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nothing selected.", "Error", MessageBoxButtons.OK);
            }
            else if (dgvSearch.SelectedRows.Count == 1)
            {
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

        private void txtBookingNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtBookingNumber.Text.Length < 10)
            {
                txtBookingNumber.BackColor = Color.LightCoral;
                //MessageBox.Show("Booking number must be 10 characters beginnin BK.", "Search error", MessageBoxButtons.OK);

            }
            if (txtBookingNumber.Text.Length > 10)
            {
                MessageBox.Show("Booking number must be 10 characters beginnin BK.", "Search error", MessageBoxButtons.OK);

            }
            else
            {
                searchOption = 1;
                //txtSearchItemName.BackColor = Color.White;
                //picSearch.Enabled = true;
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            switch (searchOption)
            {
                case 0:
                    MessageBox.Show("Please us the options below to search.", "Search error", MessageBoxButtons.OK);
                    break;
                case 1:
                    selected = dgvSearch.SelectedRows[0].Cells[0].Value.ToString();

                    
                    
                    dgvSearch.DataSource = bookingSearch;
                    dgvSearch.Columns[0].HeaderText = "Booking No";

                    dgvSearch.Columns[0].Width = 82;
                    dgvSearch.Columns[1].Width = 82;
                    dgvSearch.Columns[2].Width = 81;
                    dgvSearch.Columns[3].Width = 81;
                    dgvSearch.Columns[4].Width = 71;
                    dgvSearch.Columns[5].Width = 51;
                    dgvSearch.Columns[6].Width = 71;
                    dgvSearch.Columns[7].Width = 71;
                    dgvSearch.Columns[8].Width = 61;
                    dgvSearch.Columns[9].Width = 40;
                    break;
            }
        }

        public TableSearch()
        {
            InitializeComponent();
        }

        private void TableSearch_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlBooking = @"SELECT Booking.bookingNo AS 'Booking No', Booking.checkInDate AS 'Check In Date', BType.typeDesc AS 'Booking Type', CONVERT(char(5), Booking.bookingTime, 108) AS 'Arrival', 
                            Booking.customerNo AS 'Customer No', Customer.customerForename As 'Forename', Customer.customerSurname AS 'Surname', Payment.paymentTypeDesc AS 'Payment', 
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
            dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
    }
}
