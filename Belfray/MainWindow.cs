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

        //SQL links
        SqlDataAdapter daLogin, daBooking;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBLogin, cmdBBooking;
        DataRow drLogin, drBooking;
        String connStr, sqlLogin, sqlBooking;

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

        public void Reset()
        {
            //Resets to welcome screen
            pnlWelcome.Visible = true;
            pnlRoomBooking.Visible = false;

            picTabDisplay.Visible = false;
            picTabSearch.Visible = false;
            picTabAdd.Visible = false;
            picTabEdit.Visible = false;
            picTabDelete.Visible = false;
        }

        public void TabVisible()
        {
            picTabDisplay.Visible = true;
            picTabSearch.Visible = true;
            picTabAdd.Visible = true;
            picTabEdit.Visible = true;
            picTabDelete.Visible = true;
        }

        private void picRoomBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Room Booking
            menuSelected = 1;

            Reset();
            TabVisible();
            pnlRoomBooking.Visible = true;
        }

        private void picRoomStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Cleaning Stock
            menuSelected = 2;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picTableBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Table Booking
            menuSelected = 3;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picRestaurantStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Restaurant Stock
            menuSelected = 4;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picAccount_Click(object sender, EventArgs e)
        {
            //Set menu option select to User Profile
            menuSelected = 5;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            //Set menu option select to Administration
            menuSelected = 6;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Current User
            lblUser.Text = LoginPage.currUser;

            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            sqlLogin = @"select StaffID, staffLogin, staffPassword, accTypeID from Staff";
            daLogin = new SqlDataAdapter(sqlLogin, connStr);
            cmdBLogin = new SqlCommandBuilder(daLogin);

            daLogin.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daLogin.Fill(dsBelfray, "Staff");

            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daLogin);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            
        }
    }
}
