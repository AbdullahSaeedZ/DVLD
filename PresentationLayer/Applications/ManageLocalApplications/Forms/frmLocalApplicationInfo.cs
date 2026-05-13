using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageLocalApplications.Forms
{
    public partial class frmLocalApplicationInfo : Form
    {
        private int _LocalApplicationID;
        public frmLocalApplicationInfo(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalApplicationID = LocalDrivingLicenseApplicationID;
        }

        private void frmLocalApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalApplicationInfo1.CloseOnError += this.Close;
            ctrlLocalApplicationInfo1.LoadInfo(_LocalApplicationID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
