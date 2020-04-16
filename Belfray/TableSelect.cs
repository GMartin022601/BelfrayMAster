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
        SqlDataAdapter daCustomer, daBooking, daBookingType, daPaymentType, daBookingDGV;// daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBooking, cmdBBookingType, cmdBPaymentType;
        DataRow drCustomer, drBooking, drBookingType, drPaymentType;
        String connStr, sqlBooking, sqlCustomer, sqlBookingType, sqlPaymentType, sqlBookingDGV;
        bool formLoad = true;
        public bool arrowCreated = false;

        public TableSelect()
        {
            InitializeComponent();
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
            if (MessageBox.Show("Would you like to place a booking for Table 1?" , "Add Booking", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                pnlCustomerDetails.Enabled = true;
                numPartySize.Value = 2;
                //Data Grid View
                sqlBookingDGV = @"select bookingNo, checkInDate, typeID, bookingTime, customerNo, paymentTypeID, partySize, tableNo from Booking WHERE tableNo = '1'"; //Join RestTables on tableNo = Booking.tableNo" RestTables.allocated;
                daBookingDGV = new SqlDataAdapter(sqlBookingDGV, connStr);

                daBookingDGV.FillSchema(dsBelfray, SchemaType.Source, "Booking");
                daBookingDGV.Fill(dsBelfray, "Booking");

                dgvBooking.Visible = true;
                dgvBooking.DataSource = dsBelfray.Tables["Booking"];
                //Resize
                dgvBooking.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
            }
            else if (chkNewBooking.Checked == false)
            {
                cbBookingType.Enabled = false;
                numPartySize.Enabled = false;
                dateBooking.Enabled = false;
                cbTime.Enabled = false;
                cbPaymentTyp.Enabled = false;
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
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customr");
            daCustomer.Fill(dsBelfray, "Customer");

            //SQL for booking Type
            sqlBookingType = @"select * from BType";
            daBookingType = new SqlDataAdapter(sqlBookingType, connStr);
            cmdBBookingType = new SqlCommandBuilder(daBookingType);
            daBookingType.FillSchema(dsBelfray, SchemaType.Source, "BType");
            daBookingType.Fill(dsBelfray, "BType");

            //SQL for booking Type
            sqlPaymentType = @"select * from Payment";
            daPaymentType = new SqlDataAdapter(sqlPaymentType, connStr);
            cmdBPaymentType = new SqlCommandBuilder(daPaymentType);
            daPaymentType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPaymentType.Fill(dsBelfray, "Payment");

            //SQL for Booking DGV - TO BE EDITED TO SHOW TABLE BOOKINGS
            //sqlBookingDGV = @"select * from Booking WHERE typeID = 'TYP10002' OR typeID ='TYP10003' OR typeID ='TYP10004' OR typeID ='TYP10005' OR typeID ='TYP10006' OR typeID ='TYP10007'";
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
