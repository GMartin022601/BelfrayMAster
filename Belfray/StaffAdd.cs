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
    public partial class StaffAdd : Form
    {
        //SQL Links
        SqlDataAdapter daStaff;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBStaff;
        DataRow drStaff;
        String connStr, sqlStaff;  
        
        private MyStaff myStaff = new MyStaff();

        public StaffAdd()
        {
            InitializeComponent();
        }

        //Form Load
        private void StaffAdd_Load(object sender, EventArgs e)
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
        }

        //Staff Save Button Function
        private void picStaffSave_MouseEnter(object sender, EventArgs e)
        {
            picStaffSave.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picStaffSave_Click(object sender, EventArgs e)
        {            
            bool ok = true;
            errP.Clear();

            //Forename
            try
            {
                myStaff.Forename = txtForename.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtForename, MyEx.toString());
            }

            //Surname
            try
            {
                myStaff.Surname = txtSurname.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSurname, MyEx.toString());
            }

            //Street
            try
            {
                myStaff.Street = txtStreet.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtStreet, MyEx.toString());
            }

            //City
            try
            {
                myStaff.City = txtCity.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCity, MyEx.toString());
            }

            //County
            try
            {
                myStaff.County = txtCounty.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCounty, MyEx.toString());
            }

            //Postcode
            try
            {
                myStaff.Postcode = txtPostcode.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPostcode, MyEx.toString());
            }

            //Tel No
            try
            {
                myStaff.TelNo = txtPhoneNo.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPhoneNo, MyEx.toString());
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    //Disable User Info
                    gbUserInfo.Enabled = false;
                    picStaffCancel.Visible = false;
                    picStaffSave.Visible = false;

                    //Enable Emergency Info
                    gbEmergency.Enabled = true;
                    picEmergeSave.Visible = true;
                    picEmergeCancel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
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
            this.Close();
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
            bool ok = true;
            errP.Clear();

            //Contact Name
            try
            {
                myStaff.ContactName = txtContactName.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtContactName, MyEx.toString());
            }

            //Contact Tel No
            try
            {
                myStaff.ContactTelNo = txtContactTel.Text.ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPhoneNo, MyEx.toString());
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    //Disable Emergency Info
                    gbEmergency.Enabled = false;
                    picEmergeSave.Visible = false;
                    picEmergeCancel.Visible = false;

                    //Enable Emergency Info
                    gbAccountInfo.Enabled = true;
                    picPassSave.Visible = true;
                    picPassCancel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
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
            //Disable Emergency Info
            gbEmergency.Enabled = false;
            picEmergeSave.Visible = false;
            picEmergeCancel.Visible = false;

            //Enable User Info
            gbUserInfo.Enabled = true;
            picStaffCancel.Visible = true;
            picStaffSave.Visible = true;
        }

        private void picEmergeCancel_MouseLeave(object sender, EventArgs e)
        {
            picEmergeCancel.BackColor = Color.Transparent;
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

        //Password Cancel Button Function
        private void picPassCancel_MouseEnter(object sender, EventArgs e)
        {
            picPassCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picPassCancel_Click(object sender, EventArgs e)
        {
            //Disable User Info
            gbUserInfo.Enabled = false;
            picStaffCancel.Visible = false;
            picStaffSave.Visible = false;

            //Enable Emergency Info
            gbEmergency.Enabled = true;
            picEmergeSave.Visible = true;
            picEmergeCancel.Visible = true;
        }

        private void picPassCancel_MouseLeave(object sender, EventArgs e)
        {
            picPassCancel.BackColor = Color.Transparent;
        }
    }
}
