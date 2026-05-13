using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    public partial class frmShowLocalLicenseInfo : Form
    {
        int _LicenseID = -1;
        public frmShowLocalLicenseInfo(int LicenseID)
        {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmShowLocalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseInfo1.CloseOnError += this.Close;
            ctrlLocalDrivingLicenseInfo1.LoadInfo(_LicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
