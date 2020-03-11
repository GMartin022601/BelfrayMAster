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
    public partial class AppDisplay : Form
    {
        public static bool logOut = false;

        public AppDisplay()
        {
            InitializeComponent();
        }

        private void AppDisplay_Load(object sender, EventArgs e)
        {
            LoginPage frm = new LoginPage();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormClosed += Page_Closed;
            pnlLogin.Controls.Add(frm);
            frm.Show();
        }

        private void Page_Closed(object sender, FormClosedEventArgs e)
        {
            if (logOut == true)
            {
                pnlLogin.Visible = false;
                pnlMainWindow.Visible = true;

                MainWindow frm = new MainWindow();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.FormClosed += Page_Closed;
                pnlMainWindow.Controls.Add(frm);
                frm.Show();

                logOut = false;
            }
            else
            {
                pnlLogin.Visible = true;
                pnlMainWindow.Visible = false;

                LoginPage frm = new LoginPage();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.WindowState = FormWindowState.Maximized;
                frm.FormClosed += Page_Closed;
                pnlLogin.Controls.Add(frm);
                frm.Show();

                logOut = false;
            }

            
        }
    }
}
