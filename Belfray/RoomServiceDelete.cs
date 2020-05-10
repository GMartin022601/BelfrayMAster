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
    public partial class RoomServiceDelete : Form
    {
        SqlDataAdapter daCustomer, daBookingDets, daItem, daItemType, daDets, daItems, daDetails;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBCustomer, cmdBBookingDets, cmdBItem, cmdBItemType, cmdBDets, cmdBItems, cmdBDetails;
        DataRow drCustomer, drBookingDets, drItem, drItemType, drDets, drItems, drDetails;
        String connStr, sqlCustomer, sqlBookingDets, sqlItem, sqlItemType, sqlDets, sqlItems, sqlDetails;

        //Confirms if a room was selected
        private bool roomSel = false;

        //Confirms if a room was selected
        private bool itemSel = false;

        //User changes combobox
        private bool userChange = false;

        //User cancel
        private bool userCancel = false;

        public RoomServiceDelete()
        {
            InitializeComponent();
        }

        private void RoomServiceDelete_Load(object sender, EventArgs e)
        {
            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking Item
            sqlBookingDets = @"SELECT Bi.itemNo, Bi.bookingNo AS 'Booking Number', Bk.checkInDate AS 'Check In Date', Bk.checkOutDate AS 'Check Out Date', 
                            Bk.customerNo AS 'Customer Number', P.paymentTypeDesc AS 'Payment Type', Bk.partySize AS 'Party Size' FROM BookingItem Bi
                            LEFT JOIN Booking Bk ON bk.bookingNo = Bi.bookingNo
                            LEFT JOIN Payment P on P.paymentTypeID = Bk.paymentTypeID
                            WHERE itemNo LIKE '%RM%' AND Bk.checkInDate <= GETDATE() AND Bk.checkOutDate >= GETDATE()
                            ORDER BY itemNo ASC";
            daBookingDets = new SqlDataAdapter(sqlBookingDets, connStr);
            cmdBBookingDets = new SqlCommandBuilder(daBookingDets);
            daBookingDets.FillSchema(dsBelfray, SchemaType.Source, "Rooms");
            daBookingDets.Fill(dsBelfray, "Rooms");

            //SQL for Item
            sqlItems = @"SELECT itemNo AS 'Item Number', itemDesc AS 'Description', itemPrice AS 'Price', typeID FROM Item WHERE typeID NOT IN ('TYP100001','TYP100002')";
            daItems = new SqlDataAdapter(sqlItems, connStr);
            cmdBItems = new SqlCommandBuilder(daItems);
            daItems.FillSchema(dsBelfray, SchemaType.Source, "Items");
            daItems.Fill(dsBelfray, "Items");
            //SQL for Item
            sqlItem = @"SELECT * FROM Item WHERE typeID NOT IN ('TYP100001','TYP100002')";
            daItem = new SqlDataAdapter(sqlItem, connStr);
            cmdBItem = new SqlCommandBuilder(daItem);
            daItem.FillSchema(dsBelfray, SchemaType.Source, "Item");
            daItem.Fill(dsBelfray, "Item");

            //SQL for Room who already ordered room service
            sqlDets = @"SELECT itemNo FROM BookingDetails bd
                        LEFT JOIN Booking Bk ON bk.bookingNo = Bd.bookingNo
                        WHERE Bk.checkInDate <= GETDATE() AND Bk.checkOutDate >= GETDATE()
                        Group BY itemNo";
            daDets = new SqlDataAdapter(sqlDets, connStr);
            cmdBDets = new SqlCommandBuilder(daDets);
            daDets.FillSchema(dsBelfray, SchemaType.Source, "Dets");
            daDets.Fill(dsBelfray, "Dets");

            //SQL for Booking Details
            sqlDetails = @"SELECT * FROM BookingDetails";
            daDetails = new SqlDataAdapter(sqlDetails, connStr);
            cmdBDetails = new SqlCommandBuilder(daDetails);
            daDetails.FillSchema(dsBelfray, SchemaType.Source, "Details");
            daDetails.Fill(dsBelfray, "Details");

            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customers");
            daCustomer.Fill(dsBelfray, "Customers");

            //SQL For Item Type
            sqlItemType = @"select * from BType WHERE typeID NOT IN ('TYP100001','TYP100002')";
            daItemType = new SqlDataAdapter(sqlItemType, connStr);
            cmdBItemType = new SqlCommandBuilder(daItemType);
            daItemType.FillSchema(dsBelfray, SchemaType.Source, "Type");
            daItemType.Fill(dsBelfray, "Type");

            //CB Details Customer
            cmbItemType.DataSource = dsBelfray.Tables["Type"];
            cmbItemType.ValueMember = "typeID";
            cmbItemType.DisplayMember = "typeDesc";
            cmbItemType.SelectedIndex = -1;

            displayRooms();
            userCancel = true;
        }

        //Display Rooms
        public void displayRooms()
        {
            string[] stArray = new string[19] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            int x = 0;
            foreach (DataRow drDets in dsBelfray.Tables["Dets"].Rows)
            {
                stArray[x] = drDets["itemNo"].ToString();
                x++;
            }

            DataView room = new DataView(dsBelfray.Tables["Rooms"], "itemNo IN ('" + stArray[0] + "','" + stArray[1] + "','" + stArray[2] + "','" + stArray[3] + "','" + stArray[4] + "','" + stArray[5] + "','" + stArray[6] + "','" + stArray[7] + "','" + stArray[8] + "','" + stArray[9] + "','" + stArray[10] + "','" + stArray[11] + "','" + stArray[12] + "','" + stArray[13] + "','" + stArray[14] + "','" + stArray[15] + "','" + stArray[16] + "','" + stArray[17] + "','" + stArray[18] + "')", "itemNo", DataViewRowState.CurrentRows);
            dgvRooms.DataSource = room;

            dgvRooms.Columns[0].HeaderText = "Room Number";

            dgvRooms.Columns[0].Width = 82;
            dgvRooms.Columns[1].Width = 82;
            dgvRooms.Columns[2].Width = 81;
            dgvRooms.Columns[3].Width = 81;
            dgvRooms.Columns[4].Width = 81;
            dgvRooms.Columns[5].Width = 73;
            dgvRooms.Columns[6].Width = 73;
        }

        //Current Order Click
        private void dgvCurrentOrder_Click(object sender, EventArgs e)
        {
            if (dgvCurrentOrder.RowCount > 1)
            {
                if (dgvCurrentOrder.SelectedRows.Count == 0)
                {
                    itemSel = false;
                }
                else if (dgvCurrentOrder.SelectedRows.Count == 1)
                {
                    itemSel = true;

                    DataRow cust = dsBelfray.Tables["Item"].Rows.Find(dgvCurrentOrder.SelectedRows[0].Cells[2].Value.ToString());

                    lblItemNo.Text = cust["itemNo"].ToString();

                    string desc = cust["itemDesc"].ToString();
                    bool one = false, two = false, three = false;
                    int break1 = 0;
                    int break2 = 0;
                    int break3 = 0;
                    int max = 0;
                    if (desc.Length > 17 && desc.Length <= 37)
                    {
                        if (desc.Length > 24)
                        {
                            one = true;
                            break1 = desc.IndexOf(" ", 17);
                        }
                        max = desc.Length;
                    }
                    else if (desc.Length > 37 && desc.Length <= 57)
                    {
                        if (desc.Length > 44)
                        {
                            two = true;
                            break1 = desc.IndexOf(" ", 17);
                            break2 = desc.IndexOf(" ", 37);
                        }
                        else
                        {
                            one = true;
                            break1 = desc.IndexOf(" ", 17);
                        }
                        max = desc.Length;
                    }
                    else if (desc.Length > 57)
                    {
                        if (desc.Length > 74)
                        {
                            three = true;
                            break1 = desc.IndexOf(" ", 17);
                            break2 = desc.IndexOf(" ", 37);
                            break3 = desc.IndexOf(" ", 57);
                            max = 74;
                        }
                        else if (desc.Length > 64)
                        {
                            three = true;
                            break1 = desc.IndexOf(" ", 17);
                            break2 = desc.IndexOf(" ", 37);
                            break3 = desc.IndexOf(" ", 57);
                            max = desc.Length;
                        }
                        else
                        {
                            two = true;
                            max = desc.Length;
                            break1 = desc.IndexOf(" ", 17);
                            break2 = desc.IndexOf(" ", 37);
                        }
                    }

                    string s1 = "";
                    string s2 = "";
                    string s3 = "";
                    string s4 = "";

                    if (one == true)
                    {
                        s1 = desc.Substring(0, break1);
                        s2 = desc.Substring(break1 + 1, (max - (break1 + 1)));
                        lblItemDescription.Text = s1 + "\n" + s2;
                    }
                    else if (two)
                    {
                        s1 = desc.Substring(0, break1);
                        s2 = desc.Substring(break1 + 1, (break2 - (break1 + 1)));
                        s3 = desc.Substring(break2 + 1, (max - (break2 + 1)));
                        lblItemDescription.Text = s1 + "\n" + s2 + "\n" + s3;
                    }
                    else if (three)
                    {
                        s1 = desc.Substring(0, break1);
                        s2 = desc.Substring(break1 + 1, (break2 - (break1 + 1)));
                        s3 = desc.Substring(break2 + 1, (break3 - (break2 + 1)));
                        s4 = desc.Substring(break3 + 1, (max - (break3 + 1)));
                        lblItemDescription.Text = s1 + "\n" + s2 + "\n" + s3 + "\n" + s4;
                    }
                    else
                    {
                        lblItemDescription.Text = desc;
                    }

                    decimal price = Math.Round(Convert.ToDecimal(cust["itemPrice"].ToString()), 2);
                    lblItemPrice.Text = price.ToString();
                    txtQty.Text = dgvCurrentOrder.SelectedRows[0].Cells[4].Value.ToString();
                    lblItemTotal.Text = Convert.ToString((Convert.ToDouble(txtQty.Text.ToString())) * (Convert.ToDouble(lblItemPrice.Text.ToString())));

                    one = false;
                    two = false;
                    three = false;
                }
            }
            else
            {
                picDel.Visible = false;
            }
        }        

        //Clicke Event for dgvRooms
        private void dgvRooms_Click(object sender, EventArgs e)
        {
            if (dgvRooms.SelectedRows.Count == 0)
            {
                roomSel = false;
            }
            else if (dgvRooms.SelectedRows.Count == 1)
            {
                roomSel = true;
                picDel.Visible = true;
                
                lblRoomNo.Text = dgvRooms.SelectedRows[0].Cells[0].Value.ToString();
                lblBookingNo.Text = dgvRooms.SelectedRows[0].Cells[1].Value.ToString();
                lblCustomerNo.Text = dgvRooms.SelectedRows[0].Cells[4].Value.ToString();

                DataRow cust = dsBelfray.Tables["Customers"].Rows.Find(lblCustomerNo.Text.ToString());
                lblCustTitle.Text = cust["customerTitle"].ToString();
                lblCustForename.Text = cust["customerForename"].ToString();
                lblCustSurname.Text = cust["customerSurname"].ToString();

                foreach (DataRow drDetails in dsBelfray.Tables["Details"].Rows)
                {
                    if (drDetails["bookingNo"].ToString().Equals(lblBookingNo.Text) && drDetails["itemNo"].ToString().Equals(lblRoomNo.Text))
                    {
                        DataRow item = dsBelfray.Tables["Item"].Rows.Find(drDetails["bookingItemNo"].ToString());
                        dgvCurrentOrder.Rows.Add(drDetails["bookingNo"].ToString(), drDetails["itemNo"].ToString(), drDetails["bookingItemNo"].ToString(), item["itemPrice"].ToString(), drDetails["bookingItemQty"].ToString());
                    }
                }
            }
        }        

        //Save Button functions
        private void picDel_MouseEnter(object sender, EventArgs e)
        {
            picDel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picDel_Click(object sender, EventArgs e)
        {
            //Try Adding
            try
            {
                foreach (DataRow drDetails in dsBelfray.Tables["Details"].Rows)
                {
                    if (drDetails["bookingNo"].ToString().Equals(lblBookingNo.Text) && drDetails["itemNo"].ToString().Equals(lblRoomNo.Text))
                    {
                        drDetails.Delete();
                    }
                }

                daDetails.Update(dsBelfray, "Details");                

                MessageBox.Show("Room Service Deleted");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void picDel_MouseLeave(object sender, EventArgs e)
        {
            picDel.BackColor = Color.Transparent;
        }

        //Cancel Button functions
        private void picCancel_MouseEnter(object sender, EventArgs e)
        {
            picCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            displayRooms();

            picDel.Visible = false;

            //Rest Customer Dets
            gbCustomerDets.Enabled = false;
            lblCustomerNo.Text = "-";
            lblCustomerTitle.Text = "-";
            lblCustForename.Text = "-";
            lblCustSurname.Text = "-";

            userChange = false;
            userCancel = false;

            //Reset Item Detals
            lblItemNo.Text = "-";
            lblItemDescription.Text = "-";
            lblItemPrice.Text = "-";
            txtQty.Text = "0";
            lblItemTotal.Text = "-";

            //Reset Booking Detals
            lblBookingNo.Text = "-";
            lblRoomNo.Text = "-";
            cmbItemType.SelectedIndex = -1;
            cmbItemType.Enabled = false;

            dgvCurrentOrder.Rows.Clear();

            dgvRooms.ClearSelection();
            dgvRooms.Visible = true;

            userCancel = true;
        }

        private void picCancel_MouseLeave(object sender, EventArgs e)
        {
            picCancel.BackColor = Color.Transparent;
        }
    }
}


