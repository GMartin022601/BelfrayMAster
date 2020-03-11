using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belfray
{
    public partial class RestaurantStockAdd : Form
    {
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
            //End of tooltips

        }
    }
}
