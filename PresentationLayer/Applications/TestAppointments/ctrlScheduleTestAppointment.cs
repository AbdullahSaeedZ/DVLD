using BusinessLayer;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.TestAppointments
{
    public partial class ctrlScheduleTestAppointment : UserControl
    {
        public event Action delUpdateAppointmentsDGV;
        public event Action OnCloseButtonClicked;
        public enum enMode { eAddMode = 0, eUpdateMode = 1 };
        public enum enCreationMode { eAddNewAppointmentMode = 0, eAddRetakeAppointmentMode = 1 }
        
        private enCreationMode _CreationMode;
        private enMode _FormMode;
        private int _testAppointmentID = -1;
        private int _LocalApplicationID = -1;
        private clsLocalDrivingLicenseApplicationsBusiness _LocalApplication;
        private clsTestAppointmentsBusiness _TestAppointment ;

        private clsTestTypesBusiness.enTestType _TestType = clsTestTypesBusiness.enTestType.Vision;
        public clsTestTypesBusiness.enTestType TestType
        {
            get { return _TestType; }
            private set
            {
                _TestType = value;
                lblTitle.Text = "Schedule " + _TestType.ToString() + " " + lblTitle.Text;
            }
        }

        public ctrlScheduleTestAppointment()
        {
            InitializeComponent();
        }

        public void LoadInfo(int LocalApplicationID, clsTestTypesBusiness.enTestType TestType, int TestAppointmentID = -1)
        {
            this.TestType = TestType;
            _testAppointmentID = TestAppointmentID;
            _LocalApplicationID = LocalApplicationID;
            _LocalApplication = clsLocalDrivingLicenseApplicationsBusiness.FindLocalLicenseApplicationByID(_LocalApplicationID);

            if (_LocalApplication == null)
            {
                MessageBox.Show("Could not get Local Application Info of selected Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            lblLocalApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseDrivingClass.Text = _LocalApplication.LicenseClassInfo.ClassName;
            lblApplicantName.Text = _LocalApplication.ApplicantPersonInfo.FullName;
            lblTestTrials.Text = _LocalApplication.GetTotalTestTrialsPerTestType(_TestType).ToString();

            if (_LocalApplication.DidAttendAppointmentOfTestType(_TestType))
            {
                _CreationMode = enCreationMode.eAddRetakeAppointmentMode;
                pnlRetakeAppInfo.Enabled = true;
                lblRetakeAppID.Text = "Not Assigned Yet";
                lblRetakeAppFees.Text = clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eRetakeTest).ApplicationTypeFees.ToString();
                lblTitle.Text = "Schedule Retake " + _TestType.ToString() + " Appointment";
            }
            else
            {
                _CreationMode = enCreationMode.eAddNewAppointmentMode;
                pnlRetakeAppInfo.Enabled = false;
                lblRetakeAppID.Text = "NA";
                lblRetakeAppFees.Text = "0";
            }

            if (TestAppointmentID == -1)
            {
                _FormMode = enMode.eAddMode;
                _TestAppointment = new clsTestAppointmentsBusiness();
                lblTestFees.Text = clsTestTypesBusiness.FindTestType(_TestType).TestTypeFees.ToString();
                dtpAppointmentDate.MinDate = DateTime.Today;
                dtpAppointmentDate.Value = DateTime.Now.AddMinutes(10);
                dtpTimePicker.Value = DateTime.Now.AddMinutes(10);
            }
            else
            {
                _FormMode = enMode.eUpdateMode;
                lblTitle.Text = "Edit " + _TestType.ToString() + " Test Appointment";

                if (!_LoadTestAppointmentInfoForUpdate())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblTestFees.Text) + Convert.ToSingle(lblRetakeAppFees.Text)).ToString();

            if (!_HandleActiveAppointmentConstraint())
                return;

            if (!_HandleLockedAppointmentConstraint())
                return;

            if (!_HandlePreviousAppointmentConstraint())
                return;
        }

        private bool _LoadTestAppointmentInfoForUpdate()
        {
            _TestAppointment = clsTestAppointmentsBusiness.FindByTestAppointmentID(_testAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show($"Could not find test appointment with ID{_testAppointmentID}.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            lblTestFees.Text = _TestAppointment.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
            {
                dtpAppointmentDate.MinDate = DateTime.Now;
                dtpTimePicker.MinDate = DateTime.Now;
            }
            else
            {
                // this case is when appointment date is in the past , so i dont want to enable editing cuz new appointment need to be scheduled
                lblUserMessage.Text = "You cannot change date of due or locked appointments";
                lblUserMessage.Visible = true;
                btnSave.Enabled = false;
                dtpTimePicker.Enabled = false;
                dtpAppointmentDate.Enabled = false;
            }

            dtpTimePicker.Value = _TestAppointment.AppointmentDate;
            dtpAppointmentDate.Value = _TestAppointment.AppointmentDate;

            if (_TestAppointment.RetakeTestApplicationID == -1) // the appointment which is shown for update might be from a retake test application type
            {
                pnlRetakeAppInfo.Enabled = false;
                lblRetakeAppFees.Text = "0";
                lblRetakeAppID.Text = "NA";
            }
            else
            {
                pnlRetakeAppInfo.Enabled = true;
                lblRetakeAppFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                lblRetakeAppID.Text = _TestAppointment.RetakeTestAppInfo.ApplicationID.ToString();
            }
            return true;
        }


        // those validations are done in previous forms, but since this is a custom user control and can use it anywhere, so we put the validations inside also
        // when trying to schedule new appointment and there is already an active appointment unlocked
        private bool _HandleActiveAppointmentConstraint()
        {
            if (_FormMode == enMode.eAddMode && _LocalApplication.IsThereActiveTestAppointment(_TestType))
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = $"Person already has an active appointment of {TestType} test, cannot schedule a new appointment";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                dtpTimePicker.Enabled = false;
                return false;
            }
            return true;
        }

        // when trying to edit locked appointment
        private bool _HandleLockedAppointmentConstraint()
        {
            if (_TestAppointment.IsLocked)
            {
                lblUserMessage.Visible = true;
                lblUserMessage.Text = $"Appointment is locked, cannot edit info";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                dtpTimePicker.Enabled = false;
                return false;
            }
            return true;
        }

        // when trying to schedule new appointment and there is locked appointment with passed result
        private bool _HandlePreviousAppointmentConstraint()
        {
            switch(_TestType)
            {
                case clsTestTypesBusiness.enTestType.Vision:
                    return true;

                case clsTestTypesBusiness.enTestType.Written:

                    if (!_LocalApplication.TestsStatus.IsVisionTestPassed)
                    {
                        lblUserMessage.Text = "Person needs to pass Vision test first to be able to proceed with next tests";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        dtpTimePicker.Enabled = false;
                        return false;
                    }
                    else
                        return true;

                case clsTestTypesBusiness.enTestType.Street:

                    if (!_LocalApplication.TestsStatus.IsWrittenTestPassed)
                    {
                        lblUserMessage.Text = "Person needs to pass Written test first to be able to proceed with next tests";
                        lblUserMessage.Visible = true;
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        dtpTimePicker.Enabled = false;
                        return false;
                    }
                    else
                        return true;
            }
            return true;
        }


        private bool _HandleCreatingRetakeApplication()
        {
            if (_FormMode == enMode.eAddMode && _CreationMode == enCreationMode.eAddRetakeAppointmentMode)
            {
                clsApplicationsBusiness RetakeTestApplication = new clsApplicationsBusiness();

                RetakeTestApplication.ApplicationTypeID = clsApplicationTypesBusiness.enApplicationTypes.eRetakeTest;
                RetakeTestApplication.ApplicationStatus = clsApplicationsBusiness.enApplicationStatus.New;
                RetakeTestApplication.ApplicantPersonID = _LocalApplication.ApplicantPersonID;
                RetakeTestApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                RetakeTestApplication.PaidFees = Convert.ToSingle(lblRetakeAppFees.Text);
                
                if (RetakeTestApplication.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = RetakeTestApplication.ApplicationID;
                    return true;
                }
                else
                    return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleCreatingRetakeApplication())
            {
                MessageBox.Show("Could not create a Retake application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalApplication.LocalDrivingLicenseApplicationID;
            _TestAppointment.TestTypeID = _TestType;
            _TestAppointment.PaidFees = Convert.ToSingle(lblTestFees.Text); // test appointment fees only
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;

            DateTime selectedAppointmentDate = dtpAppointmentDate.Value.Date + dtpTimePicker.Value.TimeOfDay;
            if (selectedAppointmentDate < DateTime.Now)
            {
                MessageBox.Show("Selected time cannot be in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestAppointment.AppointmentDate = selectedAppointmentDate;

            if (_TestAppointment.Save())
            {
                _FormMode = enMode.eUpdateMode;
                MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnClose.PerformClick();
                delUpdateAppointmentsDGV?.Invoke();
            }
            else
                MessageBox.Show("Data was saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnCloseButtonClicked?.Invoke();
        }
    }
}
