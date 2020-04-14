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
    public partial class RoomBookingAdd : Form
    {
        SqlDataAdapter daBooking, daCustomer;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer;
        DataRow drBooking, drCustomer;
        String connStr, sqlBooking, sqlCustomer;

        private void cmbCustomerNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noRows = dsBelfray.Tables["Customer"].Rows.Count;

            foreach (DataRow drItem in dsBelfray.Tables["Customer"].Rows)
            {
                string customer = drCustomer["customerNo"].ToString();

                if (customer.Equals(cmbCustomerNo.ValueMember.ToString()))
                {
                    lblCustNo.Text = customer;
                    
                    txtForename.Text = drCustomer["customerForename"].ToString();
                    txtSurname.Text = drCustomer["customerSurname"].ToString();
                    txtStreet.Text = drCustomer["customerStreet"].ToString();
                    txtCity.Text = drCustomer["customerCity"].ToString();
                    txtCounty.Text = drCustomer["customerCounty"].ToString();

                    break;
                }
            }
        }

        public RoomBookingAdd()
        {
            InitializeComponent();
        }

        //Get Booking Number
        private void getBookingNum(int noRows)
        {
            drBooking = dsBelfray.Tables["Booking"].Rows[noRows - 1];
        }

        private void RoomBookingAdd_Load(object sender, EventArgs e)
        {
            //Current User
            string bookingNo = "";

            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            //SQL For ProductType
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");            

            //CB Details Supplier
            cmbCustomerNo.DataSource = dsBelfray.Tables["Customer"];
            cmbCustomerNo.ValueMember = "customerNo";
            cmbCustomerNo.DisplayMember = "customerNo";
            cmbCustomerNo.SelectedIndex = -1;

            int noRows = dsBelfray.Tables["Booking"].Rows.Count;

            if (noRows == 0)
            {
                bookingNo = "BK10000001";
            }
            else
            {
                getBookingNum(noRows);

                string code = drBooking["bookingNo"].ToString();
                string letters = "BK";
                string numStr = code.Split('K').Last();
                int num = int.Parse(numStr) + 1;

                bookingNo = letters + num.ToString(); 
            }

            lblBookingNo.Text = bookingNo;
        }
    }
}
