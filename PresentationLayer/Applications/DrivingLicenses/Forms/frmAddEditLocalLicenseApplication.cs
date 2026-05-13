using BusinessLayer;
using PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmAddEditLocalLicenseApplication : Form
    {
        // public event Action<int> OnUpdateDoneForPersonCard; 
        // public event Action<int> OnNewPersonAdded; 
        public event Action OnUpdateDoneForDGV;

        private int _localApplicationID = -1;
        clsLocalDrivingLicenseApplicationsBusiness _localApplication;
        clsApplicationTypesBusiness _localLicenseApplicationTypeInfo;
        clsLicenseClassesBusiness _selectedClassInComboBox;

        private enum enMode { eAddNewMode, eUpdateMode };
        private enMode _mode;

        public frmAddEditLocalLicenseApplication()
        {
            InitializeComponent();
            _mode = enMode.eAddNewMode;
        }
        public frmAddEditLocalLicenseApplication(int LocalApplicationID)
        {
            InitializeComponent();
            _localApplicationID = LocalApplicationID;
            _mode = enMode.eUpdateMode;
        }

        private void frmAddEditLocalLicenseApplication_Load(object sender, EventArgs e)
        {
            _FillLicenseClassesComboBox();
            _localLicenseApplicationTypeInfo = clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eNewLocalDrivingLicense);

            if (_mode == enMode.eAddNewMode)
            {
                _localApplication = new clsLocalDrivingLicenseApplicationsBusiness();
                _FillApplicationDefaultValues();
            }
            else
            {
                _localApplication = clsLocalDrivingLicenseApplicationsBusiness.FindLocalLicenseApplicationByID(_localApplicationID);
                if (_localApplication == null)
                {
                    MessageBox.Show("Could not get data of selected local application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
                else if (_localApplication.DoesHaveAnyAppointmentsRecords())
                {
                    _FillDeniedEditingInfo();
                }
                    _FillExistentApplicationInfoInForm();
            }
        }

        private void _FillLicenseClassesComboBox()
        {
            DataTable dt = clsLicenseClassesBusiness.GetAllLicenseClasses();

            foreach (DataRow row in dt.Rows)
            {
                cbLocalLicenseClasses.Items.Add(row["ClassName"]);
            }
        }
        private void _FillApplicationDefaultValues()
        {
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblApplicationFees.Text = _localLicenseApplicationTypeInfo.ApplicationTypeFees.ToString();
            lblCreatedByUser.Text = clsGlobal.CurrentUser.Username;
            cbLocalLicenseClasses.SelectedIndex = 2;
        }
        private void _FillExistentApplicationInfoInForm()
        {
            lblTitle.Text =  $"Edit Local Driving License Application with ID = {_localApplication.LocalDrivingLicenseApplicationID}";
            ctrlPersonCardWithSearch1.LoadInfo(_localApplication.ApplicantPersonID);
            ctrlPersonCardWithSearch1.FilterVisible = false;

            lblApplicationID.Text = _localApplication.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDate.Text = _localApplication.ApplicationDate.ToShortDateString();
            lblApplicationFees.Text = _localApplication.PaidFees.ToString();
            lblCreatedByUser.Text = _localApplication.CreatedByUserInfo.Username.ToString();
            cbLocalLicenseClasses.SelectedItem = _localApplication.LicenseClassInfo.ClassName;
        }

        private void _FillDeniedEditingInfo()
        {
            ctrlPersonCardWithSearch1.LoadInfo(_localApplication.ApplicantPersonID);
            ctrlPersonCardWithSearch1.FilterVisible = false;
            btnSave.Enabled = false;
            cbLocalLicenseClasses.Enabled = false;
            lblDeniedUpdate.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithSearch1.PersonID == -1)
            {
                MessageBox.Show($"Please select a person to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithSearch1.FilterFocus();
                return;
            }
            _ShowHideApplicationInfoPanel();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _ShowHideApplicationInfoPanel();
        }

        private void _ShowHideApplicationInfoPanel()
        {
            pnlApplicationInfo.Visible = !pnlApplicationInfo.Visible;
            btnBack.Visible = !btnBack.Visible;
            btnSave.Visible = !btnSave.Visible;
            btnNext.Visible = !btnNext.Visible;
        }

        private bool PerformValidation()
        {
            _selectedClassInComboBox = clsLicenseClassesBusiness.Find(cbLocalLicenseClasses.Text);

            if (!ctrlPersonCardWithSearch1.SelectedPerson.DoesMeetMinAllowedAge(_selectedClassInComboBox.MinimumAllowedAge))
            {
                MessageBox.Show($"Minimum allowed age for selected license class is {_selectedClassInComboBox.MinimumAllowedAge}, age requirements not met", 
                                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int activeNewApplicationID = clsLocalDrivingLicenseApplicationsBusiness.GetActiveLocalApplicationID(ctrlPersonCardWithSearch1.PersonID, _selectedClassInComboBox.LicenseClassID);
            if (activeNewApplicationID != -1)
            {
                MessageBox.Show($"This person already has an active new local driving license application of same class with ID = {activeNewApplicationID}, Please choose another class.",
                                 "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (clsLicensesBusiness.DidPersonIssueLicense(ctrlPersonCardWithSearch1.PersonID, _selectedClassInComboBox.LicenseClassID))
            {
                // another check for active issued license with same selected class
                MessageBox.Show("This person already has an issued driving license of same class, choose another class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!PerformValidation())
                return;

            if (_mode == enMode.eAddNewMode)
            {
                _localApplication.ApplicantPersonID = ctrlPersonCardWithSearch1.PersonID;
                _localApplication.LicenseClassID = _selectedClassInComboBox.LicenseClassID; 
                _localApplication.ApplicationStatus = clsApplicationsBusiness.enApplicationStatus.New;
                _localApplication.PaidFees = _localLicenseApplicationTypeInfo.ApplicationTypeFees;
                _localApplication.ApplicationTypeID = _localLicenseApplicationTypeInfo.ApplicationTypeID;
                _localApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            }
            else
            {
                _localApplication.LicenseClassID = _selectedClassInComboBox.LicenseClassID;
            }

            try
            {
                if (_localApplication.Save(clsGlobal.CurrentUser))
                {
                    MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _mode = enMode.eUpdateMode;
                    ctrlPersonCardWithSearch1.FilterVisible = false;
                    lblApplicationID.Text = _localApplication.LocalDrivingLicenseApplicationID.ToString();
                    lblTitle.Text = $"Edit Local Driving License Application with ID = {_localApplication.LocalDrivingLicenseApplicationID}";

                    OnUpdateDoneForDGV?.Invoke(); // to refresh dgv if Application info is updated
                }
                else
                    MessageBox.Show("Data was not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ControlBoxClose_Click(object sender, EventArgs e)
        {
            ctrlPersonCardWithSearch1.Dispose();
            this.Close();
        }

        private void frmAddEditLocalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithSearch1.FilterFocus();
        }
    }
}
