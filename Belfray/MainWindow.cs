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
    public partial class MainWindow : Form
    {
        //Determines which menu option has been selected 
        //(Room Booking = 1, Cleaning Stock = 2, Table Booking = 3, Restaurant Stock = 4, User Profile = 5, Administraion = 6)
        public int menuSelected = 0;
        String prodNumSel = "";

        //SQL links
        SqlDataAdapter daLogin, daBooking, daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBLogin, cmdBBooking, cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drLogin, drBooking, drProduct, drProductType, drSupplier;
        String connStr, sqlLogin, sqlBooking, sqlProduct, sqlProductType, sqlSupplier;

        public MainWindow()
        {
            InitializeComponent();

            pnlMenu.BackColor = Color.FromArgb(233, 233, 233);
            pnlTabControl.BackColor = Color.FromArgb(63, 63, 63);
        }

        //clear add panel
        void clearAddPanel()
        {
            txtAddCP.Clear();
            txtAddPackSize.Clear();
            txtAddPD.Clear();
            txtAddPTD.Clear();
            txtAddQTY.Clear();
            txtAddReOrder.Clear();
            cbSuppID.SelectedIndex = -1;
        }

        //GetProductNumber
        private void getProdNum(int noRows)
        {
            drProduct = dsBelfray.Tables["Product"].Rows[noRows - 1];
            lblProductNumberDisplay.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
            lblAddProdNum.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
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

        private void picTabAdd_Click(object sender, EventArgs e)
        {
            if (menuSelected == 4)
            {
                Reset();
                pnlRestStockAdd.Visible = true;

                getProdNum(dsBelfray.Tables["Product"].Rows.Count);

            }
        }

        private void picSaveAddProdDet_Click(object sender, EventArgs e)
        {
            MyProduct myProduct = new MyProduct();
            bool ok = true;
            //ErrP to be added!

            try
            {
                myProduct.ProductNo = lblAddProdNum.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.ProductTypeCode = cbAddPTC1.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.ProductDesc = txtAddPD.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.CostPrice = Convert.ToDouble(txtAddCP.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.QtyInStock = Convert.ToInt32(txtAddQTY.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.PackSize = Convert.ToInt32(txtAddPackSize.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.ReOrderLvl = Convert.ToInt32(txtAddReOrder.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.SupplierID = Convert.ToInt32(cbAddSuppID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    drProduct = dsBelfray.Tables["Product"].NewRow();

                    drProduct["productNo"] = myProduct.ProductNo;
                    drProduct["productTypeCode"] = myProduct.ProductTypeCode;
                    drProduct["productDesc"] = myProduct.ProductDesc;
                    drProduct["costPrice"] = myProduct.CostPrice;
                    drProduct["qtyInStock"] = myProduct.QtyInStock;
                    drProduct["packSize"] = myProduct.PackSize;
                    drProduct["reorderLvl"] = myProduct.ReOrderLvl;
                    drProduct["supplierId"] = myProduct.SupplierID;

                    dsBelfray.Tables["Product"].Rows.Add(drProduct);
                    daProduct.Update(dsBelfray, "Product");

                    MessageBox.Show("Product Added");

                    if (MessageBox.Show("Do you wish to add another product?", "AddProduct", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearAddPanel();
                        getProdNum(dsBelfray.Tables["Product"].Rows.Count);
                    }
                    else
                    {
                        Reset();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void picEditCancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Product Number: " + lblProductNumberDisplay.Text + "?", "Edit Product", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                //NEEDS TO BE FINISHED TO RETURN OR MOVE TO ANOTHER SCREEN
            Reset();
            TabVisible();
            pnlRestStockEdit.Visible = false;
            pnlRestStock.Visible = true;
            dgvRestStock.Visible = true;
            dgvRestStock.DataSource = dsBelfray.Tables["Product"];
            //Resize
            dgvRestStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

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
            //Resets to welcome screen
            pnlWelcome.Visible = false;
            //pnlRoomBooking.Visible = false;
            pnlRestStock.Visible = false;
        }

        public void TabVisible()
        {
            //Makes the Tab controls visible
            picTabDisplay.Visible = true;
            picTabSearch.Visible = true;
            picTabAdd.Visible = true;
            picTabEdit.Visible = true;
            picTabDelete.Visible = true;
        }

        private void PicTabEdit_Click(object sender, EventArgs e)
        {
            if (menuSelected == 4) {
                Reset();
                pnlRestStockEdit.Visible = true;

                prodNumSel = Convert.ToString((dgvRestStock).SelectedRows[0].Cells[0].Value);

                if (prodNumSel == "0")
                {
                    MessageBox.Show("Error");
                }
                else
                  {
                    lblProductNumberDisplay.Text = prodNumSel.ToString();

                    drProduct = dsBelfray.Tables["Product"].Rows.Find(lblProductNumberDisplay.Text);
                    
                    if (drProduct["productTypeCode"].ToString() == "A")
                        cbTypeCode.SelectedIndex = 0;
                    if(drProduct["productTypeCode"].ToString() == "AF")
                        cbTypeCode.SelectedIndex = 1;
                    if(drProduct["productTypeCode"].ToString() == "L")
                        cbTypeCode.SelectedIndex = 2;
                    if (drProduct["productTypeCode"].ToString() == "RE")
                        cbTypeCode.SelectedIndex = 3;
                    if (drProduct["productTypeCode"].ToString() == "F")
                        cbTypeCode.SelectedIndex = 4;

                    txtProdDesc.Text = drProduct["productDesc"].ToString();
                    txtCostPrice.Text = drProduct["costPrice"].ToString();
                    txtQTY.Text = drProduct["qtyInStock"].ToString();
                    txtPackSize.Text = drProduct["packSize"].ToString();
                    txtReOrder.Text = drProduct["reorderLvl"].ToString();

                    if (drProduct["supplierID"].ToString() == "100")
                        cbSuppID.SelectedIndex = 0;
                    if (drProduct["supplierID"].ToString() == "101")
                        cbSuppID.SelectedIndex = 1;
                    if (drProduct["supplierID"].ToString() == "102")
                        cbSuppID.SelectedIndex = 2;

                    drProductType = dsBelfray.Tables["ProductType"].Rows.Find(cbTypeCode.Text.ToString());

                    if (drProductType["productTypeCode"].ToString() == "A")
                        cbTypeCode2.SelectedIndex = 0;
                    if (drProductType["productTypeCode"].ToString() == "AF")
                        cbTypeCode2.SelectedIndex = 1;
                    if (drProductType["productTypeCode"].ToString() == "L")
                        cbTypeCode2.SelectedIndex = 2;
                    if (drProductType["productTypeCode"].ToString() == "RE")
                        cbTypeCode2.SelectedIndex = 3;
                    if (drProductType["productTypeCode"].ToString() == "F")
                        cbTypeCode2.SelectedIndex = 4;

                    txtProdDesc2.Text = drProductType["productTypeDesc"].ToString();

                    drSupplier = dsBelfray.Tables["Supplier"].Rows.Find(cbSuppID.Text.ToString());

                    if (drSupplier["supplierID"].ToString() == "100")
                        cbSuppID2.SelectedIndex = 0;
                    if (drSupplier["supplierID"].ToString() == "101")
                        cbSuppID2.SelectedIndex = 1;
                    if (drSupplier["supplierID"].ToString() == "102")
                        cbSuppID2.SelectedIndex = 2;

                    txtSuppName.Text = drSupplier["supplierName"].ToString();
                    txtSuppAddress.Text = drSupplier["supplierAddress"].ToString();
                    txtSuppTown.Text = drSupplier["supplierTown"].ToString();
                    txtSuppCounty.Text = drSupplier["supplierCounty"].ToString();
                    txtSuppPC.Text = drSupplier["supplierPostCode"].ToString();
                    txtSuppEmail.Text = drSupplier["supplierEmail"].ToString();
                    txtSuppTel.Text = drSupplier["supplierTelNo"].ToString();

                }
                
            }
            else
            {
                pnlWelcome.Visible = true;

            }

            
        }

        public void TabReset()
        {
            //Makes the Tab controls invisible
            picTabDisplay.Visible = false;
            picTabSearch.Visible = false;
            picTabAdd.Visible = false;
            picTabEdit.Visible = false;
            picTabDelete.Visible = false;
        }

        private void picRoomBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Room Booking
            menuSelected = 1;

            Reset();
            TabVisible();
            pnlRoomBooking.Visible = true;
        }

        private void picRoomStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Cleaning Stock
            menuSelected = 2;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            //Logs out of the system by closing the main window and sending the use back to the log in screen
            this.Close();           
        }

        private void picTableBooking_Click(object sender, EventArgs e)
        {
            //Set menu option select to Table Booking
            menuSelected = 3;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picRestaurantStock_Click(object sender, EventArgs e)
        {
            //Set menu option select to Restaurant Stock
            menuSelected = 4;

            Reset();
            TabVisible();
            pnlRestStock.Visible = true;
            dgvRestStock.Visible = true;
            dgvRestStock.DataSource = dsBelfray.Tables["Product"];
            //Resize
            dgvRestStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void picAccount_Click(object sender, EventArgs e)
        {
            //Set menu option select to User Profile
            menuSelected = 5;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            //Set menu option select to Administration
            menuSelected = 6;

            Reset();
            TabVisible();
            //pnlRoomBooking.Visible = true;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Current User
            lblUser.Text = LoginPage.currUser;

            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Staff
            sqlLogin = @"select * from Staff";
            daLogin = new SqlDataAdapter(sqlLogin, connStr);
            cmdBLogin = new SqlCommandBuilder(daLogin);

            daLogin.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daLogin.Fill(dsBelfray, "Staff");

            //SQL for Booking
            sqlBooking = @"select * from Booking";
            daBooking = new SqlDataAdapter(sqlBooking, connStr);
            cmdBBooking = new SqlCommandBuilder(daLogin);

            daBooking.FillSchema(dsBelfray, SchemaType.Source, "Booking");
            daBooking.Fill(dsBelfray, "Booking");

            //SQL for Product
            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daLogin);

            daProduct.FillSchema(dsBelfray, SchemaType.Source, "Product");
            daProduct.Fill(dsBelfray, "Product");

            //SQL For ProductType
            sqlProductType = @"select * from ProductType";
            daProductType = new SqlDataAdapter(sqlProductType, connStr);
            cmdBProductType = new SqlCommandBuilder(daLogin);

            daProductType.FillSchema(dsBelfray, SchemaType.Source, "ProductType");
            daProductType.Fill(dsBelfray, "ProductType");

            //SQL For Supplier
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daLogin);

            daSupplier.FillSchema(dsBelfray, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsBelfray, "Supplier");

        }
    }
}
