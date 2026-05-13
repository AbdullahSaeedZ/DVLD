using BusinessLayer;
using PresentationLayer.Properties;
using PresentationLayer.Global_Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.UsersFormsAndControls
{
    public partial class frmAddEditUser : Form
    {
        public event Action OnUpdateDone;

        private int _userID = -1;
        clsUserBusiness _user;

        private enum enMode { eAddNewMode, eUpdateMode };
        private enMode _mode;

        public frmAddEditUser()
        {
            InitializeComponent();
            _mode = enMode.eAddNewMode;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _userID = UserID;
            _mode = enMode.eUpdateMode;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            if (_mode == enMode.eAddNewMode)
                _user = new clsUserBusiness();
            else
            {
                _user = clsUserBusiness.FindUser(_userID);
                if (_user == null)
                {
                    MessageBox.Show("User Does Not Exist, Form will close", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                _FillUserPersonInfoInForm();
            }
        }


        private void _FillUserPersonInfoInForm()
        {

            ctrlPersonCardWithSearch1.LoadInfo(_user.PersonID);
            ctrlPersonCardWithSearch1.FilterVisible = false;
            lblTitle.Text = lblTitle.Text = $"Edit User with ID = {_user.UserID}";
            lblUserID.Text = _user.PersonID.ToString();

            tbUsername.Text = _user.Username;
            chbIsActive.Checked = _user.isActive;
            ctrlAddEditUserPermissions1.LoadPermissionsForUpdate(_user.Permissions);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithSearch1.PersonID == -1)
            {
                MessageBox.Show($"Please select a person to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithSearch1.FilterFocus();
                return;
            }

            if (clsUserBusiness.DoesUserExist(ctrlPersonCardWithSearch1.PersonID) && _mode == enMode.eAddNewMode) // will proceed if update mode and user exists
            {
                MessageBox.Show($"Selected Person is already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ShowHideLoginInfoPanel();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _ShowHideLoginInfoPanel();
        }

        private void _ShowHideLoginInfoPanel()
        {
            pnlLoginInfo.Visible = !pnlLoginInfo.Visible;
            btnBack.Visible = !btnBack.Visible;
            btnSave.Visible = !btnSave.Visible;
            btnNext.Visible = !btnNext.Visible;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // text boxes validations
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill necessary fields with valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mode == enMode.eAddNewMode)
                _user.PersonID = ctrlPersonCardWithSearch1.PersonID; // will not reach here without a valid personID

            _user.Username = string.IsNullOrWhiteSpace(tbUsername.Text) && _mode == enMode.eUpdateMode ? _user.Username : tbUsername.Text.Trim();
            _user.Password = string.IsNullOrWhiteSpace(tbPassword.Text) && _mode == enMode.eUpdateMode ? _user.Password : tbPassword.Text.Trim();
            _user.isActive = chbIsActive.Checked;
            _user.Permissions = ctrlAddEditUserPermissions1.GetSelectedPermissions();

            try
            {
                if (_user.Save(clsGlobal.CurrentUser))
                {
                    MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlPersonCardWithSearch1.FilterVisible = false;
                    lblUserID.Text = _user.UserID.ToString();

                    OnUpdateDone?.Invoke(); // to refresh dgv if user info is updated
                    this.Close(); // to prevent users who have adding users permission with no update Users permission
                }
                else
                    MessageBox.Show("Data was not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // login info validations
        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            // emptiness validation
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Field is required!");
                tbUsername.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUsername, null);
                tbUsername.BorderColor = Color.Silver;
            }

            // does username exist validation
            if (clsUserBusiness.DoesUsernameExist(tbUsername.Text) && tbUsername.Text != _user.Username) // to avoid validating when username is not changed when updating user info
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Username already taken!");
                tbUsername.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUsername, null);
                tbUsername.BorderColor = Color.Silver;
            }

        }
        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            // emptiness validation
            if (string.IsNullOrWhiteSpace(tbPassword.Text) && _mode == enMode.eAddNewMode)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Field is required!");
                tbPassword.BorderColor = Color.Red;
            }// pattern validation
            else if (!string.IsNullOrWhiteSpace(tbPassword.Text) && !clsBusinessSettings.IsPasswordFormatValid(tbPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password must include at least: one lowercase, one uppercase, one digit, and one special character (8-20 Length).");
                tbPassword.BorderColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, null);
                tbPassword.BorderColor = Color.Silver;
            }

        }
        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            // emptiness validation
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Field is required!");
                tbConfirmPassword.BorderColor = Color.Red;
            } // password matching validation
            else if (tbConfirmPassword.Text.Trim() != tbPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Password does not match!");
                tbConfirmPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
                tbConfirmPassword.BorderColor = Color.Silver;
            }
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            tbConfirmPassword.UseSystemPasswordChar = !tbConfirmPassword.UseSystemPasswordChar;

            if (!tbPassword.UseSystemPasswordChar)
            {
                btnShowHidePassword1.Image = Resources.hidePasswordEye;
                btnShowHidePassword2.Image = Resources.hidePasswordEye;
            }
            else
            {
                btnShowHidePassword1.Image = Resources.showPasswordEye;
                btnShowHidePassword2.Image = Resources.showPasswordEye;
            }
        }

        private void ControlBoxClose_Click(object sender, EventArgs e)
        {
            ctrlPersonCardWithSearch1.Dispose();
            this.Close();
        }

        private void frmAddEditUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithSearch1.FilterFocus();
        }
    }
}
