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
    public partial class StaffDisplay : Form
    {
        SqlDataAdapter daStaff;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBStaff;
        DataRow drStaff;
        String connStr, sqlStaff;

        public StaffDisplay()
        {
            InitializeComponent();
        }

        private void dgvStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                Globals.staffSel = null;
            }
            else if (dgvStaff.SelectedRows.Count == 1)
            {
                Globals.staffSel = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        //Form Load
        private void StaffDisplay_Load(object sender, EventArgs e)
        {
            dgvStaff.ClearSelection();

            //DB Connection
            connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            //connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Booking
            sqlStaff = @"SELECT staffID AS 'Staff ID', staffFName AS 'Forename', staffLName AS 'Surname', staffStreet AS 'Street', 
                            staffCity AS 'City', staffCounty AS 'County',  staffPcode AS 'Postcode', staffTelNo As 'Tel No', staffEmergName AS 'Emergency Contact',
                            staffEmergTel AS 'Emergency Tel No', staffLogin AS 'Login', accTypeID AS 'Account Type' FROM Staff";

            daStaff = new SqlDataAdapter(sqlStaff, connStr);
            daStaff.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daStaff.Fill(dsBelfray, "Staff");
            dgvStaff.DataSource = dsBelfray.Tables["Staff"];

            //Resize
            dgvStaff.Columns[0].Width = 96;
            dgvStaff.Columns[1].Width = 100;
            dgvStaff.Columns[2].Width = 100;
            dgvStaff.Columns[3].Width = 110;
            dgvStaff.Columns[4].Width = 70;
            dgvStaff.Columns[5].Width = 110;
            dgvStaff.Columns[6].Width = 112;
            dgvStaff.Columns[7].Width = 110;
            dgvStaff.Columns[8].Width = 108;
            dgvStaff.Columns[9].Width = 80;
            dgvStaff.Columns[10].Width = 80;
            dgvStaff.Columns[11].Width = 80;
        }
    }
}
