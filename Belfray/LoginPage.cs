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
        //SQL Links
        SqlDataAdapter daLogin;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBLogin;
        DataRow drLogin;
        String connStr, sqlLogin;

        //Global User's Name
        public static string currUser = "";

        //Global User Permissions
        public static string accType = "";

        //Login status
        //public static bool loginStatus = false;

        public LoginPage()
        {
            InitializeComponent();
    }

        private void GetNumber(int noRows)
        {
            drLogin = dsBelfray.Tables["Staff"].Rows[noRows - 1];
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool userFound = false, passFound = false;
            int noRows = dsBelfray.Tables["Staff"].Rows.Count;

            foreach(DataRow drUser in dsBelfray.Tables["Staff"].Rows)
            {
                string login = drUser["staffLogin"].ToString();
                string password = drUser["staffPassword"].ToString();
                if (txtUsername.Text.ToString().Equals(login))
                {
                    userFound = true;

                    if(txtPassword.Text.ToString().Equals(password))
                    {
                        passFound = true;
                        currUser = drUser["staffFName"].ToString() + " " + drUser["staffLName"].ToString();
                        accType = drUser["accTypeID"].ToString();
                    }

                    break;
                }
            }

            if (userFound)
            {
                if (passFound)
                {
                    txtUsername.Text = "Username";
                    txtPassword.Text = "Password";
                    txtUsername.Focus();
                    AppDisplay.logOut = true;
                    this.Close();                    
                }
                else
                {
                    MessageBox.Show("Password incorrect, please try again!", "Access Denied");
                }
            }
            else
            {
                MessageBox.Show("Username does not exist, please try again!", "Access Denied");
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';            
        }        

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            sqlLogin = @"select StaffID, staffFName, staffLName, staffLogin, staffPassword, accTypeID from Staff";
            daLogin = new SqlDataAdapter(sqlLogin, connStr);
            cmdBLogin = new SqlCommandBuilder(daLogin);

            daLogin.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daLogin.Fill(dsBelfray, "Staff");
        }
    }
}
