using BusinessLayer;
using PresentationLayer.Global_Classes;
using PresentationLayer.MainForm;
using PresentationLayer.Users.Controls;
using PresentationLayer.Users.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationLayer.UsersFormsAndControls
{
    public partial class ctrlUsers : UserControl
    {

        private DataTable dt;
        private string _searchFilter; // to use in search filters and match DT and DB column names, not dgv names

        public ctrlUsers()
        {
            InitializeComponent();
        }

        private void ctrlUsers_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            if ((dt = clsUserBusiness.GetAllUsers()) == null)
            {
                MessageBox.Show("No Records available", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvUsers.DataSource = dt;
            lblNumberOfRecords.Text = dgvUsers.RowCount.ToString();
        }


        // search User by..
        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchFilter = cbSearchBy.Text.Replace(" ", ""); // matching database names, not dgv. User ID in dgv, to be UserID here to match DT & DB

            if (_searchFilter == "None")
            {
                tbSearchUsers.Text = "";
                dt.DefaultView.RowFilter = "";
                tbSearchUsers.Visible = false;
                cbIsActive.Visible = false;
                lblNumberOfRecords.Text = dgvUsers.RowCount.ToString(); // to update number when switching to none after being filtered
                return;
            }

            if (_searchFilter == "IsActive")
            {
                tbSearchUsers.Visible = false;
                cbIsActive.Visible = true;
                return;
            }
         

            cbIsActive.Visible = false;
            tbSearchUsers.Visible = true;
            tbSearchUsers.Text = "";

            // text box placeholder text
            if (_searchFilter == "PersonID" || _searchFilter == "UserID")
                tbSearchUsers.PlaceholderText = "Only numbers allowed";
            else
                tbSearchUsers.PlaceholderText = "Search..";

            tbSearchUsers.Focus();
        }
        private void tbSearchUsers_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearchUsers.Text))
            {
                dt.DefaultView.RowFilter = ""; // when deleting text
                lblNumberOfRecords.Text = dgvUsers.RowCount.ToString();
                return;
            }

            dt.DefaultView.RowFilter = $"Convert({_searchFilter}, 'System.String') LIKE '{tbSearchUsers.Text}%'";
            lblNumberOfRecords.Text = dgvUsers.RowCount.ToString();

            // filtering expression uses DataColumn Expression Language
            // it takes column names from dataTable that took them from Database, not names in dgv
            //since like is for strings only and we might get int column, we cast column type to string using this method from DT special language
        }
        private void tbSearchUsers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_searchFilter == "PersonID" || _searchFilter == "UserID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; // if Handled == true then will prevent any action
        }
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIsActive.Text == "All")
            {
                dt.DefaultView.RowFilter = "";
                lblNumberOfRecords.Text = dgvUsers.RowCount.ToString();
                return;
            }

            byte filter = cbIsActive.Text == "No" ? (byte)0 : (byte)1;
            dt.DefaultView.RowFilter = $"IsActive = {filter}";
            lblNumberOfRecords.Text = dgvUsers.RowCount.ToString();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eAddUser))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmAddEditUser addUserForm = new frmAddEditUser();
            clsUtilities.AddToBreadcrumb("> Add-Edit User");
            addUserForm.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Add-Edit User");

            RefreshDataGridView();
        }
        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo((int)dgvUsers.SelectedCells[0].Value);
            clsUtilities.AddToBreadcrumb("> User Details");
            UserInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> User Details");
        }


        // toolstrips menu
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo UserInfo = new frmUserInfo((int)dgvUsers.SelectedCells[0].Value);
            clsUtilities.AddToBreadcrumb("> User Details");
            UserInfo.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> User Details");
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eUpdateUser))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmAddEditUser EditUserForm = new frmAddEditUser((int)dgvUsers.SelectedCells[0].Value);
            EditUserForm.OnUpdateDone += RefreshDataGridView;
            clsUtilities.AddToBreadcrumb("> Edit User");
            EditUserForm.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Edit User");
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eUpdateUser))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmChangePassword changePassword = new frmChangePassword((int)dgvUsers.SelectedCells[0].Value);
            clsUtilities.AddToBreadcrumb("> Change User Password");
            changePassword.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Change User Password");
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eDeleteUser))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int UserID = (int)dgvUsers.SelectedCells[0].Value;

            if (UserID == clsGlobal.CurrentUser.UserID)
            {
                MessageBox.Show("Current user can not be deleted, log in with different user first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Are you sure to delete User wIth ID {UserID}?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    if (clsUserBusiness.DeleteUser(UserID, clsGlobal.CurrentUser))
                    {
                        MessageBox.Show($"User with ID {UserID} was successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridView();
                    }
                    else
                        MessageBox.Show($"User with ID {UserID} CAN NOT be deleted due to linked data to be deleted first.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
