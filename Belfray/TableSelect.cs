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
        SqlDataAdapter daCustomer, daBooking, daBookingType, daPaymentType, daBookingDGV, daTables;// daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingType, cmdBPaymentType, cmdBTables;
        DataRow drCustomer, drBooking, drBookingType, drPaymentType, drTables;
        String connStr, sqlBooking, sqlCustomer, sqlBookingType, sqlPaymentType, sqlBookingDGV, sqlTables;
        bool formLoad = true;
        bool getInfo, bookingInfo;
        bool newCustomer, newBooking;
        public bool arrowCreated = false;
        int tableNoSelected;

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



        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            //int noRows = dsBelfray.Tables["Customer"].Rows.Count;
            getInfo = true;

            foreach (DataRow drCustomer in dsBelfray.Tables["Customer"].Rows)
            {
                string customer = drCustomer["customerNo"].ToString();

                if (customer.Equals(txtCustID.Text))
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

        private void btnGetBookingInfo_Click(object sender, EventArgs e)
        {
            bookingInfo = true;

            foreach (DataRow drBooking in dsBelfray.Tables["Booking"].Rows)
            {
                foreach (DataRow drBookingType in dsBelfray.Tables["BType"].Rows)
                {
                    foreach (DataRow drPaymentType in dsBelfray.Tables["Payment"].Rows)
                    {
                        string booking = drBooking["bookingNo"].ToString();
                        string btype = drBookingType["typeID"].ToString();
                        //int partySize = Convert.ToInt32(drBooking["partySize"].ToString());
                        //Convert.ToInt32(drBooking["partySize"].ToString());

                        if (booking.Equals(txtBookingNo.Text))
                        {
                            // string btype = drBookingType["typeID"].ToString();
                            int partySize = Convert.ToInt32(drBooking["partySize"].ToString());
                            string bDate = drBooking["checkInDate"].ToString();
                            string bTime = drBooking["bookingTime"].ToString();


                            if (drBookingType["typeID"].ToString() == "TYP100002")
                            {
                                cbBookingType.SelectedValue = drBookingType["typeDesc"].ToString();
                            }
                            if (drBookingType["typeID"].ToString() == "TYP100003")
                            {
                                cbBookingType.SelectedValue = drBookingType["typeDesc"].ToString();
                            }
                            if (drBookingType["typeID"].ToString() == "TYP100004")
                            {
                                cbBookingType.SelectedValue = drBookingType["typeDesc"].ToString();
                            }
                            if (drBookingType["typeID"].ToString() == "TYP100005")
                            {
                                cbBookingType.SelectedValue = drBookingType["typeDesc"].ToString();
                            }
                            if (drBookingType["typeID"].ToString() == "TYP100006")
                            {
                                cbBookingType.SelectedValue = drBookingType["typeDesc"].ToString();
                            }

                            numPartySize.Value = partySize;
                            dateBooking.Value = Convert.ToDateTime(bDate);
                            dtpBookingTime.Value = Convert.ToDateTime(bTime);

                            if (drBooking["paymentTypeID"].ToString() == "PAY101")
                            {
                                cbPaymentTyp.SelectedValue = drPaymentType["paymentTypeDesc"].ToString();
                            }
                            if (drBooking["paymentTypeID"].ToString() == "PAY102")
                            {
                                cbPaymentTyp.SelectedValue = drPaymentType["paymentTypeDesc"].ToString();
                            }
                            if (drBooking["paymentTypeID"].ToString() == "PAY103")
                            {
                                cbPaymentTyp.SelectedValue = drPaymentType["paymentTypeDesc"].ToString();
                            }
                            if (drBooking["paymentTypeID"].ToString() == "PAY104")
                            {
                                cbPaymentTyp.SelectedValue = drPaymentType["paymentTypeDesc"].ToString();
                            }
                        }
                    }
                }
            }//after here
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
                    myCust.CustomerNumber = txtCustID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCustID, MyEx.toString());
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
                    myBook.CustomerNumber = txtBookingNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtBookingNo, MyEx.toString());
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
                    myCust.CustomerNumber = txtCustID.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtCustID, MyEx.toString());
                }
                //Try Booking
                try
                {
                    myBook.BookingNumber = txtBookingNo.Text.Trim();
                }
                catch (MyException MyEx)
                {
                    ok = false;
                    errP.SetError(txtBookingNo, MyEx.toString());
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
            if (MessageBox.Show("Would you like to place a booking for Table 1?", "Add Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                pnlCustomerDetails.Enabled = true;
                numPartySize.Value = 2;
                tableNoSelected = 1;
            }
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
                    txtCustID.Text = "CUS100000";
                }
                else
                {
                    getCustNum(noRows);
                }

                string s = drCustomer["customerNo"].ToString();
                string s1 = "CUS" + (Convert.ToInt32(s.Replace("CUS", "")) + 1).ToString().PadLeft(5, '0');
                txtCustID.Text = s1;


            }
            else if (chkNewCustomer.Checked == false)
            {
                cbTitle.Enabled = false;
                //txtCustID.Enabled = false;
                txtFname.Enabled = false;
                txtLName.Enabled = false;
                txtStreet.Enabled = false;
                txtCity.Enabled = false;
                txtCounty.Enabled = false;
                txtPC.Enabled = false;
                txtTelNo.Enabled = false;
                txtCustID.Text = "";
                newCustomer = false;
            }

        }

        private void chkNewBooking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNewBooking.Checked)
            {
                cbBookingType.Enabled = true;
                numPartySize.Enabled = true;
                dateBooking.Enabled = true;
                cbTime.Enabled = true;
                cbPaymentTyp.Enabled = true;
                newBooking = true;

                //generate booking number
                int noRows = dsBelfray.Tables["Booking"].Rows.Count;

                if (noRows == 0)
                {
                    txtBookingNo.Text = "BK100000000";
                }
                else
                {
                    getBookingNum(noRows);
                }

                string s = drBooking["bookingNo"].ToString();
                string s1 = "BK" + (Convert.ToInt32(s.Replace("BK", "")) + 1).ToString().PadLeft(5, '0');
                txtBookingNo.Text = s1;
            }
            else if (chkNewBooking.Checked == false)
            {
                cbBookingType.Enabled = false;
                numPartySize.Enabled = false;
                dateBooking.Enabled = false;
                cbTime.Enabled = false;
                cbPaymentTyp.Enabled = false;
                txtBookingNo.Text = "";
                newBooking = false;
            }
        }

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
            //SQL For Tables
            //sqlTables = @"select * from RestTables";
            //daTables = new SqlDataAdapter(sqlTables, connStr);
            //cmdBTables = new SqlCommandBuilder(daTables);
            //daTables.FillSchema(dsBelfray, SchemaType.Source, "RestTables");
            //daTables.Fill(dsBelfray, "RestTables");

            ////SQL for Booking DGV - TO BE EDITED TO SHOW TABLE BOOKINGS
            //sqlBookingDGV = @"select * from Booking WHERE Booking.tableNo = '2'";
            ////typeID = 'TYP10002' OR typeID ='TYP10003' OR typeID ='TYP10004' OR typeID ='TYP10005' OR typeID ='TYP10006' OR typeID ='TYP10007'";
            //daBookingDGV = new SqlDataAdapter(sqlBooking, connStr);

            //daBookingDGV.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            //daBookingDGV.Fill(dsBelfray, "Booking");

            //dgvBooking.Visible = true;
            //dgvBooking.DataSource = dsBelfray.Tables["Booking"];
            ////Resize
            //dgvBooking.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //cb BookingType
            cbBookingType.DataSource = dsBelfray.Tables["BType"];
            cbBookingType.ValueMember = "typeID";
            cbBookingType.DisplayMember = "typeDesc";
            cbBookingType.SelectedIndex = -1;

            //cb ayment type
            cbPaymentTyp.DataSource = dsBelfray.Tables["Payment"];
            cbPaymentTyp.ValueMember = "paymentTypeID";
            cbPaymentTyp.DisplayMember = "paymentTypeDesc";
            cbPaymentTyp.SelectedIndex = -1;

            //cb Title
            //cbTitle.DataSource = dsBelfray.Tables["Customer"];
            //cbTitle.ValueMember = "customerTitle";
            //cbTitle.DisplayMember = "customerTitle";
            //cbTitle.SelectedIndex = -1;

            //dtpBookingTime = new DateTimePicker();
            dtpBookingTime.Format = DateTimePickerFormat.Custom;
            dtpBookingTime.CustomFormat = "HH:mm"; // Only use hours and minutes
            dtpBookingTime.ShowUpDown = true;

        }


        //Table2
        //private void tbl2_MouseEnter(object sender, EventArgs e)
        //{
        //    string s1 = "Table Number: 2\n";
        //    string s2 = "Party Size: 2\n";
        //    string s3 = "Increase Size: Yes";
        //    ToolTip tpTable2 = new ToolTip();
        //    tpTable2.ShowAlways = true;
        //    tpTable2.ToolTipTitle = "Table Information";
        //    tpTable2.ToolTipIcon = ToolTipIcon.Info;
        //    tpTable2.SetToolTip(tbl2, s1  + s2 + s3);
        //}


    }
}
