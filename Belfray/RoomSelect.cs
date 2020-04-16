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
    public partial class RoomSelect : Form
    {
        public bool arrowCreated = false;

        //SQL Links
        SqlDataAdapter daRoom, daBooking;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBRoom, cmdBBooking;
        DataRow drRoom, drBooking;
        String connStr, sqlRoom, sqlBooking, room;
        bool userChange = false;

        //Room Selected
        public static string roomSelected = "";

        //Room Selected
        public static bool cancelled = false;

        //Save active
        private static bool saveActive = false;

        //Check In Date
        public static DateTime checkInDate = new DateTime();

        //Check Out Date
        public static DateTime checkOutDate = new DateTime();

        public RoomSelect()
        {
            InitializeComponent();
        }

        //Creates the Up arrow
        public void arrowControlUp(Color colour, bool created, int x, int y)
        {
            SolidBrush sb = new SolidBrush(colour);
            Point[] pointArray = { new Point(x, y), new Point(x+20, y+25), new Point(x-20, y + 25) };
            Graphics g = pnlFloorPlan.CreateGraphics();
            if (created == false)
            {                
                g.FillPolygon(sb, pointArray);
            }
            else
            {
                pnlFloorPlan.Refresh();
            }
        }

        //Creates the Down arrow
        public void arrowControlDown(Color colour, bool created, int x, int y)
        {
            SolidBrush sb = new SolidBrush(colour);
            Point[] pointArray = { new Point(x, y), new Point(x + 20, y - 25), new Point(x - 20, y - 25) };
            Graphics g = pnlFloorPlan.CreateGraphics();
            if (created == false)
            {
                g.FillPolygon(sb, pointArray);
            }
            else
            {
                pnlFloorPlan.Refresh();
            }
        }

        //Creates the Left arrow
        public void arrowControlLeft(Color colour, bool created, int x, int y)
        {
            SolidBrush sb = new SolidBrush(colour);
            Point[] pointArray = { new Point(x, y), new Point(x + 25, y + 20), new Point(x + 25, y - 20) };
            Graphics g = pnlFloorPlan.CreateGraphics();
            if (created == false)
            {
                g.FillPolygon(sb, pointArray);
            }
            else
            {
                pnlFloorPlan.Refresh();
            }
        }

        //Room 101
        private void picRoom101_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("101");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(3, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(3, 187);
                pnlRed.Visible = true;
            }

            picRoom101.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "101";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "101";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom101_Click(object sender, EventArgs e)
        {
            if(saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("101"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom101_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom101.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 103, 165);
        }

        //Room 102
        private void picRoom102_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("102");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 102 Green Panel
                pnlGreen.Location = new Point(124, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 102 Red Panel
                pnlRed.Location = new Point(124, 187);
                pnlRed.Visible = true;
            }

            picRoom102.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 224, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "102";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "102";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom102_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("102"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom102_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom102.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 224, 165);
        }

        //Room 103
        private void picRoom103_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("103");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 103 Green Panel
                pnlGreen.Location = new Point(248, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 103 Red Panel
                pnlRed.Location = new Point(248, 187);
                pnlRed.Visible = true;
            }

            picRoom103.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 348, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "103";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "103";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom103_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("103"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom103_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom103.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 348, 165);
        }

        //Room 104
        private void picRoom104_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("104");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 104 Green Panel
                pnlGreen.Location = new Point(372, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 104 Red Panel
                pnlRed.Location = new Point(372, 187);
                pnlRed.Visible = true;
            }

            picRoom104.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 472, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "104";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "104";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom104_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("104"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom104_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom104.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 472, 165);
        }

        //Room 105
        private void picRoom105_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("105");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 105 Green Panel
                pnlGreen.Location = new Point(496, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 105 Red Panel
                pnlRed.Location = new Point(496, 187);
                pnlRed.Visible = true;
            }

            picRoom105.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 596, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "105";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "105";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom105_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("105"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom105_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom105.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 596, 165);
        }

        //Room 106
        private void picRoom106_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("106");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 106 Green Panel
                pnlGreen.Location = new Point(620, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 106 Red Panel
                pnlRed.Location = new Point(620, 187);
                pnlRed.Visible = true;
            }

            picRoom106.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 720, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "106";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "106";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom106_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("106"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom106_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom106.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 720, 165);
        }

        //Room 107
        private void picRoom107_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("107");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 107 Green Panel
                pnlGreen.Location = new Point(744, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 107 Red Panel
                pnlRed.Location = new Point(744, 187);
                pnlRed.Visible = true;
            }

            picRoom107.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 844, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "107";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "107";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom107_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("107"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom107_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom107.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 844, 165);
        }

        //Room 108
        private void picRoom108_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("108");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 108 Green Panel
                pnlGreen.Location = new Point(868, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 108 Red Panel
                pnlRed.Location = new Point(868, 187);
                pnlRed.Visible = true;
            }

            picRoom108.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 968, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "108";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "108";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom108_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("108"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom108_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom108.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 968, 165);
        }

        //Room 109
        private void picRoom109_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("109");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 109 Green Panel
                pnlGreen.Location = new Point(994, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 109 Red Panel
                pnlRed.Location = new Point(994, 187);
                pnlRed.Visible = true;
            }

            picRoom109.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 1094, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "109";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "109";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom109_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("109"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom109_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom109.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlUp(colour, arrowCreated, 1094, 165);
        }

        //Room 110
        private void picRoom110_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("110");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 110 Green Panel
                pnlGreen.Location = new Point(185, 194);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 110 Red Panel
                pnlRed.Location = new Point(185, 194);
                pnlRed.Visible = true;
            }

            picRoom110.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 163, 254);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "110";
            lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "110";
            lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom110_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("110"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom110_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom110.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 163, 254);
        }

        //Room 111
        private void picRoom111_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("111");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 111 Green Panel
                pnlGreen.Location = new Point(185, 314);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 111 Red Panel
                pnlRed.Location = new Point(185, 314);
                pnlRed.Visible = true;
            }

            picRoom111.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 163, 374);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "111";
            lblGreenRoomType.Text = "Single";
            lblGreenCapacityValue.Text = "1";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "111";
            lblRedRoomType.Text = "Single";
            lblRedCapacityValue.Text = "1";
        }

        private void picRoom111_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("111"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom111_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom111.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 163, 374);
        }

        //Room 112
        private void picRoom112_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("112");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 112 Green Panel
                pnlGreen.Location = new Point(185, 434);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 112 Red Panel
                pnlRed.Location = new Point(185, 434);
                pnlRed.Visible = true;
            }

            picRoom112.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 163, 494);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "112";
            lblGreenRoomType.Text = "Single";
            lblGreenCapacityValue.Text = "1";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "112";
            lblRedRoomType.Text = "Single";
            lblRedCapacityValue.Text = "1";
        }

        private void picRoom112_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("112"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom112_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom112.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 163, 494);
        }

        //Room 113
        private void picRoom113_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("113");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 113 Green Panel
                pnlGreen.Location = new Point(405, 434);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 113 Red Panel
                pnlRed.Location = new Point(405, 434);
                pnlRed.Visible = true;
            }

            picRoom113.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 385, 494);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "113";
            lblGreenRoomType.Text = "Family";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "113";
            lblRedRoomType.Text = "Family";
            lblRedCapacityValue.Text = "4";
        }

        private void picRoom113_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("113"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom113_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom113.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 385, 494);
        }

        //Room 114
        private void picRoom114_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("114");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 114 Green Panel
                pnlGreen.Location = new Point(405, 314);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 114 Red Panel
                pnlRed.Location = new Point(405, 314);
                pnlRed.Visible = true;
            }

            picRoom114.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 385, 374);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "114";
            lblGreenRoomType.Text = "Family";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "114";
            lblRedRoomType.Text = "Family";
            lblRedCapacityValue.Text = "4";
        }

        private void picRoom114_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("114"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom114_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom114.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlLeft(colour, arrowCreated, 385, 374);
        }

        //Room 115
        private void picRoom115_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("115");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 115 Green Panel
                pnlGreen.Location = new Point(188, 54);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 115 Red Panel
                pnlRed.Location = new Point(188, 54);
                pnlRed.Visible = true;
            }

            picRoom115.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 288, 194);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "115";
            lblGreenRoomType.Text = "Family";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "115";
            lblRedRoomType.Text = "Family";
            lblRedCapacityValue.Text = "4";
        }

        private void picRoom115_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("115"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom115_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom115.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 288, 174);
        }

        //Room 116
        private void picRoom116_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("116");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 116 Green Panel
                pnlGreen.Location = new Point(382, 54);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 116 Red Panel
                pnlRed.Location = new Point(382, 54);
                pnlRed.Visible = true;
            }

            picRoom116.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 482, 194);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "116";
            lblGreenRoomType.Text = "Family";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "116";
            lblRedRoomType.Text = "Family";
            lblRedCapacityValue.Text = "4";
        }

        private void picRoom116_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("116"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom116_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom116.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 482, 174);
        }

        //Room 117
        private void picRoom117_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("117");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 117 Green Panel
                pnlGreen.Location = new Point(576, 54);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 117 Red Panel
                pnlRed.Location = new Point(576, 54);
                pnlRed.Visible = true;
            }

            picRoom117.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 676, 194);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "117";
            lblGreenRoomType.Text = "Twin";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "117";
            lblRedRoomType.Text = "Twin";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom117_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("117"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom117_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom117.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 676, 174);
        }

        //Room 118
        private void picRoom118_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("118");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 118 Green Panel
                pnlGreen.Location = new Point(770, 54);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 118 Red Panel
                pnlRed.Location = new Point(770, 54);
                pnlRed.Visible = true;
            }

            picRoom118.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 870, 194);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "118";
            lblGreenRoomType.Text = "Twin";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "118";
            lblRedRoomType.Text = "Twin";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom118_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("118"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom118_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom118.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 870, 174);
        }

        //Room 119
        private void picRoom119_MouseEnter(object sender, EventArgs e)
        {
            //Checks Date
            bool available = checkDate("119");
            saveActive = available;

            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 119 Green Panel
                pnlGreen.Location = new Point(964, 54);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 119 Red Panel
                pnlRed.Location = new Point(964, 54);
                pnlRed.Visible = true;
            }

            picRoom119.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 1064, 194);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "119";
            lblGreenRoomType.Text = "Honeymoon";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "119";
            lblRedRoomType.Text = "Honeymoon";
            lblRedCapacityValue.Text = "2";
        }

        private void picRoom119_Click(object sender, EventArgs e)
        {
            if (saveActive)
            {
                picSaveRoomSelect.Visible = true;
            }
            else
            {
                picSaveRoomSelect.Visible = false;
            }

            int noRows = dsBelfray.Tables["Rooms"].Rows.Count;

            foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
            {
                room = drRoom["roomNo"].ToString();

                if (room.Equals("119"))
                {


                    decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                    TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                    int days = ts.Days + 1;
                    decimal total = price * days;

                    lblRoomNo.Text = room;
                    lblRoomType.Text = drRoom["roomType"].ToString();
                    lblRoomCapacity.Text = drRoom["capacity"].ToString();
                    lblRoomDesc.Text = drRoom["roomDesc"].ToString();
                    lblPPDay.Text = "£" + decimal.Round(price, 2);
                    lblTotalPrice.Text = "£" + decimal.Round(total, 2);

                    break;
                }
            }
        }

        private void picRoom119_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            picRoom119.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControlDown(colour, arrowCreated, 1064, 174);
        }

        private void RoomSelect_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //Room Table
            sqlRoom = @"select * from Rooms";
            daRoom = new SqlDataAdapter(sqlRoom, connStr);
            cmdBRoom = new SqlCommandBuilder(daRoom);

            daRoom.FillSchema(dsBelfray, SchemaType.Source, "Rooms");
            daRoom.Fill(dsBelfray, "Rooms");

            //Booking Table
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daBooking);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            //Sets Date Time Picker to today for check in and 1 day later for check out
            dtpCheckOutDate.Value = dtpCheckOutDate.Value.AddDays(1);
            userChange = true;
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1);
        }

        //Save Button Code
        private void picSaveRoomSelect_MouseEnter(object sender, EventArgs e)
        {
            picSaveRoomSelect.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picSaveRoomSelect_Click(object sender, EventArgs e)
        {
            roomSelected = lblRoomNo.Text;
            checkInDate = dtpCheckInDate.Value;
            checkOutDate = dtpCheckOutDate.Value;
            cancelled = false;
            MainWindow.maxCap = int.Parse(lblRoomCapacity.Text);
            this.Close();
        }

        private void picSaveRoomSelect_MouseLeave(object sender, EventArgs e)
        {
            picSaveRoomSelect.BackColor = Color.Transparent;
        }

        //Cancel Button Code
        private void picCancellRoomSelect_MouseEnter(object sender, EventArgs e)
        {
            picCancellRoomSelect.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picCancellRoomSelect_Click(object sender, EventArgs e)
        {
            cancelled = true;
            this.Close();
        }

        private void picCancellRoomSelect_MouseLeave(object sender, EventArgs e)
        {
            picCancellRoomSelect.BackColor = Color.Transparent;
        }
        
        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            if (userChange)
            {
                foreach (DataRow drRoom in dsBelfray.Tables["Rooms"].Rows)
                {
                    string newRoom = drRoom["roomNo"].ToString();

                    if (newRoom.Equals(room))
                    {
                        decimal price = Convert.ToDecimal(drRoom["PricePerDay"]);
                        TimeSpan ts = dtpCheckOutDate.Value - dtpCheckInDate.Value;
                        int days = ts.Days + 1;
                        decimal total = price * days;

                        lblTotalPrice.Text = "£" + decimal.Round(total, 2);
                    }
                }
            }            
        }

        private bool checkDate(string roomNum)
        {
            bool available = true;
            foreach (DataRow drBooking in dsBelfray.Tables["Booking"].Rows)
            {
                DateTime checkIn = Convert.ToDateTime(drBooking["checkInDate"]);
                DateTime checkOut = Convert.ToDateTime(drBooking["checkOutDate"]);

                if (drBooking["roomNo"].ToString().Equals(roomNum))
                {
                    if (dtpCheckInDate.Value.Year.CompareTo(checkIn.Year) == 0 || dtpCheckInDate.Value.Year.CompareTo(checkOut.Year) == 0 || dtpCheckOutDate.Value.Year.CompareTo(checkIn.Year) == 0 || dtpCheckOutDate.Value.Year.CompareTo(checkOut.Year) == 0)
                    {
                        if (dtpCheckInDate.Value.Month.CompareTo(checkIn.Month) == 0 || dtpCheckInDate.Value.Year.CompareTo(checkOut.Year) == 0 || dtpCheckOutDate.Value.Month.CompareTo(checkIn.Month) == 0 || dtpCheckOutDate.Value.Month.CompareTo(checkOut.Month) == 0)
                        {
                            int min = checkIn.Day;
                            int max = checkOut.Day;
                            int arrive = dtpCheckInDate.Value.Day;
                            int leave = dtpCheckOutDate.Value.Day;
                            if (arrive <= min && leave >= max)
                            {
                                available = false;
                            }
                            else if (arrive >= min && arrive < max || leave > min && leave <= max)
                            {
                                available = false;
                            }
                            else
                            {
                                available = true;
                            }
                        }
                        else
                        {
                            available = true;
                        }
                    }
                    else
                    {
                        available = true;
                    }
                }

                if(!available)
                {
                    break;
                }
            }
            return available;
        }
    }
}
