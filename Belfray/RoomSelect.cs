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

        public void arrowControl(Color colour, bool created, int x, int y)
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
            arrowControl(colour, arrowCreated, 103, 165);

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
            arrowControl(colour, arrowCreated, 103, 165);
        }

        private void picRoom102_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(124, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(124, 187);
                pnlRed.Visible = true;
            }

            picRoom102.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControl(colour, arrowCreated, 224, 165);

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
            arrowControl(colour, arrowCreated, 224, 165);
        }

        private void picRoom103_MouseEnter(object sender, EventArgs e)
        {
            bool available = true;
            Color colour = new Color();
            arrowCreated = false;

            if (available == true)
            {
                colour = Color.FromArgb(57, 181, 74);
                //Location of 101 Green Panel
                pnlGreen.Location = new Point(248, 187);
                pnlGreen.Visible = true;
            }
            else
            {
                colour = Color.FromArgb(205, 36, 36);
                //Location of 101 Red Panel
                pnlRed.Location = new Point(248, 187);
                pnlRed.Visible = true;
            }

            picRoom103.BackColor = colour;

            //Color of arrow, if the arrow is created, x of point of arrow & y of point of arrow
            arrowControl(colour, arrowCreated, 348, 165);

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
            arrowControl(colour, arrowCreated, 348, 165);
        }

        private void picRoom104_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom104_Click(object sender, EventArgs e)
        {

        }

        private void picRoom104_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom105_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom105_Click(object sender, EventArgs e)
        {

        }

        private void picRoom105_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom106_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom106_Click(object sender, EventArgs e)
        {

        }

        private void picRoom106_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom107_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom107_Click(object sender, EventArgs e)
        {

        }

        private void picRoom107_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom108_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom108_Click(object sender, EventArgs e)
        {

        }

        private void picRoom108_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom109_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom109_Click(object sender, EventArgs e)
        {

        }

        private void picRoom109_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom110_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom110_Click(object sender, EventArgs e)
        {

        }

        private void picRoom110_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom111_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom111_Click(object sender, EventArgs e)
        {

        }

        private void picRoom111_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom112_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom112_Click(object sender, EventArgs e)
        {

        }

        private void picRoom112_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom113_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom113_Click(object sender, EventArgs e)
        {

        }

        private void picRoom113_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom114_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom114_Click(object sender, EventArgs e)
        {

        }

        private void picRoom114_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom115_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom115_Click(object sender, EventArgs e)
        {

        }

        private void picRoom115_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom116_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom116_Click(object sender, EventArgs e)
        {

        }

        private void picRoom116_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom117_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom117_Click(object sender, EventArgs e)
        {

        }

        private void picRoom117_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom118_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom118_Click(object sender, EventArgs e)
        {

        }

        private void picRoom118_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picRoom119_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picRoom119_Click(object sender, EventArgs e)
        {

        }

        private void picRoom119_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
