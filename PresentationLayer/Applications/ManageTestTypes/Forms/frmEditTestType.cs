using BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static BusinessLayer.clsTestTypesBusiness;

namespace PresentationLayer.Applications.ManageTestTypes.Forms
{
    public partial class frmEditTestType : Form
    {

        public event Action delRefreshDgv;
        private enTestType _testTypeID = 0;
        private clsTestTypesBusiness _testType;

        public frmEditTestType(int TestTypeID)
        {
            InitializeComponent();
            _testTypeID = (enTestType)TestTypeID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            if (_testTypeID == 0)
            {
                MessageBox.Show("No Valid TestTypeID", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _testType = clsTestTypesBusiness.FindTestType(_testTypeID);
            if (_testType == null)
            {
                MessageBox.Show("Could not retrieve data from database", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _FillTestTypeInfo();
        }

        private void _FillTestTypeInfo()
        {
            lblTestTypeID.Text = ((int)_testType.TestTypeID).ToString();
            tbTestTypeTitle.Text = _testType.TestTypeTitle;
            tbTestTypeDescription.Text = _testType.TestTypeDescription;
            tbTestTypeFees.Text = _testType.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill required fields with valid data", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _testType.TestTypeTitle = tbTestTypeTitle.Text.Trim();
            _testType.TestTypeDescription = tbTestTypeDescription.Text.Trim();
            _testType.TestTypeFees = Convert.ToSingle(tbTestTypeFees.Text.Trim());

            if (_testType.Save())
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
        private void tbTestTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestTypeTitle.Text))
            {
                errorProvider1.SetError(tbTestTypeTitle, "Filed is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTestTypeTitle, null);
                e.Cancel = false;
            }
        }

        private void tbTestTypeDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestTypeDescription.Text))
            {
                errorProvider1.SetError(tbTestTypeDescription, "Filed is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTestTypeDescription, null);
                e.Cancel = false;
            }
        }

        private void tbTestTypeFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestTypeFees.Text))
            {
                errorProvider1.SetError(tbTestTypeFees, "Filed is required!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTestTypeFees, null);
                e.Cancel = false;
            }

            if (!clsBusinessSettings.IsValidFloat(tbTestTypeFees.Text))
            {
                errorProvider1.SetError(tbTestTypeFees, "Only numbers allowed");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbTestTypeFees, null);
                e.Cancel = false;
            }
        }


        // to put curser on text box once form is shown
        private void frmEditTestType_Shown(object sender, EventArgs e)
        {
            tbTestTypeTitle.Focus();
            tbTestTypeTitle.SelectionStart = tbTestTypeTitle.Text.Length;
            tbTestTypeTitle.SelectionLength = 0;
        }
    }
}
