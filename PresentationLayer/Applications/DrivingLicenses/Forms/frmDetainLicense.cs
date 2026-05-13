using BusinessLayer;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmDetainLicense : Form
    {
        public event Action UpdateDGVOnLicenseDetained;
        private int _DetainID = -1;


        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _FillDetentionDefaultInfo();
        }

        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfoWithFilter1.FilterFocus();
        }


        private void _FillDetentionDefaultInfo()
        {
            lblDetentionDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
        }


        private void ctrlLocalDrivingLicenseInfoWithFilter1_OnLicenseSelected()
        {
            btnShowLicensesHistory.Enabled = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo != null;

            // when entering valid license then entering invalid license id in the same time
            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo == null)
            {
                btnDetainLicense.Enabled = false;
                return;
            }

            lblLicenseID.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            if (!_HandleBusinessConstraints())
            {
                btnDetainLicense.Enabled = false; // to avoid putting valid license and enable the button then switch to invalid license
                return;
            }

            tbFineFees.Focus();
            btnDetainLicense.Enabled = true;
        }

        private bool _HandleBusinessConstraints()
        {
            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseDetained())
            {
                MessageBox.Show($"Selected License is already detained", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            
            if (MessageBox.Show("Are you sure to proceed with license detention?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;

            try
            {
                _DetainID = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DetainLicense(Convert.ToSingle(tbFineFees.Text.Trim()), clsGlobal.CurrentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
           
            if (_DetainID != -1)
            {
                lblDetainID.Text = _DetainID.ToString();
                btnShowDetainedLicenseInfo.Enabled = true;
                btnDetainLicense.Enabled = false;
                ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                tbFineFees.Enabled = false;
                UpdateDGVOnLicenseDetained?.Invoke();
                MessageBox.Show($"License is detained successfully with new detention ID {_DetainID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Failed to detain the license", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnShowDetainedLicenseInfo_Click(object sender, EventArgs e)
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

        private void tbFineFees_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFineFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFineFees, "Field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFineFees, null);
            }
        }
    }
}
