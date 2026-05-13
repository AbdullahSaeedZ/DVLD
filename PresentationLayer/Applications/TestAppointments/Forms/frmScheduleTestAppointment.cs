using BusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.TestAppointments.Forms
{
    public partial class frmScheduleTestAppointment : Form
    {
        public event Action delUpdateAppointmentsDGV;
    
        private clsTestTypesBusiness.enTestType _SelectedTestType; 
        private int _testAppointmentID = -1;
        private int _LocalApplicationID = -1;

        // default appointment parameter will tell the control if there is an existing appointment or nor
        public frmScheduleTestAppointment(int LocalApplicationID, clsTestTypesBusiness.enTestType SelectedTestType, int TestAppointmentID = -1)
        {
            InitializeComponent();
            _SelectedTestType = SelectedTestType;
            _testAppointmentID = TestAppointmentID;
            _LocalApplicationID = LocalApplicationID;
        }

        private void frmScheduleTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlScheduleTestAppointment1.delUpdateAppointmentsDGV += this.delUpdateAppointmentsDGV;
            ctrlScheduleTestAppointment1.LoadInfo(_LocalApplicationID, _SelectedTestType, _testAppointmentID);
        }

        private void ctrlScheduleTestAppointment1_OnCloseButtonClicked()
        {
            this.Close();
        }
    }
}
