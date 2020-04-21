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
    public partial class TableSelect : Form
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

        public TableSelect()
        {
            InitializeComponent();
        }

        //GetProductNumber
        private void getCustNum(int noRows)
        {
            drCustomer = dsBelfray.Tables["Customer"].Rows[noRows - 1];

        }
        private void getBookingNum(int noRows)
        {
            drBooking = dsBelfray.Tables["Booking"].Rows[noRows - 1];
        }

        //Creates the Up arrow
        public void arrowControlUp(Color colour, bool created, int x, int y)
        {
            SolidBrush sb = new SolidBrush(colour);
            Point[] pointArray = { new Point(x, y), new Point(x + 20, y + 25), new Point(x - 20, y + 25) };
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

        //Table1 Effects
        private void tbl1_MouseHover(object sender, EventArgs e)
        {
            //string s1 = "Table Number: 1\n";
            //string s2 = "Party Size: 2\n";
            //string s3 = "Increase Size: Yes";
            //ToolTip tpTable1 = new ToolTip();
            //tpTable1.ShowAlways = true;
            //tpTable1.ToolTipTitle = "Table Information";
            //tpTable1.ToolTipIcon = ToolTipIcon.Info;
            //tpTable1.SetToolTip(tbl1, s1 + s2 + s3);
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(8, 100);
                pnlGreen.Visible = true;
                pnlGreen.BringToFront();
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(8, 100);
                pnlRed.Visible = true;
            }

            tbl1.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "1";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "1";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }
        private void tbl1_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl1.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        //tABLE 2
        private void tbl2_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 100);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 100);
                pnlRed.Visible = true;
            }

            tbl2.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "2";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "2";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl2_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl2.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

        }

        private void tbl3_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 100);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 100);
                pnlRed.Visible = true;
            }

            tbl3.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "3";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "3";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";

        }

        private void tbl3_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl3.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl4_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 100);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 100);
                pnlRed.Visible = true;
            }

            tbl4.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "4";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "4";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl4_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl4.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

        }

        private void tbl5_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 100);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 100);
                pnlRed.Visible = true;
            }

            tbl5.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "5";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "5";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl5_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl5.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl6_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(455, 100);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(455, 100);
                pnlRed.Visible = true;
            }

            tbl6.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "6";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "6";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl6_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl6.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl7_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(470, 100);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(470, 100);
                pnlRed.Visible = true;
            }

            tbl7.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "7";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "2";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "7";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "2";
        }

        private void tbl7_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl7.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl8_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 180);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 180);
                pnlRed.Visible = true;
            }

            tbl8.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "8";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "8";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl8_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl8.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl9_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 180);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 180);
                pnlRed.Visible = true;
            }

            tbl9.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "9";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "9";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl9_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl9.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl10_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 180);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 180);
                pnlRed.Visible = true;
            }

            tbl10.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "10";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "10";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl10_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl10.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl11_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 180);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 180);
                pnlRed.Visible = true;
            }

            tbl11.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "11";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "11";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl11_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl11.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl12_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 270);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 270);
                pnlRed.Visible = true;
            }

            tbl12.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "12";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "12";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl12_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl12.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl13_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 270);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 270);
                pnlRed.Visible = true;
            }

            tbl13.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "13";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "13";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl13_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl13.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl14_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 270);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 270);
                pnlRed.Visible = true;
            }

            tbl14.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "14";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "14";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl14_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl14.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl15_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 270);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 270);
                pnlRed.Visible = true;
            }

            tbl15.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "15";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "15";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl15_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl15.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl16_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T6)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(442, 190);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(442, 190);
                pnlRed.Visible = true;
            }

            tbl16.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "16";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = s;

            //Set Pop-up box values (Red)
            lblRedNo.Text = "16";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = s;
        }

        private void picSaveRoomSelect_Click(object sender, EventArgs e)
        {
            pnlCustomerDetails.Enabled = true;
            numPartySize.Enabled = true;
            dateBooking.Enabled = true;
            txtTime.Enabled = true;
            cbPaymentTyp.Enabled = true;
            newBooking = true;
            
            //generate booking number
            int noRows = dsBelfray.Tables["Booking"].Rows.Count;

            if (noRows == 0)
            {
                lblBookingNo.Text = "BK100000000";
            }
            else
            {
                getBookingNum(noRows);
            }

            string s = drBooking["bookingNo"].ToString();
            string s1 = "BK" + (Convert.ToInt32(s.Replace("BK", "")) + 1).ToString().PadLeft(5, '0');
            lblBookingNo.Text = s1;
            dgvBooking.Rows.Add(lblBookingNo.Text, lblTableNo.Text);

        }

        private void tbl2_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 2;
            tableNoSelected = 2;
            lblTableNo.Text = "002";
            lblTableNumDisplay.Text = "2";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl3_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 2;
            tableNoSelected = 3;
            lblTableNo.Text = "3";
            lblTableNumDisplay.Text = "3";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl4_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 2;
            tableNoSelected = 4;
            lblTableNo.Text = "4";
            lblTableNumDisplay.Text = "4";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl5_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 2;
            tableNoSelected = 5;
            lblTableNo.Text = "5";
            lblTableNumDisplay.Text = "5";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl6_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 2;
            tableNoSelected = 6;
            lblTableNo.Text = "6";
            lblTableNumDisplay.Text = "6";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl7_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 2;
            tableNoSelected = 7;
            lblTableNo.Text = "7";
            lblTableNumDisplay.Text = "7";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void tbl8_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 8;
            lblTableNo.Text = "8";
            lblTableNumDisplay.Text = "8";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl9_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 9;
            lblTableNo.Text = "9";
            lblTableNumDisplay.Text = "9";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl10_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 10;
            lblTableNo.Text = "10";
            lblTableNumDisplay.Text = "10";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl11_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 11;
            lblTableNo.Text = "11";
            lblTableNumDisplay.Text = "11";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl12_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 12;
            lblTableNo.Text = "12";
            lblTableNumDisplay.Text = "12";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl13_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 13;
            lblTableNo.Text = "13";
            lblTableNumDisplay.Text = "13";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl14_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 14;
            lblTableNo.Text = "14";
            lblTableNumDisplay.Text = "14";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl15_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 15;
            lblTableNo.Text = "15";
            lblTableNumDisplay.Text = "15";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl16_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 16;
            lblTableNo.Text = "16";
            lblTableNumDisplay.Text = "16";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl17_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 17;
            lblTableNo.Text = "17";
            lblTableNumDisplay.Text = "17";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl18_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 18;
            lblTableNo.Text = "18";
            lblTableNumDisplay.Text = "18";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl19_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 19;
            lblTableNo.Text = "19";
            lblTableNumDisplay.Text = "19";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl20_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 20;
            lblTableNo.Text = "20";
            lblTableNumDisplay.Text = "20";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl21_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 21;
            lblTableNo.Text = "21";
            lblTableNumDisplay.Text = "21";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl22_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 22;
            lblTableNo.Text = "22";
            lblTableNumDisplay.Text = "22";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void tbl23_Click(object sender, EventArgs e)
        {
            numPartySize.Value = 4;
            tableNoSelected = 23;
            lblTableNo.Text = "23";
            lblTableNumDisplay.Text = "23";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "4";
        }

        private void dgvBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                tableSelected = false;
                tableNoSelected = 0;
                //prdSel = null;
            }
            else if (dgvBooking.SelectedRows.Count == 1)
            {
                tableSelected = true;
                lblTableNo.Text = dgvBooking.SelectedRows[0].Cells[1].Value.ToString();
                tableNoSelected = dgvBooking.SelectedRows[0].Index;
                //prdSel = Globals.prdNoSel;
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
                dgvBooking.Rows.Remove(dgvBooking.Rows[tableNoSelected]);
                lblTableNo.Text = "-";
                dgvBooking.ClearSelection();
            }
        }

        private void picAddTable_Click(object sender, EventArgs e)
        {
            pnlCustomerDetails.Enabled = true;
            numPartySize.Enabled = true;
            dateBooking.Enabled = true;
            txtTime.Enabled = true;
            cbPaymentTyp.Enabled = true;
            newBooking = true;

            //generate booking number
            int noRows = dsBelfray.Tables["Booking"].Rows.Count;

            if (noRows == 0)
            {
                lblBookingNo.Text = "BK100000000";
            }
            else
            {
                getBookingNum(noRows);
            }

            string s = drBooking["bookingNo"].ToString();
            string s1 = "BK" + (Convert.ToInt32(s.Replace("BK", "")) + 1).ToString().PadLeft(5, '0');
            lblBookingNo.Text = s1;
            dgvBooking.Rows.Add(lblBookingNo.Text, lblTableNo.Text, lblTableCapacity.Text);

            //Sum of party size
            int sum = 0;
            for (int i = 0; i < dgvBooking.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvBooking.Rows[i].Cells[2].Value);
            }
            numPartySize.Value = sum;
        }

        private void picAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void tbl16_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl16.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void cbCustNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                //int noRows = dsBelfray.Tables["Customer"].Rows.Count;
                getInfo = true;

                foreach (DataRow drCustomer in dsBelfray.Tables["Customer"].Rows)
                {
                    string customer = drCustomer["customerNo"].ToString();

                    if (customer.Equals(cbCustNo.Text))
                    {

                        if (drCustomer["customerTitle"].ToString() == "MR")
                        {
                            cbTitle.SelectedIndex = 0;
                        }
                        if (drCustomer["customerTitle"].ToString() == "MISS")
                        {
                            cbTitle.SelectedIndex = 1;
                        }
                        if (drCustomer["customerTitle"].ToString() == "MRS")
                        {
                            cbTitle.SelectedIndex = 2;
                        }
                        if (drCustomer["customerTitle"].ToString() == "MS")
                        {
                            cbTitle.SelectedIndex = 3;
                        }
                        if (drCustomer["customerTitle"].ToString() == "DR")
                        {
                            cbTitle.SelectedIndex = 4;
                        }

                        txtFname.Text = drCustomer["customerForename"].ToString();
                        txtLName.Text = drCustomer["customerSurname"].ToString();
                        txtStreet.Text = drCustomer["customerStreet"].ToString();
                        txtCity.Text = drCustomer["customerCity"].ToString();
                        txtCounty.Text = drCustomer["customerCounty"].ToString();
                        txtPC.Text = drCustomer["customerPostcode"].ToString();
                        txtTelNo.Text = drCustomer["customerTel"].ToString();
                        break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (newCustomer == true && newBooking == true)
            {
                MyCustomer myCust = new MyCustomer();
                MyBooking myBook = new MyBooking();
                bool ok = true;
                errP.Clear();

                //Customer Number
                try
                {
                    myCust.CustomerNumber = cbCustNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cbCustNo, MyEx.toString());
                }

                //Customer Title
                try
                {
                    myCust.Title = cbTitle.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cbTitle, MyEx.toString());
                }

                //Customer Forename
                try
                {
                    myCust.Forename = txtFname.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtFname, MyEx.toString());
                }

                //Customer Surname
                try
                {
                    myCust.Surname = txtLName.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtLName, MyEx.toString());
                }

                //Customer Street
                try
                {
                    myCust.Street = txtStreet.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtStreet, MyEx.toString());
                }

                //Customer City
                try
                {
                    myCust.City = txtCity.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCity, MyEx.toString());
                }

                //Customer County
                try
                {
                    myCust.County = txtCounty.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCounty, MyEx.toString());
                }

                //Customer PostCode
                try
                {
                    myCust.Postcode = txtPC.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtPC, MyEx.toString());
                }

                //Customer TelNo
                try
                {
                    myCust.TelNo = txtTelNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtTelNo, MyEx.toString());
                }

                //Try Booking
                try
                {
                    myBook.BookingNumber = lblBookingNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblBookingNo, MyEx.toString());
                }
                try
                {
                    myBook.PartySize = Convert.ToInt32(numPartySize.Value);
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(numPartySize, MyEx.toString());
                }
                try
                {
                    myBook.CheckInDate = dateBooking.Value;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dateBooking, MyEx.toString());
                }
                try
                {
                    myBook.BookingTime = txtTime.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtTime, MyEx.toString());
                }
                try
                {
                    myBook.PaymentTypeID = cbPaymentTyp.SelectedValue.ToString();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cbPaymentTyp, MyEx.toString());
                }

                //Try Adding
                try
                {
                    if (ok)
                    {
                        drCustomer = dsBelfray.Tables["Customer"].NewRow();
                        drCustomer["customerNo"] = myCust.CustomerNumber;
                        drCustomer["customerTitle"] = myCust.Title;
                        drCustomer["customerForename"] = myCust.Forename;
                        drCustomer["customerSurname"] = myCust.Surname;
                        drCustomer["customerStreet"] = myCust.Street;
                        drCustomer["customerCity"] = myCust.City;
                        drCustomer["customerCounty"] = myCust.County;
                        drCustomer["customerPostcode"] = myCust.Postcode;
                        drCustomer["customerTel"] = myCust.TelNo;
                        dsBelfray.Tables["Customer"].Rows.Add(drCustomer);
                        daCustomer.Update(dsBelfray, "Customer");

                    }
                    if (ok)
                    {
                        drBooking = dsBelfray.Tables["Booking"].NewRow();
                        drBooking["bookingNo"] = myBook.BookingNumber;
                        drBooking["checkInDate"] = myBook.CheckInDate;
                        drBooking["bookingTime"] = myBook.BookingTime;
                        drBooking["customerNo"] = myCust.CustomerNumber;
                        drBooking["paymentTypeID"] = myBook.PaymentTypeID;
                        drBooking["partySize"] = myBook.PartySize;
                        dsBelfray.Tables["Booking"].Rows.Add(drBooking);
                        daBooking.Update(dsBelfray, "Booking");
                    }
                    if (ok)
                    {
                        int tableRows = dgvBooking.RowCount - 1;

                        for (int x = 0; x < tableRows; x++)
                        {
                            drBookingItem = dsBelfray.Tables["BookingItem"].NewRow();
                            drBookingItem["bookingNo"] = dgvBooking.Rows[x].Cells[0].Value.ToString();
                            drBookingItem["itemNo"] = "TB" + dgvBooking.Rows[x].Cells[1].Value.ToString();
                            drBookingItem["itemQty"] = DBNull.Value;
                            dsBelfray.Tables["BookingItem"].Rows.Add(drBookingItem);
                        }

                        daBookingItem.Update(dsBelfray, "BookingItem");
                    }
                    MessageBox.Show("Booking Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
            if (newCustomer == false)
            {
                MyBooking myBook = new MyBooking();
                MyCustomer myCust = new MyCustomer();
                bool ok = true;
                errP.Clear();

                //Customer Number
                try
                {
                    myCust.CustomerNumber = cbCustNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cbCustNo, MyEx.toString());
                }
                //Try Booking
                try
                {
                    myBook.BookingNumber = lblBookingNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(lblBookingNo, MyEx.toString());
                }
                try
                {
                    myBook.PartySize = Convert.ToInt32(numPartySize.Value);
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(numPartySize, MyEx.toString());
                }
                try
                {
                    myBook.CheckInDate = dateBooking.Value;
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(dateBooking, MyEx.toString());
                }
                try
                {
                    myBook.BookingTime = txtTime.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtTime, MyEx.toString());
                }
                try
                {
                    myBook.PaymentTypeID = cbPaymentTyp.SelectedValue.ToString();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(cbPaymentTyp, MyEx.toString());
                }
                //Try Adding
                try
                {
                    if (ok)
                    {
                        drBooking = dsBelfray.Tables["Booking"].NewRow();
                        drBooking["bookingNo"] = myBook.BookingNumber;
                        drBooking["checkInDate"] = myBook.CheckInDate;
                        drBooking["bookingTime"] = myBook.BookingTime;
                        drBooking["customerNo"] = myCust.CustomerNumber;
                        drBooking["paymentTypeID"] = myBook.PaymentTypeID;
                        drBooking["partySize"] = myBook.PartySize;
                        dsBelfray.Tables["Booking"].Rows.Add(drBooking);
                        daBooking.Update(dsBelfray, "Booking");
                    }
                    if (ok)
                    {
                        int tableRows = dgvBooking.RowCount - 1;

                        for (int x = 0; x < tableRows; x++)
                        {
                            drBookingItem = dsBelfray.Tables["BookingItem"].NewRow();
                            drBookingItem["bookingNo"] = dgvBooking.Rows[x].Cells[0].Value.ToString();
                            drBookingItem["itemNo"] = "TB" + dgvBooking.Rows[x].Cells[1].Value.ToString();
                            drBookingItem["itemQty"] = DBNull.Value;
                            dsBelfray.Tables["BookingItem"].Rows.Add(drBookingItem);
                        }

                        daBookingItem.Update(dsBelfray, "BookingItem");
                    }
                    MessageBox.Show("Booking Added");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }
        }

        private void tbl17_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(442, 265);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(442, 265);
                pnlRed.Visible = true;
            }

            tbl17.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "17";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = s;

            //Set Pop-up box values (Red)
            lblRedNo.Text = "17";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = s;
        }

        private void tbl17_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl17.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl23_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(100, 370);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(100, 370);
                pnlRed.Visible = true;
            }

            tbl23.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "23";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "17";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        //Close Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbl23_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl23.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl22_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(190, 370);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(190, 370);
                pnlRed.Visible = true;
            }

            tbl22.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "22";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "22";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl22_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl22.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl21_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(280, 370);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(280, 370);
                pnlRed.Visible = true;
            }

            tbl21.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "21";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "21";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl21_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl21.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl20_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(365, 370);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(365, 370);
                pnlRed.Visible = true;
            }

            tbl20.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "20";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "20";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        //private void cbBookingType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (!formLoad)
        //    {
        //        DataRow drMethod = dsBelfray.Tables["BType"].Rows.Find(cbBookingType.SelectedValue.ToString());
        //        //txtProdTypeCode.Text = drMethod["productTypeCode"].ToString();
        //        //txtProdDesc2.Text = drMethod["productTypeDesc"].ToString();
        //    }
        //}

        private void tbl20_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl20.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl19_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(455, 370);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(455, 370);
                pnlRed.Visible = true;
            }

            tbl19.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "19";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "19";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl19_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl19.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl18_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;
            string s = "4\n(6 add T7)";

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(530, 370);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(530, 370);
                pnlRed.Visible = true;
            }

            tbl18.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);

            //Set Pop-up box values (Green)
            lblGreenNo.Text = "18";
            //lblGreenRoomType.Text = "Double";
            lblGreenCapacityValue.Text = "4";

            //Set Pop-up box values (Red)
            lblRedNo.Text = "18";
            //lblRedRoomType.Text = "Double";
            lblRedCapacityValue.Text = "4";
        }

        private void tbl18_MouseLeave(object sender, EventArgs e)
        {
            arrowCreated = true;
            Color colour = new Color();
            colour = Color.Transparent;

            pnlGreen.Visible = false;
            pnlRed.Visible = false;

            //Change Picture background colour
            tbl18.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            //arrowControlUp(colour, arrowCreated, 103, 165);
        }

        private void tbl1_Click(object sender, EventArgs e)
        {
            //pnlCustomerDetails.Enabled = true;
            numPartySize.Value = 2;
            tableNoSelected = 1;
            lblTableNo.Text = "001";
            lblTableNumDisplay.Text = "1";
            lblSeatsAvail.Text = "Yes/No";
            lblTableCapacity.Text = "2";
        }

        private void chkNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewCustomer.Checked)
            {
                cbTitle.Enabled = true;
                txtFname.Enabled = true;
                txtLName.Enabled = true;
                txtStreet.Enabled = true;
                txtCity.Enabled = true;
                txtCounty.Enabled = true;
                txtPC.Enabled = true;
                txtTelNo.Enabled = true;
                newCustomer = true;

                //generate cust number
                int noRows = dsBelfray.Tables["Customer"].Rows.Count;

                if (noRows == 0)
                {
                    cbCustNo.SelectedIndex = -1;// "CUS100000";
                }
                else
                {
                    getCustNum(noRows);
                }

                string s = drCustomer["customerNo"].ToString();
                string s1 = "CUS" + (Convert.ToInt32(s.Replace("CUS", "")) + 1).ToString().PadLeft(5, '0');
                cbCustNo.Text = s1;


            }
            else if (chkNewCustomer.Checked == false)
            {
                cbTitle.Enabled = false;
                txtFname.Enabled = false;
                txtLName.Enabled = false;
                txtStreet.Enabled = false;
                txtCity.Enabled = false;
                txtCounty.Enabled = false;
                txtPC.Enabled = false;
                txtTelNo.Enabled = false;
                cbCustNo.SelectedIndex = -1;
                newCustomer = false;
            }

        }

        //private void chkNewBooking_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkNewBooking.Checked)
        //    {
        //        numPartySize.Enabled = true;
        //        dateBooking.Enabled = true;
        //        txtTime.Enabled = true;
        //        cbPaymentTyp.Enabled = true;
        //        newBooking = true;

        //        //generate booking number
        //        int noRows = dsBelfray.Tables["Booking"].Rows.Count;

        //        if (noRows == 0)
        //        {
        //            lblBookingNo.Text = "BK100000000";
        //        }
        //        else
        //        {
        //            getBookingNum(noRows);
        //        }

        //        string s = drBooking["bookingNo"].ToString();
        //        string s1 = "BK" + (Convert.ToInt32(s.Replace("BK", "")) + 1).ToString().PadLeft(5, '0');
        //        lblBookingNo.Text = s1;
        //    }
        //    else if (chkNewBooking.Checked == false)
        //    {
        //        numPartySize.Enabled = false;
        //        dateBooking.Enabled = false;
        //        txtTime.Enabled = false;
        //        cbPaymentTyp.Enabled = false;
        //        lblBookingNo.Text = "";
        //        newBooking = false;
        //    }
        //}

        private void TableSelect_Load(object sender, EventArgs e)
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
            cbPaymentTyp.ValueMember = "paymentTypeID";
            cbPaymentTyp.DisplayMember = "paymentTypeDesc";
            cbPaymentTyp.SelectedIndex = -1;

            //cb Title
            cbCustNo.DataSource = dsBelfray.Tables["Customer"];
            cbCustNo.ValueMember = "customerNo";
            cbCustNo.DisplayMember = "customerNo";
            cbCustNo.SelectedIndex = -1;

            //Test
            cbTitle.SelectedIndex = -1;
            txtFname.Text = "";
            txtLName.Text = "";
            txtStreet.Text = "";
            txtCity.Text = "";
            txtCounty.Text = "";
            txtPC.Text = "";
            txtTelNo.Text = "";

            //int noRows = dsBelfray.Tables["Booking"].Rows.Count;

            //if (noRows == 0)
            //{
            //    lblBookingNo.Text = "BK10000001";
            //}
            //else
            //{
            //    getBookingNum(noRows);

            //}
            //string s = drBooking["bookingNo"].ToString();
            //string s1 = "BK" + (Convert.ToInt32(s.Replace("BK", "")) + 1).ToString().PadLeft(5, '0');
            //lblBookingNo.Text = s1;
        }
    }
}