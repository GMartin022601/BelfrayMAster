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
using System.Globalization;

namespace Belfray
{
    public partial class RestaurantStockDelete : Form
    {
        //SQL links
        SqlDataAdapter daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drProduct, drProductType, drSupplier;
        String connStr, sqlProduct, sqlProductType, sqlSupplier;
        string prdSel = "";
        bool prdSelected;
        bool formLoad = true;
        int menuSel;

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string temp = "";

            if (dgvOptions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an option from the list.", "Select Option");
            }
            else
            {
                switch (menuSel)
                {
                    case 1:
                        drProduct = dsBelfray.Tables["Product"].Rows.Find(dgvOptions.SelectedRows[0].Cells[0].Value);
                        temp = drProduct["productDesc"].ToString();

                        if (MessageBox.Show("Are you sure you want to delete " + temp + " ?", "Delete Product", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            drProduct.Delete();
                            daProduct.Update(dsBelfray, "Product");
                            MessageBox.Show("Product: " + temp + " Successfully Deleted!");
                            clearProdPanel();
                        }
                        break;
                    case 2:
                        drProductType = dsBelfray.Tables["ProductType"].Rows.Find(dgvOptions.SelectedRows[0].Cells[0].Value);
                        temp = drProductType["productTypeDesc"].ToString();

                        if (MessageBox.Show("Are you sure you want to delete product type: " + temp + " ?", "Delete Product Type", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            drProductType.Delete();
                            daProductType.Update(dsBelfray, "ProductType");
                            MessageBox.Show("Product Type: " + temp + " Successfully Deleted!");
                            clearPTPanel();
                        }
                        break;
                    case 3:
                        drSupplier = dsBelfray.Tables["Supplier"].Rows.Find(dgvOptions.SelectedRows[0].Cells[0].Value);
                        temp = drSupplier["supplierName"].ToString();

                        if (MessageBox.Show("Are you sure you want to delete supplier: " + temp + " ?", "Delete Supplier", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            drSupplier.Delete();
                            daSupplier.Update(dsBelfray, "Supplier");
                            MessageBox.Show("Supplier " + temp + ": Successfully Deleted!");
                            clearSuppPanel();
                        }
                        break;
                }
            }

        }
        void clearSuppPanel()
        {
            lblSuName.Text = "";
            lblSuID.Text = "";
            lblSuAdd.Text = "";
            lblSuTown.Text = "";
            lblSuPC.Text = "";
            lblSuEma.Text = "";
            lblSuTel.Text = "";
        }
        void clearPTPanel()
        {
            lblPTC.Text = "";
            lblPTD.Text = "";
        }
        void clearProdPanel()
        {
            lblProdDesc.Text = "";
            lblProdCode.Text = "";
            lblProdNumber.Text = "";
            lblQty.Text = "";
            lblSupplierID.Text = "";
        }

        private void DgvOptions_Click(object sender, EventArgs e)
        {
            if (dgvOptions.SelectedRows.Count == 0)
            {
                prdSelected = false;
                Globals.prdNoSel = null;
            }
            else if (dgvOptions.SelectedRows.Count == 1)
            {
                prdSelected = true;
                Globals.prdNoSel = dgvOptions.SelectedRows[0].Cells[0].Value.ToString();
                //Product
                if (menuSel == 1)
                {
                    drProduct = dsBelfray.Tables["Product"].Rows.Find(Globals.prdNoSel.ToString());
                    pnlProduct.BringToFront();
                    pnlProdType.SendToBack();
                    pnlProduct.Visible = true;
                    lblProdDesc.Text = drProduct["productDesc"].ToString();
                    lblProdCode.Text = drProduct["productTypeCode"].ToString();
                    lblProdNumber.Text = drProduct["productNumber"].ToString();
                    lblQty.Text = drProduct["qtyInStock"].ToString();
                    lblSupplierID.Text = drProduct["supplierID"].ToString();
                    lblSuppName.Visible = false;
                    label2.Visible = false;
                }
                if (menuSel == 2)
                {
                    drProductType = dsBelfray.Tables["ProductType"].Rows.Find(Globals.prdNoSel.ToString());
                    pnlProduct.SendToBack();
                    pnlProdType.BringToFront();
                    pnlProdType.Visible = true;
                    lblPTC.Text = drProductType["productTypeCode"].ToString();
                    lblPTD.Text = drProductType["productTypeDesc"].ToString();
                }
                if (menuSel == 3)
                {
                    drSupplier = dsBelfray.Tables["Supplier"].Rows.Find(Globals.prdNoSel.ToString());
                    pnlProduct.SendToBack();
                    pnlProdType.SendToBack();
                    pnlSupplier.BringToFront();
                    pnlSupplier.Visible = true;
                    lblSuName.Text = drSupplier["supplierName"].ToString();
                    lblSuID.Text = drSupplier["supplierID"].ToString();
                    lblSuAdd.Text = drSupplier["supplierAddress"].ToString();
                    lblSuTown.Text = drSupplier["supplierTown"].ToString();
                    lblSuPC.Text = drSupplier["supplierPostCode"].ToString();
                    lblSuEma.Text = drSupplier["supplierEmail"].ToString();
                    lblSuTel.Text = drSupplier["supplierTelNo"].ToString();
                }

            }
        }


        private void CbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                if (cbSelect.Text == "Product")
                {
                    menuSel = 1;
                    pnlProdType.Visible = false;
                    pnlSupplier.Visible = false;
                    dgvOptions.Visible = true;
                    dgvOptions.DataSource = dsBelfray.Tables["Product"];
                    //Resize
                    dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //Format
                    dgvOptions.Columns[3].DefaultCellStyle.Format = "c2";
                    dgvOptions.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
                    //Headers
                    dgvOptions.Columns[0].HeaderCell.Value = "Product Number";
                    dgvOptions.Columns[1].HeaderCell.Value = "Product Type Code";
                    dgvOptions.Columns[2].HeaderCell.Value = "Description";
                    dgvOptions.Columns[3].HeaderCell.Value = "Cost Price";
                    dgvOptions.Columns[4].HeaderCell.Value = "Qty in Stock";
                    dgvOptions.Columns[5].HeaderCell.Value = "Pack Size";
                    dgvOptions.Columns[6].HeaderCell.Value = "Re-Order Level";
                    dgvOptions.Columns[7].HeaderCell.Value = "Supplier ID";
                }
                else if (cbSelect.Text == "Product Type")
                {
                    menuSel = 2;
                    pnlProduct.Visible = false;
                    pnlSupplier.Visible = false;
                    dgvOptions.Visible = true;
                    dgvOptions.DataSource = dsBelfray.Tables["ProductType"];
                    //Resize
                    dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //Headers
                    dgvOptions.Columns[0].HeaderCell.Value = "Product Type ID";
                    dgvOptions.Columns[1].HeaderCell.Value = "Description";
                }
                else if (cbSelect.Text == "Supplier")
                {
                    menuSel = 3;
                    pnlProdType.Visible = false;
                    pnlProduct.Visible = false;
                    dgvOptions.Visible = true;
                    dgvOptions.DataSource = dsBelfray.Tables["Supplier"];
                    //Resize
                    dgvOptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //Headers
                    dgvOptions.Columns[0].HeaderCell.Value = "Supplier ID";
                    dgvOptions.Columns[1].HeaderCell.Value = "Name";
                    dgvOptions.Columns[2].HeaderCell.Value = "Address";
                    dgvOptions.Columns[3].HeaderCell.Value = "Town";
                    dgvOptions.Columns[4].HeaderCell.Value = "County";
                    dgvOptions.Columns[5].HeaderCell.Value = "Postcode";
                    dgvOptions.Columns[6].HeaderCell.Value = "Email";
                    dgvOptions.Columns[7].HeaderCell.Value = "Telephone Number";
                }
            }
        }


        public RestaurantStockDelete()
        {
            InitializeComponent();
        }

        private void RestaurantStockDelete_Load(object sender, EventArgs e)
        {

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

            //panels
            pnlProduct.Visible = false;
            pnlProdType.Visible = false;
            pnlSupplier.Visible = false;

            formLoad = false;
        }
    }
}
