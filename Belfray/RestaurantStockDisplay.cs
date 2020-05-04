using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using System.Data.SqlClient;

namespace Belfray
{
    public partial class RestaurantStockDisplay : Form
    {
        //SQL links
        SqlDataAdapter daProduct;
        DataSet dsBelfray = new DataSet();
        String connStr, sqlProduct;
        //string prdSel = "";
        bool prdSelected;

        public RestaurantStockDisplay()
        {
            InitializeComponent();

        }

        private void DgvRestStock_Click(object sender, EventArgs e)
        {
            if (dgvRestStock.SelectedRows.Count == 0)
            {
                prdSelected = false;
                Globals.prdNoSel = null;
                //prdSel = null;
            }
            else if (dgvRestStock.SelectedRows.Count == 1)
            {
                prdSelected = true;
                Globals.prdNoSel = dgvRestStock.SelectedRows[0].Cells[0].Value.ToString();
                //prdSel = Globals.prdNoSel;
            }
        }

        private void RestaurantStockDisplay_Load(object sender, EventArgs e)
        {
            Globals.firstLoad = true;

            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Product
            sqlProduct = @"select * from Product";
            daProduct = new SqlDataAdapter(sqlProduct, connStr);

            daProduct.FillSchema(dsBelfray, SchemaType.Source, "Product");
            daProduct.Fill(dsBelfray, "Product");

            dgvRestStock.Visible = true;
            dgvRestStock.DataSource = dsBelfray.Tables["Product"];
            //Resize
            dgvRestStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //Rename
            dgvRestStock.Columns[0].HeaderCell.Value = "Product Number";
            dgvRestStock.Columns[1].HeaderCell.Value = "Product Type Code";
            dgvRestStock.Columns[2].HeaderCell.Value = "Product Description";
            dgvRestStock.Columns[3].HeaderCell.Value = "Cost Price";
            dgvRestStock.Columns[4].HeaderCell.Value = "Qty in Stock";
            dgvRestStock.Columns[5].HeaderCell.Value = "Pack Size";
            dgvRestStock.Columns[6].HeaderCell.Value = "Re-Order Level";
            dgvRestStock.Columns[7].HeaderCell.Value = "Supplier ID";
            //Format
            dgvRestStock.Columns[3].DefaultCellStyle.Format = "c2";
            dgvRestStock.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-GB");
        }
    }
}
