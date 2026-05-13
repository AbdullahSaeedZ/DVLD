using BusinessLayer;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using PresentationLayer.PeopleFormsAndControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageInternationalApplications
{
    public partial class ctrlManageInternationalApplications : UserControl
    {
        public event Action<UserControl> delRemoveFromMainFormContainer_ManageInternationalApplications;
        private DataTable dt;
        private string _searchFilter; // to use in search filters and match DT and DB column names, not dgv names
        private int _PersonID = -1;

        public ctrlManageInternationalApplications()
        {
            InitializeComponent();
        }

        private void ctrlManageInternationalApplications_Load(object sender, EventArgs e)
        {
            clsUtilities.AddToBreadcrumb("> Manage International Licenses Applications");
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if ((dt = clsInternationalLicensesBusiness.GetAllInternationalLicenses()) == null)
                return;

            dgvApplications.DataSource = dt;
            lblNumberOfRecords.Text = dgvApplications.RowCount.ToString();
        }


        // search Applications by..
        // controlling textBox based on comboBox option
        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // i will use this filter variable in the data table filter, and it has to match the DB column name not the one i used in combo box, the rest are ok
            _searchFilter = cbSearchBy.Text == "Int. License ID" ? "InternationalLicenseID" : cbSearchBy.Text == "L. License ID" ? "IssuedUsingLocalLicenseID" : cbSearchBy.Text.Replace(" ", "");

            if (_searchFilter == "None")
            {
                tbSearchApplication.Text = "";
                tbSearchApplication.Visible = false;
                cbIsActive.Visible = false;
                lblNumberOfRecords.Text = dgvApplications.RowCount.ToString(); // to update number when switching to none after being filtered
                return;
            }

            if (_searchFilter == "IsActive")
            {
                tbSearchApplication.Visible = false;
                cbIsActive.Visible = true;
                return;
            }

            cbIsActive.Visible = false;
            tbSearchApplication.Visible = true;
            tbSearchApplication.Text = "";
            tbSearchApplication.Focus();
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                dt.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvApplications.RowCount.ToString();
                return;
            }

            byte IsActive = cbIsActive.Text == "Active" ? (byte)1 : (byte)0;
            dt.DefaultView.RowFilter = $"IsActive = {IsActive}";
            lblNumberOfRecords.Text = dgvApplications.RowCount.ToString();
        }
        private void tbSearchApplication_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchApplication.Text))
            {
                dt.DefaultView.RowFilter = ""; // when deleting text
                lblNumberOfRecords.Text = dgvApplications.RowCount.ToString();
                return;
            }

            dt.DefaultView.RowFilter = $"Convert({_searchFilter}, 'System.String') LIKE '{tbSearchApplication.Text}%'";
            lblNumberOfRecords.Text = dgvApplications.RowCount.ToString();

            // filtering expression uses DataColumn Expression Language
            // it takes column names from dataTable that took them from Database, not header names in dgv
            //since like is for strings only and we might get int column, we cast column type to string using this method from DT special language
        }
        private void tbSearchApplication_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; // if Handled == true then will prevent any action
        }


        private void btnNewLicesnse_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmIssueInternationalLicense issueInternationalLicense = new frmIssueInternationalLicense();
            issueInternationalLicense.UpdateDGVOnLicenseIssued += RefreshDataGridView;
            clsUtilities.AddToBreadcrumb("> Add New Application");
            issueInternationalLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Add New Application");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUtilities.RemoveFromBreadcrumb("> Manage International Licenses Applications");
            delRemoveFromMainFormContainer_ManageInternationalApplications?.Invoke(this);
        }

        private void dgvApplications_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _PersonID = clsApplicationsBusiness.FindBaseApplicationByID((int)dgvApplications.CurrentRow.Cells[1].Value).ApplicantPersonID;
            showPersonInfoToolStripMenuItem_Click(sender, EventArgs.Empty);
        }


        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvApplications.RowCount == 0)
                return;

            _PersonID = clsApplicationsBusiness.FindBaseApplicationByID((int)dgvApplications.CurrentRow.Cells[1].Value).ApplicantPersonID;
        }
        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonInfo personInfo = new frmPersonInfo(_PersonID);
            clsUtilities.AddToBreadcrumb("> Person Info");
            personInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Person Info");
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            clsUtilities.AddToBreadcrumb($"> License Info");
            frmShowInternationalLicenseInfo internationalLicenseInfo = new frmShowInternationalLicenseInfo(LicenseID);
            internationalLicenseInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb($"> License Info");
        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDriverLicensesHistory licenseHistory = new frmDriverLicensesHistory(_PersonID);
            clsUtilities.AddToBreadcrumb("> Licenses History");
            licenseHistory.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Licenses History");
        }
    }
}
