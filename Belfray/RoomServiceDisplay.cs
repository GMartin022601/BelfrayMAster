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
    public partial class RoomServiceDisplay : Form
    {
        SqlDataAdapter daBookingItem;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBookingItem;
        DataRow drBookingItem;
        String connStr, sqlBookingItem;

        private void RoomServiceDisplay_Load(object sender, EventArgs e)
        {
            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlBookingItem = @"SELECT Bi.itemNo AS 'Room Number', Bi.bookingNo AS 'Booking Number', Bk.checkInDate AS 'Check In Date', Bk.checkOutDate AS 'Check Out Date', 
                            Bk.customerNo AS 'Customer Number', C.customerTitle AS 'Title', C.customerForename AS 'Forename', C.customerSurname AS 'Surname', 
                            P.paymentTypeDesc AS 'Payment Type', Bk.partySize AS 'Party Size' FROM BookingItem Bi
                            LEFT JOIN Booking Bk ON bk.bookingNo = Bi.bookingNo
                            LEFT JOIN Customer C on C.customerNo = Bk.customerNo
                            LEFT JOIN Payment P on P.paymentTypeID = Bk.paymentTypeID
                            WHERE itemNo LIKE '%RM%' AND Bk.checkInDate <= GETDATE() AND Bk.checkOutDate >= GETDATE()
                            ORDER BY itemNo ASC";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookingItem");
            daBookingItem.Fill(dsBelfray, "BookingItem");
            
            dgvRooms.DataSource = dsBelfray.Tables["BookingItem"];
            dgvRooms.Columns[0].Width = 120;
            dgvRooms.Columns[1].Width = 120;
            dgvRooms.Columns[2].Width = 120;
            dgvRooms.Columns[3].Width = 120;
            dgvRooms.Columns[4].Width = 120;
            dgvRooms.Columns[5].Width = 120;
            dgvRooms.Columns[6].Width = 120;
            dgvRooms.Columns[7].Width = 120;
            dgvRooms.Columns[8].Width = 106;
            dgvRooms.Columns[9].Width = 106;
        }

        public RoomServiceDisplay()
        {
            InitializeComponent();
        }
    }
}
