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
    public partial class StaffEdit : Form
    {
        //SQL Links
        SqlDataAdapter daStaff;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBStaff;
        DataRow drStaff;
        String connStr, sqlStaff;

        // which cancel is pressed 0 = none, 1 = user info, 2 = emergency contact, 3 = password
        private int buttonPress = 0;

        private string staffID = "";

        public StaffEdit()
        {
            InitializeComponent();
        }

        //Form Load
        private void StaffEdit_Load(object sender, EventArgs e)
        {
            staffID = Globals.staffSel;

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
            foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
            {
                if (drStaff["staffID"].ToString().Equals(lblStaffNo.Text))
                {
                    MyStaff myStaff = new MyStaff();
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
                            int length = txtSurname.Text.ToString().Length;
                            string lastInitial = txtSurname.Text.ToString().Substring(0, 1);
                            string lName = txtSurname.Text.ToString().Substring(1, length - 1);
                            char[] fName = txtForename.Text.ToString().ToCharArray();
                            string initial = fName[0].ToString().ToUpper();
                            lblLogin.Text = lastInitial.ToUpper() + lName + initial;

                            drStaff.BeginEdit();
                            drStaff["staffFName"] = myStaff.Forename;
                            drStaff["staffLName"] = myStaff.Surname;
                            drStaff["staffStreet"] = myStaff.Street;
                            drStaff["staffCity"] = myStaff.City;
                            drStaff["staffCounty"] = myStaff.County;
                            drStaff["staffPcode"] = myStaff.Postcode;
                            drStaff["staffTelNo"] = myStaff.TelNo;
                            drStaff["staffLogin"] = lblLogin.Text.ToString();
                            drStaff.EndEdit();
                            daStaff.Update(dsBelfray, "Staff");

                            MessageBox.Show("User Info Updated");

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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }
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
            buttonPress = 1;

            if (MessageBox.Show("Cancel the editing of staff User Info?", "Edit User Info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                loadDets();

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
            foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
            {
                if (drStaff["staffID"].ToString().Equals(lblStaffNo.Text))
                {
                    MyStaff myStaff = new MyStaff();
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
                            drStaff.BeginEdit();
                            drStaff["staffEmergName"] = myStaff.ContactName;
                            drStaff["staffEmergTel"] = myStaff.ContactTelNo;
                            drStaff.EndEdit();
                            daStaff.Update(dsBelfray, "Staff");

                            MessageBox.Show("Emergency Contact Info Updated");

                            picEmergeCancel.Visible = false;
                            picEmergeSave.Visible = false;
                            picEmergeEdit.Visible = true;

                            txtContactName.Enabled = false;
                            txtContactTel.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }
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
            buttonPress = 2;

            if (MessageBox.Show("Cancel the editing of staff enrgency contact info?", "Edit Emergency Contact Info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                loadDets();

                picEmergeCancel.Visible = false;
                picEmergeSave.Visible = false;
                picEmergeEdit.Visible = true;

                txtContactName.Enabled = false;
                txtContactTel.Enabled = false;
            }
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
            foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
            {
                if (drStaff["staffID"].ToString().Equals(lblStaffNo.Text))
                {
                    MyStaff myStaff = new MyStaff();
                    bool ok = true;
                    errP.Clear();

                    //Account Type
                    try
                    {
                        switch (cmbAccountType.SelectedIndex)
                        {
                            case 0:
                                myStaff.AccType = "ADM";
                                break;
                            case 1:
                                myStaff.AccType = "HTL";
                                break;
                            case 2:
                                myStaff.AccType = "RES";
                                break;
                        }
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(cmbAccountType, MyEx.toString());
                    }

                    //Staff Password
                    try
                    {
                        myStaff.StaffPW = txtCurrent.Text.ToString();
                    }
                    catch (MyException MyEx)
                    {
                        ok = false;
                        errP.SetError(txtCurrent, MyEx.toString());
                    }

                    //Try Adding
                    try
                    {
                        if (ok)
                        {
                            drStaff.BeginEdit();
                            drStaff["staffPassword"] = myStaff.StaffPW;
                            drStaff["accTypeID"] = myStaff.AccType;
                            drStaff.EndEdit();
                            daStaff.Update(dsBelfray, "Staff");

                            MessageBox.Show("Account Info Updated");

                            picPassCancel.Visible = false;
                            picPassSave.Visible = false;
                            picPassEdit.Visible = true;

                            txtCurrent.Enabled = false;
                            cmbAccountType.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    }
                }
            }
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

            cmbAccountType.Enabled = true;
            txtCurrent.Enabled = true;
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
            buttonPress = 3;

            if (MessageBox.Show("Cancel the editing of staff account info?", "Edit Emergency Contact Info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                loadDets();

                picPassCancel.Visible = false;
                picPassSave.Visible = false;
                picPassEdit.Visible = true;

                txtCurrent.Enabled = false;

                cmbAccountType.Enabled = false;
            }

        }

        private void picPassCancel_MouseLeave(object sender, EventArgs e)
        {
            picPassCancel.BackColor = Color.Transparent;
        }

        //Load All Details
        private void loadDets()
        {
            if (buttonPress == 0)
            {
                foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
                {
                    if (drStaff["staffID"].ToString().Equals(staffID))
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

                        switch (drStaff["accTypeID"].ToString())
                        {
                            case "ADM":
                                cmbAccountType.SelectedIndex = 0;
                                break;
                            case "HTL":
                                cmbAccountType.SelectedIndex = 1;
                                break;
                            case "RES":
                                cmbAccountType.SelectedIndex = 2;
                                break;
                        }

                        txtCurrent.Text = drStaff["staffPassword"].ToString();
                    }
                }
            }
            else if (buttonPress == 1)
            {
                foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
                {
                    if (drStaff["staffID"].ToString().Equals(staffID))
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
                    }
                }
            }
            else if (buttonPress == 2)
            {
                foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
                {
                    if (drStaff["staffID"].ToString().Equals(staffID))
                    {
                        //Contact Dets
                        txtContactName.Text = drStaff["staffEmergName"].ToString();
                        txtContactTel.Text = drStaff["staffEmergTel"].ToString();
                    }
                }
            }
            else if (buttonPress == 3)
            {
                foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
                {
                    if (drStaff["staffID"].ToString().Equals(staffID))
                    {
                        //Account Dets
                        lblLogin.Text = drStaff["staffLogin"].ToString();

                        switch (drStaff["accTypeID"].ToString())
                        {
                            case "ADM":
                                cmbAccountType.SelectedIndex = 0;
                                break;
                            case "HTL":
                                cmbAccountType.SelectedIndex = 1;
                                break;
                            case "RES":
                                cmbAccountType.SelectedIndex = 2;
                                break;
                        }
                    }
                }
            }
        }

        //Current Password Visible
        private void picCurrVisible_MouseDown(object sender, MouseEventArgs e)
        {
            txtCurrent.UseSystemPasswordChar = false;
            picCurrVisible.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picCurrVisible_MouseUp(object sender, MouseEventArgs e)
        {
            txtCurrent.UseSystemPasswordChar = true;
            picCurrVisible.BackColor = Color.Transparent;
        }
    }
}
