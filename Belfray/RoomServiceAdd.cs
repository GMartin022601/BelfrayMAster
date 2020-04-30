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
    public partial class RoomServiceAdd : Form
    {
        SqlDataAdapter daCustomer, daBookingDets, daItem, daItemType;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBookingDets, cmdBItem, cmdBItemType;
        DataRow drCustomer, drBookingDets, drItem, drItemType;
        String connStr, sqlCustomer, sqlBookingDets, sqlItem, sqlItemType;

        public RoomServiceAdd()
        {
            InitializeComponent();
        }

        private void RoomServiceAdd_Load(object sender, EventArgs e)
        {            
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking Item
            sqlBookingDets = @"SELECT Bi.itemNo, Bi.bookingNo AS 'Booking Number', Bk.checkInDate AS 'Check In Date', Bk.checkOutDate AS 'Check Out Date', 
                            Bk.customerNo AS 'Customer Number', P.paymentTypeDesc AS 'Payment Type', Bk.partySize AS 'Party Size' FROM BookingItem Bi
                            LEFT JOIN Booking Bk ON bk.bookingNo = Bi.bookingNo
                            LEFT JOIN Payment P on P.paymentTypeID = Bk.paymentTypeID
                            WHERE itemNo LIKE '%RM%' AND Bk.checkInDate <= GETDATE() AND Bk.checkOutDate >= GETDATE()
                            ORDER BY itemNo ASC";
            daBookingDets = new SqlDataAdapter(sqlBookingDets, connStr);
            cmdBBookingDets = new SqlCommandBuilder(daBookingDets);
            daBookingDets.FillSchema(dsBelfray, SchemaType.Source, "Rooms");
            daBookingDets.Fill(dsBelfray, "Rooms");

            //SQL for Booking
            sqlItem = @"SELECT * FROM Item";
            daItem = new SqlDataAdapter(sqlItem, connStr);
            cmdBItem = new SqlCommandBuilder(daItem);
            daItem.FillSchema(dsBelfray, SchemaType.Source, "Items");
            daItem.Fill(dsBelfray, "Items");

            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customers");
            daCustomer.Fill(dsBelfray, "Customers");

            //SQL For Customer
            sqlItemType = @"select * from BType WHERE typeID NOT IN ('TYP100001','TYP100002')";
            daItemType = new SqlDataAdapter(sqlItemType, connStr);
            cmdBItemType = new SqlCommandBuilder(daItemType);
            daItemType.FillSchema(dsBelfray, SchemaType.Source, "Type");
            daItemType.Fill(dsBelfray, "Type");

            //CB Details Customer
            cmbItemType.DataSource = dsBelfray.Tables["Type"];
            cmbItemType.ValueMember = "typeID";
            cmbItemType.DisplayMember = "typeDesc";
            cmbItemType.SelectedIndex = -1;

            displayRooms();
        }

        //Display Rooms
        public void displayRooms()
        {
            dgvRooms.DataSource = dsBelfray.Tables["Rooms"];

            dgvRooms.Columns[0].HeaderText = "Room Number";

            dgvRooms.Columns[0].Width = 82;
            dgvRooms.Columns[1].Width = 82;
            dgvRooms.Columns[2].Width = 81;
            dgvRooms.Columns[3].Width = 81;
            dgvRooms.Columns[4].Width = 81;
            dgvRooms.Columns[5].Width = 73;
            dgvRooms.Columns[6].Width = 73;
        }
    }
}
