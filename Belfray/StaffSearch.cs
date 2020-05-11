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
    public partial class StaffSearch : Form
    {
        SqlDataAdapter daStaff, daStaffSearch;
        DataSet dsBelfray = new DataSet();
        SqlCommandBuilder cmdBStaff, cmdBStaffSearch;
        DataRow drStaff, drStaffSearch;
        String connStr, sqlStaff, sqlStaffSearch;

        private bool rowSel = false;

        private string rowSelected = "";

        public StaffSearch()
        {
            InitializeComponent();
        }

        private void StaffSearch_Load(object sender, EventArgs e)
        {
            //DB Connection
            //connStr = @"Data Source = (localdb)\MSSQLLocalDB; Initial catalog = BelfrayHotel; Integrated Security = true";
            //****Code for Seans Laptop*****
            //connStr = @"Data Source = .\SQLEXPRESS; Initial catalog = BelfrayHotel; Integrated Security = true";
            //Connection for Tech Machine***
            connStr = @"Data Source = .; Initial catalog = BelfrayHotel; Integrated Security = true";

            //SQL for Staff
            sqlStaff = @"SELECT staffID, staffFName, staffLName, staffStreet AS 'Street',
                            staffCity AS 'City', staffCounty AS 'County',  staffPcode AS 'Postcode', staffTelNo As 'Tel No', staffEmergName AS 'Emergency Contact',
                            staffEmergTel AS 'Emergency Tel No', staffLogin AS 'Login', accTypeID AS 'Account Type' FROM Staff
                            ORDER BY staffID";
            daStaff = new SqlDataAdapter(sqlStaff, connStr);
            daStaff.FillSchema(dsBelfray, SchemaType.Source, "Staff");
            daStaff.Fill(dsBelfray, "Staff");

            displayStaff();
        }

        //Data Grid Click
        private void dgvStaffSearch_Click(object sender, EventArgs e)
        {
            if (dgvStaffSearch.SelectedRows.Count == 0)
            {
                rowSel = false;
            }
            else if (dgvStaffSearch.SelectedRows.Count == 1)
            {
                rowSel = true;
                rowSelected = dgvStaffSearch.SelectedRows[0].Cells[0].Value.ToString();

                pnlStaffDets.Visible = true;

                lblStaffID.Text = dgvStaffSearch.SelectedRows[0].Cells[0].Value.ToString();
                lblStaffForename.Text = dgvStaffSearch.SelectedRows[0].Cells[1].Value.ToString();
                lblStaffSurname.Text = dgvStaffSearch.SelectedRows[0].Cells[2].Value.ToString(); ;
                lblStaffStreet.Text = dgvStaffSearch.SelectedRows[0].Cells[3].Value.ToString();
                lblStaffCity.Text = dgvStaffSearch.SelectedRows[0].Cells[4].Value.ToString();
                lblStaffCounty.Text = dgvStaffSearch.SelectedRows[0].Cells[5].Value.ToString();
                lblStaffPcode.Text = dgvStaffSearch.SelectedRows[0].Cells[6].Value.ToString();
                lblStaffTel.Text = dgvStaffSearch.SelectedRows[0].Cells[7].Value.ToString();
            }
        }

        //ID Text Changed
        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchID.Text.Length > 0)
            {
                txtSearchForename.Text = "";
                txtSearchSurname.Text = "";
            }

            DataView staffSearch = new DataView(dsBelfray.Tables["Staff"], "staffID LIKE '%" + txtSearchID.Text.ToString() + "%'", "staffID", DataViewRowState.CurrentRows);
            dgvStaffSearch.DataSource = staffSearch;

            dgvStaffSearch.Columns[0].HeaderText = "Staff ID";
            dgvStaffSearch.Columns[1].HeaderText = "Forename";
            dgvStaffSearch.Columns[2].HeaderText = "Surname";

            dgvStaffSearch.Sort(dgvStaffSearch.Columns[0], ListSortDirection.Ascending);

            //Resize
            dgvStaffSearch.Columns[0].Width = 96;
            dgvStaffSearch.Columns[1].Width = 100;
            dgvStaffSearch.Columns[2].Width = 100;
            dgvStaffSearch.Columns[3].Width = 110;
            dgvStaffSearch.Columns[4].Width = 70;
            dgvStaffSearch.Columns[5].Width = 110;
            dgvStaffSearch.Columns[6].Width = 112;
            dgvStaffSearch.Columns[7].Width = 110;
            dgvStaffSearch.Columns[8].Width = 108;
            dgvStaffSearch.Columns[9].Width = 80;
            dgvStaffSearch.Columns[10].Width = 80;
            dgvStaffSearch.Columns[11].Width = 80;
        }

        //Forename Text Changed
        private void txtSearchForename_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchForename.Text.Length > 0)
            {
                txtSearchID.Text = "";
                txtSearchSurname.Text = "";
            }

            DataView staffSearch = new DataView(dsBelfray.Tables["Staff"], "staffFname LIKE '%" + txtSearchForename.Text.ToString() + "%'", "staffFname", DataViewRowState.CurrentRows);
            dgvStaffSearch.DataSource = staffSearch;

            dgvStaffSearch.Columns[0].HeaderText = "Staff ID";
            dgvStaffSearch.Columns[1].HeaderText = "Forename";
            dgvStaffSearch.Columns[2].HeaderText = "Surname";

            dgvStaffSearch.Sort(dgvStaffSearch.Columns[0], ListSortDirection.Ascending);

            //Resize
            dgvStaffSearch.Columns[0].Width = 96;
            dgvStaffSearch.Columns[1].Width = 100;
            dgvStaffSearch.Columns[2].Width = 100;
            dgvStaffSearch.Columns[3].Width = 110;
            dgvStaffSearch.Columns[4].Width = 70;
            dgvStaffSearch.Columns[5].Width = 110;
            dgvStaffSearch.Columns[6].Width = 112;
            dgvStaffSearch.Columns[7].Width = 110;
            dgvStaffSearch.Columns[8].Width = 108;
            dgvStaffSearch.Columns[9].Width = 80;
            dgvStaffSearch.Columns[10].Width = 80;
            dgvStaffSearch.Columns[11].Width = 80;
        }

        //Surname Text Changed
        private void txtSearchSurname_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchSurname.Text.Length > 0)
            {
                txtSearchForename.Text = "";
                txtSearchID.Text = "";
            }

            DataView staffSearch = new DataView(dsBelfray.Tables["Staff"], "staffLName LIKE '%" + txtSearchSurname.Text.ToString() + "%'", "staffLName", DataViewRowState.CurrentRows);
            dgvStaffSearch.DataSource = staffSearch;

            dgvStaffSearch.Columns[0].HeaderText = "Staff ID";
            dgvStaffSearch.Columns[1].HeaderText = "Forename";
            dgvStaffSearch.Columns[2].HeaderText = "Surname";

            dgvStaffSearch.Sort(dgvStaffSearch.Columns[0], ListSortDirection.Ascending);

            //Resize
            dgvStaffSearch.Columns[0].Width = 96;
            dgvStaffSearch.Columns[1].Width = 100;
            dgvStaffSearch.Columns[2].Width = 100;
            dgvStaffSearch.Columns[3].Width = 110;
            dgvStaffSearch.Columns[4].Width = 70;
            dgvStaffSearch.Columns[5].Width = 110;
            dgvStaffSearch.Columns[6].Width = 112;
            dgvStaffSearch.Columns[7].Width = 110;
            dgvStaffSearch.Columns[8].Width = 108;
            dgvStaffSearch.Columns[9].Width = 80;
            dgvStaffSearch.Columns[10].Width = 80;
            dgvStaffSearch.Columns[11].Width = 80;
        }

        //Display Staff
        public void displayStaff()
        {
            dgvStaffSearch.DataSource = dsBelfray.Tables["Staff"];

            dgvStaffSearch.Columns[0].HeaderText = "Staff ID";
            dgvStaffSearch.Columns[1].HeaderText = "Forename";
            dgvStaffSearch.Columns[2].HeaderText = "Surname";

            dgvStaffSearch.Sort(dgvStaffSearch.Columns[0], ListSortDirection.Ascending);

            //Resize
            dgvStaffSearch.Columns[0].Width = 96;
            dgvStaffSearch.Columns[1].Width = 100;
            dgvStaffSearch.Columns[2].Width = 100;
            dgvStaffSearch.Columns[3].Width = 110;
            dgvStaffSearch.Columns[4].Width = 70;
            dgvStaffSearch.Columns[5].Width = 110;
            dgvStaffSearch.Columns[6].Width = 112;
            dgvStaffSearch.Columns[7].Width = 110;
            dgvStaffSearch.Columns[8].Width = 108;
            dgvStaffSearch.Columns[9].Width = 80;
            dgvStaffSearch.Columns[10].Width = 80;
            dgvStaffSearch.Columns[11].Width = 80;
        }
    }
}
