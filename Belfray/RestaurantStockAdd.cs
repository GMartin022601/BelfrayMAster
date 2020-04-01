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
        bool formLoad = true;

        private void picCancellAddProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel adding Product Number: " + lblProductNumberDisplay.Text + "?", "Add Product", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            clearAddPanel();
            clearSuppPanel();
            txtProdTypeCode.Text = "";
            txtProdDesc2.Text = "";
            errP.Clear();
            //pnlDetails.Enabled = false;
            //pnlProdType.Enabled = false;
            //pnlSuppDetails.Enabled = false;
        }

        private void picCancelAddSupp_Click(object sender, EventArgs e)
        {
            clearSuppPanel();
            pnlSuppDetails.Enabled = false;
            pnlDetails.Enabled = true;
            errP.Clear();
        }

        private void picAddNewSupp_Click(object sender, EventArgs e)
        {
            pnlDetails.Enabled = false;
            pnlSuppDetails.Enabled = true;
            clearSuppPanel();

            int noRows = dsBelfray.Tables["Supplier"].Rows.Count;

            if (noRows == 0)
            {
                lblSupplierID.Text = "101";
            }
            else
            {
                getProdNum(noRows);
            }

            lblSupplierID.Text = (int.Parse(drProduct["supplierID"].ToString()) + 1).ToString();

        }

        private void picSaveADDSupp_Click(object sender, EventArgs e)
        {
            MySupplier mySupp = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupp.SupplierID = Convert.ToInt32(lblSupplierID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblSupplierID, MyEx.toString());
            }
            try
            {
                mySupp.SupplierName = txtSuppName.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppName, MyEx.toString());
            }
            try
            {
                mySupp.SupplierAddress = txtSuppAddress.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppAddress, MyEx.toString());
            }
            try
            {
                mySupp.SupplierTown = txtSuppTown.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppTown, MyEx.toString());
            }
            try
            {
                mySupp.SupplierCounty = txtSuppCounty.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppCounty, MyEx.toString());
            }
            try
            {
                mySupp.SupplierPostCode = txtSuppPC.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppPC, MyEx.toString());
            }
            try
            {
                mySupp.SupplierEmail = txtSuppEmail.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppEmail, MyEx.toString());
            }
            try
            {
                mySupp.SupplierTelNo = txtSuppTel.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtSuppTel, MyEx.toString());
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    drSupplier = dsBelfray.Tables["Supplier"].NewRow();
                    drSupplier["supplierID"] = mySupp.SupplierID;
                    drSupplier["supplierName"] = mySupp.SupplierName;
                    drSupplier["supplierAddress"] = mySupp.SupplierAddress;
                    drSupplier["supplierTown"] = mySupp.SupplierTown;
                    drSupplier["supplierCounty"] = mySupp.SupplierCounty;
                    drSupplier["supplierPostCode"] = mySupp.SupplierPostCode;
                    drSupplier["supplierEmail"] = mySupp.SupplierEmail;
                    drSupplier["supplierTelNo"] = mySupp.SupplierTelNo;
                    dsBelfray.Tables["Supplier"].Rows.Add(drSupplier);
                    daSupplier.Update(dsBelfray, "Supplier");

                    MessageBox.Show("Supplier Added");
                    if (MessageBox.Show("Do you wish to add another Supplier?", "AddSupplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        clearSuppPanel();
                    }
                    else
                    {
                        pnlSuppDetails.Enabled = false;
                        pnlDetails.Enabled = true;
                        clearSuppPanel();
                        clearAddPanel();

                        //cb ProductType
                        //cbSuppID.DataSource = dsBelfray.Tables["Supplier"];
                        //cbSuppID.ValueMember = "supplierID";
                        //cbSuppID.DisplayMember = "supplierName";
                        //cbSuppID.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        //**THIS NEEDS WORK**
        private void CbTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!formLoad)
            {
                DataRow drMethod = dsBelfray.Tables["ProductType"].Rows.Find(cbTypeCode.SelectedValue);
                txtProdTypeCode.Text = drMethod["productTypeCode"].ToString();
                txtProdDesc2.Text = drMethod["productTypeDesc"].ToString();
            }
        }

        private void CbSuppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                DataRow drSuppCombo = dsBelfray.Tables["Supplier"].Rows.Find(cbSuppID.SelectedValue);
                lblSupplierID.Text = drSuppCombo["supplierID"].ToString();
                txtSuppName.Text = drSuppCombo["supplierName"].ToString();
                txtSuppAddress.Text = drSuppCombo["supplierAddress"].ToString();
                txtSuppCounty.Text = drSuppCombo["supplierCounty"].ToString();
                txtSuppTown.Text = drSuppCombo["supplierTown"].ToString();
                txtSuppPC.Text = drSuppCombo["supplierPostCode"].ToString();
                txtSuppEmail.Text = drSuppCombo["supplierEmail"].ToString();
                txtSuppTel.Text = drSuppCombo["supplierTelNo"].ToString();

            }
        }

        private void picCancelADDPTD_Click(object sender, EventArgs e)
        {
            pnlProdType.Enabled = false;
            txtProdTypeCode.Text = "";
            txtProdDesc2.Text = "";
            pnlDetails.Enabled = true;
            clearAddPanel();
            errP.Clear();
        }

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
                errP.SetError(txtProdTypeCode, MyEx.toString());
            }
            try
            {
                myProdType.ProdTypeDesc = txtProdDesc2.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtProdDesc2, MyEx.toString());
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

                    MessageBox.Show("Product Type Added");
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
                       //cbTypeCode.DataSource = dsBelfray.Tables["ProductType"];
                       //cbTypeCode.ValueMember = "productTypeCode";
                       //cbTypeCode.DisplayMember = "productTypeDesc";
                       //cbTypeCode.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        //End Add Product Type Details Save
        
        //AddNew Product Type
        private void picAddNewPT_Click(object sender, EventArgs e)
        {
            pnlDetails.Enabled = false;
            pnlProdType.Enabled = true;
            txtProdTypeCode.Text = "";
            txtProdDesc2.Text = "";

        }
        //end of add prod type

        //GetProductNumber
        private void getProdNum(int noRows)
        {
            drProduct = dsBelfray.Tables["Product"].Rows[noRows - 1];
            //lblProductNumberDisplay.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
            //lblSupplierID.Text = (int.Parse(drProduct["supplierID"].ToString()) + 1).ToString();
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
        //clear supplier panel
        void clearSuppPanel()
        {
            lblSupplierID.Text = "";
            txtSuppAddress.Clear();
            txtSuppCounty.Clear();
            txtSuppEmail.Clear();
            txtSuppName.Clear();
            txtSuppPC.Clear();
            txtSuppTel.Clear();
            txtSuppTown.Clear();
        }

        //SaveProduct
        private void picSaveAddProdDet_Click(object sender, EventArgs e)
        {
            MyProduct myProduct = new MyProduct();
            bool ok = true;
            errP.Clear();
            //ErrP to be added!

            try
            {
                myProduct.ProductNo = lblProductNumberDisplay.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblProductNumberDisplay, MyEx.toString());
            }
            try
            {
                myProduct.ProductTypeCode = cbTypeCode.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cbTypeCode, MyEx.toString());
            }
            try
            {
                myProduct.ProductDesc = txtProdDesc.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtProdDesc, MyEx.toString());
            }
            try
            {
                myProduct.CostPrice = Convert.ToDouble(txtCostPrice.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCostPrice, MyEx.toString());
            }
            try
            {
                myProduct.QtyInStock = Convert.ToInt32(txtQTY.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtQTY, MyEx.toString());
            }
            try
            {
                myProduct.PackSize = Convert.ToInt32(txtPackSize.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPackSize, MyEx.toString());
            }
            try
            {
                myProduct.ReOrderLvl = Convert.ToInt32(txtReOrder.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtReOrder, MyEx.toString());
            }
            try
            {
                myProduct.SupplierID = Convert.ToInt32(cbSuppID.SelectedValue.ToString());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(cbSuppID, MyEx.toString());
            }

            //Try Adding
            try
            {
                if (ok)
                {
                    drProduct = dsBelfray.Tables["Product"].NewRow();
                    drProduct["productNumber"] = myProduct.ProductNo;
                    drProduct["productTypeCode"] = myProduct.ProductTypeCode;
                    drProduct["productDesc"] = myProduct.ProductDesc;
                    drProduct["costPrice"] = myProduct.CostPrice;
                    drProduct["qtyInStock"] = myProduct.QtyInStock;
                    drProduct["packSize"] = myProduct.PackSize;
                    drProduct["reorderLvl"] = myProduct.ReOrderLvl;
                    drProduct["supplierID"] = myProduct.SupplierID;

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

            ToolTip tpCancelAddProd = new ToolTip();
            tpCancelAddProd.ShowAlways = true;
            tpCancelAddProd.SetToolTip(picCancellAddProd, "Cancel Add New");

            ToolTip tpCancelAddPTD = new ToolTip();
            tpCancelAddPTD.ShowAlways = true;
            tpCancelAddPTD.SetToolTip(picCancelADDPTD, "Cancel Add New Product Type Details");

            ToolTip tpCancelAddSupp = new ToolTip();
            tpCancelAddSupp.ShowAlways = true;
            tpCancelAddSupp.SetToolTip(picCancelAddSupp, "Cancel Add New Supplier");

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
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Product
            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);
            cmdBProduct = new SqlCommandBuilder(daProduct);
            daProduct.FillSchema(dsBelfray, SchemaType.Source, "Product");
            daProduct.Fill(dsBelfray, "Product");

            //SQL For ProductType
            sqlProductType = @"select * from ProductType";
            daProductType = new SqlDataAdapter(sqlProductType, connStr);
            cmdBProductType = new SqlCommandBuilder(daProductType);
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
            cbTypeCode.DisplayMember = "productTypeDesc";
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

            formLoad = false;

            int noRows = dsBelfray.Tables["Product"].Rows.Count;

            if (noRows == 0)
            {
                lblProductNumberDisplay.Text = "1101";
            }
            else
            {
                getProdNum(noRows);
            }

            lblProductNumberDisplay.Text = (int.Parse(drProduct["productNumber"].ToString()) + 1).ToString();
        }
    }
}
