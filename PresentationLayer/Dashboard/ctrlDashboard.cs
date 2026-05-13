using BusinessLayer;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Applications.TestAppointments.Forms;
using PresentationLayer.Dashboard;
using PresentationLayer.Global_Classes;
using PresentationLayer.PeopleFormsAndControls;
using PresentationLayer.UsersFormsAndControls;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.DashboardControls
{
    public partial class ctrlDashboard : UserControl
    {
        private int _TimerStop = 95;
        private int _TimerInitial = 0;
        private string _TimeNow;
        private string _DateNow;
        private clsDashboardBusiness _Data;
        private DataTable _dtTodaysAppointments;

        public ctrlDashboard()
        {
            InitializeComponent();
           
        }

        private void ctrlDashboard_Load(object sender, EventArgs e)
        {
            _Data = clsDashboardBusiness.GetDashboardData();
            if (_Data == null)
            {
                MessageBox.Show("Could not retrieve overview data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _DateNow = DateTime.Now.ToLongDateString();
            _TimeNow = DateTime.Now.ToLongTimeString();
            _StartTimers();
            _FillData();
        }

        private void _StartTimers()
        {
            timer1.Enabled = true;
            NumbersTimer.Enabled = true;
        }

        private void _FillData()
        {
            lblTodayDate.Text = _DateNow + "                  |                  " + _TimeNow;
            lblGoodMorningEvening.Text = "Good " + (DateTime.Now.Hour >= 12 ? "Evening, " : "Morning, ") + clsGlobal.CurrentUser.Person.FirstName + " !";

            progbTotalTestsPassed.Maximum = _Data.TotalTests;
            progbTotalTestsPassed.Value = _Data.TotalPassedTests;

            progbTotalCompletedApplications.Maximum = _Data.TotalApplications;
            progbTotalCompletedApplications.Value = _Data.TotalApplicationsCompleted;

            _LoadTodaysAppointments();
        }

        private void _LoadTodaysAppointments()
        {
            _dtTodaysAppointments = clsDashboardBusiness.GetTodaysAppointments();

            if (_dtTodaysAppointments == null)
            {
                lblNoAppointments.Visible = true;
                return;
            }

            foreach (DataRow row in _dtTodaysAppointments.Rows)
            {
                ctrlAppointmentItem appointment = new ctrlAppointmentItem();
                appointment.LoadInfo((int)row["TestAppointmentID"], (DateTime)row["AppointmentDate"], (bool)row["IsLocked"], (bool)row["IsTestTaken"]);
                fpnlTodaysAppointments.Controls.Add(appointment);
            }
        }


        // numbers timer
        private void NumbersTimer_Tick(object sender, EventArgs e)
        {
            if (_TimerInitial < _TimerStop)
            {
                _TimerInitial += 5;
                lblTotalExamxComplete.Text = $"{_TimerInitial} of {_TimerInitial}";
                lblTotalApplicationsCompleted.Text = $"{_TimerInitial} of {_TimerInitial}";
                lblTotalDrivers.Text = $"{_TimerInitial}";
                lblTotalUsers.Text = $"{_TimerInitial}";
                lblTotalPeople.Text = $"{_TimerInitial}";
                lblTotalLicenses.Text = $"{_TimerInitial}";
                lblTotalFeesThisMonth.Text = $"{_TimerInitial}";
                lblTotalFeesAllTime.Text = $"{_TimerInitial}";
            }
            else
            {
                NumbersTimer.Enabled = false;

                lblTotalExamxComplete.Text = $"{_Data.TotalPassedTests} of {_Data.TotalTests}";
                lblTotalApplicationsCompleted.Text = $"{_Data.TotalApplicationsCompleted} of {_Data.TotalApplications}";
                lblTotalDrivers.Text = _Data.TotalDrivers.ToString();
                lblTotalUsers.Text = _Data.TotalUsers.ToString();
                lblTotalPeople.Text = _Data.TotalPeople.ToString();
                lblTotalLicenses.Text = _Data.TotalLicenses.ToString();
                lblTotalFeesThisMonth.Text = _Data.TotalPaidFeesThisMonth.ToString();
                lblTotalFeesAllTime.Text = _Data.TotalPaidFeesAllTime.ToString();

                progbTotalTestsPassed.Value = _Data.TotalPassedTests;
                progbTotalCompletedApplications.Value = _Data.TotalApplicationsCompleted;
            }

        }

        // time seconds timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            _TimeNow = DateTime.Now.ToLongTimeString();
            lblTodayDate.Text = _DateNow + "                  |                  " + _TimeNow;
        }

        private void ctrlDashboard_Leave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            NumbersTimer.Enabled = false;
        }

        // quick actions buttons
        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense detain = new frmDetainLicense();
            clsUtilities.AddToBreadcrumb("> Detain License");
            detain.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Detain License");
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser addUser = new frmAddEditUser();
            clsUtilities.AddToBreadcrumb("> Add User");
            addUser.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Add User");
            
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addPerson = new frmAddEditPerson();
            clsUtilities.AddToBreadcrumb("> Add Person");
            addPerson.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Add Person");
        }

        private void btnShowLicenseInfo_Click(object sender, EventArgs e)
        {
            _RunEnterIDForm(frmEnterID.enInfoMode.eLicenseInfo);
        }

        private void ShowApplicationInfo_Click(object sender, EventArgs e)
        {
            _RunEnterIDForm(frmEnterID.enInfoMode.eApplicationInfo);
        }

        private void _RunEnterIDForm(frmEnterID.enInfoMode Mode)
        {
            frmEnterID enter = new frmEnterID(Mode);
            enter.ShowDialog();
        }

    }
}
