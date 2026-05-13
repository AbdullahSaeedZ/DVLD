using BusinessLayer;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmRenewLicense : Form
    {
        private clsLicensesBusiness _RenewedLicense;

        public frmRenewLicense()
        {
            InitializeComponent();
        }

        private void frmRenewLicense_Load(object sender, EventArgs e)
        {
            _FillApplicationDefaultInfo();
        }

        private void frmRenewLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfoWithFilter1.FilterFocus();
        }

       
        private void _FillApplicationDefaultInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = (clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eRenewDrivingLicense)).ApplicationTypeFees.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
        }


        private void ctrlLocalDrivingLicenseInfoWithFilter1_OnLicenseSelected()
        {
            btnShowLicensesHistory.Enabled = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo != null;

            // when entering valid license then entering invalid license id in the same time
            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo == null)
            {
                btnRenewLicense.Enabled = false;
                return;
            }

            lblOldLicenseID.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            if (!_HandleBusinessConstraints())
            {
                btnRenewLicense.Enabled = false;
                return;
            }

            btnRenewLicense.Enabled = true;

            lblExpirationDate.Text = DateTime.Now.AddYears(ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseCLassInfo.DefaultValidityLength).ToShortDateString();
            lblLicenseFees.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseCLassInfo.ClassFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblApplicationFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
        }

        private bool _HandleBusinessConstraints()
        {
            // expired licenses are still active, we cant do any kind of operations on inactive licenses.

            if (!ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show($"Selected License is not Active, cannot renew inactive licenses", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License is not expired yet, expiration date is: {ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate.ToShortDateString()}",
                                  "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private void btnRenewLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to proceed with license renewal?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;

            try
            {
                _RenewedLicense = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(tbNotes.Text, clsGlobal.CurrentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (_RenewedLicense != null)
            {
                lblRenewedLicenseID.Text = _RenewedLicense.LicenseID.ToString();
                tbNotes.Enabled = false;
                btnShowNewLicenseInfo.Enabled = true;
                btnRenewLicense.Enabled = false;
                ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                MessageBox.Show($"License is renewed successfully with new ID {_RenewedLicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Failed to renew the license", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnShowRenewedLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowLocalLicenseInfo licensesInfo = new frmShowLocalLicenseInfo(_RenewedLicense.LicenseID);
            clsUtilities.AddToBreadcrumb("> License Info");
            licensesInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> License Info");
        }

        private void btnShowLicensesHistory_Click(object sender, EventArgs e)
        {
            frmDriverLicensesHistory licensesHistory = new frmDriverLicensesHistory(ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            clsUtilities.AddToBreadcrumb("> Licenses History");
            licensesHistory.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Licenses History");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
