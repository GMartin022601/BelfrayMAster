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
    public partial class RoomBookingDelete : Form
    {
        //SQL links
        SqlDataAdapter daBooking, daCustomer;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBooking, cmdBCustomer;
        DataRow drBooking, drCustomer;
        String connStr, sqlBooking, sqlCustomer;

        //Row Selected
        private bool rowSelected = false; 

        //Form Loading
        private bool formLoad = true;

        private void RoomBookingDelete_Load(object sender, EventArgs e)
        {
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

            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");

            ////SQL For Payment Type
            //sqlPayType = @"select * from Payment";
            //daPayType = new SqlDataAdapter(sqlPayType, connStr);
            //cmdBPayType = new SqlCommandBuilder(daPayType);
            //daPayType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            //daPayType.Fill(dsBelfray, "Payment");

            formLoad = false;
        }

        public RoomBookingDelete()
        {
            InitializeComponent();
        }

        //Setting Details
        private void dgvDisplay_Click(object sender, EventArgs e)
        {
            if (dgvDisplay.SelectedRows.Count == 0)
            {
                rowSelected = false;
                Globals.rowSel = null;
            }
            else if (dgvDisplay.SelectedRows.Count == 1)
            {
                rowSelected = true;
                Globals.rowSel = dgvDisplay.SelectedRows[0].Cells[0].Value.ToString();

                //Display info in groupbox
                //Product
                if (cmbSelect.SelectedIndex == 0)
                {
                    drBooking = dsBelfray.Tables["Booking"].Rows.Find(Globals.rowSel.ToString());
                    pnlBooking.BringToFront();
                    pnlBooking.Visible = true;

                    lblBookingNo.Text = drBooking["bookingNo"].ToString();
                    lblCheckIn.Text = drBooking["checkInDate"].ToString();
                    lblCheckOut.Text = drBooking["checkOutDate"].ToString();
                    lblCheckInTime.Text = drBooking["bookingTime"].ToString();
                    lblBookingType.Text = "Room";
                    lblBookingPayment.Text = drBooking["paymentTypeID"].ToString();
                    lblRoomNo.Text = drBooking["roomNo"].ToString();
                    lblBookingPartySize.Text = drBooking["partySize"].ToString();
                    lblCustNo.Text = drBooking["customerNo"].ToString();
                }
                if (cmbSelect.SelectedIndex == 1)
                {
                    drCustomer = dsBelfray.Tables["Customer"].Rows.Find(Globals.rowSel.ToString());
                    pnlCustomer.BringToFront();
                    pnlCustomer.Visible = true;

                    lblCustNo.Text = drCustomer["customerNo"].ToString();
                    lblCustTitle.Text = drCustomer["customerTitle"].ToString();
                    lblCustForename.Text = drCustomer["customerForename"].ToString();
                    lblCustSurname.Text = drCustomer["customerSurname"].ToString();
                    lblCustStreet.Text = drCustomer["customerStreet"].ToString();
                    lblCustCity.Text = drCustomer["customerCity"].ToString();
                    lblCustCounty.Text = drCustomer["customerCounty"].ToString();
                    lblCustPostcode.Text = drCustomer["customerPostcode"].ToString();
                    lblCustPhone.Text = drCustomer["customerTel"].ToString();
                }
            }
        }

        //Determines what has been choosen in Combobox
        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                if (cmbSelect.Text == "Booking")
                {
                    pnlBooking.Visible = false;
                    pnlCustomer.Visible = false;
                    dgvDisplay.Visible = true;
                    dgvDisplay.DataSource = dsBelfray.Tables["Product"];
                    //Resize
                    dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else if (cmbSelect.Text == "Customer")
                {
                    pnlBooking.Visible = false;
                    pnlCustomer.Visible = false;
                    dgvDisplay.Visible = true;
                    dgvDisplay.DataSource = dsBelfray.Tables["ProductType"];
                    //Resize
                    dgvDisplay.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }

        //Cancel Functions
        private void btnCancelDel_MouseEnter(object sender, EventArgs e)
        {

        }       

        private void btnCancelDel_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelDel_MouseLeave(object sender, EventArgs e)
        {

        }

        //Delete Functions
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {

        }

       
    }
}
