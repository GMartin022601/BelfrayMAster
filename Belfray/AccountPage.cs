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

        // which cancel is pressed 0 = none, 1 = user info, 2 = emergency contact, 3 = password
        private int buttonPress = 0;

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
                            drStaff.BeginEdit();
                            drStaff["staffFName"] = myStaff.Forename;
                            drStaff["staffLName"] = myStaff.Surname;
                            drStaff["staffStreet"] = myStaff.Street;
                            drStaff["staffCity"] = myStaff.City;
                            drStaff["staffCounty"] = myStaff.County;
                            drStaff["staffPcode"] = myStaff.Postcode;
                            drStaff["staffTelNo"] = myStaff.TelNo;
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

            if (MessageBox.Show("Cancel the editing of your User Info?", "Edit User Info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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

            if (MessageBox.Show("Cancel the editing of your enrgency contact info?", "Edit Emergency Contact Info", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
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
                    if (txtCurrent.Text.ToString().Equals(drStaff["staffPassword"].ToString()))
                    {
                        if(txtNew1.Text.ToString().Equals(txtNew2.Text.ToString()))
                        {
                            if (txtNew1.Text.Length > 8)
                            {
                                drStaff.BeginEdit();
                                drStaff["staffPassword"] = txtNew1.Text.ToString();
                                drStaff.EndEdit();
                                daStaff.Update(dsBelfray, "Staff");

                                MessageBox.Show("Password successfully changed");

                                picPassCancel.Visible = false;
                                picPassSave.Visible = false;
                                picPassEdit.Visible = true;

                                txtCurrent.Enabled = false;
                                txtNew1.Enabled = false;
                                txtNew2.Enabled = false;

                                txtCurrent.Text = "";
                                txtNew1.Text = "";
                                txtNew2.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Your new password must be at least 8 characters long.", "Password error", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your new passwords do not match is incorrect, please try again.", "Password error", MessageBoxButtons.OK);
                            txtNew1.Text = "";
                            txtNew2.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your current password is incorrect, please try again.", "Password error", MessageBoxButtons.OK);
                    }

                    break;
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
            buttonPress = 3;

            picPassCancel.Visible = false;
            picPassSave.Visible = false;
            picPassEdit.Visible = true;

            txtCurrent.Enabled = false;
            txtNew1.Enabled = false;
            txtNew2.Enabled = false;

            txtCurrent.Text = "";
            txtNew1.Text = "";
            txtNew2.Text = "";

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
                    if (drStaff["staffID"].ToString().Equals(Globals.staffNo))
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
            else if (buttonPress == 1)
            {
                foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
                {
                    if (drStaff["staffID"].ToString().Equals(Globals.staffNo))
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
            else if(buttonPress == 2)
            {
                foreach (DataRow drStaff in dsBelfray.Tables["Staff"].Rows)
                {
                    if (drStaff["staffID"].ToString().Equals(Globals.staffNo))
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
                    if (drStaff["staffID"].ToString().Equals(Globals.staffNo))
                    {
                        //Account Dets
                        lblLogin.Text = drStaff["staffLogin"].ToString();

                        switch (drStaff["accTypeID"].ToString())
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

        //New1 Password Visible
        private void picNew1Visible_MouseDown(object sender, MouseEventArgs e)
        {
            txtNew1.UseSystemPasswordChar = false;
            picNew1Visible.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picNew1Visible_MouseUp(object sender, MouseEventArgs e)
        {
            txtNew1.UseSystemPasswordChar = true;
            picNew1Visible.BackColor = Color.Transparent;
        }

        //New2 Password Visible
        private void picNew2Visible_MouseDown(object sender, MouseEventArgs e)
        {
            txtNew2.UseSystemPasswordChar = false;
            picNew2Visible.BackColor = Color.FromArgb(57, 181, 74);
        }

        private void picNew2Visible_MouseUp(object sender, MouseEventArgs e)
        {
            txtNew2.UseSystemPasswordChar = true;
            picNew2Visible.BackColor = Color.Transparent;
        }
    }
}
