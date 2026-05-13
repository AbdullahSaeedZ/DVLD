using BusinessLayer;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.TestAppointments.Forms
{
    public partial class frmTakeTest : Form
    {
        public event Action<bool> OnTestPerformed;

        private int _testAppointmentID;
        private clsTestTypesBusiness.enTestType _TestType;

        private int _TestID = -1;
        private clsTestsBusiness _Test;

        public frmTakeTest(int TestAppointmentID, clsTestTypesBusiness.enTestType TestType)
        {
            InitializeComponent();
            _testAppointmentID = TestAppointmentID;
            _TestType = TestType;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlScheduledTestInfo1.LoadInfo(_testAppointmentID, _TestType);

            if (ctrlScheduledTestInfo1.TestAppointmentID == -1)
            {
                MessageBox.Show("Could not get Test Appointment data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            if (ctrlScheduledTestInfo1.TestID != -1) // means there was a taken test so we just show info
            {
                _Test = clsTestsBusiness.FindByTestID(ctrlScheduledTestInfo1.TestID);

                if (_Test.TestResult)
                    rbPass.Checked = true;
                else
                    rbFail.Checked = true;

                tbTestNotes.Text = _Test.Notes;
                _OnlyShowInfo();
            }
            
        }

        private void _OnlyShowInfo()
        {
            lblDeniedUpdate.Visible = true;
            rbFail.Enabled = false;
            rbPass.Enabled = false;
            tbTestNotes.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to proceed with this test result? Test result cannot be changed later and appointment will be locked.", 
                                "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                return;

            _Test = new clsTestsBusiness();
            _Test.TestAppointmentID = _testAppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = tbTestNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                // appointment is locked automatically once test record is added (see adding query)
                MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _OnlyShowInfo();
                OnTestPerformed?.Invoke(_Test.TestResult);
            }
            else
                MessageBox.Show("Data was not saved successfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
