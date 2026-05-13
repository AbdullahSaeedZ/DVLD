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

namespace PresentationLayer.PeopleFormsAndControls
{
    public partial class frmAddEditPerson : Form
    {
        public event Action<int> OnUpdateDoneForPersonCard; // to send PersonID outside to update any control when person info is updated here
        public event Action<int> OnNewPersonAdded; // to send PersonID outside to update any control when person info is updated here
        public event Action OnUpdateDoneForDGV;

        private int _personID = -1;
        clsPeopleBusiness person;
        public enum enGender { Male = 0, Female = 1 };

        public frmAddEditPerson()
        {
            InitializeComponent();
        }
        public frmAddEditPerson(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _FillCountriesComboBox();
            rbMale.Checked = true;
            dtpBirthDate.MaxDate = clsBusinessSettings._defaultMinAllowedAge;

            if (_personID == -1)
            {
                person = new clsPeopleBusiness();
            }
            else
            {
                person = clsPeopleBusiness.FindPerson(_personID);
                if (person == null)
                {
                    MessageBox.Show("Person Does Not Exist, Form will close", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                _FillPersonInfoInForm();
            }
        }

        private void _FillCountriesComboBox()
        {
            DataTable dt = clsCountriesBusiness.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
            cbCountry.SelectedItem = clsBusinessSettings._defaultComboBoxCountry;
        }
        private void _FillPersonInfoInForm()
        {

            lblPersonID.Text = person.PersonID.ToString();
            lblFormTitle.Text = $"Edit person with ID = {person.PersonID}";

            tbNationalNumber.Text = person.NationalID;
            tbFirstName.Text = person.FirstName;
            tbSecondName.Text = person.SecondName;
            tbThirdName.Text = person.ThirdName;
            tbLastName.Text = person.LastName;
            tbEmail.Text = person.Email;
            dtpBirthDate.Value = person.BirthDate;
            tbPhone.Text = person.Phone;
            tbAddress.Text = person.Address;
            cbCountry.SelectedIndex = cbCountry.FindString(person.CountryInfo.CountryName); //////

            if (person.Gender == (byte)enGender.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (string.IsNullOrEmpty(person.ImagePath))
            {
                pbImage.Image = rbMale.Checked ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
            }
            else
            {
                using (FileStream fs = new FileStream(person.ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pbImage.Image = new Bitmap(fs);
                }
                pbImage.ImageLocation = person.ImagePath; // to track if current pic will be changed.
                btnRemoveImage.Visible = true;
            }
        }

        
        private void _HandlePersonImage()
        {
            string oldPath = string.IsNullOrEmpty(person.ImagePath) ? "" : person.ImagePath; // if empty means no pic before
            string newPath = string.IsNullOrEmpty(pbImage.ImageLocation) ? "" : pbImage.ImageLocation; // if empty means removed or no pic added in this session

            // if paths dont match, user changed something
            if (oldPath != newPath)
                person.ImagePath = clsBusinessSettings.CopyImageToServer(pbImage.ImageLocation, person.ImagePath);
        }

        private void _SavePersonInfo()
        {
            person.NationalID = tbNationalNumber.Text.Trim();
            person.FirstName = tbFirstName.Text.Trim();
            person.SecondName = tbSecondName.Text.Trim();
            person.ThirdName = string.IsNullOrEmpty(tbThirdName.Text) ? "" : tbThirdName.Text.Trim();
            person.LastName = tbLastName.Text.Trim();
            person.Email = tbEmail.Text.Trim();
            person.Phone = tbPhone.Text.Trim();
            person.Address = tbAddress.Text.Trim();
            person.BirthDate = dtpBirthDate.Value.Date;
            person.Gender = rbMale.Checked ? clsPeopleBusiness.enGender.Male : clsPeopleBusiness.enGender.Female;
            person.NationalityCountryID = (clsCountriesBusiness.GetCountry(cbCountry.Text)).CountryID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (!this.ValidateChildren()) // runs all validations linked to the error Provider
             {
                 MessageBox.Show("Fields with * must be filled with valid data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 return;
             }

             _HandlePersonImage();
            _SavePersonInfo();

            try
            {
                if (person.Save(clsGlobal.CurrentUser))
                {
                    MessageBox.Show($"Data Saved Successfully, PersonID {person.PersonID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblPersonID.Text = person.PersonID.ToString();
                    lblFormTitle.Text = $"Edit person with ID = {person.PersonID}";

                    OnUpdateDoneForPersonCard?.Invoke(person.PersonID); // update if opened from personCard
                    OnUpdateDoneForDGV?.Invoke();  // update if opened from ctrlPeople, not personCard
                    OnNewPersonAdded?.Invoke(person.PersonID);
                }
                else
                    MessageBox.Show("Data Was Not Saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (pbImage.Image != null) 
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
            if (clsPeopleBusiness.DoesPersonExist(tbNationalNumber.Text.Trim()) && person.NationalID != tbNationalNumber.Text.Trim())
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)// prevent non digit and allow backspace
            {
                e.Handled = true; // will make the event handled which will prevent any input in text box
            }
        }

        // releasing bitmap objects
        private void frmAddEditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pbImage.Image != null) // since im uploading profile pic to ram as bitmap obj, release it when done to avoid memory leaks
            {
                pbImage.Image.Dispose();
                pbImage.Image = null;
            }
        }

        private void frmAddEditPerson_Activated(object sender, EventArgs e)
        {
            tbFirstName.Focus();
            tbFirstName.SelectionStart = tbFirstName.Text.Length;
        }
    }
}
