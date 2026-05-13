using BusinessLayer;
using PresentationLayer.Properties;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Controls
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public int BorderThickness
        {
            set
            {
                pnlCardBorder.BorderThickness = value;
            }
            get
            {
                return pnlCardBorder.BorderThickness;
            }
        }
        public Color BorderColor
        {
            set
            {
                pnlCardBorder.BorderColor = value;
            }
            get
            {
                return pnlCardBorder.BorderColor;
            }
        }

        clsInternationalLicensesBusiness _IntrLicense;
        public clsInternationalLicensesBusiness SelectedLocalLicense { get { return _IntrLicense; } }


        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int InternationalLicenseID)
        {
            _IntrLicense = clsInternationalLicensesBusiness.Find(InternationalLicenseID);
            if (_IntrLicense == null)
            {
                MessageBox.Show($"Could not find international License ID = {InternationalLicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLicenseInfo();
        }

        private void _FillLicenseInfo()
        {
            lblName.Text = _IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.FullName;
            lblInternationalLicenseID.Text = _IntrLicense.InternationalLicenseID.ToString();
            lblLocalLicenseID.Text = _IntrLicense.IssuedUsingLicenseID.ToString();
            lblNationalNo.Text = _IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.NationalID;
            lblBirthDate.Text = _IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.BirthDate.ToShortDateString();
            lblGender.Text = _IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.Gender.ToString();
            lblIsActive.Text = _IntrLicense.IsActive ? "Yes" : "No";
            lblIsDetained.Text = _IntrLicense.IsLicenseDetained() ? "Yes" : "No";
            lblDriverID.Text = _IntrLicense.DriverID.ToString();
            lblExpirationDate.Text = _IntrLicense.ExpirationDate.ToShortDateString();
            lblIssueDate.Text = _IntrLicense.IssueDate.ToShortDateString();
            lblApplicationID.Text = _IntrLicense.ApplicationID.ToString();

            _LoadPersonImage();
        }

        private void _LoadPersonImage()
        {
            if (string.IsNullOrEmpty(_IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.ImagePath))
                pbPersonPic.Image = _IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.Gender == clsPeopleBusiness.enGender.Male ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
            else
            {
                if (File.Exists(_IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.ImagePath))
                {
                    using (FileStream fs = new FileStream(_IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        pbPersonPic.Image = new Bitmap(fs);
                    }
                }
                else
                    MessageBox.Show($"Could not find image of this path: {_IntrLicense.LocalLicenseInfo.DriverInfo.PersonInfo.ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
