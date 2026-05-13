using BusinessLayer;
using PresentationLayer.Global_Classes;
using PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Users.Forms
{
    public partial class frmChangePassword : Form
    {
        private int _userID;
        
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _userID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadInfo(_userID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Fill necessary fields with valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (ctrlUserCard1.SelectedUser.ChangePassword(tbNewPassword.Text.Trim(), clsGlobal.CurrentUser))
                {
                    MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlUserCard1.SelectedUser.Password = tbNewPassword.Text.Trim(); // to update new password in the current session if form not closed and need to change password again
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


        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            // emptiness validation
            if (string.IsNullOrWhiteSpace(tbCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Field is required!");
                tbCurrentPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPassword, null);
                tbCurrentPassword.BorderColor = Color.Silver;
            }

            // current password correct ?
            if (ctrlUserCard1.SelectedUser.Password != clsBusinessSecurity.ComputeHash(tbCurrentPassword.Text.Trim(), ctrlUserCard1.SelectedUser.PasswordSalt))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Password is not correct!");
                tbCurrentPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCurrentPassword, null);
                tbCurrentPassword.BorderColor = Color.Silver;
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            // emptiness validation
            if (string.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Field is required!");
                tbNewPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNewPassword, null);
                tbNewPassword.BorderColor = Color.Silver;
            }

            // pattern validation
            if (!clsBusinessSettings.IsPasswordFormatValid(tbNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Password must include at least: one lowercase, one uppercase, one digit, and one special character (8-20 Length).");
                tbNewPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNewPassword, null);
                tbNewPassword.BorderColor = Color.Silver;
            }
        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            // emptiness validation
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Field is required!");
                tbConfirmPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbConfirmPassword, null);
                tbConfirmPassword.BorderColor = Color.Silver;
            }

            // is matching new password?
            if (tbConfirmPassword.Text.Trim() != tbNewPassword.Text.Trim())
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
            tbNewPassword.UseSystemPasswordChar = !tbNewPassword.UseSystemPasswordChar;
            tbConfirmPassword.UseSystemPasswordChar = !tbConfirmPassword.UseSystemPasswordChar;

            if (!tbNewPassword.UseSystemPasswordChar)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
