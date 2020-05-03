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
    public partial class RoomBookingDisplay : Form
    {
        SqlDataAdapter daBooking;
        DataSet dsBelfray = new DataSet();
        String connStr, sqlBooking;

        bool bookSelected;
                
        public RoomBookingDisplay()
        {
            InitializeComponent();
        }

        private void dgvBookings_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0)
            {
                bookSelected = false;
                Globals.bookNoSel = null;
                //prdSel = null;
            }
            else if (dgvBookings.SelectedRows.Count == 1)
            {
                bookSelected = true;
                Globals.bookNoSel = dgvBookings.SelectedRows[0].Cells[0].Value.ToString();
                //prdSel = Globals.prdNoSel;
            }
        }

        private void RoomBookingDisplay_Load(object sender, EventArgs e)
        {
            dgvBookings.ClearSelection();

            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlBooking = @"SELECT Booking.bookingNo AS 'Booking No', Booking.checkInDate AS 'Check In Date', Booking.checkOutDate AS 'Check Out Date', BType.typeDesc AS 'Booking Type', CONVERT(char(5), Booking.bookingTime, 108) AS 'Arrival', 
                            Booking.customerNo AS 'Customer No', Customer.customerForename As 'Forename', Customer.customerSurname AS 'Surname', Payment.paymentTypeDesc AS 'Payment', 
                            Booking.partySize AS 'Party Size', Count(BookingItem.itemNo) AS 'Rooms Booked' FROM Booking                            
                            LEFT JOIN Customer on Customer.customerNo = Booking.customerNo
                            LEFT JOIN Payment on Payment.paymentTypeID = Booking.paymentTypeID
                            LEFT JOIN BookingItem on BookingItem.bookingNo = Booking.bookingNo
                            LEFT JOIN Item ON  Item.itemNo = BookingItem.itemNo
                            LEFT JOIN BType ON  BType.typeID = Item.typeID
                            WHERE BType.typeID = 'TYP100001'
                            GROUP BY Booking.bookingNo, Booking.checkInDate, Booking.checkOutDate,  BType.typeDesc, 
							Booking.bookingTime, Booking.customerNo, Customer.customerForename, Customer.customerSurname,
							Payment.paymentTypeDesc, Booking.partySize";

            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            dgvBookings.Visible = true;
            dgvBookings.DataSource = dsBelfray.Tables["Booking"];
            //Resize
            dgvBookings.Columns[0].Width = 110;
            dgvBookings.Columns[1].Width = 110;
            dgvBookings.Columns[2].Width = 110;
            dgvBookings.Columns[3].Width = 110;
            dgvBookings.Columns[4].Width = 110;
            dgvBookings.Columns[5].Width = 110;
            dgvBookings.Columns[6].Width = 110;
            dgvBookings.Columns[7].Width = 102;
            dgvBookings.Columns[8].Width = 100;
            dgvBookings.Columns[9].Width = 100;
            dgvBookings.Columns[10].Width = 100;

            //Globals.rooms Reset
            for (int x = 0; x < 19; x++)
            {
                Globals.rooms[x] = " ";
            }

            //Globals.capacity Reset
            for (int x = 0; x < 19; x++)
            {
                Globals.capacity[x] = 0;
            }
        }
    }
}
