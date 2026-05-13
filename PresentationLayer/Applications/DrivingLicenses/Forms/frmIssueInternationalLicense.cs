using BusinessLayer;
using PresentationLayer.Drivers.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmIssueInternationalLicense : Form
    {
        public event Action UpdateDGVOnLicenseIssued;
        private int _InternationalLicenseID = -1;

        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {
            _FillApplicationDefaultInfo();
        }
        private void frmIssueInternationalLicense_Activated(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfoWithFilter1.FilterFocus();
        }
        private void _FillApplicationDefaultInfo()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = (clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eNewInternationalLicense)).ApplicationTypeFees.ToString();
            lblExpirationDate.Text = DateTime.Now.AddYears(1).ToShortDateString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
        }


        private void ctrlLocalDrivingLicenseInfoWithFilter1_OnLicenseSelected()
        {
            btnShowLicensesHistory.Enabled = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo != null;

            // when entering valid license then entering invalid license id in the same time
            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo == null)
            {
                btnIssueLicense.Enabled = false;
                return;
            }

            lblLocalLicenseID.Text = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseID.ToString();

            if (!_HandleBusinessConstraints())
            {
                btnIssueLicense.Enabled = false;
                return;
            }

            btnIssueLicense.Enabled = true;
        }

        private bool _HandleBusinessConstraints()
        {

            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassID != clsLicenseClassesBusiness.enLicenseClass.Class3Ordinary)
            {
                MessageBox.Show($"Local License Classification must be of Class-3-Ordinary type, not allowed to proceed", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show($"Local License is expired, not allowed to proceed", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show($"Local License is not active, not allowed to proceed", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // each person is allowed only one active international license
            _InternationalLicenseID = clsInternationalLicensesBusiness.GetActiveInterNationalLicenseIDByPersonID(ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            if (_InternationalLicenseID != -1)
            {
                MessageBox.Show($"Person already has an active International License with ID {_InternationalLicenseID}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        
        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to proceed with license issuance?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                return;

            int NewInternationalApplicationID = _HandleCreatingInternationalLicenseApplication();
            if (NewInternationalApplicationID == -1)
            {
                MessageBox.Show("Failed to create new International Driving License Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _InternationalLicenseID = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.IssueInternationalLicense(NewInternationalApplicationID, clsGlobal.CurrentUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if (_InternationalLicenseID != -1)
            {
                MessageBox.Show($"International License is successfully issued with ID {_InternationalLicenseID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInterLicenseID.Text = _InternationalLicenseID.ToString();
                btnShowLicenseInfo.Enabled = true;
                btnIssueLicense.Enabled = false;
                ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = false;
                UpdateDGVOnLicenseIssued?.Invoke();
            }
            else
                MessageBox.Show($"Data was not saved successfully", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int _HandleCreatingInternationalLicenseApplication()
        {
            
            clsApplicationsBusiness InternationalApplication = new clsApplicationsBusiness();

            InternationalApplication.ApplicationTypeID = clsApplicationTypesBusiness.enApplicationTypes.eNewInternationalLicense;
            InternationalApplication.ApplicationStatus = clsApplicationsBusiness.enApplicationStatus.New;
            InternationalApplication.ApplicantPersonID = ctrlLocalDrivingLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            InternationalApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            InternationalApplication.PaidFees = Convert.ToSingle(lblFees.Text);

            if (InternationalApplication.Save())
            {
                lblInterApplicationID.Text = InternationalApplication.ApplicationID.ToString();
                return InternationalApplication.ApplicationID;
            }
            else
                return -1;
        }


        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            frmShowInternationalLicenseInfo licensesInfo = new frmShowInternationalLicenseInfo(_InternationalLicenseID);
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
