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
    public partial class RestaurantStockEdit : Form
    {
        //SQL links
        SqlDataAdapter daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drProduct, drProductType, drSupplier;
        String connStr, sqlProduct, sqlProductType, sqlSupplier;
        bool formLoad = true;

        private void CbTypeCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                DataRow drMethod = dsBelfray.Tables["ProductType"].Rows.Find(cbTypeCode.SelectedValue);
                lblPTC.Text = drMethod["productTypeCode"].ToString();
                txtProdDesc2.Text = drMethod["productTypeDesc"].ToString();
            }
        }

        private void CbSuppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                DataRow drSuppCombo = dsBelfray.Tables["Supplier"].Rows.Find(cbSuppID.SelectedValue);
                lblESupplierID.Text = drSuppCombo["supplierID"].ToString();
                txtSuppName.Text = drSuppCombo["supplierName"].ToString();
                txtSuppAddress.Text = drSuppCombo["supplierAddress"].ToString();
                txtSuppCounty.Text = drSuppCombo["supplierCounty"].ToString();
                txtSuppTown.Text = drSuppCombo["supplierTown"].ToString();
                txtSuppPC.Text = drSuppCombo["supplierPostCode"].ToString();
                txtSuppEmail.Text = drSuppCombo["supplierEmail"].ToString();
                txtSuppTel.Text = drSuppCombo["supplierTelNo"].ToString();
            }
        }

        private void BtnCancProdDet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Product: " + lblProductNumberDisplay.Text + "?", "Edit Product", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //clearSuppPanel();
                //pnlSuppDetails.Enabled = false;
                //pnlDetails.Enabled = true;
                //pnlRestStockEdit.Visible = false;
                errP.Clear();
                this.Close();
                //MessageBox.Show("Press display to show Products.");
            }
        }

        private void PicSaveProductEdit_Click(object sender, EventArgs e)
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
            //try edit
            try
            {
                if (ok)
                {
                    drProduct.BeginEdit();
                    drProduct["productNumber"] = myProduct.ProductNo;
                    drProduct["productTypeCode"] = myProduct.ProductTypeCode;
                    drProduct["productDesc"] = myProduct.ProductDesc;
                    drProduct["costPrice"] = myProduct.CostPrice;
                    drProduct["qtyInStock"] = myProduct.QtyInStock;
                    drProduct["packSize"] = myProduct.PackSize;
                    drProduct["reorderLvl"] = myProduct.ReOrderLvl;
                    drProduct["supplierID"] = myProduct.SupplierID;
                    drProduct.EndEdit();
                    daProduct.Update(dsBelfray, "Product");
                    MessageBox.Show("Product Details Edited");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        //THIS DOESNT WORK
        private void PicSaveADDPTD_Click(object sender, EventArgs e)
        {
            MyProdTypeCode myProdType = new MyProdTypeCode();
            bool ok = true;
            errP.Clear();

            try
            {
                myProdType.ProdTypeCode = lblPTC.Text.Trim();
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblPTC, MyEx.toString());
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
                    drProductType.BeginEdit();
                    //drProductType["productTypeCode"] = myProdType.ProdTypeCode;
                    drProductType["productTypeDesc"] = myProdType.ProdTypeDesc;
                    drProductType.EndEdit();
                    daProductType.Update(dsBelfray, "ProductType");
                    pnlProdType.Enabled = false;
                    lblPTC.Enabled = false;
                    txtProdDesc2.Enabled = false;
                    chkBxEditPTD.Checked = false;

                    MessageBox.Show("Product Type Edited");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void PicSaveSupplier_Click(object sender, EventArgs e)
        {
            MySupplier mySupp = new MySupplier();
            bool ok = true;
            errP.Clear();

            try
            {
                mySupp.SupplierID = Convert.ToInt32(lblESupplierID.Text.Trim());
            }
            catch (MyException MyEx)
            {
                ok = false;
                errP.SetError(lblESupplierID, MyEx.toString());
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
                    drSupplier.BeginEdit();
                    //drSupplier["supplierID"] = mySupp.SupplierID;
                    drSupplier["supplierName"] = mySupp.SupplierName;
                    drSupplier["supplierAddress"] = mySupp.SupplierAddress;
                    drSupplier["supplierTown"] = mySupp.SupplierTown;
                    drSupplier["supplierCounty"] = mySupp.SupplierCounty;
                    drSupplier["supplierPostCode"] = mySupp.SupplierPostCode;
                    drSupplier["supplierEmail"] = mySupp.SupplierEmail;
                    drSupplier["supplierTelNo"] = mySupp.SupplierTelNo;
                    drSupplier.EndEdit();
                    daSupplier.Update(dsBelfray, "Supplier");
                    MessageBox.Show("Supplier Updated");
                    chkBxEditSupp.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.TargetSite + "", ex.Message + "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        //get prod num
        private void getProdNum(int noRows)
        {
            drProduct = dsBelfray.Tables["Product"].Rows[noRows - 1];
        }

        //clear supplier panl
        void clearSuppPanel()
        {
            lblESupplierID.Text = "";
            txtSuppAddress.Clear();
            txtSuppCounty.Clear();
            txtSuppEmail.Clear();
            txtSuppName.Clear();
            txtSuppPC.Clear();
            txtSuppTel.Clear();
            txtSuppTown.Clear();
        }
        //cancel edit supplier
        private void BtnCancelEditSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Supplier: " + txtSuppName.Text + "?", "Edit Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                //clearSuppPanel();
                pnlSuppDetails.Enabled = false;
                pnlDetails.Enabled = true;
                chkBxEditSupp.Checked = false;
                errP.Clear();
            }
        }
        //cancel ptd edit
        private void BtnCancelEditPTD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Product Type Code: " + lblPTC.Text + "?", "Edit Product Type Code", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                pnlProdType.Enabled = false;
                //lblPTC.Text = "";
                //txtProdDesc2.Text = "";
                pnlDetails.Enabled = true;
                chkBxEditPTD.Checked = false;
                //clearAddPanel();
                errP.Clear();
            }
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


        public RestaurantStockEdit()
        {
            InitializeComponent();
        }

        private void ChkBxEditPTD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxEditPTD.Checked)
            {
                pnlProdType.Enabled = true;
                lblPTC.Enabled = true;
                txtProdDesc2.Enabled = true;
            }
            else if (chkBxEditPTD.Checked == false)
            {
                pnlProdType.Enabled = false;
                lblPTC.Enabled = false;
                txtProdDesc2.Enabled =  false;
            }
        }

        private void ChkBxEditSupp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxEditSupp.Checked)
            {
                pnlSuppDetails.Enabled = true;
                lblESupplierID.Enabled = true;
                txtSuppAddress.Enabled = true;
                txtSuppCounty.Enabled = true;
                txtSuppEmail.Enabled = true;
                txtSuppName.Enabled = true;
                txtSuppPC.Enabled = true;
                txtSuppTel.Enabled = true;
                txtSuppTown.Enabled = true;                
            }
            else if (chkBxEditSupp.Checked == false)
            {
                pnlSuppDetails.Enabled = false;
                lblESupplierID.Enabled = false;
                txtSuppAddress.Enabled = false;
                txtSuppCounty.Enabled = false;
                txtSuppEmail.Enabled = false;
                txtSuppName.Enabled = false;
                txtSuppPC.Enabled = false;
                txtSuppTel.Enabled = false;
                txtSuppTown.Enabled = false;
            }
        }

        private void RestaurantStockEdit_Load(object sender, EventArgs e)
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
            cbSuppID.DisplayMember = "supplierID";
            cbSuppID.SelectedIndex = -1;

            //cb ProductType
            cbTypeCode.DataSource = dsBelfray.Tables["ProductType"];
            cbTypeCode.ValueMember = "productTypeCode";
            cbTypeCode.DisplayMember = "productTypeCode";
            cbTypeCode.SelectedIndex = -1;

            //Panels
            pnlDetails.Visible = true;
            pnlImage.Visible = true;
            pnlProdType.Visible = true;
            pnlSuppDetails.Visible = true;

            //Fill Form
            lblProductNumberDisplay.Text = Globals.prdNoSel.ToString();

            drProduct = dsBelfray.Tables["Product"].Rows.Find(lblProductNumberDisplay.Text);
            //drProductType = dsBelfray.Tables["ProductType"].Rows.Find(txtProdDesc2)
            //drProduct = dsBelfray.Tables["Product"].Rows.Find(cbTypeCode.SelectedValue);

            cbTypeCode.SelectedValue = drProduct["productTypeCode"].ToString();
            txtProdDesc.Text = drProduct["productDesc"].ToString();
            txtCostPrice.Text = drProduct["costPrice"].ToString();
            txtQTY.Text = drProduct["qtyInStock"].ToString();
            txtPackSize.Text = drProduct["packSize"].ToString();
            txtReOrder.Text = drProduct["reorderLvl"].ToString();
            cbSuppID.SelectedValue = drProduct["supplierID"].ToString();
            //ProductTypeCode
            drProductType = dsBelfray.Tables["ProductType"].Rows.Find(cbTypeCode.SelectedValue);
            lblPTC.Text = drProductType["productTypeCode"].ToString();
            txtProdDesc2.Text = drProductType["productTypeDesc"].ToString();
            //Supplier
            drSupplier = dsBelfray.Tables["Supplier"].Rows.Find(cbSuppID.SelectedValue);
            lblESupplierID.Text = drSupplier["supplierID"].ToString();
            txtSuppName.Text = drSupplier["supplierName"].ToString();
            txtSuppAddress.Text = drSupplier["supplierAddress"].ToString();
            txtSuppCounty.Text = drSupplier["supplierCounty"].ToString();
            txtSuppTown.Text = drSupplier["supplierTown"].ToString();
            txtSuppPC.Text = drSupplier["supplierPostCode"].ToString();
            txtSuppEmail.Text = drSupplier["supplierEmail"].ToString();
            txtSuppTel.Text = drSupplier["supplierTelNo"].ToString();

            formLoad = false;

        }
    }
}
