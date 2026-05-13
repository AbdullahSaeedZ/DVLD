using BusinessLayer;
using PresentationLayer.Global_Classes;
using PresentationLayer.MainForm;
using PresentationLayer.Properties;
using System;
using System.Windows.Forms;

namespace PresentationLayer.LoginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                clsGlobal.CurrentUser = clsUserBusiness.FindUserByToken(clsBusinessSettings.GetTokenFromRegistry());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (clsGlobal.CurrentUser == null)
                return;

            if (!clsGlobal.CurrentUser.isActive)
            {
                MessageBox.Show("Your account is not active, please contact your admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenMainForm();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = clsUserBusiness.FindUser(tbUsername.Text.Trim(), tbPassword.Text.Trim());

            if (clsGlobal.CurrentUser == null)
            {
                MessageBox.Show("Invalid Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus();
                return;
            }

            if (clsGlobal.CurrentUser.Person == null)
            {
                MessageBox.Show("could not fetch person Info for this user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Focus();
                return;
            }

            try
            {
                if (chbKeepMeLoggedIn.Checked)
                    clsGlobal.CurrentUser.CreateLoginToken();
            }    
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (!clsGlobal.CurrentUser.isActive)
            {
                MessageBox.Show("Your account is not active, please contact your admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenMainForm();
        }

        private void OpenMainForm()
        {
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog(); // dialog to wait for main form to close then continue to next line
            this.Show(); // once logged out from Main form, this will unhide instead of new object created in memory
            tbUsername.Text = "";
            tbPassword.Text = "";
            chbKeepMeLoggedIn.Checked = false;
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !tbPassword.UseSystemPasswordChar;
            

            if (!tbPassword.UseSystemPasswordChar)
            {
                btnShowHidePassword1.Image = Resources.hidePasswordEye;
            }
            else
            {
                btnShowHidePassword1.Image = Resources.showPasswordEye;
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    } 
}
