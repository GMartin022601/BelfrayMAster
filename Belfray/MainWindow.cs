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
    public partial class MainWindow : Form
    {
        //Determines which menu option has been selected 
        //(Room Booking = 1, Cleaning Stock = 2, Table Booking = 3, Restaurant Stock = 4, User Profile = 5, Administraion = 6)
        public int menuSelected = 0;

        //Determines which menu option has been selected 
        //(Display = 1, Search = 2, Add = 3, Edit = 4, Delete = 5)
        public static int tabSelected = 0;

        //SQL links
        SqlDataAdapter daLogin, daBooking, daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBLogin, cmdBBooking, cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drLogin, drBooking, drProduct, drProductType, drSupplier;
        String connStr, sqlLogin, sqlBooking, sqlProduct, sqlProductType, sqlSupplier;

        //Room Select Cancelled?
        private bool cancelled = false;

        //Max Room Capacity
        public static int maxCap = 0;

        public MainWindow()
        {
            InitializeComponent();

            pnlMenu.BackColor = Color.FromArgb(233, 233, 233);
            pnlTabControl.BackColor = Color.FromArgb(63, 63, 63);            
        }

        private void picRoomBooking_MouseEnter(object sender, EventArgs e)
        {
            picRoomBooking.BackColor = Color.FromArgb(137, 36, 26);
        }

        private void picRoomBooking_MouseLeave(object sender, EventArgs e)
        {
            picRoomBooking.BackColor = Color.Transparent;
        }

        private void picRoomStock_MouseEnter(object sender, EventArgs e)
        {
            picRoomStock.BackColor = Color.FromArgb(137, 36, 26);
        }

        private void picRoomStock_MouseLeave(object sender, EventArgs e)
        {
            picRoomStock.BackColor = Color.Transparent;
        }

        private void picTableBooking_MouseEnter(object sender, EventArgs e)
        {
            picTableBooking.BackColor = Color.FromArgb(137, 36, 26);
        }

        private void picTableBooking_MouseLeave(object sender, EventArgs e)
        {
            picTableBooking.BackColor = Color.Transparent;
        }

        private void picRestaurantStock_MouseEnter(object sender, EventArgs e)
        {
            picRestaurantStock.BackColor = Color.FromArgb(137, 36, 26);
        }

        private void picRestaurantStock_MouseLeave(object sender, EventArgs e)
        {
            picRestaurantStock.BackColor = Color.Transparent;
        }

        private void picAccount_MouseEnter(object sender, EventArgs e)
        {
            picAccount.BackColor = Color.FromArgb(137, 36, 26);
        }

        private void picAccount_MouseLeave(object sender, EventArgs e)
        {
            picAccount.BackColor = Color.Transparent;
        }

        private void picAdmin_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.BackColor = Color.FromArgb(137, 36, 26);
        }

        private void picAdmin_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.BackColor = Color.Transparent;
        }

        private void picTabDisplay_MouseEnter(object sender, EventArgs e)
        {
            picTabDisplay.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void picTabDisplay_MouseLeave(object sender, EventArgs e)
        {
            picTabDisplay.BackColor = Color.Transparent;
        }

        private void picTabSearch_MouseEnter(object sender, EventArgs e)
        {
            picTabSearch.BackColor = Color.FromArgb(19, 19, 19);
        }        

        private void picTabSearch_MouseLeave(object sender, EventArgs e)
        {
            picTabSearch.BackColor = Color.Transparent;
        }

        private void picTabAdd_MouseEnter(object sender, EventArgs e)
        {
            picTabAdd.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void picTabAdd_MouseLeave(object sender, EventArgs e)
        {
            picTabAdd.BackColor = Color.Transparent;
        }

        private void picTabEdit_MouseEnter(object sender, EventArgs e)
        {
            picTabEdit.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void picTabEdit_MouseLeave(object sender, EventArgs e)
        {
            picTabEdit.BackColor = Color.Transparent;
        }

        private void picTabDelete_MouseEnter(object sender, EventArgs e)
        {
            picTabDelete.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void picTabDelete_MouseLeave(object sender, EventArgs e)
        {
            picTabDelete.BackColor = Color.Transparent;
        }

        private void picLogOut_MouseEnter(object sender, EventArgs e)
        {
            picLogOut.BackColor = Color.FromArgb(19, 19, 19);
        }

        private void picLogOut_MouseLeave(object sender, EventArgs e)
        {
            picLogOut.BackColor = Color.Transparent;
        }

        public void TabVisible()
        {
            //Makes the Tab controls visible
            picTabDisplay.Visible = true;
            picTabSearch.Visible = true;
            picTabAdd.Visible = true;
            picTabEdit.Visible = true;
            picTabDelete.Visible = true;
        }

        public void TabReset()
        {
            //Makes the Tab controls invisible
            picTabDisplay.Visible = false;
            picTabSearch.Visible = false;
            picTabAdd.Visible = false;
            picTabEdit.Visible = false;
            picTabDelete.Visible = false;
        }

        private void picRoomBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Room Booking
            menuSelected = 1;

            TabVisible();

            picTabDisplay_Click(sender, e);
        }

        private void picRoomStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Cleaning Stock
            menuSelected = 2;

            TabVisible();

            picTabDisplay_Click(sender, e);
        }

        //needs edited to be in the panel as full screen
        private void picTableBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Table Booking
            menuSelected = 3;

            picTabDisplay_Click(sender, e);
        }

        private void picRestaurantStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Table Booking
            menuSelected = 4;

            picTabDisplay_Click(sender, e);
        }

        private void picAccount_Click(object sender, EventArgs e)
        {
            //Set menu option select to User Profile
            menuSelected = 5;

            AccountPage frm = new AccountPage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlMainBody.Controls.Add(frm);
            frm.Show();
            TabReset();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            //Set menu option select to Administration
            menuSelected = 6;

            TabVisible();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            //Logs out of the system by closing the main window and sending the use back to the log in screen
            this.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Current User
            lblUser.Text = LoginPage.currUser;
            int AccType = 0;

            //Links the accType on DB to values 1, 2 and 3 so the switch statement works (Sean comment this out if you are using an old version of the DB)
            if(LoginPage.accType.ToString().Equals("ADM"))
            {
                AccType = 1;
            }
            else if (LoginPage.accType.ToString().Equals("HTL"))
            {
                AccType = 2;
            }
            else if(LoginPage.accType.ToString().Equals("RES"))
            {
                AccType = 3;
            }

            //Determines account type and what menu they will get upon entry
            switch (AccType)
            {
                case 1: //Admin            
                    break;
                case 2: //Hotel
                    picTableBooking.Visible = false;
                    picRestaurantStock.Visible = false;
                    picAdmin.Visible = false;

                    picRoomBooking.Location = new Point(358, 10);
                    picRoomStock.Location = new Point(549, 10);
                    picAccount.Location = new Point(740, 10);
                    break;
                case 3: //Restaurant
                    picRoomBooking.Visible = false;
                    picRoomStock.Visible = false;
                    picAdmin.Visible = false;

                    picTableBooking.Location = new Point(358, 10);
                    picRestaurantStock.Location = new Point(549, 10);
                    picAccount.Location = new Point(740, 10);
                    break;
            }

            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Staff
            sqlLogin = @"select * from Staff";
            daLogin = new SqlDataAdapter(sqlLogin, connStr);
            cmdBLogin = new SqlCommandBuilder(daLogin);

            daLogin.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daLogin.Fill(dsBelfray, "Staff");

            //SQL for Booking
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daLogin);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            //SQL for Product
            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daLogin);

            daProduct.FillSchema(dsBelfray, SchemaType.Source, "Product");
            daProduct.Fill(dsBelfray, "Product");

            //SQL For ProductType
            sqlProductType = @"select * from ProductType";
            daProductType = new SqlDataAdapter(sqlProductType, connStr);
            cmdBProductType = new SqlCommandBuilder(daLogin);

            daProductType.FillSchema(dsBelfray, SchemaType.Source, "ProductType");
            daProductType.Fill(dsBelfray, "ProductType");

            //SQL For Supplier
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daLogin);

            daSupplier.FillSchema(dsBelfray, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsBelfray, "Supplier");

        }

        private void picTabDisplay_Click(object sender, EventArgs e)
        {
            tabSelected = 0;

            switch(menuSelected)
            {
                case 0: //Welcome
                    break;
                case 1: //Room Booking
                    RoomBookingDisplay frm = new RoomBookingDisplay();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm);
                    frm.Show();
                    break;
                case 2: //Room Stock
                    RoomServiceDisplay frm2 = new RoomServiceDisplay();
                    frm2.TopLevel = false;
                    frm2.FormBorderStyle = FormBorderStyle.None;
                    frm2.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm2);
                    frm2.Show();
                    break;
                case 3: //Table Booking
                    TableBookingDisplay frm3 = new TableBookingDisplay();
                    frm3.TopLevel = false;
                    frm3.FormBorderStyle = FormBorderStyle.None;
                    frm3.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm3);
                    frm3.Show();
                    TabVisible();
                    break;
                case 4: //Restaurant Stock
                    RestaurantStockDisplay frm4 = new RestaurantStockDisplay();
                    frm4.TopLevel = false;
                    frm4.FormBorderStyle = FormBorderStyle.None;
                    frm4.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm4);
                    frm4.Show();
                    TabVisible();
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }

            //Diable Selected Tab
            picTabDisplay.Enabled = false;

            //Enable All Other Tabs
            picTabSearch.Enabled = true;
            picTabAdd.Enabled = true;
            picTabEdit.Enabled = true;
            picTabDelete.Enabled = true;

            Globals.roomLoad = true;
        }

        private void picTabSearch_Click(object sender, EventArgs e)
        {
            tabSelected = 1;

            switch (menuSelected)
            {
                case 0: //Welcome
                    break;
                case 1: //Room Booking
                    RoomBookingSearch frm = new RoomBookingSearch();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm);
                    frm.Show();
                    break;
                case 2: //Room Stock
                    RoomServiceSearch frm2 = new RoomServiceSearch();
                    frm2.TopLevel = false;
                    frm2.FormBorderStyle = FormBorderStyle.None;
                    frm2.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm2);
                    frm2.Show();
                    break;
                case 3: //Table Booking
                    TableSearch frm3 = new TableSearch();
                    frm3.TopLevel = false;
                    frm3.FormBorderStyle = FormBorderStyle.None;
                    frm3.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm3);
                    frm3.Show();
                    break;
                case 4: //Restaurant Stock
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }

            if (menuSelected != 2)
            {
                //Diable Selected Tab and Edit Tab
                picTabSearch.Enabled = false;
                picTabEdit.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabAdd.Enabled = true;
                picTabDelete.Enabled = true;
            }
            else
            {
                //Diable Selected Tab and Edit Tab
                picTabSearch.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabAdd.Enabled = true;
                picTabDelete.Enabled = true;
                picTabEdit.Enabled = true;
            }
        }

        private void picTabAdd_Click(object sender, EventArgs e)
        {
            tabSelected = 2;

            switch (menuSelected)
            {
                case 0: //Welcome
                    break;
                case 1: //Room Booking
                    pnlRoomSelect.BringToFront();
                    pnlRoomSelect.Visible = true;

                    RoomSelect frm = new RoomSelect();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.FormClosing += RoomSelect_Closing;
                    frm.FormClosed += RoomSelect_Closed;
                    pnlRoomSelect.Controls.Add(frm);
                    frm.Show();
                    break;
                case 2: //Room Service
                    RoomServiceAdd frm2 = new RoomServiceAdd();
                    frm2.TopLevel = false;
                    frm2.FormBorderStyle = FormBorderStyle.None;
                    frm2.WindowState = FormWindowState.Maximized;
                    frm2.FormClosed += RoomServiceAdd_Closed;
                    pnlMainBody.Controls.Add(frm2);
                    frm2.Show();
                    break;
                case 3: //Table Booking
                    pnlTableSelect.BringToFront();
                    pnlTableSelect.Visible = true;
                    TableSelect form = new TableSelect();
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.WindowState = FormWindowState.Maximized;
                    form.FormClosed += TableSelect_Closed;
                    pnlTableSelect.Controls.Add(form);
                    form.Show();
                    break;
                case 4: //Restaurant Stock
                    RestaurantStockAdd frm4 = new RestaurantStockAdd();
                    frm4.TopLevel = false;
                    frm4.FormBorderStyle = FormBorderStyle.None;
                    frm4.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm4);
                    frm4.Show();
                    TabVisible();
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }

            if (menuSelected != 2)
            {
                //Diable Selected Tab and Edit Tab
                picTabAdd.Enabled = false;
                picTabEdit.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabSearch.Enabled = true;
                picTabDelete.Enabled = true;
            }
            else
            {
                //Diable Selected Tab and Edit Tab
                picTabAdd.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabSearch.Enabled = true;
                picTabDelete.Enabled = true;
                picTabEdit.Enabled = true;
            }
        }

        private void picTabEdit_Click(object sender, EventArgs e)
        {
            tabSelected = 3;
            bool error = false;

            switch (menuSelected)
            {
                case 0: //Welcome
                    break;
                case 1: //Room Booking
                    if (Globals.bookNoSel == "")
                    {
                        MessageBox.Show("Error: No Booking Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                    else
                    {
                        RoomBookingEdit frm = new RoomBookingEdit();
                        frm.TopLevel = false;
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.FormClosed += RoomBookingEdit_Closed;
                        frm.FormClosing += RoomBookingEdit_Closing;
                        pnlMainBody.Controls.Add(frm);
                        frm.Show();
                    }
                    break;
                case 2: //Room Service
                    RoomServiceEdit frm2 = new RoomServiceEdit();
                    frm2.TopLevel = false;
                    frm2.FormBorderStyle = FormBorderStyle.None;
                    frm2.WindowState = FormWindowState.Maximized;
                    frm2.FormClosed += RoomServiceEdit_Closed;
                    pnlMainBody.Controls.Add(frm2);
                    frm2.Show();
                    break;
                case 3: //Table Booking
                    if (Globals.bookSel == null)
                    {
                        MessageBox.Show("Error: No Booking Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pnlTableSelect.BringToFront();
                        pnlTableSelect.Visible = true;

                        TableSelectEdit form = new TableSelectEdit();
                        form.TopLevel = false;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.WindowState = FormWindowState.Maximized;
                        form.FormClosed += TableSelectEdit_Closed;
                        pnlTableSelect.Controls.Add(form);
                        form.Show();
                        break;
                    }
                    break;
                case 4: //Restaurant Stock NEEDS WORK
                    if (Globals.prdNoSel == null)
                    {
                        MessageBox.Show("Error: No Product Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        error = true;
                    }
                    else
                    {
                        RestaurantStockEdit frm4 = new RestaurantStockEdit();
                        frm4.TopLevel = false;
                        frm4.FormBorderStyle = FormBorderStyle.None;
                        frm4.WindowState = FormWindowState.Maximized;
                        pnlMainBody.Controls.Add(frm4);
                        frm4.Show();
                        TabVisible();
                        //break;
                    }
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }

            if (!error)
            {
                //Disable Selected Tab
                picTabEdit.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabSearch.Enabled = true;
                picTabAdd.Enabled = true;
                picTabDelete.Enabled = true;

                //Globals.bookNoSel = "";
            }
        }

        private void picTabDelete_Click(object sender, EventArgs e)
        {
            tabSelected = 4;

            switch (menuSelected)
            {
                case 0: //Welcome
                    break;
                case 1: //Room Booking
                    RoomBookingDelete frm = new RoomBookingDelete();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm);
                    frm.Show();
                    break;
                case 2: //Room Service
                    RoomServiceDelete frm2 = new RoomServiceDelete();
                    frm2.TopLevel = false;
                    frm2.FormBorderStyle = FormBorderStyle.None;
                    frm2.WindowState = FormWindowState.Maximized;
                    frm2.FormClosed += RoomServiceDel_Closed;
                    pnlMainBody.Controls.Add(frm2);
                    frm2.Show();
                    break;
                case 3: //Table Booking
                    break;
                case 4: //Restaurant Stock
                    RestaurantStockDelete frm4 = new RestaurantStockDelete();
                    frm4.TopLevel = false;
                    frm4.FormBorderStyle = FormBorderStyle.None;
                    frm4.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm4);
                    frm4.Show();
                    TabVisible();
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }

            if (menuSelected != 2)
            {
                //Disable Selected Tab and Edit Tab
                picTabDelete.Enabled = false;
                picTabEdit.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabSearch.Enabled = true;
                picTabAdd.Enabled = true;
            }
            else
            {
                //Disable Selected Tab and Edit Tab
                picTabDelete.Enabled = false;

                //Enable All Other Tabs
                picTabDisplay.Enabled = true;
                picTabSearch.Enabled = true;
                picTabAdd.Enabled = true;
                picTabEdit.Enabled = true;
            }
        }

        //Room Select Closing
        private void RoomSelect_Closing(object sender, FormClosingEventArgs e)
        {
            cancelled = RoomSelect.cancelled;
        }

        //Room Select Close
        private void RoomSelect_Closed(object sender, FormClosedEventArgs e)
        {
            if (tabSelected == 2)
            {
                if (cancelled)
                {
                    pnlRoomSelect.Visible = false;

                    picTabDisplay_Click(sender, e);
                }
                else
                {
                    pnlRoomSelect.Visible = false;

                    RoomBookingAdd frm = new RoomBookingAdd();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.FormClosing += RoomBookingAdd_Closing;
                    frm.FormClosed += RoomBookingAdd_Closed;
                    pnlMainBody.Controls.Add(frm);
                    frm.Show();
                }
            }
            else if (tabSelected == 3)
            {
                if (cancelled)
                {
                    pnlRoomSelect.Visible = false;

                    //Globals.firstLoad = true;

                    picTabEdit_Click(sender, e);
                }
                else
                {
                    pnlRoomSelect.Visible = false;

                    Globals.firstLoad = false;

                    RoomBookingEdit frm = new RoomBookingEdit();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.FormClosing += RoomBookingEdit_Closing;
                    frm.FormClosed += RoomBookingEdit_Closed;
                    pnlMainBody.Controls.Add(frm);
                    frm.Show();
                }
            }
        }

        //Table Select Close
        private void TableSelect_Closed(object sender, FormClosedEventArgs e)
        {
            pnlTableSelect.Visible = false;

            TableBookingDisplay frm = new TableBookingDisplay();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlMainBody.Controls.Add(frm);
            frm.Show();
            TabVisible();
        }
        private void TableSelectEdit_Closed(object sender, FormClosedEventArgs e)
        {
            pnlTableSelect.Visible = false;

            TableBookingDisplay frm = new TableBookingDisplay();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlMainBody.Controls.Add(frm);
            frm.Show();
            TabVisible();
        }

        //Room Booking Add Closing
        private void RoomBookingAdd_Closing(object sender, FormClosingEventArgs e)
        {
            cancelled = RoomBookingAdd.cancelled;
        }

        //Room Booking Add Close
        private void RoomBookingAdd_Closed(object sender, FormClosedEventArgs e)
        {
            if (cancelled)
            {
                pnlRoomSelect.Visible = false;

                Globals.firstLoad = true;

                picTabDisplay_Click(sender, e);
            }
            else
            {
                pnlRoomSelect.Visible = true;
                pnlRoomSelect.BringToFront();

                RoomSelect frm = new RoomSelect();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.FormClosing += RoomSelect_Closing;
                frm.FormClosed += RoomSelect_Closed;
                pnlRoomSelect.Controls.Add(frm);
                frm.Show();
            }
        }

        //Room Booking Edit Closing
        private void RoomBookingEdit_Closing(object sender, FormClosingEventArgs e)
        {
            cancelled = RoomBookingEdit.cancelled;
        }

        //Room Booking Edit Close
        private void RoomBookingEdit_Closed(object sender, FormClosedEventArgs e)
        {
            if (cancelled)
            {
                pnlRoomSelect.Visible = false;

                Globals.firstLoad = true;

                picTabDisplay_Click(sender, e);
            }
            else
            {
                pnlRoomSelect.Visible = true;
                pnlRoomSelect.BringToFront();

                Globals.firstLoad = false;

                RoomSelect frm = new RoomSelect();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.FormClosing += RoomSelect_Closing;
                frm.FormClosed += RoomSelect_Closed;
                pnlRoomSelect.Controls.Add(frm);
                frm.Show();
            }
        }

        //Room Booking Edit Close
        private void RoomServiceAdd_Closed(object sender, FormClosedEventArgs e)
        {
            picTabDisplay_Click(sender, e);
        }

        //Room Booking Edit Close
        private void RoomServiceEdit_Closed(object sender, FormClosedEventArgs e)
        {
            picTabDisplay_Click(sender, e);
        }

        //Room Booking Delete Close
        private void RoomServiceDel_Closed(object sender, FormClosedEventArgs e)
        {
            picTabDisplay_Click(sender, e);
        }
    }
}
