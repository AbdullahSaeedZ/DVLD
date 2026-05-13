using BusinessLayer;
using Guna.UI2.WinForms;
using PresentationLayer.Applications;
using PresentationLayer.DashboardControls;
using PresentationLayer.Drivers;
using PresentationLayer.Global_Classes;
using PresentationLayer.PeopleFormsAndControls;
using PresentationLayer.Properties;
using PresentationLayer.Settings;
using PresentationLayer.UsersFormsAndControls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PresentationLayer.MainForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            clsUtilities.OnBreadcrumbUpdate += UpdateBreadcrumb;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //guna2ShadowForm1.SetShadowForm(this);

            // to start app with overview
            btnOverview_Click(btnOverview, EventArgs.Empty);
            _LoadProfileInfo();
        }

        private void _LoadProfileInfo()
        {
            if (clsGlobal.CurrentUser == null)
            {
                MessageBox.Show($"Could not find user account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (string.IsNullOrEmpty(clsGlobal.CurrentUser.Person.ImagePath))
                pbProfilePic.Image = clsGlobal.CurrentUser.Person.Gender == 0 ? Resources.defaultMaleProfile : Resources.defaultFemaleProfile;
            else
                using (FileStream fs = new FileStream(clsGlobal.CurrentUser.Person.ImagePath, FileMode.Open, FileAccess.Read))
                {
                    pbProfilePic.Image = new Bitmap(fs);
                }

            lblProfilePersonName.Text = clsGlobal.CurrentUser.Person.FirstName + " " + clsGlobal.CurrentUser.Person.LastName;
            lblProfileUsername.Text = clsGlobal.CurrentUser.Username;
        }
        public void _UpdateButtons(object sender)
        {
            Guna2Button selectedButten = (Guna2Button)sender;
            // to reset unchosen buttons color and icon
            btnOverview.FillColor = Color.Transparent;
            btnOverview.ForeColor = Color.DimGray;
            btnOverview.Image = Resources.overviewNoFillThin;

            btnApplications.FillColor = Color.Transparent;
            btnApplications.ForeColor = Color.DimGray;
            btnApplications.Image = Resources.applicationNoFillThin;

            btnPeople.FillColor = Color.Transparent;
            btnPeople.ForeColor = Color.DimGray;
            btnPeople.Image = Resources.peopleNoFillThin;

            btnDrivers.FillColor = Color.Transparent;
            btnDrivers.ForeColor = Color.DimGray;
            btnDrivers.Image = Resources.driversNoFillThin;

            btnUsers.FillColor = Color.Transparent;
            btnUsers.ForeColor = Color.DimGray;
            btnUsers.Image = Resources.usersNoFill;

            btnSettings.FillColor = Color.Transparent;
            btnSettings.ForeColor = Color.DimGray;
            btnSettings.Image = Resources.settingNoFill;

            // to highlight selected color
            selectedButten.FillColor = Color.White;
            selectedButten.Image = selectedButten.HoverState.Image;
            selectedButten.ForeColor = Color.Black;

            clsUtilities.BreadcrumbText = selectedButten.Tag.ToString();
            pbBreadcrumb.Image = selectedButten.HoverState.Image;
        }
        private void _RefreshControlsContainer()
        {
            pnlControlsContainer.Controls.Clear();
        }
        private void UpdateBreadcrumb()
        {
            lblBreadcrumb.Text = clsUtilities.BreadcrumbText;
        }

        // menu buttons
        private void btnOverview_Click(object sender, EventArgs e)
        {
            _RefreshControlsContainer();
            ctrlDashboard dashboard = new ctrlDashboard();
            pnlControlsContainer.Controls.Add(dashboard);
            _UpdateButtons(sender);
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            _RefreshControlsContainer();

            ctrlMainServices MainServices = new ctrlMainServices();
            MainServices.delAddToMainFormContainer += pnlControlsContainer.Controls.Add;
            MainServices.delRemoveFromMainFormContainer += pnlControlsContainer.Controls.Remove;
            pnlControlsContainer.Controls.Add(MainServices);

            _UpdateButtons(sender);
        }
        private void btnPeople_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eListPeople))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _RefreshControlsContainer();
            ctrlPeople People = new ctrlPeople();
            pnlControlsContainer.Controls.Add(People);
            _UpdateButtons(sender);

        }
        private void btnDrivers_Click(object sender, EventArgs e)
        {
            _RefreshControlsContainer();
            ctrlDrivers drivers = new ctrlDrivers();
            pnlControlsContainer.Controls.Add(drivers);
            _UpdateButtons(sender);
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eListUsers))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _RefreshControlsContainer();
            ctrlUsers Users = new ctrlUsers();
            pnlControlsContainer.Controls.Add(Users);
            _UpdateButtons(sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            _RefreshControlsContainer();
            ctrlSettings settings = new ctrlSettings();
            settings.OnProfileUpdate += _LoadProfileInfo;
            pnlControlsContainer.Controls.Add(settings);
            _UpdateButtons(sender);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                clsGlobal.CurrentUser.RemoveLoginToken();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clsGlobal.CurrentUser = null;
            this.Close();
        }


        // PersonID Quick Search
        private void lblQuickSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbQuickSearch.Text , out int ID))
            {
                if (clsPeopleBusiness.DoesPersonExist(ID))
                {
                    frmPersonInfo Info = new frmPersonInfo(ID);
                    clsUtilities.AddToBreadcrumb("> Person Details");
                    Info.ShowDialog();
                    clsUtilities.RemoveFromBreadcrumb("> Person Details");
                }
                else
                    MessageBox.Show($"Person With ID {ID} Does Not Exist", "Error", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Only Numbers Allowed", "Error", MessageBoxButtons.OK);
        }
        private void tbQuickSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lblQuickSearch_Click(sender, EventArgs.Empty);
        }
       

        // Closing the app
        private void ControlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
