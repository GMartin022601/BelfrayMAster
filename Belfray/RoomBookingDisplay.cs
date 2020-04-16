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
                
        public RoomBookingDisplay()
        {
            InitializeComponent();
        }

        private void RoomBookingDisplay_Load(object sender, EventArgs e)
        {
            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Product
            sqlBooking = @"SELECT bookingNo AS 'Booking No', checkInDate AS 'Check In Date', checkOutDate AS 'Check Out Date', BType.typeDesc AS 'Booking Type', CONVERT(char(5), Booking.bookingTime, 108) AS 'Arrival', 
                            Booking.customerNo AS 'Customer No', Customer.customerForename As 'Forename', Customer.customerSurname AS 'Surname', Payment.paymentTypeDesc AS 'Payment', 
                            Booking.partySize AS 'Party Size', Booking.roomNo AS 'Room', Rooms.roomtype AS 'Room Type', Rooms.pricePerDay AS 'Price Per Day' FROM Booking
                            LEFT JOIN BType ON  BType.typeID = Booking.typeID
                            LEFT JOIN Customer on Customer.customerNo = Booking.customerNo
                            LEFT JOIN Payment on Payment.paymentTypeID = Booking.paymentTypeID
                            LEFT JOIN Rooms on Rooms.roomNo = Booking.roomNo
                            WHERE Booking.typeID = 'TYP100001'";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            dgvBookings.Visible = true;
            dgvBookings.DataSource = dsBelfray.Tables["Booking"];
            //Resize
            dgvBookings.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
