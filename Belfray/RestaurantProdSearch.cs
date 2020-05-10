using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;

namespace Belfray
{
    public partial class RestaurantProdSearch : Form
    {
        //SQL links
        SqlDataAdapter daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drProduct, drProductType, drSupplier;
        String connStr, sqlProduct, sqlProductType, sqlSupplier;
        int searchOption;

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            if (txtSupplier.Text.Length > 8)
            {
                MessageBox.Show("Supplier ID is a max 8 characters beginning SUP.", "Search error", MessageBoxButtons.OK);
                txtSupplier.Text = "";
            }
                txtProdDesc.Enabled = false;
                txtProdDesc.BackColor = Color.LightCoral;
                txtProdNumber.Enabled = false;
                txtProdNumber.BackColor = Color.LightCoral;
                txtProdType.Enabled = false;
                txtProdType.BackColor = Color.LightCoral;

            DataView supSearch = new DataView(dsBelfray.Tables["Product"], "supplierID LIKE '%" + txtSupplier.Text.ToString() + "%'", "supplierID", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = supSearch;

            if (txtSupplier.Text.Length == 0)
            {
                txtSupplier.Text = ""; 
                txtProdDesc.Enabled = true;
                txtProdDesc.BackColor = Color.White;
                txtProdNumber.Enabled = true;
                txtProdNumber.BackColor = Color.White;
                txtProdType.Enabled = true;
                txtProdType.BackColor = Color.White;
            }


        }

        private void txtProdType_TextChanged(object sender, EventArgs e)
        {
            if (txtProdType.Text.Length > 2)
            {
                MessageBox.Show("Product Type Code is 2 characters.", "Search error", MessageBoxButtons.OK);
                txtProdType.Text = "";
            }
            txtProdDesc.Enabled = false;
            txtProdDesc.BackColor = Color.LightCoral;
            txtProdNumber.Enabled = false;
            txtProdNumber.BackColor = Color.LightCoral;
            txtSupplier.Enabled = false;
            txtSupplier.BackColor = Color.LightCoral;

            DataView ptSearch = new DataView(dsBelfray.Tables["Product"], "productTypeCode LIKE '" + txtProdType.Text.ToString() + "%'", "productTypeCode", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = ptSearch;

            if (txtProdType.Text.Length == 0)
            {
                txtProdType.Text = "";
                txtProdDesc.Enabled = Enabled;
                txtProdDesc.BackColor = Color.White;
                txtProdNumber.Enabled = Enabled;
                txtProdNumber.BackColor = Color.White;
                txtSupplier.Enabled = Enabled;
                txtSupplier.BackColor = Color.White;
            }
        }
        private void txtProdDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtProdDesc.Text.Length > 30)
            {
                MessageBox.Show("Product description must be max 30 characters.", "Search error", MessageBoxButtons.OK);
                txtProdDesc.Text = "";
            }
            txtProdType.Enabled = false;
            txtProdType.BackColor = Color.LightCoral;
            txtProdNumber.Enabled = false;
            txtProdNumber.BackColor = Color.LightCoral;
            txtSupplier.Enabled = false;
            txtSupplier.BackColor = Color.LightCoral;

            if (txtProdDesc.Text.Length == 0)
            {
                txtProdDesc.Text = "";
                txtProdType.Enabled = Enabled;
                txtProdType.BackColor = Color.White;
                txtProdNumber.Enabled = Enabled;
                txtProdNumber.BackColor = Color.White;
                txtSupplier.Enabled = Enabled;
                txtSupplier.BackColor = Color.White;
            }

            DataView prdDSearch = new DataView(dsBelfray.Tables["Product"], "productDesc LIKE '%" + txtProdDesc.Text.ToString() + "%'", "productDesc", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = prdDSearch;
        }

        private void picClear_Click(object sender, EventArgs e)
        {
            dgvSearch.Visible = true;
            dgvSearch.DataSource = dsBelfray.Tables["Product"];
            //Resize
            dgvSearch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txtSupplier.Text = "";
            txtProdType.Text = "";
            txtProdNumber.Text = "";
        }


        public RestaurantProdSearch()
        {
            InitializeComponent();
        }

        private void txtProdNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtProdNumber.Text.Length > 10)
            {
                MessageBox.Show("Product number must be max 10 characters beginnin PRD.", "Search error", MessageBoxButtons.OK);
                txtProdNumber.Text = "";
            }
            txtProdType.Enabled = false;
            txtProdType.BackColor = Color.LightCoral;
            txtProdDesc.Enabled = false;
            txtProdDesc.BackColor = Color.LightCoral;
            txtSupplier.Enabled = false;
            txtSupplier.BackColor = Color.LightCoral;

            if (txtProdNumber.Text.Length == 0)
            {
                txtProdNumber.Text = "";
                txtProdType.Enabled = Enabled;
                txtProdType.BackColor = Color.White;
                txtProdDesc.Enabled = Enabled;
                txtProdDesc.BackColor = Color.White;
                txtSupplier.Enabled = Enabled;
                txtSupplier.BackColor = Color.White;
            }

            DataView prdSearch = new DataView(dsBelfray.Tables["Product"], "productNumber LIKE '%" + txtProdNumber.Text.ToString() + "%'", "productNumber", DataViewRowState.CurrentRows);
            dgvSearch.DataSource = prdSearch;
        }

        private void RestaurantProdSearch_Load(object sender, EventArgs e)
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

            dgvSearch.Visible = true;
            dgvSearch.DataSource = dsBelfray.Tables["Product"];
            //Resize
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Rename
            dgvSearch.Columns[0].HeaderCell.Value = "Product Number";
            dgvSearch.Columns[1].HeaderCell.Value = "Product Type Code";
            dgvSearch.Columns[2].HeaderCell.Value = "Product Description";
            dgvSearch.Columns[3].HeaderCell.Value = "Cost Price";
            dgvSearch.Columns[4].HeaderCell.Value = "Qty in Stock";
            dgvSearch.Columns[5].HeaderCell.Value = "Pack Size";
            dgvSearch.Columns[6].HeaderCell.Value = "Re-Order Level";
            dgvSearch.Columns[7].HeaderCell.Value = "Supplier ID";
            //Format
            dgvSearch.Columns[3].DefaultCellStyle.Format = "c2";
            dgvSearch.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
        }
    }
}