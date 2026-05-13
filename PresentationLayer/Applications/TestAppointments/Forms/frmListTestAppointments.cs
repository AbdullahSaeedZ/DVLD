using BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Applications.TestAppointments.Forms
{
    public partial class frmListTestAppointments : Form
    {
        public event Action delUpdateLocalApplicationsDGV;

        private int _LocalApplicationID = -1;
        private clsTestTypesBusiness.enTestType _SelectedTestType; // this will determine which test type for the whole process
        private DataTable dt;

        public frmListTestAppointments(int LocalApplicationID, clsTestTypesBusiness.enTestType SelectedTestType)
        {
            InitializeComponent();
            _LocalApplicationID = LocalApplicationID;
            _SelectedTestType = SelectedTestType;
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            ctrlLocalApplicationInfo1.LoadInfo(_LocalApplicationID);

            if (_LocalApplicationID == -1 || ctrlLocalApplicationInfo1.SelectedLocalApplication == null)
            {
                MessageBox.Show("Could not get Local Driving License Application info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            lblTitle.Text = _SelectedTestType.ToString() + " " + lblTitle.Text;
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if ((dt = clsTestAppointmentsBusiness.GetAllTestAppointmentsByTestTypeID(_LocalApplicationID, _SelectedTestType)) == null)
                return;

            dgvTestAppointments.DataSource = dt;
            lblNumberOfRecords.Text = dgvTestAppointments.RowCount.ToString();
        }


        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            // active = scheduled unlocked appointment
            if (ctrlLocalApplicationInfo1.SelectedLocalApplication.IsThereActiveTestAppointment(_SelectedTestType))
            {
                MessageBox.Show("This person already has an active appointment for this test, you can not add a new appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // no active so person either didnt schedule appointment at all or has a locked one 
            clsTestsBusiness LastTestTaken = ctrlLocalApplicationInfo1.SelectedLocalApplication.GetLastTestPerTestType(_SelectedTestType);
            if (LastTestTaken == null)
            {
                // new appointment is allowed, the control inside will determine if new or new retake test appointment
                frmScheduleTestAppointment AddNewAppointment = new frmScheduleTestAppointment(_LocalApplicationID, _SelectedTestType);
                AddNewAppointment.delUpdateAppointmentsDGV += RefreshDataGridView;
                AddNewAppointment.ShowDialog();
                return;
            }
            else if (LastTestTaken.TestResult)
            {
                // locked with passed test ? not allowed
                MessageBox.Show("This person has performed and passed the test, cannot add new appointment of passed test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // locked with failed test allowed:
           // new appointment is allowed, the control inside will determine if new or new retake test appointment
            frmScheduleTestAppointment AddNewRetakeAppointment = new frmScheduleTestAppointment(_LocalApplicationID, _SelectedTestType);
            AddNewRetakeAppointment.delUpdateAppointmentsDGV += RefreshDataGridView;
            AddNewRetakeAppointment.ShowDialog();
        }

        // toolstrip menu options
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dgvTestAppointments.Rows.Count == 0)
                return;
            else
            {
                int SelectedAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;
                bool IsAppointmentLocked = (bool)dgvTestAppointments.CurrentRow.Cells[3].Value == true;

                clsTestsBusiness test = clsTestsBusiness.FindByTestAppointmentID(SelectedAppointmentID);
                if (test == null && IsAppointmentLocked)
                {
                    takeTestToolStripMenuItem.Text = "Take Test (Appointment Missed)";
                    takeTestToolStripMenuItem.Enabled = false;
                    return;
                }

                if (IsAppointmentLocked)
                    takeTestToolStripMenuItem.Text = "Show Taken Test Info";
                else
                    takeTestToolStripMenuItem.Text = "Take Test";
            }

           // removed selected testAppointment from here cuz user might just trigger this event without selecting any options of the menu
        }

        // done and tested when locked and unlocked
        private void editAppointmentDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // (not allowed to edit when locked, only show info) (allowed to edit when unlocked)
            int SelectedAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;

            frmScheduleTestAppointment editScheduledTestAppointment = new frmScheduleTestAppointment(_LocalApplicationID, _SelectedTestType, SelectedAppointmentID);
            editScheduledTestAppointment.delUpdateAppointmentsDGV += RefreshDataGridView;
            editScheduledTestAppointment.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedAppointmentID = (int)dgvTestAppointments.CurrentRow.Cells[0].Value;

            frmTakeTest takeTest = new frmTakeTest(SelectedAppointmentID, _SelectedTestType);
            takeTest.OnTestPerformed += UpdateInfoOnTestPerformed;
            takeTest.ShowDialog();
        }

        private void UpdateInfoOnTestPerformed(bool TestResult)
        {
            RefreshDataGridView(); // to update appointments dgv regardless of result

            if (TestResult)
            {
                ctrlLocalApplicationInfo1.LoadInfo(_LocalApplicationID); // to update passed tests count shown in the local application info control
                delUpdateLocalApplicationsDGV?.Invoke(); // update passed tests in the manage local applications form's dgv 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
