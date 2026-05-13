using BusinessLayer;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Global_Classes;
using PresentationLayer.PeopleFormsAndControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageLocalApplications.Controls
{
    public partial class ctrlLocalApplicationInfo : UserControl
    {
        public event Action CloseOnError;
        public int SelectedLocalApplicationID { get; private set; } //  if needed outside
        private clsLocalDrivingLicenseApplicationsBusiness _LocalApplication;
        public clsLocalDrivingLicenseApplicationsBusiness SelectedLocalApplication { get { return _LocalApplication; } }

        public int DrivingLicenseApplicationBorderThickness
        {
            set
            {
                pnlLocalApplicationInfo.BorderThickness = value;
            }
            get
            {
                return pnlLocalApplicationInfo.BorderThickness;
            }
        }
        public Color DrivingLicenseApplicationBorderColor
        {
            set
            {
                pnlLocalApplicationInfo.BorderColor = value;
            }
            get
            {
                return pnlLocalApplicationInfo.BorderColor;
            }
        }

        public int BasicApplicationBorderThickness
        {
            set
            {
                pnlBaseApplicationInfo.BorderThickness = value;
            }
            get
            {
                return pnlBaseApplicationInfo.BorderThickness;
            }
        }
        public Color BasicApplicationBorderColor
        {
            set
            {
                pnlBaseApplicationInfo.BorderColor = value;
            }
            get
            {
                return pnlBaseApplicationInfo.BorderColor;
            }
        }

        public ctrlLocalApplicationInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int LocalDrivingLicenseApplicationID)
        {
            _LocalApplication = clsLocalDrivingLicenseApplicationsBusiness.FindLocalLicenseApplicationByID(LocalDrivingLicenseApplicationID);

            if (_LocalApplication == null)
            {
                MessageBox.Show($"Local Driving License Application ID = {LocalDrivingLicenseApplicationID} was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseOnError?.Invoke();
                return;
            }
            SelectedLocalApplicationID = LocalDrivingLicenseApplicationID;
            _FillLocalApplicationInfo();
            _FillBaseApplicationInfo();
        }

        private void _FillLocalApplicationInfo()
        {
            lblLocalApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClassName.Text = _LocalApplication.LicenseClassInfo.ClassName;
            lblPassedTests.Text = _LocalApplication.TestsStatus.PassedTestsCount.ToString() + " out of 3";

            btnShowLicenseInfo.Visible = _LocalApplication.IsLicenseIssued();
        }

        private void _FillBaseApplicationInfo()
        {
            lblBaseApplicationID.Text = _LocalApplication.ApplicationID.ToString();
            lblApplicationStatus.Text = _LocalApplication.ApplicationStatus.ToString();
            lblApplicationLastStatus.Text = _LocalApplication.LastStatusDate.ToShortDateString();
            lblApplicationFees.Text = _LocalApplication.PaidFees.ToString();
            lblApplicationType.Text = _LocalApplication.ApplicationTypeInfo.ApplicationTypeTitle;
            lblApplicantFullName.Text = _LocalApplication.ApplicantPersonInfo.FullName;
            lblApplicationDate.Text = _LocalApplication.ApplicationDate.ToShortDateString();
            lblCreatedByUser.Text = _LocalApplication.CreatedByUserInfo.Username;
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            int LicenseID = clsLicensesBusiness.GetLicenseIDbyLocalApplicationID(_LocalApplication.LocalDrivingLicenseApplicationID);

            clsUtilities.AddToBreadcrumb("> License Info");
            frmShowLocalLicenseInfo licenseInfo = new frmShowLocalLicenseInfo(LicenseID);
            licenseInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> License Info");
        }

        private void btnShowPersonInfo_Click(object sender, EventArgs e)
        {
            if (_LocalApplication != null)
            {
                clsUtilities.AddToBreadcrumb("> Person Info");
                frmPersonInfo frmPersonInfo = new frmPersonInfo(_LocalApplication.ApplicantPersonID);
                frmPersonInfo.ShowDialog();
                clsUtilities.RemoveFromBreadcrumb("> Person Info");
            }
        }
    }
}
