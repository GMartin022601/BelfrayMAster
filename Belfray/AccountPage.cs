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
    public partial class AccountPage : Form
    {
        //SQL Links
        SqlDataAdapter daStaff;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBStaff;
        DataRow drStaff;
        String connStr, sqlStaff;

        public AccountPage()
        {
            InitializeComponent();
        }

        //Form Load
        private void AccountPage_Load(object sender, EventArgs e)
        {
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            sqlStaff = @"select * from Staff";
            daStaff = new SqlDataAdapter(sqlStaff, connStr);
            cmdBStaff = new SqlCommandBuilder(daStaff);
            daStaff.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daStaff.Fill(dsBelfray, "Staff");

            loadDets();
        }

        //Staff Edit Button Function
        private void picStaffEdit_MouseEnter(object sender, EventArgs e)
        {
            picStaffEdit.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picStaffEdit_Click(object sender, EventArgs e)
        {
            picStaffCancel.Visible = true;
            picStaffSave.Visible = true;
            picStaffEdit.Visible = false;

            txtForename.Enabled = true;
            txtSurname.Enabled = true;
            txtStreet.Enabled = true;
            txtCity.Enabled = true;
            txtCounty.Enabled = true;
            txtPostcode.Enabled = true;
            txtPhoneNo.Enabled = true;
        }

        private void picStaffEdit_MouseLeave(object sender, EventArgs e)
        {
            picStaffEdit.BackColor = Color.Transparent;
        }

        //Staff Save Button Function
        private void picStaffSave_MouseEnter(object sender, EventArgs e)
        {
            picStaffSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picStaffSave_Click(object sender, EventArgs e)
        {

        }

        private void picStaffSave_MouseLeave(object sender, EventArgs e)
        {
            picStaffSave.BackColor = Color.Transparent;
        }

        //Staff Cancel Button Function
        private void picStaffCancel_MouseEnter(object sender, EventArgs e)
        {
            picStaffCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picStaffCancel_Click(object sender, EventArgs e)
        {
            picStaffCancel.Visible = false;
            picStaffSave.Visible = false;
            picStaffEdit.Visible = true;

            txtForename.Enabled = false;
            txtSurname.Enabled = false;
            txtStreet.Enabled = false;
            txtCity.Enabled = false;
            txtCounty.Enabled = false;
            txtPostcode.Enabled = false;
            txtPhoneNo.Enabled = false;
        }

        private void picStaffCancel_MouseLeave(object sender, EventArgs e)
        {
            picStaffCancel.BackColor = Color.Transparent;
        }

        //Emergency Contact Save Button Function
        private void picEmergeSave_MouseEnter(object sender, EventArgs e)
        {
            picEmergeSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picEmergeSave_Click(object sender, EventArgs e)
        {

        }

        private void picEmergeSave_MouseLeave(object sender, EventArgs e)
        {
            picEmergeSave.BackColor = Color.Transparent;
        }

        //Emergency Contact Cancel Button Function
        private void picEmergeCancel_MouseEnter(object sender, EventArgs e)
        {
            picEmergeCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picEmergeCancel_Click(object sender, EventArgs e)
        {
            picEmergeCancel.Visible = false;
            picEmergeSave.Visible = false;
            picEmergeEdit.Visible = true;

            txtContactName.Enabled = false;
            txtContactTel.Enabled = false;
        }

        private void picEmergeCancel_MouseLeave(object sender, EventArgs e)
        {
            picEmergeCancel.BackColor = Color.Transparent;
        }

        //Emergency Contact Edit Button Function
        private void picEmergeEdit_MouseEnter(object sender, EventArgs e)
        {
            picEmergeEdit.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picEmergeEdit_Click(object sender, EventArgs e)
        {
            picEmergeCancel.Visible = true;
            picEmergeSave.Visible = true;
            picEmergeEdit.Visible = false;

            txtContactName.Enabled = true;
            txtContactTel.Enabled = true;
        }

        private void picEmergeEdit_MouseLeave(object sender, EventArgs e)
        {
            picEmergeEdit.BackColor = Color.Transparent;
        }

        //Password Save Button Function
        private void picPassSave_MouseEnter(object sender, EventArgs e)
        {
            picPassSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picPassSave_Click(object sender, EventArgs e)
        {

        }

        private void picPassSave_MouseLeave(object sender, EventArgs e)
        {
            picPassSave.BackColor = Color.Transparent;
        }

        //Password Edit Button Function
        private void picPassEdit_MouseEnter(object sender, EventArgs e)
        {
            picPassEdit.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picPassEdit_Click(object sender, EventArgs e)
        {
            picPassCancel.Visible = true;
            picPassSave.Visible = true;
            picPassEdit.Visible = false;

            txtCurrent.Enabled = true;
            txtNew1.Enabled = true;
            txtNew2.Enabled = true;
        }

        private void picPassEdit_MouseLeave(object sender, EventArgs e)
        {
            picPassEdit.BackColor = Color.Transparent;
        }

        //Password Cancel Button Function
        private void picPassCancel_MouseEnter(object sender, EventArgs e)
        {
            picPassCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picPassCancel_Click(object sender, EventArgs e)
        {
            picPassCancel.Visible = false;
            picPassSave.Visible = false;
            picPassEdit.Visible = true;

            txtCurrent.Enabled = false;
            txtNew1.Enabled = false;
            txtNew2.Enabled = false;
        }

        private void picPassCancel_MouseLeave(object sender, EventArgs e)
        {
            picPassCancel.BackColor = Color.Transparent;
        }        

        //Load All Details
        private void loadDets()
        {
            foreach(DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
            {
                if(drStaff["staffID"].ToString().Equals(Globals.staffNo))
                {
                    //Staf Dets
                    lblStaffNo.Text = drStaff["staffID"].ToString();
                    txtForename.Text = drStaff["staffFName"].ToString();
                    txtSurname.Text = drStaff["staffLName"].ToString();
                    txtStreet.Text = drStaff["staffStreet"].ToString();
                    txtCity.Text = drStaff["staffCity"].ToString();
                    txtCounty.Text = drStaff["staffCounty"].ToString();
                    txtPostcode.Text = drStaff["staffPcode"].ToString();
                    txtPhoneNo.Text = drStaff["staffTelNo"].ToString();

                    //Contact Dets
                    txtContactName.Text = drStaff["staffEmergName"].ToString();
                    txtContactTel.Text = drStaff["staffEmergTel"].ToString();

                    //Account Dets
                    lblLogin.Text = drStaff["staffLogin"].ToString();

                    switch(drStaff["accTypeID"].ToString())
                    {
                        case "ADM":
                            lblType.Text = "Administrator";
                            break;
                        case "HTL":
                            lblType.Text = "Hotel";
                            break;
                        case "RES":
                            lblType.Text = "Restaurant";
                            break;
                    }
                }
            }
        }
    }
}
