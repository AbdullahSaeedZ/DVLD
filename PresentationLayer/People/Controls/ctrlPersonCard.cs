using BusinessLayer;
using PresentationLayer.Global_Classes;
using PresentationLayer.MainForm;
using PresentationLayer.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PresentationLayer.PeopleFormsAndControls
{
    public partial class ctrlPersonCard : UserControl
    {
        public event Action PersonCardUpdated; // custom event that will eventually update DGV in ctrlPeople if invoked

        // outside usage:  use loadInfo method then can use PersonID;
        enum enGender { Male = 0, Female = 1 };
        private int _personID = -1;
        public int PersonID { get { return _personID; } } // to use current personID outside the control
        private clsPeopleBusiness _person;
        public clsPeopleBusiness SelectedPersonInfo { get { return _person; } } // to get person info outside the control
        public int BorderThickness 
        {
            set
            {
                pnlFullBorder.BorderThickness = value;
            }        
            get
            {
                return pnlFullBorder.BorderThickness;
            }        
        }
        public Color BorderColor 
        {
            set
            {
                pnlFullBorder.BorderColor = value;
            }        
            get
            {
                return pnlFullBorder.BorderColor;
            }        
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
            btnEditInfo.Visible = false;
        }

        public void LoadInfo(int personID)
        {
            _person = clsPeopleBusiness.FindPerson(personID);
            
            if (_person == null)
            {
                MessageBox.Show( $"PersonID = {personID} was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnEditInfo.Visible = true;
            _FillPersonInfo();
        }

        public void LoadInfo(string NationalID)
        {
            _person = clsPeopleBusiness.FindPerson(NationalID);
            
            if (_person == null)
            {
                MessageBox.Show( $"PersonID = {NationalID} was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btnEditInfo.Visible = true;
            _FillPersonInfo();
        }

        public void ResetPersonInfo()
        {
            _personID = -1;
            lblName.Text = "NA";
            lblPersonID.Text = "NA";
            lblNationalID.Text = "NA";
            lblCountry.Text = "NA";
            lblEmail.Text = "NA";
            lblBirthDate.Text = "NA";
            lblAddress.Text = "NA";
            lblGender.Text = "NA";
            lblPhone.Text = "NA";
            pbProfilePic.Image = Resources.defaultMaleProfile;

        }

        private void _UpdateDGVandCard(int ID)
        {
            LoadInfo(ID); // to update info here in personCard when info is updated in AddEdit form
            PersonCardUpdated?.Invoke(); // to update dgv in people form
        }

        private void _FillPersonInfo()
        {
            _personID = _person.PersonID;
            lblName.Text = _person.FullName;
            lblPersonID.Text = _person.PersonID.ToString();
            lblNationalID.Text = _person.NationalID.ToString();
            lblCountry.Text = _person.CountryInfo.CountryName;
            lblEmail.Text = string.IsNullOrEmpty(_person.Email) ? "NA" : _person.Email;
            lblBirthDate.Text = _person.BirthDate.ToShortDateString();
            lblAddress.Text = _person.Address;
            lblGender.Text = ((enGender)_person.Gender).ToString();
            lblPhone.Text = _person.Phone;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            if (string.IsNullOrEmpty(_person.ImagePath))
                pbProfilePic.Image = _person.Gender == clsPeopleBusiness.enGender.Male ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
            else
            {
                if (File.Exists(_person.ImagePath))
                {
                    using (FileStream fs = new FileStream(_person.ImagePath, FileMode.Open, FileAccess.Read))
                    {
                        pbProfilePic.Image = new Bitmap(fs);
                    }
                }
                else
                    MessageBox.Show($"Could not find image of this path: {_person.ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eUpdatePerson))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmAddEditPerson editPerson = new frmAddEditPerson(_personID);
            editPerson.OnUpdateDoneForPersonCard += _UpdateDGVandCard;
            clsUtilities.AddToBreadcrumb("> Edit Person Info");
            editPerson.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Edit Person Info");
        }
    }
}
