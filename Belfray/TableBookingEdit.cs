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
    public partial class TableBookingEdit : Form
    {
        //SQL links
        SqlDataAdapter daCustomer, daBooking, daBookingType, daPaymentType, daBookingItem, daItem;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingType, cmdBPaymentType, cmdBBookingItem, cmdBItem;

        DataRow drCustomer, drBooking, drBookingType, drPaymentType, drBookingItem, drItem;
        String connStr, sqlBooking, sqlCustomer, sqlBookingType, sqlPaymentType, sqlBookingItem, sqlItem;
        bool formLoad = true;
        bool tableSelected;
        //bool getInfo, bookingInfo;
        //bool newCustomer, newBooking, tableSelected;
        //public bool arrowCreated = false;
        //int tableNoSelected, partySize;

        private void dgvBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                tableSelected = false;
                Globals.tableSel = null;
                //prdSel = null;
            }
            else if (dgvBooking.SelectedRows.Count == 1)
            {
                tableSelected = true;
                Globals.tableSel = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();
                lblTablNo.Text = Globals.tableSel.ToString();
            }
        }

            private void picRemoveTable_Click(object sender, EventArgs e)
        {
            if (!tableSelected)
            {
                MessageBox.Show("Please select a table to remove it from the booking", "Remove a Table", MessageBoxButtons.OK);
            }
            else
            {
                dgvBooking.Rows.RemoveAt(this.dgvBooking.SelectedRows[0].Index);
                //dgvBooking.Rows.RemoveAt(dgvBooking.Rows[Convert.ToInt32(lblTablNo.Text]);
                //lblTableNo.Text = "-";
                dgvBooking.ClearSelection();
                lblTablNo.Text = "";
                //Sum of party size
                int sum = 0;
                for (int i = 0; i < dgvBooking.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dgvBooking.Rows[i].Cells[2].Value);
                }
                numPartySize.Value = sum;
            }
        }

        private void picAddNewTable_Click(object sender, EventArgs e)
        {
            TableBookingAdd frm = new TableBookingAdd();
            frm.Show();
        }

        // private void cbPaymentTyp_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!formLoad)
        //    {
        //        DataRow drMethod = dsBelfray.Tables["Payment"].Rows.Find(cbPaymentTyp.SelectedValue);
        //      cbPaymentTyp.SelectedValue = drMethod["paymentTypeDesc"].ToString();

        //  }
        //
        //}

        private void getCustNum(int noRows)
        {
            drCustomer = dsBelfray.Tables["Customer"].Rows[noRows - 1];
        }
        private void getBookingNum(int noRows)
        {
            drBooking = dsBelfray.Tables["Booking"].Rows[noRows - 1];
        }

        public TableBookingEdit()
        {
            InitializeComponent();
        }

        private void TableBookingEdit_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

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
            //SQL for Item Type
            sqlItem = @"select * from Item";
            daItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBItem = new SqlCommandBuilder(daItem);
            daItem.FillSchema(dsBelfray, SchemaType.Source, "Item");
            daItem.Fill(dsBelfray, "Item");
            //cbPayment type
            cbPaymentTyp.DataSource = dsBelfray.Tables["Payment"];
            cbPaymentTyp.ValueMember = "paymentTypeID";
            cbPaymentTyp.DisplayMember = "paymentTypeDesc";
            cbPaymentTyp.SelectedIndex = -1;

            //cb Title
            cbCustNo.DataSource = dsBelfray.Tables["Customer"];
            cbCustNo.ValueMember = "customerNo";
            cbCustNo.DisplayMember = "customerNo";
            cbCustNo.SelectedIndex = -1;
            //cb title
            cbTitle.DataSource = dsBelfray.Tables["Customer"];
            cbTitle.ValueMember = "customerTitle";
            cbTitle.DisplayMember = "customerTitle";
            cbTitle.SelectedIndex = -1;


            //Fill Form
            lblBookingNo.Text = Globals.bookSel.ToString();

            drBooking = dsBelfray.Tables["Booking"].Rows.Find(lblBookingNo.Text);
            //drPaymentType = dsBelfray.Tables["Booking"].Rows.Find(cbPaymentTyp.SelectedIndex);

            txtTime.Text = drBooking["bookingTime"].ToString();
            numPartySize.Value = Convert.ToInt32(drBooking["partySize"].ToString());
            //cbPaymentTyp.SelectedValue = drPaymentType["paymentTypeDesc"].ToString();
            
            //dgvBooking.Rows.Add(lblBookingNo.Text, lblTableNo.Text, lblTableCapacity.Text);

            foreach (DataRow drBook in dsBelfray.Tables["BookingItem"].Rows)
            {
                
                string tableNumber = "";
                string itemNumber = "";
                string partySize = "";

                if (drBook["bookingNo"].Equals(lblBookingNo.Text))
                {
                    //drItem = dsBelfray.Tables["Item"].Rows.Find(tableNumber);

                    tableNumber = drBook["bookingNo"].ToString();
                    itemNumber = drBook["itemNo"].ToString();
                    //partySize = drItem["capacity"].ToString();
                    partySize = drBooking["partySize"].ToString();

                    dgvBooking.ColumnCount = 3;
                    dgvBooking.Columns[0].Name = "Booking Number";
                    dgvBooking.Columns[0].Width = 190;
                    dgvBooking.Columns[1].Name = "Table Number";
                    dgvBooking.Columns[1].Width = 190;
                    dgvBooking.Columns[2].Name = "Party Size";
                    dgvBooking.Columns[2].Width = 100;

                    dgvBooking.Rows.Add(tableNumber, itemNumber, partySize);
                }
            }

            cbCustNo.SelectedValue = drBooking["customerNo"].ToString();
            drCustomer = dsBelfray.Tables["Customer"].Rows.Find(cbCustNo.SelectedValue);
            cbTitle.SelectedValue = drCustomer["customerTitle"].ToString();
            txtFname.Text = drCustomer["customerForename"].ToString();
            txtLName.Text = drCustomer["customerSurname"].ToString();
            txtCity.Text = drCustomer["Customercity"].ToString();
            txtStreet.Text = drCustomer["customerStreet"].ToString();
            txtCounty.Text = drCustomer["customerCounty"].ToString();
            txtPC.Text = drCustomer["customerPostcode"].ToString();
            txtTelNo.Text = drCustomer["customerTel"].ToString();

            formLoad = false;


        }
    }
}
