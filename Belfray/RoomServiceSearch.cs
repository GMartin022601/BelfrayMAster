﻿using System;
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
    public partial class RoomServiceSearch : Form
    {
        //SQL links
        SqlDataAdapter daBookingDets, daCustomer, daBookingItem, daPayType;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBBookingDets, cmdBCustomer, cmdBBookingItem, cmdBPayType;
        DataRow drBookingDets, drCustomer, drBookingItem, drPayType;
        String connStr, sqlBookingDets, sqlCustomer, sqlBookingItem, sqlPayType;

        private bool roomSel = false;

        private bool itemSel = false;

        private string roomSelected = "";

        //Search option 0 = none, 1 = Room Search, 2 = Item No search, 3 = Item Name Search
        private int searchOption = 0;

        public RoomServiceSearch()
        {
            InitializeComponent();
        }

        //Search Item Name Text Changed
        private void txtSearchItemName_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchItemName.Text.Length == 0)
            {
                dgvItemSearch.Visible = false;
                dgvRoomSearch.Visible = true;
            }
            else if (txtSearchItemName.Text.Length > 0)
            {
                txtSearchItemNo.Text = "";
                txtSearchRoomNo.Text = "";
                //displayItems();

                dgvItemSearch.Visible = true;
                dgvRoomSearch.Visible = false;

                DataView item2Search = new DataView(dsBelfray.Tables["BookingDets"], "itemDesc LIKE '%" + txtSearchItemName.Text.ToString() + "%'", "itemDesc", DataViewRowState.CurrentRows);
                dgvItemSearch.DataSource = item2Search;

                dgvItemSearch.Columns[0].HeaderText = "Room Number";
                dgvItemSearch.Columns[2].HeaderText = "Item Number";
                dgvItemSearch.Columns[3].HeaderText = "Item Description";

                dgvItemSearch.Columns[0].Width = 72;
                dgvItemSearch.Columns[1].Width = 90;
                dgvItemSearch.Columns[2].Width = 82;
                dgvItemSearch.Columns[3].Width = 292;
                dgvItemSearch.Columns[4].Width = 72;
                dgvItemSearch.Columns[5].Width = 62;
                dgvItemSearch.Columns[6].Width = 42;
            }
        }

        //Search Item Number Text Changed
        private void txtSearchItemNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchItemNo.Text.Length == 0)
            {
                dgvItemSearch.Visible = false;
                dgvRoomSearch.Visible = true;
            }
            else if (txtSearchItemNo.Text.Length > 0)
            {
                txtSearchItemName.Text = "";
                txtSearchRoomNo.Text = "";
                //displayItems();


                dgvItemSearch.Visible = true;
                dgvRoomSearch.Visible = false;


                DataView itemSearch = new DataView(dsBelfray.Tables["BookingDets"], "bookingItemNo LIKE '%" + txtSearchItemNo.Text.ToString() + "%'", "bookingItemNo", DataViewRowState.CurrentRows);
                dgvItemSearch.DataSource = itemSearch;

                dgvItemSearch.Columns[0].HeaderText = "Room Number";
                dgvItemSearch.Columns[2].HeaderText = "Item Number";
                dgvItemSearch.Columns[3].HeaderText = "Item Description";

                dgvItemSearch.Columns[0].Width = 72;
                dgvItemSearch.Columns[1].Width = 90;
                dgvItemSearch.Columns[2].Width = 82;
                dgvItemSearch.Columns[3].Width = 292;
                dgvItemSearch.Columns[4].Width = 72;
                dgvItemSearch.Columns[5].Width = 62;
                dgvItemSearch.Columns[6].Width = 42;
            }
        }

        //Search Room Number Text Changed
        private void txtSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchRoomNo.Text.Length > 0)
            {
                txtSearchItemNo.Text = "";
                txtSearchItemName.Text = "";
            }

            dgvItemSearch.Visible = false;
            dgvRoomSearch.Visible = true;

            DataView roomSearch = new DataView(dsBelfray.Tables["BookItem"], "itemNo LIKE '%" + txtSearchRoomNo.Text.ToString() + "%'", "itemNo", DataViewRowState.CurrentRows);
            dgvRoomSearch.DataSource = roomSearch;

            dgvRoomSearch.Columns[0].HeaderText = "Room Number";

            dgvRoomSearch.Columns[0].Width = 82;
            dgvRoomSearch.Columns[1].Width = 82;
            dgvRoomSearch.Columns[2].Width = 81;
            dgvRoomSearch.Columns[3].Width = 81;
            dgvRoomSearch.Columns[4].Width = 71;
            dgvRoomSearch.Columns[5].Width = 51;
            dgvRoomSearch.Columns[6].Width = 71;
            dgvRoomSearch.Columns[7].Width = 71;
            dgvRoomSearch.Columns[8].Width = 61;
            dgvRoomSearch.Columns[9].Width = 61;

            picCancel.Visible = false;
        }

        //Row Clicked Rooms
        private void dgvRoomServiceSearch_Click(object sender, EventArgs e)
        {
            searchOption = 1;
            if (dgvRoomSearch.SelectedRows.Count == 0)
            {
                roomSel = false;                
            }
            else if (dgvRoomSearch.SelectedRows.Count == 1)
            {
                roomSel = true;
                roomSelected = dgvRoomSearch.SelectedRows[0].Cells[0].Value.ToString();

                dgvRoomSearch.Visible = false;
                dgvItemSearch.Visible = true;

                DataView roomSearch = new DataView(dsBelfray.Tables["BookingDets"], "itemNo = '" + roomSelected + "'", "itemNo", DataViewRowState.CurrentRows);
                dgvItemSearch.DataSource = roomSearch;

                dgvItemSearch.Columns[0].HeaderText = "Room Number";
                dgvItemSearch.Columns[2].HeaderText = "Item Number";
                dgvItemSearch.Columns[3].HeaderText = "Item Description";

                dgvItemSearch.Columns[0].Width = 72;
                dgvItemSearch.Columns[1].Width = 100;
                dgvItemSearch.Columns[2].Width = 62;
                dgvItemSearch.Columns[3].Width = 292;
                dgvItemSearch.Columns[4].Width = 72;
                dgvItemSearch.Columns[5].Width = 72;
                dgvItemSearch.Columns[6].Width = 42;

                pnlRoom.Visible = true;
                pnlItem.Visible = false;

                lblBookingNo.Text = dgvRoomSearch.SelectedRows[0].Cells[0].Value.ToString();
                DateTime checkIn = Convert.ToDateTime(dgvRoomSearch.SelectedRows[0].Cells[2].Value);
                lblCheckIn.Text = checkIn.ToShortDateString();
                DateTime checkOut = Convert.ToDateTime(dgvRoomSearch.SelectedRows[0].Cells[3].Value);
                lblCheckOut.Text = checkOut.ToShortDateString();
                lblBookingType.Text = "Room";
                lblRooms.Text = dgvRoomSearch.SelectedRows[0].Cells[1].Value.ToString();
                lblCheckInTime.Text = "13:00";
                lblBookingCustomer.Text = dgvRoomSearch.SelectedRows[0].Cells[5].Value.ToString();

                lblCusForename.Text = dgvRoomSearch.SelectedRows[0].Cells[6].Value.ToString();
                lblCusSurname.Text = dgvRoomSearch.SelectedRows[0].Cells[7].Value.ToString();
                lblBookingPayment.Text = dgvRoomSearch.SelectedRows[0].Cells[8].Value.ToString();
                lblBookingPartySize.Text = dgvRoomSearch.SelectedRows[0].Cells[9].Value.ToString();

                picCancel.Visible = true;
            }
        }

        //Row Clicked Items
        private void dgvItemSearch_Click(object sender, EventArgs e)
        {
            searchOption = 1;
            if (dgvItemSearch.SelectedRows.Count == 0)
            {
                itemSel = false;
            }
            else if (dgvItemSearch.SelectedRows.Count == 1)
            {
                itemSel = true;

                dgvRoomSearch.Visible = false;
                dgvItemSearch.Visible = true;

                pnlRoom.Visible = false;
                pnlItem.Visible = true;

                lblRoomNo.Text = dgvItemSearch.SelectedRows[0].Cells[0].Value.ToString();
                lblItemBookNo.Text = dgvItemSearch.SelectedRows[0].Cells[1].Value.ToString();
                lblItemNo.Text = dgvItemSearch.SelectedRows[0].Cells[2].Value.ToString();

                string desc = dgvItemSearch.SelectedRows[0].Cells[3].Value.ToString();
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
                    lblDescription.Text = s1 + "\n" + s2;
                }
                else if (two)
                {
                    s1 = desc.Substring(0, break1);
                    s2 = desc.Substring(break1 + 1, (break2 - (break1 + 1)));
                    s3 = desc.Substring(break2 + 1, (max - (break2 + 1)));
                    lblDescription.Text = s1 + "\n" + s2 + "\n" + s3;
                }
                else if (three)
                {
                    s1 = desc.Substring(0, break1);
                    s2 = desc.Substring(break1 + 1, (break2 - (break1 + 1)));
                    s3 = desc.Substring(break2 + 1, (break3 - (break2 + 1)));
                    s4 = desc.Substring(break3 + 1, (max - (break3 + 1)));
                    lblDescription.Text = s1 + "\n" + s2 + "\n" + s3 + "\n" + s4;
                }
                else
                {
                    lblDescription.Text = desc;
                }
                                
                lblItemTypeDescription.Text = dgvItemSearch.SelectedRows[0].Cells[4].Value.ToString();
                decimal price = Math.Round(Convert.ToDecimal(dgvItemSearch.SelectedRows[0].Cells[5].Value.ToString()), 2);
                lblPrice.Text = price.ToString();
                lblQty.Text = dgvItemSearch.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        //Form Load
        private void RoomServiceSearch_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            

            //SQL for BookingItems
            sqlBookingItem = @"SELECT Bi.itemNo, Bi.bookingNo AS 'Booking Number', Bk.checkInDate AS 'Check In Date', Bk.checkOutDate AS 'Check Out Date', 
                            Bk.customerNo AS 'Customer Number', C.customerTitle AS 'Title', C.customerForename AS 'Forename', C.customerSurname AS 'Surname', 
                            P.paymentTypeDesc AS 'Payment Type', Bk.partySize AS 'Party Size' FROM BookingItem Bi
                            LEFT JOIN Booking Bk ON bk.bookingNo = Bi.bookingNo
                            LEFT JOIN Customer C on C.customerNo = Bk.customerNo
                            LEFT JOIN Payment P on P.paymentTypeID = Bk.paymentTypeID
                            WHERE itemNo LIKE '%RM%'
                            ORDER BY itemNo ASC";
            daBookingItem = new SqlDataAdapter(sqlBookingItem, connStr);
            cmdBBookingItem = new SqlCommandBuilder(daBookingItem);
            daBookingItem.FillSchema(dsBelfray, SchemaType.Source, "BookItem");
            daBookingItem.Fill(dsBelfray, "BookItem");

            //SQL for BookingDetails
            sqlBookingDets = @"SELECT Bd.itemNo, Bd.bookingNo AS 'Booking Number', Bd.bookingItemNo, It.itemDesc, 
                                Ty.typeDesc AS 'Type', It.itemPrice AS 'Price', Bd.bookingItemQty AS 'Qty' FROM BookingDetails Bd
                                LEFT JOIN Item It ON It.itemNo = Bd.bookingItemNo
                                LEFT JOIN BType Ty ON Ty.typeID = It.typeID
                                WHERE Bd.itemNo LIKE '%RM%'";
            daBookingDets = new SqlDataAdapter(sqlBookingDets, connStr);
            cmdBBookingDets = new SqlCommandBuilder(daBookingDets);
            daBookingDets.FillSchema(dsBelfray, SchemaType.Source, "BookingDets");
            daBookingDets.Fill(dsBelfray, "BookingDets");

            //SQL For Customer
            sqlCustomer = @"select * from Customer";
            daCustomer = new SqlDataAdapter(sqlCustomer, connStr);
            cmdBCustomer = new SqlCommandBuilder(daCustomer);
            daCustomer.FillSchema(dsBelfray, SchemaType.Source, "Customer");
            daCustomer.Fill(dsBelfray, "Customer");

            //SQL For Payment Type
            sqlPayType = @"select * from Payment";
            daPayType = new SqlDataAdapter(sqlPayType, connStr);
            cmdBPayType = new SqlCommandBuilder(daPayType);
            daPayType.FillSchema(dsBelfray, SchemaType.Source, "Payment");
            daPayType.Fill(dsBelfray, "Payment");


            displayRooms();
            displayItems();
        } 
        
        //Display Rooms
        public void displayRooms()
        {
            dgvRoomSearch.DataSource = dsBelfray.Tables["BookItem"];

            dgvRoomSearch.Columns[0].HeaderText = "Room Number";

            dgvRoomSearch.Columns[0].Width = 82;
            dgvRoomSearch.Columns[1].Width = 82;
            dgvRoomSearch.Columns[2].Width = 81;
            dgvRoomSearch.Columns[3].Width = 81;
            dgvRoomSearch.Columns[4].Width = 71;
            dgvRoomSearch.Columns[5].Width = 51;
            dgvRoomSearch.Columns[6].Width = 71;
            dgvRoomSearch.Columns[7].Width = 71;
            dgvRoomSearch.Columns[8].Width = 61;
            dgvRoomSearch.Columns[9].Width = 61;
        }

        //Display Items
        public void displayItems()
        {
            dgvItemSearch.DataSource = dsBelfray.Tables["BookingDets"];

            dgvItemSearch.Columns[0].HeaderText = "Room Number";
            dgvItemSearch.Columns[2].HeaderText = "Item Number";
            dgvItemSearch.Columns[3].HeaderText = "Item Description";

            dgvItemSearch.Columns[0].Width = 72;
            dgvItemSearch.Columns[1].Width = 90;
            dgvItemSearch.Columns[2].Width = 82;
            dgvItemSearch.Columns[3].Width = 292;
            dgvItemSearch.Columns[4].Width = 72;
            dgvItemSearch.Columns[5].Width = 62;
            dgvItemSearch.Columns[6].Width = 42;
        }

        //Table Price Formatting
        private void dgvItemSearch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.CellStyle.Format = "N2";
            }
        }

        //Cancel Button Functions
        private void picCancel_MouseEnter(object sender, EventArgs e)
        {
            picCancel.BackColor = Color.FromArgb(205, 36, 36);
        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            dgvItemSearch.Visible = false;
            dgvRoomSearch.Visible = true;

            txtSearchItemName.Text = "";
            txtSearchItemNo.Text = "";
            txtSearchRoomNo.Text = "";

            pnlItem.Visible = false;
            pnlRoom.Visible = false;

            picCancel.Visible = false;
        }

        private void picCancel_MouseLeave(object sender, EventArgs e)
        {
            picCancel.BackColor = Color.Transparent;
        }
    }
}
