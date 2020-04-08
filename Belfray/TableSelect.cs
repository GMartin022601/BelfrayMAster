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
    public partial class TableSelect : Form
    {
        public TableSelect()
        {
            InitializeComponent();
        }

        private void tbl1_MouseHover(object sender, EventArgs e)
        {
            string s1 = "Table Number: 1\n";
            string s2 = "Party Size: 2\n";
            string s3 = "Increase Size: Yes";
            ToolTip tpTable1 = new ToolTip();
            tpTable1.ShowAlways = true;
            tpTable1.ToolTipTitle = "Table Information";
            tpTable1.ToolTipIcon = ToolTipIcon.Info;
            tpTable1.SetToolTip(tbl1, s1 + s2 + s3);
        }

        private void tbl2_MouseEnter(object sender, EventArgs e)
        {
            string s1 = "Table Number: 2\n";
            string s2 = "Party Size: 2\n";
            string s3 = "Increase Size: Yes";
            ToolTip tpTable2 = new ToolTip();
            tpTable2.ShowAlways = true;
            tpTable2.ToolTipTitle = "Table Information";
            tpTable2.ToolTipIcon = ToolTipIcon.Info;
            tpTable2.SetToolTip(tbl2, s1  + s2 + s3);
        }
    }
}
