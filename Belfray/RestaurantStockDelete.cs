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

        private void BtnDelete_Click(object sender, EventArgs e)
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
                        }
                        break;
                }

            }
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
            }
        }


        private void CbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoad)
            {
                if (cbSelect.Text == "Product")
                {
                    menuSel = 1;
                    dgvOptions.Visible = true;
                    dgvOptions.DataSource = dsBelfray.Tables["Product"];
                    //Resize
                    dgvOptions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else if (cbSelect.Text == "Product Type")
                {
                    menuSel = 2;
                    dgvOptions.Visible = true;
                    dgvOptions.DataSource = dsBelfray.Tables["ProductType"];
                    //Resize
                    dgvOptions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else if (cbSelect.Text == "Supplier")
                {
                    menuSel = 3;
                    dgvOptions.Visible = true;
                    dgvOptions.DataSource = dsBelfray.Tables["Supplier"];
                    //Resize
                    dgvOptions.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }


        public RestaurantStockDelete()
        {
            InitializeComponent();
            //picTabDelete.BackColor = Color.FromArgb(233, 233, 233);
            //picTabDelete.BackColor = Color.FromArgb(63, 63, 63);
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

            formLoad = false;
        }
    }
}
