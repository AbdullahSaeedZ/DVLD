using BusinessLayer;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using PresentationLayer.PeopleFormsAndControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Drivers
{
    public partial class ctrlDrivers : UserControl
    {
        private DataTable dt;
        private string _searchFilter; // to use in search filters and match DT and DB column names, not dgv names

        public ctrlDrivers()
        {
            InitializeComponent();
        }

        private void ctrlDrivers_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if ((dt = clsDriversBusiness.GetAllDrivers()) == null)
                return;

            dgvDrivers.DataSource = dt;
            lblNumberOfRecords.Text = dgvDrivers.RowCount.ToString();
        }


        // search by..
        // controlling textBox based on comboBox option
        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchFilter = cbSearchBy.Text.Replace(" ", ""); // matching database names, not dgv. Full Name in dgv, to be FullName here to match DT & DB

            if (_searchFilter == "None")
            {
                tbSearchDrivers.Text = "";
                tbSearchDrivers.Visible = false;
                lblNumberOfRecords.Text = dgvDrivers.RowCount.ToString(); // to update number when switching to none after being filtered
                return;
            }

            tbSearchDrivers.Visible = true;
            tbSearchDrivers.Text = "";

            if (_searchFilter == "PersonID" || _searchFilter == "DriverID")
                tbSearchDrivers.PlaceholderText = "Only numbers allowed";
            else
                tbSearchDrivers.PlaceholderText = "Search..";

            tbSearchDrivers.Focus();
        }
        private void tbSearchDrivers_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchDrivers.Text))
            {
                dt.DefaultView.RowFilter = ""; // when deleting text
                lblNumberOfRecords.Text = dgvDrivers.RowCount.ToString();
                return;
            }

            dt.DefaultView.RowFilter = $"Convert({_searchFilter}, 'System.String') LIKE '{tbSearchDrivers.Text}%'";
            lblNumberOfRecords.Text = dgvDrivers.RowCount.ToString();

            // filtering expression uses DataColumn Expression Language
            // it takes column names from dataTable that took them from Database, not names in dgv
            //since like is for strings only and we might get int column, we cast column type to string using this method from DT special language
        }
        private void tbSearchDrivers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_searchFilter == "PersonID" || _searchFilter == "DriverID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; // if Handled == true then will prevent any action
        }


        // toolStrip menu
        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonInfo personInfo = new frmPersonInfo((int)dgvDrivers.CurrentRow.Cells[1].Value);
            clsUtilities.AddToBreadcrumb("> Person Info");
            personInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Person Info");
        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicensesHistory licenseHistory = new frmDriverLicensesHistory((int)dgvDrivers.CurrentRow.Cells[1].Value);
            clsUtilities.AddToBreadcrumb("> Licenses History");
            licenseHistory.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Licenses History");
        }

        private void dgvDrivers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showPersonInfoToolStripMenuItem_Click(sender, e);
        }
    }
}
