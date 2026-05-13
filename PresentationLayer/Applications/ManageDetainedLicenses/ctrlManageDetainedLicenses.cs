using BusinessLayer;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using PresentationLayer.PeopleFormsAndControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageDetainedLicenses
{
    public partial class ctrlManageDetainedLicenses : UserControl
    {
        public event Action<UserControl> delRemoveFromMainFormContainer_DetainLicenses;

        private DataTable dt;
        private string _searchFilter; // to use in search filters and match DT and DB column names, not dgv names
        private clsLicensesBusiness _SelectedLicense; // when need to show license history, instead of calling db twice in opening menu event and then in show history menu.


        public ctrlManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void ctrlManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            clsUtilities.AddToBreadcrumb("> Manage Detained Licenses");
            RefreshDataGridView();
        }


        private void RefreshDataGridView()
        {
            if ((dt = clsDetainedLicensesBusiness.GetAllDetainedLicenses()) == null)
                return;

            dgvDetainedLicenses.DataSource = dt;
            // To show a specific text when the value is null
            dgvDetainedLicenses.Columns["ReleaseApplicationID"].DefaultCellStyle.NullValue = "N/A";
            dgvDetainedLicenses.Columns["ReleaseDate"].DefaultCellStyle.NullValue = "N/A";
            lblNumberOfRecords.Text = dgvDetainedLicenses.RowCount.ToString();
        }


        // search Applications by..
        // controlling textBox based on comboBox option
        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // i will use this filter variable in the data table filter, and it has to match the DB column name not the one i used in combo box, the rest are ok
            _searchFilter = cbSearchBy.Text.Replace(" ", "");

            if (_searchFilter == "None")
            {
                tbSearch.Text = "";
                tbSearch.Visible = false;
                cbIsReleased.Visible = false;
                lblNumberOfRecords.Text = dgvDetainedLicenses.RowCount.ToString(); // to update number when switching to none after being filtered
                return;
            }

            if (_searchFilter == "IsReleased")
            {
                tbSearch.Visible = false;
                cbIsReleased.Visible = true;
                return;
            }

            cbIsReleased.Visible = false;
            tbSearch.Visible = true;
            tbSearch.Text = "";

            if (_searchFilter == "FullName" || _searchFilter == "NationalNo")
                 tbSearch.PlaceholderText = "Search..";
            else
                 tbSearch.PlaceholderText = "Only numbers allowed";



            tbSearch.Focus();
        }
        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt == null) return;

            if (cbIsReleased.Text == "All")
            {
                dt.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvDetainedLicenses.RowCount.ToString();
                return;
            }

            byte IsReleased = cbIsReleased.Text == "Yes" ? (byte)1 : (byte)0;
            dt.DefaultView.RowFilter = $"IsReleased = {IsReleased}";
            lblNumberOfRecords.Text = dgvDetainedLicenses.RowCount.ToString();
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                dt.DefaultView.RowFilter = ""; // when deleting text
                lblNumberOfRecords.Text = dgvDetainedLicenses.RowCount.ToString();
                return;
            }

            dt.DefaultView.RowFilter = $"Convert({_searchFilter}, 'System.String') LIKE '{tbSearch.Text}%'";
            lblNumberOfRecords.Text = dgvDetainedLicenses.RowCount.ToString();

            // filtering expression uses DataColumn Expression Language
            // it takes column names from dataTable that took them from Database, not header names in dgv
            //since like is for strings only and we might get int column, we cast column type to string using this method from DT special language
        }
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_searchFilter != "FullName" && _searchFilter != "NationalNo") 
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; // if Handled == true then will prevent any action
        }


        private void dgvDetainedLicenses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _SelectedLicense = clsLicensesBusiness.FindByLicenseID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            if (_SelectedLicense == null)
                return;
            showPersonDetailsToolStripMenuItem_Click(sender, EventArgs.Empty);
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eDetainLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDetainLicense detainLicense = new frmDetainLicense();
            clsUtilities.AddToBreadcrumb("> Detain License");
            detainLicense.UpdateDGVOnLicenseDetained += RefreshDataGridView;
            detainLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Detain License");
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eAddApplications))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmReleaseDetainedLicense releaseLicense = new frmReleaseDetainedLicense();
            clsUtilities.AddToBreadcrumb("> Release License");
            releaseLicense.UpdateDGVOnLicenseReleased += RefreshDataGridView;
            releaseLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Release License");
        }


        // tool strip menu
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvDetainedLicenses.RowCount <= 0)
            {
                contextMenuStrip1.Close();
                return;
            }
            // if i use detainInfo inside the selected license, it will get the last record of detention, but in dgv, use might select old detention records
            releaseDetainedLicenseToolStripMenuItem.Enabled = !clsDetainedLicensesBusiness.FindByDetainID((int)dgvDetainedLicenses.CurrentRow.Cells[0].Value).IsReleased;
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SelectedLicense = clsLicensesBusiness.FindByLicenseID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmPersonInfo personInfo = new frmPersonInfo(_SelectedLicense.DriverInfo.PersonID);
            clsUtilities.AddToBreadcrumb("> Person Details");
            personInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Person Details");
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SelectedLicense = clsLicensesBusiness.FindByLicenseID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmShowLocalLicenseInfo licenseInfo = new frmShowLocalLicenseInfo(_SelectedLicense.LicenseID);
            clsUtilities.AddToBreadcrumb("> License Details");
            licenseInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> License Details");
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _SelectedLicense = clsLicensesBusiness.FindByLicenseID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(_SelectedLicense.DriverInfo.PersonID);
            clsUtilities.AddToBreadcrumb("> Licenses History");
            licensesHistory.ShowDialog();

            clsUtilities.RemoveFromBreadcrumb("> Licenses History");
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eAddApplications))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _SelectedLicense = clsLicensesBusiness.FindByLicenseID((int)dgvDetainedLicenses.CurrentRow.Cells[1].Value);
            frmReleaseDetainedLicense releaseLicense = new frmReleaseDetainedLicense(_SelectedLicense.LicenseID);
            clsUtilities.AddToBreadcrumb("> Release License");
            releaseLicense.UpdateDGVOnLicenseReleased += RefreshDataGridView;
            releaseLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Release License");
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUtilities.RemoveFromBreadcrumb("> Manage Detained Licenses");
            delRemoveFromMainFormContainer_DetainLicenses?.Invoke(this);
        }

      
    }
}
