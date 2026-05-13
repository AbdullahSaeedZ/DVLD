using BusinessLayer;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmReleaseDetainedLicense : Form
    {
        public event Action UpdateDGVOnLicenseReleased;
        private int _LicenseID = -1;


        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            if (_LicenseID == -1) // means form opened by default constructor
                return;

            ctrlLocalDrivingLicenseInfoWithFilter1.LoadInfo(_LicenseID);
            ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void frmReleaseDetainedLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfoWithFilter1.FilterFocus();
        }

        private void ctrlLocalDrivingLicenseInfoWithFilter1_OnLicenseSelected()
        {
            btnShowLicensesHistory.Enabled = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo != null;
            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo == null)
            {
                btnReleaseLicense.Enabled = false;
                return;
            }

            lblLicenseID.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();
            if (!_HandleBusinessConstraints())
            {
                btnReleaseLicense.Enabled = false; // to avoid putting valid license and enable the button then switch to invalid license
                _ResetDetentionInfo();
                return;
            }

            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo == null)
            {
                MessageBox.Show($"Selected License Detention info is not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillDetentionInfo();
            btnReleaseLicense.Enabled = true;
        }

        private bool _HandleBusinessConstraints()
        {
            if (!ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseDetained())
            {
                MessageBox.Show($"Selected License is not detained", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _FillDetentionInfo()
        {
            lblDetainID.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainID.ToString();
            lblDetentionDate.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.DetainDate.ToShortDateString();
            lblApplicationFees.Text = clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eReleaseDetainedDrivingLicense).ApplicationTypeFees.ToString();
            lblFineFees.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DetainedInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblFineFees.Text) + Convert.ToSingle(lblApplicationFees.Text)).ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
        }
        private void _ResetDetentionInfo()
        {
            lblDetainID.Text = "NA";
            lblDetentionDate.Text = "NA";
            lblApplicationFees.Text = "NA";
            lblFineFees.Text = "NA";
            lblTotalFees.Text = "NA";
            lblCreatedByUser.Text = "NA";
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to proceed with license release?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;

            int ReleaseApplicationID = -1;
            try
            {
                ReleaseApplicationID = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseLicense(clsGlobal.CurrentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (ReleaseApplicationID != -1)
            {
                lblApplicationID.Text = ReleaseApplicationID.ToString();
                btnShowReleasedLicenseInfo.Enabled = true;
                btnReleaseLicense.Enabled = false;
                ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                UpdateDGVOnLicenseReleased?.Invoke();
                MessageBox.Show($"License is released successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Failed to release the license", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnShowReleasedLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowLocalLicenseInfo licensesInfo = new frmShowLocalLicenseInfo(ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID);
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
