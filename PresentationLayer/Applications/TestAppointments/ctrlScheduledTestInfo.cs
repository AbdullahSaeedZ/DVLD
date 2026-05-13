using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Applications.TestAppointments
{
    public partial class ctrlScheduledTestInfo : UserControl
    {
        private int _TestAppointmentID = -1;
        private int _LocalApplicationID = -1;
        private int _TestID = -1;

        private clsTestAppointmentsBusiness _TestAppointment;
        private clsLocalDrivingLicenseApplicationsBusiness _LocalApplication;

        private clsTestTypesBusiness.enTestType _TestType = clsTestTypesBusiness.enTestType.Vision;
        public clsTestTypesBusiness.enTestType TestType
        {
            get { return _TestType; }
            private set
            {
                _TestType = value;
                lblTitle.Text = "Scheduled " + _TestType.ToString() + " " + lblTitle.Text;
            }
        }

        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        public ctrlScheduledTestInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID, clsTestTypesBusiness.enTestType TestType)
        {
            this.TestType = TestType;
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointmentsBusiness.FindByTestAppointmentID(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show($"Could not get info of Test Appointment with ID{TestAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;
            _LocalApplication = clsLocalDrivingLicenseApplicationsBusiness.FindLocalLicenseApplicationByID(_LocalApplicationID);

            if (_TestAppointment == null)
            {
                MessageBox.Show($"Could not get info of Local Application with ID{_TestAppointment.LocalDrivingLicenseApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTestTrials.Text = _LocalApplication.GetTotalTestTrialsPerTestType(_TestType).ToString();
            lblLocalApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseDrivingClass.Text = _LocalApplication.LicenseClassInfo.ClassName;
            lblApplicantName.Text = _LocalApplication.ApplicantPersonInfo.FullName;
            lblTestFees.Text = _TestAppointment.PaidFees.ToString();  // this is the test fees paid when scheduled appointment
            lblTestAppointmentDate.Text = _TestAppointment.AppointmentDate.ToShortDateString();

            _TestID = _TestAppointment.GetTestID();
            lblTestID.Text = _TestID == -1 ? "Not Assigned Yet" : _TestID.ToString();
        }
    }
}
