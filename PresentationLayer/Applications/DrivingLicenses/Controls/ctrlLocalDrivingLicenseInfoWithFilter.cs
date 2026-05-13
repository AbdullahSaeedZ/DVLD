using BusinessLayer;
using PresentationLayer.PeopleFormsAndControls;
using System.Drawing;
using System;

using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses.Controls
{
    public partial class ctrlLocalDrivingLicenseInfoWithFilter : UserControl
    {
        public event Action OnLicenseSelected;
        public clsLicensesBusiness SelectedLicenseInfo { get { return ctrlLocalDrivingLicenseInfo1.SelectedLocalLicense; } }

        public int FilterBorderThickness
        {
            set
            {
                pnlFilter.BorderThickness = value;
            }
            get
            {
                return pnlFilter.BorderThickness;
            }
        }
        public Color FilterBorderColor
        {
            set
            {
                pnlFilter.BorderColor = value;
            }
            get
            {
                return pnlFilter.BorderColor;
            }
        }
        public int LicenseCardBorderThickness
        {
            set
            {
                ctrlLocalDrivingLicenseInfo1.BorderThickness = value;
            }
            get
            {
                return ctrlLocalDrivingLicenseInfo1.BorderThickness;
            }
        }
        public Color LicenseCardBorderColor
        {
            set
            {
                ctrlLocalDrivingLicenseInfo1.BorderColor = value;
            }
            get
            {
                return ctrlLocalDrivingLicenseInfo1.BorderColor;
            }
        }
        public bool FilterEnabled
        {
            set
            {
                pnlFilter.Enabled = value;
            }
            get
            {
                return pnlFilter.Enabled;
            }
        }
        public bool FilterVisible
        {
            set
            {
                pnlFilter.Visible = value;
            }
            get
            {
                return pnlFilter.Visible;
            }
        }


        public ctrlLocalDrivingLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public void LoadInfo(int LicenseID)// when i need to load info without the user entering id in text box
        {
            tbSearch.Text = LicenseID.ToString();
            ctrlLocalDrivingLicenseInfo1.LoadInfo(LicenseID);

            if (FilterEnabled)
                OnLicenseSelected?.Invoke();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                MessageBox.Show($"Field is empty, enter License ID to proceed", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseID = int.Parse(tbSearch.Text.Trim());
            LoadInfo(LicenseID);
        }

        public void FilterFocus()
        {
            tbSearch.Focus();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; // if Handled == true then will prevent any action
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, EventArgs.Empty);
        }
    }
}
