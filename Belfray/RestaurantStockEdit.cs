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
                clearSuppPanel();
                pnlSuppDetails.Enabled = false;
                pnlDetails.Enabled = true;
                errP.Clear();
            }
        }
        //cancel ptd edit
        private void BtnCancelEditPTD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancel the edit of Product Type Code: " + txtPTC.Text + "?", "Edit Product Type Code", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                pnlProdType.Enabled = false;
                txtPTC.Text = "";
                txtProdDesc2.Text = "";
                pnlDetails.Enabled = true;
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
                txtPTC.Enabled = true;
                txtProdDesc2.Enabled = true;
            }
            else if (chkBxEditPTD.Checked == false)
            {
                pnlProdType.Enabled = false;
                txtPTC.Enabled = false;
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
            cbSuppID.DisplayMember = "supplierName";
            cbSuppID.SelectedIndex = -1;

            //cb ProductType
            cbTypeCode.DataSource = dsBelfray.Tables["ProductType"];
            cbTypeCode.ValueMember = "productTypeCode";
            cbTypeCode.DisplayMember = "productTypeDesc";
            cbTypeCode.SelectedIndex = 0;

            //Panels
            pnlDetails.Visible = true;
            pnlImage.Visible = true;
            pnlProdType.Visible = true;
            pnlSuppDetails.Visible = true;

            //Fill Form
            //lblProdNo.Text = prdNoSelected.ToString();
        }
    }
}
