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
    public partial class MainWindow : Form
    {
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
            pnlWelcome.Visible = false;
            //pnlRoomBooking.Visible = false;
        }

        private void picRoomBooking_Click(object sender, EventArgs e)
        {
            Reset();
            //pnlRoomBooking.Visible = true;
        }
    }
}
