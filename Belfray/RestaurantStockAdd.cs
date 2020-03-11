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
    public partial class RestaurantStockAdd : Form
    {
        //SQL links
        SqlDataAdapter daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drProduct, drProductType, drSupplier;
        String connStr, sqlProduct, sqlProductType, sqlSupplier;

        //ADD Product Type Details
        private void picSaveADDPTD_Click(object sender, EventArgs e)
        {
            MyProdTypeCode myProdType = new MyProdTypeCode();
            bool ok = true;
            errP.Clear();
            //ErrP to be added!

            try
            {
                myProdType.ProdTypeCode = txtProdTypeCode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtProdTypeCode, MyEx.ToString());
            }
            try
            {
                myProdType.ProdTypeDesc = txtProdDesc2.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtProdDesc2, MyEx.ToString());
            }
            //Try Adding
            try
            {
                if (ok)
                {
                    drProductType = dsBelfray.Tables["ProductType"].NewRow();
                    drProductType["productTypeCode"] = myProdType.ProdTypeCode;
                    drProductType["productTypeDesc"] = myProdType.ProdTypeDesc;
                    dsBelfray.Tables["ProductType"].Rows.Add(drProductType);
                    daProductType.Update(dsBelfray, "ProductType");

                    MessageBox.Show("Product Added");
                    if (MessageBox.Show("Do you wish to add another product type?", "AddProductType", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        //clearAddPanel();
                        txtProdTypeCode.Text = "";
                        txtProdDesc2.Text = "";
                        //getProdNum(dsBelfray.Tables["ProductTy"].Rows.Count);
                    }
                    else
                    {
                        pnlProdType.Enabled = false;
                        txtProdTypeCode.Text = "";
                        txtProdDesc2.Text = "";
                        pnlDetails.Enabled = true;
                        clearAddPanel();

                        //cb ProductType
                        cbTypeCode.DataSource = dsBelfray.Tables["ProductType"];
                        cbTypeCode.ValueMember = "productTypeCode";
                        //cbTypeCode.DisplayMember = "productTypeDesc";
                        cbTypeCode.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        //End Add Product Type Details Save

        private void picAddNewPT_Click(object sender, EventArgs e)
        {
            pnlDetails.Enabled = false;
            pnlProdType.Enabled = true;

        }//end of add prod type

        

        //GetProductNumber
        private void getProdNum(int noRows)
        {
            drProduct = dsBelfray.Tables["Product"].Rows[noRows - 1];
            lblProductNumberDisplay.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
            //lblAddProdNum.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
        }
        //clear add panel
       void clearAddPanel()
        {
            txtProdDesc.Clear();
            txtPackSize.Clear();
            txtCostPrice.Clear();
            txtQTY.Clear();
            txtReOrder.Clear();
            cbSuppID.SelectedIndex = -1;
            cbTypeCode.SelectedIndex = -1;
        }


        private void picSaveAddProdDet_Click(object sender, EventArgs e)
        {
            MyProduct myProduct = new MyProduct();
            bool ok = true;

            //ErrP to be added!

            try
            {
                myProduct.ProductNo = lblProductNumberDisplay.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.ProductTypeCode = cbTypeCode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.ProductDesc = txtProdDesc.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.CostPrice = Convert.ToDouble(txtCostPrice.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.QtyInStock = Convert.ToInt32(txtQTY.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.PackSize = Convert.ToInt32(txtPackSize.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.ReOrderLvl = Convert.ToInt32(txtReOrder.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                MyEx.ToString();
            }
            try
            {
                myProduct.SupplierID = Convert.ToInt32(cbSuppID.Text.Trim());
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
                        clearAddPanel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        public RestaurantStockAdd()
        {
            InitializeComponent();

            //ToolTips for Buttons
            ToolTip tpAddNewPT = new ToolTip();
            tpAddNewPT.ShowAlways = true;
            tpAddNewPT.SetToolTip(picAddNewPT, "Add New Product Type");

            ToolTip tpAddNewSupp = new ToolTip();
            tpAddNewSupp.ShowAlways = true;
            tpAddNewSupp.SetToolTip(picAddNewSupp, "Add New Supplier");

            ToolTip tpSaveProduct = new ToolTip();
            tpSaveProduct.ShowAlways = true;
            tpSaveProduct.SetToolTip(picSaveAddProdDet, "Save New Product");

            //End of tooltips

            //PANEL PRODUCT TYPE AND SUPPLIER ARE NOT ENABLED
            //ENABLE ONCE ADD NEW IS PRESSED

        }

        private void RestaurantStockAdd_Load(object sender, EventArgs e)
        {
            //Current User
            //lblUser.Text = LoginPage.currUser;

            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Product
            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsBelfray, SchemaType.Source, "Product");
            daProduct.Fill(dsBelfray, "Product");

            //SQL For ProductType
            sqlProductType = @"select * from ProductType";
            daProductType = new SqlDataAdapter(sqlProductType, connStr);
            cmdBProduct = new SqlCommandBuilder(daProductType);
            daProductType.FillSchema(dsBelfray, SchemaType.Source, "ProductType");
            daProductType.Fill(dsBelfray, "ProductType");
            
            //SQL For Supplier
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);
            cmdBSupplier = new SqlCommandBuilder(daSupplier);
            daSupplier.FillSchema(dsBelfray, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsBelfray, "Supplier");

            //CB Details Supplier
            cbSuppID.DataSource = dsBelfray.Tables["Supplier"];
            cbSuppID.ValueMember = "supplierID";
            cbSuppID.DisplayMember = "supplierName";
            cbSuppID.SelectedIndex = -1;
            
            //cb ProductType
            cbTypeCode.DataSource = dsBelfray.Tables["ProductType"];
            cbTypeCode.ValueMember = "productTypeCode";
            //cbTypeCode.DisplayMember = "productTypeDesc";
            cbTypeCode.SelectedIndex = -1;
            //ProductTypePanel
            //cbTypeCode2.DataSource = dsBelfray.Tables["ProductType"];
            //cbTypeCode2.ValueMember = "productTypeCode";
            //cbTypeCode.DisplayMember = "productTypeDesc";
            //cbTypeCode2.SelectedIndex = -1;

            pnlDetails.Visible = true;
            pnlImage.Visible = true;
            pnlProdType.Visible = true;
            pnlSuppDetails.Visible = true;

            int noRows = dsBelfray.Tables["Product"].Rows.Count;

            if (noRows == 0)
            {
                lblProductNumberDisplay.Text = "1101";
            }
            else
            {
                getProdNum(noRows);
            }
        }
    }
}
