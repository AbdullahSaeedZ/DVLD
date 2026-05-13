using BusinessLayer;
using Guna.UI2.WinForms;
using PresentationLayer.Global_Classes;
using PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static PresentationLayer.PeopleFormsAndControls.frmAddEditPerson;

namespace PresentationLayer.Settings
{
    public partial class ctrlSettings : UserControl
    {

        public event Action OnProfileUpdate;

        // person object in user is readonly
        private clsPeopleBusiness _PersonInfo;


        // same logicc of addEditPerson form but i wanted to change UI with extra stuff
        public ctrlSettings()
        {
            InitializeComponent();
        }

        private void ctrlSettings_Load(object sender, EventArgs e)
        {
            _FillCountriesComboBox();
            _FillPersonInfoInForm();
            _FillLoginInfo();
            ctrlAddEditUserPermissions1.LoadPermissionsForDisplay(clsGlobal.CurrentUser.Permissions);
        }


        private void _FillCountriesComboBox()
        {
            DataTable dt = clsCountriesBusiness.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _FillPersonInfoInForm()
        {

            lblPersonID.Text = clsGlobal.CurrentUser.Person.PersonID.ToString();
            tbNationalNumber.Text = clsGlobal.CurrentUser.Person.NationalID;
            tbFirstName.Text = clsGlobal.CurrentUser.Person.FirstName;
            tbSecondName.Text = clsGlobal.CurrentUser.Person.SecondName;
            tbThirdName.Text = clsGlobal.CurrentUser.Person.ThirdName;
            tbLastName.Text = clsGlobal.CurrentUser.Person.LastName;
            tbEmail.Text = clsGlobal.CurrentUser.Person.Email;
            dtpBirthDate.Value = clsGlobal.CurrentUser.Person.BirthDate;
            tbPhone.Text = clsGlobal.CurrentUser.Person.Phone;
            tbAddress.Text = clsGlobal.CurrentUser.Person.Address;
            cbCountry.SelectedItem = clsGlobal.CurrentUser.Person.CountryInfo.CountryName;

            if (clsGlobal.CurrentUser.Person.Gender == (byte)enGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (string.IsNullOrEmpty(clsGlobal.CurrentUser.Person.ImagePath))
            {
                pbImage.Image = rbMale.Checked ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
            }
            else
            {
                using (FileStream fs = new FileStream(clsGlobal.CurrentUser.Person.ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pbImage.Image = new Bitmap(fs);
                }
                pbImage.ImageLocation = clsGlobal.CurrentUser.Person.ImagePath; // to track if current pic will be changed.
                btnRemoveImage.Visible = true;
            }
        }
        private void _FillLoginInfo()
        {
            lblUserID.Text = clsGlobal.CurrentUser.UserID.ToString();
            lblUsername.Text = clsGlobal.CurrentUser.Username;
            lblIsActive.Text = clsGlobal.CurrentUser.isActive == false ? "No" : "Yes";
        }


        private void _HandlePersonImage()
        {
            string oldPath = string.IsNullOrEmpty(_PersonInfo.ImagePath) ? "" : _PersonInfo.ImagePath; // if empty means no pic before
            string newPath = string.IsNullOrEmpty(pbImage.ImageLocation) ? "" : pbImage.ImageLocation; // if empty means removed or no pic added in this session.

            // if paths dont match, user changed something.
            if (oldPath != newPath)
                _PersonInfo.ImagePath = clsBusinessSettings.CopyImageToServer(pbImage.ImageLocation, _PersonInfo.ImagePath);
        }
        private void _SavePersonInfo()
        {
            _PersonInfo.NationalID = tbNationalNumber.Text.Trim();
            _PersonInfo.FirstName = tbFirstName.Text.Trim();
            _PersonInfo.SecondName = tbSecondName.Text.Trim();
            _PersonInfo.ThirdName = string.IsNullOrEmpty(tbThirdName.Text) ? "" : tbThirdName.Text.Trim();
            _PersonInfo.LastName = tbLastName.Text.Trim();
            _PersonInfo.Email = tbEmail.Text.Trim();
            _PersonInfo.Phone = tbPhone.Text.Trim();
            _PersonInfo.Address = tbAddress.Text.Trim();
            _PersonInfo.BirthDate = dtpBirthDate.Value;
            _PersonInfo.Gender = rbMale.Checked ? clsPeopleBusiness.enGender.Male : clsPeopleBusiness.enGender.Female;
            _PersonInfo.NationalityCountryID = (clsCountriesBusiness.GetCountry(cbCountry.Text)).CountryID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren()) // runs all validations linked to the error Provider
            {
                MessageBox.Show("Fields with * must be filled with valid data and not empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!string.IsNullOrEmpty(tbCurrentPassword.Text))
                clsGlobal.CurrentUser.Password = tbNewPassword.Text.Trim();

            _PersonInfo = clsPeopleBusiness.FindPerson(clsGlobal.CurrentUser.Person.PersonID); // the person object inside user object is readonly

            if (_PersonInfo == null)
            {
                MessageBox.Show("Could not find person info ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            _HandlePersonImage();
            _SavePersonInfo();

            try 
            {
                if (_PersonInfo.Save(clsGlobal.CurrentUser))
                {
                    MessageBox.Show("Data Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OnProfileUpdate?.Invoke();
                }
                else
                    MessageBox.Show("Data Was Not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       

     

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Profile_Pic";
            openFileDialog1.Title = "Choose a Profile Picture";
            openFileDialog1.DefaultExt = "png"; // default extension of file to be saved, user just enters file name then .txt will be attached to it
            openFileDialog1.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.gif";
            openFileDialog1.FilterIndex = 1; //which extension to be default when dialog opens.(starts from 1)
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = openFileDialog1.FileName;
                if (pbImage.Image != null) // to release any old loaded pic from ram
                    pbImage.Image.Dispose();

                using (FileStream fs = new FileStream(pbImage.ImageLocation, FileMode.Open, FileAccess.Read))
                {
                    pbImage.Image = new Bitmap(fs);
                }
                btnRemoveImage.Visible = true;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            btnRemoveImage.Visible = false;
            pbImage.ImageLocation = ""; // will indicate that user deleted his pic;

            pbImage.Image = rbMale.Checked ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbImage.ImageLocation)) // set default if pic not added
                pbImage.Image = rbMale.Checked ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
        }


        // textBoxes error Validations
        private void tbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            // if not empty, go to next validation
            if (string.IsNullOrWhiteSpace(tbNationalNumber.Text))
            {
                e.Cancel = true;  // AutoValidate property to allow focus change, in designer
                errorProvider1.SetError(tbNationalNumber, "Field is required!");
                tbNationalNumber.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNumber, null);
                tbNationalNumber.BorderColor = Color.Silver;
            }

            // if ID is used 
            if (clsPeopleBusiness.DoesPersonExist(tbNationalNumber.Text.Trim()) && clsGlobal.CurrentUser.Person.NationalID != tbNationalNumber.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "National No. is already registered");
                tbNationalNumber.BorderColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNationalNumber, null);
                tbNationalNumber.BorderColor = Color.Silver;
            }
        }
        // not required, but if email entered, needs validation
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            // if user forgets space in the end, it will give false
            bool isFormatValid = clsBusinessSettings.IsEmailFormatValid(tbEmail.Text.Trim());

            if (!string.IsNullOrWhiteSpace(tbEmail.Text) && !isFormatValid)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Invalid Email format");
                tbEmail.BorderColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, null);
                tbEmail.BorderColor = Color.Silver;
            }
        }
        // multiple textBoxes subscribed to this event
        private void EmptyTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(((Guna2TextBox)sender).Text))
            {
                e.Cancel = true;
                errorProvider1.SetError((Guna2TextBox)sender, "Field is required!");
                ((Guna2TextBox)sender).BorderColor = Color.Red;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError((Guna2TextBox)sender, null);
                ((Guna2TextBox)sender).BorderColor = Color.Silver;
            }
        }
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)// prevent non digit and backspace
            {
                e.Handled = true; // will make the event handled which will prevent any input in text box
            }
        }


        // change password validation
        private void tbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            // current password correct ?
            if (!string.IsNullOrWhiteSpace(tbCurrentPassword.Text) && clsGlobal.CurrentUser.Password != clsBusinessSecurity.ComputeHash(tbCurrentPassword.Text.Trim(), clsGlobal.CurrentUser.PasswordSalt))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCurrentPassword, "Current Password is not correct!");
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
            // if current password is filled, then must proceed with other password fields 
            if (string.IsNullOrWhiteSpace(tbNewPassword.Text) && !string.IsNullOrWhiteSpace(tbCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNewPassword, "Field is required, or clear all password fields");
                tbNewPassword.BorderColor = Color.Red;
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbNewPassword, null);
                tbNewPassword.BorderColor = Color.Silver;
            }

            // pattern validation when this field is not empty only
            if (!string.IsNullOrWhiteSpace(tbNewPassword.Text) && !clsBusinessSettings.IsPasswordFormatValid(tbNewPassword.Text.Trim()))
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
            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text) && !string.IsNullOrWhiteSpace(tbNewPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "Field is required, or clear all password fields");
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


        // releasing bitmap objects
        private void ctrlSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pbImage.Image != null) // since im uploading profile pic to ram as bitmap obj, release it when done to avoid memory leaks
            {
                pbImage.Image.Dispose();
                pbImage.Image = null;
            }
        }

    }
}
