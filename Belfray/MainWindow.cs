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
        //String prodNumSel = "";

        //SQL links
        SqlDataAdapter daLogin, daBooking, daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBLogin, cmdBBooking, cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drLogin, drBooking, drProduct, drProductType, drSupplier;
        String connStr, sqlLogin, sqlBooking, sqlProduct, sqlProductType, sqlSupplier;

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

        public void Reset()
        {
            
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

            Reset();
            TabVisible();

            RoomBookingDisplay frm = new RoomBookingDisplay();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlMainBody.Controls.Add(frm);
            frm.Show();
        }

        private void picRoomStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Cleaning Stock
            menuSelected = 2;

            TabVisible();
        }

        private void picTableBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Table Booking
            menuSelected = 3;

            TabVisible();
        }

        private void picRestaurantStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Table Booking
            menuSelected = 4;

            RestaurantStockDisplay frm = new RestaurantStockDisplay();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlMainBody.Controls.Add(frm);
            frm.Show();
            TabVisible();
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
            //TabVisible();
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
            
            switch(LoginPage.accType)
            {
                case 1: //Admin            
                    break;
                case 2: //Hotel
                    picTableBooking.Visible = false;
                    picRestaurantStock.Visible = false;

                    picRoomBooking.Location = new Point(259, 10);
                    picRoomStock.Location = new Point(450, 10);
                    picAccount.Location = new Point(641, 10);
                    picAdmin.Location = new Point(832, 10);
                    break;
                case 3: //Restaurant
                    picRoomBooking.Visible = false;
                    picRoomStock.Visible = false;

                    picTableBooking.Location = new Point(259, 10);
                    picRestaurantStock.Location = new Point(450, 10);
                    picAccount.Location = new Point(641, 10);
                    picAdmin.Location = new Point(832, 10);
                    break;
            }

            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
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
                    break;
                case 3: //Table Booking
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
        }

        private void picTabSearch_Click(object sender, EventArgs e)
        {
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
                    break;
                case 3: //Table Booking
                    break;
                case 4: //Restaurant Stock
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }
        }

        private void picTabAdd_Click(object sender, EventArgs e)
        {
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
                    frm.FormClosed += RoomSelect_Closed;
                    pnlRoomSelect.Controls.Add(frm);
                    frm.Show();
                    break;
                case 2: //Room Stock
                    break;
                case 3: //Table Booking
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
        }

        private void picTabEdit_Click(object sender, EventArgs e)
        {
            switch (menuSelected)
            {
                case 0: //Welcome
                    break;
                case 1: //Room Booking
                    RoomBookingEdit frm = new RoomBookingEdit();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.WindowState = FormWindowState.Maximized;
                    pnlMainBody.Controls.Add(frm);
                    frm.Show();
                    break;
                case 2: //Room Stock
                    break;
                case 3: //Table Booking
                    break;
                case 4: //Restaurant Stock NEEDS WORK
                    if (Globals.prdNoSel == null)
                    {
                        MessageBox.Show("Error: No Product Selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void picTabDelete_Click(object sender, EventArgs e)
        {
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
                case 2: //Room Stock
                    break;
                case 3: //Table Booking
                    break;
                case 4: //Restaurant Stock
                    break;
                case 5: //Staff
                    break;
                case 6: //Administration
                    break;
            }
        }
        private void RoomSelect_Closed(object sender, FormClosedEventArgs e)
        {
            pnlRoomSelect.Visible = false;

            RoomBookingAdd frm = new RoomBookingAdd();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            pnlMainBody.Controls.Add(frm);
            frm.Show();
        }
    }
}
