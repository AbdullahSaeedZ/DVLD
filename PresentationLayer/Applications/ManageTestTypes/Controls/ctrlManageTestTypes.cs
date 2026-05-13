using BusinessLayer;
using PresentationLayer.Applications.ManageTestTypes.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageTestTypes.Controls
{
    public partial class ctrlManageTestTypes : UserControl
    {
        public event Action<UserControl> delRemoveFromMainFormContainer_TestTypes;
        private DataTable dt;


        public ctrlManageTestTypes()
        {
            InitializeComponent();
        }


        private void ctrlManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshDgv();
            clsUtilities.AddToBreadcrumb("> Manage Test Types");
        }

        private void _RefreshDgv()
        {
            dt = clsTestTypesBusiness.GetAllTestTypes();
            dgvTestTypes.DataSource = dt;
            lblNumberOfRecords.Text = dgvTestTypes.RowCount.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUtilities.RemoveFromBreadcrumb("> Manage Test Types");
            delRemoveFromMainFormContainer_TestTypes?.Invoke(this);
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eUpdateTestType))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmEditTestType editTestType = new frmEditTestType((int)dgvTestTypes.SelectedCells[0].Value);
            editTestType.delRefreshDgv += _RefreshDgv;
            clsUtilities.AddToBreadcrumb("> Edit Type Info");
            editTestType.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Edit Type Info");
        }
    }
}
