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
        SqlDataAdapter daBooking;
        DataSet dsBelfray = new DataSet();
        String connStr, sqlBooking;
       
        public RoomBookingSearch()
        {
            InitializeComponent();
        }

        private void RoomBookingSearch_Load(object sender, EventArgs e)
        {
            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Product
            sqlBooking = @"select * from Booking WHERE typeID = 'TYP100001'";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            dgvBookingSearch.Visible = true;
            dgvBookingSearch.DataSource = dsBelfray.Tables["Booking"];
            //Resize
            dgvBookingSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
