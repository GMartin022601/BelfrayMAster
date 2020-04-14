using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belfray
{
    public partial class RoomSelect : Form
    {
        public bool arrowCreated = false;

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
            bool available = true;
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
            lblRoomNo.Text = "101";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "102";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "103";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "104";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "105";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "106";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "107";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "108";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "109";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "110";
            lblRoomType.Text = "Double";
            lblRoomCapacity.Text = "2";
            lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "111";
            lblRoomType.Text = "Single";
            lblRoomCapacity.Text = "1";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "112";
            lblRoomType.Text = "Single";
            lblRoomCapacity.Text = "1";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "113";
            lblRoomType.Text = "Family";
            lblRoomCapacity.Text = "4";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "114";
            lblRoomType.Text = "Family";
            lblRoomCapacity.Text = "4";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "115";
            lblRoomType.Text = "Family";
            lblRoomCapacity.Text = "4";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "116";
            lblRoomType.Text = "Family";
            lblRoomCapacity.Text = "4";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "117";
            lblRoomType.Text = "Twin";
            lblRoomCapacity.Text = "2";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "118";
            lblRoomType.Text = "Twin";
            lblRoomCapacity.Text = "2";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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
            bool available = true;
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
            lblRoomNo.Text = "119";
            lblRoomType.Text = "Honeymoon";
            lblRoomCapacity.Text = "2";
            //lblRoomDesc.Text = "A very Luxurious room with a homely feel perfect for proffesional and couples a like. This room comes \nfully fitted with a TV, Free Wifi, En-suite, Snacks and Mini Bar.";
            //lblPPDay.Text = "£" + ;
            //lblTotalPrice.Text = "£" + ;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomSelect_Load(object sender, EventArgs e)
        {
            dtpCheckOutDate.Value = dtpCheckOutDate.Value.AddDays(1);
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            dtpCheckOutDate.Value = dtpCheckInDate.Value.AddDays(1);
        }
    }
}
