using BusinessLayer;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmIssueLicenseReplacement : Form
    {
        private clsLicensesBusiness _ReplacementLicense;
        private clsLicensesBusiness.enIssueReason _IssueReason = clsLicensesBusiness.enIssueReason.ReplacementForDamaged;


        public frmIssueLicenseReplacement()
        {
            InitializeComponent();
        }

        private void frmIssueLicenseReplacement_Load(object sender, EventArgs e)
        {
            _FillApplicationDefaultInfo();

        }

        private void frmIssueLicenseReplacement_Activated(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfoWithFilter1.FilterFocus();

        }

        private void _FillApplicationDefaultInfo()
        {
            // default, will change with radio buttons 
            lblApplicationFees.Text = (clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eDamagedDrivingLicenseReplacement)).ApplicationTypeFees.ToString();

            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
        }


        private void ctrlLocalDrivingLicenseInfoWithFilter1_OnLicenseSelected()
        {
            btnShowLicensesHistory.Enabled = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo != null;

            // when entering valid license then entering invalid license id in the same time
            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo == null)
            {
                btnReplaceLicense.Enabled = false;
                return;
            }

            lblOldLicenseID.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            if (!_HandleBusinessConstraints())
            {
                btnReplaceLicense.Enabled = false; // to avoid putting valid license and enable the button then switch to invalid license
                return;
            }

            btnReplaceLicense.Enabled = true;
        }

        private bool _HandleBusinessConstraints()
        {
            // expired licenses are still active, we cant do any kind of operations on inactive licenses.
            if (!ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show($"Selected License is not Active, cannot replace inactive licenses", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License is expired, cannot replace expired licenses, license must be renewed" ,"Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void rbDamagedType_CheckedChanged(object sender, EventArgs e)
        {
            _IssueReason = clsLicensesBusiness.enIssueReason.ReplacementForDamaged;
            lblTitle.Text = "Replacement for Damaged License";
            lblApplicationFees.Text = (clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eDamagedDrivingLicenseReplacement)).ApplicationTypeFees.ToString();
        }

        private void rbLostType_CheckedChanged(object sender, EventArgs e)
        {
            _IssueReason = clsLicensesBusiness.enIssueReason.ReplacementForLost;
            lblTitle.Text = "Replacement for Lost License";
            lblApplicationFees.Text = (clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eLostDrivingLicenseReplacement)).ApplicationTypeFees.ToString();
        }

        private void btnReplaceLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to proceed with license replacement?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;

            try
            {
                _ReplacementLicense = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.ReplaceLicense(_IssueReason, clsGlobal.CurrentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (_ReplacementLicense != null)
            {
                lblReplacementLicenseID.Text = _ReplacementLicense.LicenseID.ToString();
                btnShowNewLicenseInfo.Enabled = true;
                btnReplaceLicense.Enabled = false;
                ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                rbDamagedType.Enabled = false;
                rbLostType.Enabled = false;
                MessageBox.Show($"License is replaced successfully with new ID {_ReplacementLicense.LicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Failed to replace the license", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnShowNewLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowLocalLicenseInfo licensesInfo = new frmShowLocalLicenseInfo(_ReplacementLicense.LicenseID);
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
