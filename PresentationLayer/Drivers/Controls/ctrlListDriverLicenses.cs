using BusinessLayer;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Applications.TestAppointments.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static BusinessLayer.clsTestTypesBusiness;

namespace PresentationLayer.Drivers.Controls
{
    public partial class ctrlListDriverLicenses : UserControl
    {
        public int OuterBorderThickness
        {
            set
            {
                pnlOuterBorder.BorderThickness = value;
            }
            get
            {
                return pnlOuterBorder.BorderThickness;
            }
        }
        public Color OuterBorderColor
        {
            set
            {
                pnlOuterBorder.BorderColor = value;
            }
            get
            {
                return pnlOuterBorder.BorderColor;
            }
        }

        public int TabBorderThickness
        {
            set
            {
                pnlTabBorder.BorderThickness = value;
            }
            get
            {
                return pnlTabBorder.BorderThickness;
            }
        }
        public Color TabBorderColor
        {
            set
            {
                pnlTabBorder.BorderColor = value;
            }
            get
            {
                return pnlTabBorder.BorderColor;
            }
        }

        public int DGVBorderThickness
        {
            set
            {
                pnlDGVBorder.BorderThickness = value;
            }
            get
            {
                return pnlOuterBorder.BorderThickness;
            }
        }
        public Color DGVBorderColor
        {
            set
            {
                pnlDGVBorder.BorderColor = value;
            }
            get
            {
                return pnlDGVBorder.BorderColor;
            }
        }

        private int _PersonID = -1;
        private DataTable dtLocalLicenses;
        private DataTable dtInternationalLicenses;

        public ctrlListDriverLicenses()
        {
            InitializeComponent();
        }

        public void LoadInfo(int PersonID) // personID will be provided by person control with valid person object, otherwise wont reach here
        {
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                lblNoLicensesIssued.Visible = true;
                return;
            }
            _LoadInternationalLicenses();
            _LoadLocalLicenses();
            lblNoLicensesIssued.Visible = dtLocalLicenses == null ? true : false;
            lblNumberOfRecords.Text = dgvLocalLicenses.RowCount.ToString();
        }
        private void btnShowInternationalLicenses_Click(object sender, EventArgs e)
        {
            ToggleLicensesType();
            lblNoLicensesIssued.Visible = dtInternationalLicenses == null ? true : false;
            lblNumberOfRecords.Text = dgvInternationalLicenses.RowCount.ToString();
        }

        private void btnShowLocalLicenses_Click(object sender, EventArgs e)
        {
            ToggleLicensesType();
            lblNoLicensesIssued.Visible = dtLocalLicenses == null ? true : false;
            lblNumberOfRecords.Text = dgvLocalLicenses.RowCount.ToString();
        }

        private void _LoadLocalLicenses()
        {
            dtLocalLicenses = clsLicensesBusiness.GetAllLocalLicenses(_PersonID);
            if (dtLocalLicenses == null)
                return;

            dgvLocalLicenses.DataSource = dtLocalLicenses;
            lblNumberOfRecords.Text = dgvLocalLicenses.RowCount.ToString();
        }
        private void _LoadInternationalLicenses()
        {
            dtInternationalLicenses = clsInternationalLicensesBusiness.GetAllInternationalLicensesByPersonID(_PersonID);
            if (dtInternationalLicenses == null)
                return;

            dgvInternationalLicenses.DataSource = dtInternationalLicenses;
            lblNumberOfRecords.Text = dgvInternationalLicenses.RowCount.ToString();
        }
        private void ToggleLicensesType()
        {
            dgvInternationalLicenses.Visible = !dgvInternationalLicenses.Visible;
            dgvLocalLicenses.Visible = !dgvLocalLicenses.Visible;

            btnShowLocalLicenses.Visible = !btnShowLocalLicenses.Visible;
            btnShowInternationalLicenses.Visible = !btnShowInternationalLicenses.Visible;

            lblLicenseTypeTitle.Text = dgvLocalLicenses.Visible ?   
                lblLicenseTypeTitle.Text.Replace("International", "Local"): lblLicenseTypeTitle.Text.Replace("Local", "International");
        }

        private void showInternationalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.RowCount == 0)
                return;

            int LicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            clsUtilities.AddToBreadcrumb($"> License Info");
            frmShowInternationalLicenseInfo internationalLicenseInfo = new frmShowInternationalLicenseInfo(LicenseID);
            internationalLicenseInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb($"> License Info");
        }

        private void showLocalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.RowCount == 0)
                return;

            int LicenseID = (int)dgvLocalLicenses.CurrentRow.Cells[0].Value;
            frmShowLocalLicenseInfo localLicenseInfo = new frmShowLocalLicenseInfo(LicenseID);
            clsUtilities.AddToBreadcrumb($"> License Info");
            localLicenseInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb($"> License Info");
        }
    }
}
