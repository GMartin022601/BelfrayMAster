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
    public partial class RestaurantStockAdd : Form
    {
        //SQL links
        SqlDataAdapter daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drProduct, drProductType, drSupplier;
        String connStr, sqlProduct, sqlProductType, sqlSupplier;
        bool formLoad = true;
        bool test = false;

        private void picCancellAddProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel adding Product Number: " + lblProductNumberDisplay.Text + "?", "Add Product", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            clearAddPanel();
            clearSuppPanel();
            txtProdTypeCode.Text = "";
            txtProdDesc2.Text = "";
            errP.Clear();
            //formLoad = true;
            test = true;
            this.Close();
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
                lblSupplierID.Text = "10001";
            }
            else
            {
                getProdNum(noRows);
            }

            string s = drProduct["supplierID"].ToString();
            string s1 = "SUP" + (Convert.ToInt32(s.Replace("SUP", "")) + 1).ToString().PadLeft(5, '0');

            lblSupplierID.Text = s1;
        }

        private void picSaveADDSupp_Click(object sender, EventArgs e)
        {
            MySupplier mySupp = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupp.SupplierID = lblSupplierID.Text.Trim();
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
                        test = true;
                    }
                    else
                    {
                        pnlSuppDetails.Enabled = false;
                        pnlDetails.Enabled = true;
                        clearSuppPanel();
                        test = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        private void CbTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!formLoad)
            {
                DataRow drMethod = dsBelfray.Tables["ProductType"].Rows.Find(cbTypeCode.SelectedValue.ToString());
                txtProdTypeCode.Text = drMethod["productTypeCode"].ToString();
                txtProdDesc2.Text = drMethod["productTypeDesc"].ToString();
            }
            if (test)
            {
                DataRow drMethod = dsBelfray.Tables["ProductType"].Rows.Find(cbTypeCode.SelectedValue.ToString());
                txtProdTypeCode.Text = drMethod["productTypeCode"].ToString();
                txtProdDesc2.Text = drMethod["productTypeDesc"].ToString();
            }
            if (txtProdDesc2.Text.Equals("Alcohol"))
            {
                //pnlImage.BringToFront();
                picAlcohol.Visible = true;
                picAlcohol.BringToFront();
            }
            if (txtProdDesc2.Text.Equals("Alcohol Free"))
            {
                //pnlImage.BringToFront();
                picAF.Visible = true;
                picAF.BringToFront();
            }
            if (txtProdDesc2.Text.Equals("Linen"))
            {
                //pnlImage.BringToFront();
                picLinen.Visible = true;
                picLinen.BringToFront();
            }
            if (txtProdDesc2.Text.Equals("Fresh Goods"))
            {
                //pnlImage.BringToFront();
                picFood.Visible = true;
                picFood.BringToFront();
            }
            if (txtProdDesc2.Text.Equals("Room Extras"))
            {
                //pnlImage.BringToFront();
                picRoomService.Visible = true;
                picRoomService.BringToFront();
            }

        }

        private void CbSuppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                DataRow drSuppCombo = dsBelfray.Tables["Supplier"].Rows.Find(cbSuppID.SelectedValue.ToString());
                lblSupplierID.Text = drSuppCombo["supplierID"].ToString();
                txtSuppName.Text = drSuppCombo["supplierName"].ToString();
                txtSuppAddress.Text = drSuppCombo["supplierAddress"].ToString();
                txtSuppCounty.Text = drSuppCombo["supplierCounty"].ToString();
                txtSuppTown.Text = drSuppCombo["supplierTown"].ToString();
                txtSuppPC.Text = drSuppCombo["supplierPostCode"].ToString();
                txtSuppEmail.Text = drSuppCombo["supplierEmail"].ToString();
                txtSuppTel.Text = drSuppCombo["supplierTelNo"].ToString();
            }
            if (test)
            {
                DataRow drSuppCombo = dsBelfray.Tables["Supplier"].Rows.Find(cbSuppID.SelectedValue.ToString());
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
        private void picSaveADDPTD_Click(object sender, EventArgs e)
        {
            MyProdTypeCode myProdType = new MyProdTypeCode();
            bool ok = true;
            errP.Clear();

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
                        txtProdTypeCode.Text = "";
                        txtProdDesc2.Text = "";
                        formLoad = true;
                        test = true;
                    }
                    else
                    {
                        pnlProdType.Enabled = false;
                        txtProdTypeCode.Text = "";
                        txtProdDesc2.Text = "";
                        pnlDetails.Enabled = true;
                        formLoad = true;
                        test = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
        private void picAddNewPT_Click(object sender, EventArgs e)
        {
            pnlDetails.Enabled = false;
            pnlProdType.Enabled = true;
            txtProdTypeCode.Text = "";
            txtProdDesc2.Text = "";

        }
        private void getProdNum(int noRows)
        {
            drProduct = dsBelfray.Tables["Product"].Rows[noRows - 1];
        }
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
                myProduct.ProductTypeCode = cbTypeCode.SelectedValue.ToString();
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
                myProduct.CostPrice = txtCostPrice.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtCostPrice, MyEx.toString());
            }
            try
            {
                myProduct.QtyInStock = txtQTY.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtQTY, MyEx.toString());
            }
            try
            {
                myProduct.PackSize = txtPackSize.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtPackSize, MyEx.toString());
            }
            try
            {
                myProduct.ReOrderLvl = txtReOrder.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(txtReOrder, MyEx.toString());
            }
            try
            {
                myProduct.SupplierID = cbSuppID.SelectedValue.ToString();
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
                        formLoad = true;
                        clearAddPanel();
                        getProdNum(dsBelfray.Tables["Product"].Rows.Count);
                        string s = drProduct["productNumber"].ToString();
                        string s1 = "PRD" + (Convert.ToInt32(s.Replace("PRD", "")) + 1).ToString().PadLeft(5, '0');
                        lblProductNumberDisplay.Text = s1;                        
                    }
                    else
                    {
                        this.Close();
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

        }

        private void RestaurantStockAdd_Load(object sender, EventArgs e)
        {
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

            pnlDetails.Visible = true;
            pnlImage.Visible = true;
            pnlProdType.Visible = true;
            pnlSuppDetails.Visible = true;

            formLoad = false;

            int noRows = dsBelfray.Tables["Product"].Rows.Count;

            if (noRows == 0)
            {
                lblProductNumberDisplay.Text = "PRD100000";
            }
            else
            {
                getProdNum(noRows);
            }

            string s = drProduct["productNumber"].ToString();
            string s1 = "PRD" + (Convert.ToInt32(s.Replace("PRD", "")) + 1).ToString().PadLeft(5, '0');
            lblProductNumberDisplay.Text = s1;
        }
    }
}
