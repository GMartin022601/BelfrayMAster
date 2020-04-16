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
        }
    }
}
