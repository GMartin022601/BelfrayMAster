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

        public TableBookingDisplay()
        {
            InitializeComponent();
        }

        private void TableBookingDisplay_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Product
            sqlBooking = @"select * from Booking";// WHERE typeID = '10001' AND typeID ='10002'";
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
