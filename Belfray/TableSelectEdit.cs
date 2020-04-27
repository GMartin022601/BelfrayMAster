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
    public partial class TableSelectEdit : Form
    {
        //SQL links
        SqlDataAdapter daCustomer, daBooking, daBookingType, daPaymentType, daBookingDGV, daBookingItem;// daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingType, cmdBPaymentType, cmdBBookingItem;
        DataRow drCustomer, drBooking, drBookingType, drPaymentType, drBookingItem;
        String connStr, sqlBooking, sqlCustomer, sqlBookingType, sqlPaymentType, sqlBookingDGV, sqlBookingItem;
        bool formLoad = true;
        bool getInfo, bookingInfo;
        bool newCustomer, newBooking, tableSelected;
        public bool arrowCreated = false;
        int tableNoSelected, partySize;

        private void TableSelectEdit_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            formLoad = false;

            //SQL For Booking
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);
            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");
            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");
            //SQL for booking Type
            sqlBookingType = @"select * from BType";
            daBookingType = new SqlDataAdapter(sqlBookingType, connStr);
            cmdBBookingType = new SqlCommandBuilder(daBookingType);
            daBookingType.FillSchema(dsBelfray, SchemaType.Source, "BType");
            daBookingType.Fill(dsBelfray, "BType");
            //SQL for Payment Type
            sqlPaymentType = @"select * from Payment";
            daPaymentType = new SqlDataAdapter(sqlPaymentType, connStr);
            cmdBPaymentType = new SqlCommandBuilder(daPaymentType);
            daPaymentType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPaymentType.Fill(dsBelfray, "Payment");
            //SQL for bookingItem Type
            sqlBookingItem = @"select * from BookingItem";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookingItem");
            daBookingItem.Fill(dsBelfray, "BookingItem");
            //cbPayment type
            cbPaymentTyp.DataSource = dsBelfray.Tables["Payment"];
            cbPaymentTyp.ValueMember = "paymentTypeDesc";
            cbPaymentTyp.DisplayMember = "paymentTypeDesc";
            cbPaymentTyp.SelectedIndex = -1;
            //cb title
            cbTitle.DataSource = dsBelfray.Tables["Customer"];
            cbTitle.ValueMember = "customerTitle";
            cbTitle.DisplayMember = "customerTitle";
            cbTitle.SelectedIndex = -1;

            //Fill booking Details
            lblBookingNo.Text = Globals.bookSel.ToString();
            drBooking = dsBelfray.Tables["Booking"].Rows.Find(lblBookingNo.Text);

            foreach (DataRow drBooking in dsBelfray.Tables["Booking"].Rows)
            {
                    foreach (DataRow drBookingType in dsBelfray.Tables["BType"].Rows)
                    {
                        foreach (DataRow drPaymentType2 in dsBelfray.Tables["Payment"].Rows)
                        {
                            string bDate = drBooking["checkInDate"].ToString();
                            string bTime = drBooking["bookingTime"].ToString();
                            //string pType = drPaymentType["paymentTypeDesc"].ToString();
                            int partySize = Convert.ToInt32(drBooking["partySize"].ToString());

                            dateBooking.Value = Convert.ToDateTime(bDate);
                            txtTime.Text = bTime;
                            numPartySize.Value = partySize;
                            lblCustNo.Text = drBooking["customerNo"].ToString();
                            cbPaymentTyp.SelectedValue = drPaymentType2["paymentTypeDesc"].ToString();
                            //txtPaymentType.Text = drPaymentType2["paymentTypeDesc"].ToString();
                        }
                    }
            }
            //DGV Populate
            foreach (DataRow drTable in dsBelfray.Tables["BookingItem"].Rows)
            {
                string bookingNo = "";
                string itemNo = "";

                if (drTable["bookingNo"].Equals(lblBookingNo.Text))
                {
                    bookingNo = drTable["bookingNo"].ToString();
                    itemNo = drTable["itemNo"].ToString();
                    dgvBooking.ColumnCount = 2;
                    dgvBooking.Columns[0].Name = "Booking Number";
                    dgvBooking.Columns[0].Width = 237;
                    dgvBooking.Columns[1].Name = "Table Number";
                    dgvBooking.Columns[1].Width = 240;
                    dgvBooking.Rows.Add(bookingNo, itemNo);
                }
            }
            //Fill Customer details
            drCustomer = dsBelfray.Tables["Customer"].Rows.Find(lblCustNo.Text);
            txtFname.Text = drCustomer["customerForename"].ToString();
            txtLName.Text = drCustomer["customerSurname"].ToString();
            txtStreet.Text = drCustomer["customerStreet"].ToString();
            txtCity.Text = drCustomer["customerCity"].ToString();
            txtCounty.Text = drCustomer["customerCounty"].ToString();
            txtPC.Text = drCustomer["customerPostcode"].ToString();
            txtTelNo.Text = drCustomer["customerTel"].ToString();
            cbTitle.SelectedValue = drCustomer["customerTitle"].ToString();
        }

            public TableSelectEdit()
        {
            InitializeComponent();
        }
    }
}
