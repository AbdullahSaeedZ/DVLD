using BusinessLayer;
using PresentationLayer.Applications.ManageApplicationTypes.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.Applications.ManageApplicationTypes.Controls
{
    public partial class ctrlManageApplicationsTypes : UserControl
    {
        public event Action<UserControl> delRemoveFromMainFormContainer_AppTypes;
        private DataTable dt;

        public ctrlManageApplicationsTypes()
        {
            InitializeComponent();
        }

        private void ctrlManageApplicationsTypes_Load(object sender, EventArgs e)
        {
            _RefreshDgv();
            clsUtilities.AddToBreadcrumb("> Manage Applications Types");
        }

        private void _RefreshDgv()
        {
            dt = clsApplicationTypesBusiness.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = dt;
            lblNumberOfRecords.Text = dgvApplicationTypes.RowCount.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUtilities.RemoveFromBreadcrumb("> Manage Applications Types");
            delRemoveFromMainFormContainer_AppTypes?.Invoke(this);
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eUpdateApplicationType))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmEditApplicationType editApplicationType = new frmEditApplicationType((int)dgvApplicationTypes.SelectedCells[0].Value);
            editApplicationType.delRefreshDgv += _RefreshDgv;
            clsUtilities.AddToBreadcrumb("> Edit Type Info");
            editApplicationType.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Edit Type Info");
        }

    }
}
