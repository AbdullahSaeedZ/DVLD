using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Applications.ManageLocalApplications.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Dashboard
{
    public partial class frmEnterID : Form
    {
        public enum enInfoMode { eApplicationInfo = 1, eLicenseInfo = 2}
        private enInfoMode _Mode;

        private int _ID = -1;
        

        public frmEnterID(enInfoMode InfoMode)
        {
            InitializeComponent();
            _Mode = InfoMode;
        }

        private void frmEnterID_Activated(object sender, EventArgs e)
        {
            if (_Mode == enInfoMode.eApplicationInfo)
                lblEnterID.Text = "Application ID:";
            else
                lblEnterID.Text = "License ID:";
            tbID.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
                return;
            
            if (int.TryParse(tbID.Text.Trim(), out int ID))
                _ID = ID;
            else
            {
                MessageBox.Show("Entered ID is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (_Mode == enInfoMode.eApplicationInfo)
            {
                clsUtilities.AddToBreadcrumb("> Application Info");
                frmLocalApplicationInfo info = new frmLocalApplicationInfo(_ID);
                info.ShowDialog();
                clsUtilities.RemoveFromBreadcrumb("> Application Info");
            }
            else
            {
                clsUtilities.AddToBreadcrumb("> License Info");
                frmShowLocalLicenseInfo info = new frmShowLocalLicenseInfo(_ID);
                info.ShowDialog();
                clsUtilities.RemoveFromBreadcrumb("> License Info");
            }

            this.Close();
        }

        private void tbID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbID, "Field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbID, null);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void tbID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch.PerformClick();
        }
    }
}
