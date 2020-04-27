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
    public partial class TableBookingDisplay : Form
    {
        SqlDataAdapter daBooking;
        DataSet dsBelfray = new DataSet();
        String connStr, sqlBooking;
        bool tableSelected;

        public TableBookingDisplay()
        {
            InitializeComponent();
        }

        private void dgvBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                tableSelected = false;
                Globals.bookSel = null;
                //prdSel = null;
            }
            else if (dgvBooking.SelectedRows.Count == 1)
            {
                tableSelected = true;
                Globals.bookSel = dgvBooking.SelectedRows[0].Cells[0].Value.ToString();
                //prdSel = Globals.prdNoSel;
            }
        }

        private void TableBookingDisplay_Load(object sender, EventArgs e)
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

            dgvBooking.Visible = true;
            dgvBooking.DataSource = dsBelfray.Tables["Booking"];
            //Resize
            dgvBooking.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
