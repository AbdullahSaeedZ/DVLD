using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.TestAppointments.Forms
{
    public partial class frmShowAppointmentInfo : Form
    {
        private clsTestAppointmentsBusiness _TestAppointment;
        private clsLocalDrivingLicenseApplicationsBusiness _LocalApplication;
        private int _testAppointmentID = -1;

        public frmShowAppointmentInfo(int TestAppointmentID)
        {
            InitializeComponent();
            _testAppointmentID = TestAppointmentID;
        }

        private void frmShowAppointmentInfo_Load(object sender, System.EventArgs e)
        {
            if (_testAppointmentID == -1)
            {
                MessageBox.Show("Could not get Test Appointment ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestAppointment = clsTestAppointmentsBusiness.FindByTestAppointmentID(_testAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show($"Could not find info of Test Appointment ID {_testAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalApplication = clsLocalDrivingLicenseApplicationsBusiness.FindLocalLicenseApplicationByID(_TestAppointment.LocalDrivingLicenseApplicationID);

            if (_LocalApplication == null)
            {
                MessageBox.Show("Could not get Local Application Info of selected Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAppointmentID.Text = _TestAppointment.TestAppointmentID.ToString();
            lblLocalApplicationID.Text = _LocalApplication.LocalDrivingLicenseApplicationID.ToString();
            lblAppointmentDate.Text = _TestAppointment.AppointmentDate.ToString();
            lblLicenseDrivingClass.Text = _LocalApplication.LicenseClassInfo.ClassName;
            lblApplicantName.Text = _LocalApplication.ApplicantPersonInfo.FullName;

            lblTestTrials.Text = _LocalApplication.GetTotalTestTrialsPerTestType(_TestAppointment.TestTypeID).ToString();
            lblTestFees.Text = clsTestTypesBusiness.FindTestType(_TestAppointment.TestTypeID).TestTypeFees.ToString();
            lblTestType.Text = _TestAppointment.TestTypeID.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
