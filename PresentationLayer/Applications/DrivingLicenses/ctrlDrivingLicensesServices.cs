using BusinessLayer;
using Guna.UI2.WinForms;
using PresentationLayer.Applications.DrivingLicenses.Forms;
using PresentationLayer.Global_Classes;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Applications.DrivingLicenses
{
    public partial class ctrlDrivingLicensesServices : UserControl
    {
        public event Action<UserControl> delRemoveFromMainFormContainer_DrivingLicenses;
        public ctrlDrivingLicensesServices()
        {
            InitializeComponent();
        }

        private void ctrlDrivingLicensesServices_Load(object sender, EventArgs e)
        {
            clsUtilities.AddToBreadcrumb("> Driving Licenses Services");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            clsUtilities.RemoveFromBreadcrumb("> Driving Licenses Services");
            delRemoveFromMainFormContainer_DrivingLicenses?.Invoke(this);
        }

        // to control the buttons shadow effect
        private void buttons_MouseEnter(object sender, EventArgs e)
        {
            string btnName = ((Guna2Button)sender).Tag.ToString();

            switch (btnName)
            {
                case "Release Detained License":
                    pnlReleaseDetainedLicense.ShadowDepth = 25;
                    break;
                case  "License Replacement":
                    pnlLicenseReplacement.ShadowDepth = 25;
                    break;
                case  "New Local License":
                    pnlNewLocalLicense.ShadowDepth = 25;
                    break;
                case  "New International License":
                    pnlNewInternationalLicense.ShadowDepth = 25;
                    break;
                case "Retake Test":
                    pnlRetakeTest.ShadowDepth = 25;
                    break;
                case  "Renew Driving License":
                    pnlRenewDrivingLicense.ShadowDepth = 25;
                    break;
            }
        }
        private void buttons_MouseLeave(object sender, EventArgs e)
        {
            string btnName = ((Guna2Button)sender).Tag.ToString();

            switch (btnName)
            {
                case "Release Detained License":
                    pnlReleaseDetainedLicense.ShadowDepth = 0;
                    break;
                case "License Replacement":
                    pnlLicenseReplacement.ShadowDepth = 0;
                    break;
                case "New Local License":
                    pnlNewLocalLicense.ShadowDepth = 0;
                    break;
                case "New International License":
                    pnlNewInternationalLicense.ShadowDepth = 0;
                    break;
                case "Retake Test":
                    pnlRetakeTest.ShadowDepth = 0;
                    break;
                case "Renew Driving License":
                    pnlRenewDrivingLicense.ShadowDepth = 0;
                    break;
            }
        }


        // buttons
        private void btnNewLocalLicenseApplication_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eAddApplications))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsUtilities.AddToBreadcrumb("> New Local Driving License");
            frmAddEditLocalLicenseApplication addLocalLicense = new frmAddEditLocalLicenseApplication();
            addLocalLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> New Local Driving License");
        }

        private void btnNewInternationalLicenseApplication_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsUtilities.AddToBreadcrumb("> New International Driving License");
            frmIssueInternationalLicense addInterLicense = new frmIssueInternationalLicense();
            addInterLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> New International Driving License");
        }

        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsUtilities.AddToBreadcrumb("> Renew Driving License");
            frmRenewLicense renewLicense = new frmRenewLicense();
            renewLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Renew Driving License");
        }

        private void btnLicenseReplacement_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            clsUtilities.AddToBreadcrumb("> Replace Driving License");
            frmIssueLicenseReplacement replaceLicense = new frmIssueLicenseReplacement();
            replaceLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Replace Driving License");
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eDetainLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDetainLicense detainLicense = new frmDetainLicense();
            clsUtilities.AddToBreadcrumb("> Detain License");
            detainLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Detain License");
        }

        private void btnReleaseDetainedLicense_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.HasPermission(clsBusinessSettings.enPermissions.eReleaseLicense))
            {
                MessageBox.Show("Access Denied, contact your admin to get permission.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmReleaseDetainedLicense releaseLicense = new frmReleaseDetainedLicense();
            clsUtilities.AddToBreadcrumb("> Release License");
            releaseLicense.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Release License");
        }
    }
}
