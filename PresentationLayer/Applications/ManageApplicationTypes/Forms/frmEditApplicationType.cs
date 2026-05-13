using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageApplicationTypes.Forms
{
    public partial class frmEditApplicationType : Form
    {
        public event Action delRefreshDgv;

        private int _applicationTypeID = -1;
        private clsApplicationTypesBusiness _appType;

        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _applicationTypeID = ApplicationTypeID;
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            if (_applicationTypeID == -1)
            {
                MessageBox.Show("No Valid ApplicationTypeID", "error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }    

            _appType = clsApplicationTypesBusiness.FindApplicationType((clsApplicationTypesBusiness.enApplicationTypes)_applicationTypeID);
            if (_appType == null)
            {
                MessageBox.Show("Could not retrieve data from database", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _FillApplicationTypeInfo();
        }

        private void _FillApplicationTypeInfo()
        {
            lblApplicationTypeID.Text = ((int)_appType.ApplicationTypeID).ToString();
            tbApplicationTypeTitle.Text = _appType.ApplicationTypeTitle;
            tbApplicationTypeFees.Text = _appType.ApplicationTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill required fields with valid data", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _appType.ApplicationTypeTitle = tbApplicationTypeTitle.Text.Trim();
            _appType.ApplicationTypeFees = Convert.ToSingle(tbApplicationTypeFees.Text.Trim());

            if (_appType.Save())
            {
                MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                delRefreshDgv?.Invoke();
            }
            else
                MessageBox.Show("Data was not saved successfully", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // validations
        private void tbApplicationTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationTypeTitle.Text))
            {
                errorProvider1.SetError(tbApplicationTypeTitle, "Filed is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbApplicationTypeTitle, null);
                e.Cancel = false;
            }
        }

        private void tbApplicationTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbApplicationTypeFees.Text))
            {
                errorProvider1.SetError(tbApplicationTypeFees, "Filed is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbApplicationTypeFees, null);
                e.Cancel = false;
            }

            if (!clsBusinessSettings.IsValidFloat(tbApplicationTypeFees.Text)) 
            {
                errorProvider1.SetError(tbApplicationTypeFees, "Only numbers allowed");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbApplicationTypeFees, null);
                e.Cancel = false;
            }
        }

        // to put curser on text box once form is shown
        private void frmEditApplicationType_Shown(object sender, EventArgs e)
        {
            tbApplicationTypeTitle.Focus();
            tbApplicationTypeTitle.SelectionStart = tbApplicationTypeTitle.Text.Length;
            tbApplicationTypeTitle.SelectionLength = 0;
        }
    }
}
