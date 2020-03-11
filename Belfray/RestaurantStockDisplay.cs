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
        SqlDataAdapter daProduct, daProductType, daSupplier;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBProduct, cmdBProductType, cmdBSupplier;
        DataRow drProduct, drProductType, drSupplier;
        String connStr, sqlProduct, sqlProductType, sqlSupplier;

        public RestaurantStockDisplay()
        {
            InitializeComponent();
            dgvRestStock.Visible = true;
            dgvRestStock.DataSource = dsBelfray.Tables["Product"];
            //Resize
            dgvRestStock.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void RestaurantStockDisplay_Load(object sender, EventArgs e)
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

            daProduct.FillSchema(dsBelfray, SchemaType.Source, "Product");
            daProduct.Fill(dsBelfray, "Product");

            //SQL For ProductType
            sqlProductType = @"select * from ProductType";
            daProductType = new SqlDataAdapter(sqlProductType, connStr);

            daProductType.FillSchema(dsBelfray, SchemaType.Source, "ProductType");
            daProductType.Fill(dsBelfray, "ProductType");

            //SQL For Supplier
            sqlSupplier = @"select * from Supplier";
            daSupplier = new SqlDataAdapter(sqlSupplier, connStr);

            daSupplier.FillSchema(dsBelfray, SchemaType.Source, "Supplier");
            daSupplier.Fill(dsBelfray, "Supplier");
        }
    }
}
