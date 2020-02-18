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
    public partial class LoginPage : Form
    {
        SqlDataAdapter daLogin;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBLogin;
        DataRow drLoging;
        String connStr, sqlLogin;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if()
            //{
                MainWindow main = new MainWindow();
                main.Show();
            //}            
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //sqlLogin = @"select staffLogin, staffPassword from Staff";
            //daLogin = new SqlDataAdapter(sqlLogin, connStr);
            //cmdBLogin = new SqlCommandBuilder(daLogin);
        }
    }
}
