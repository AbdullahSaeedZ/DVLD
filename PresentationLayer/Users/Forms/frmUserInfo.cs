using Microsoft.VisualBasic.ApplicationServices;
using PresentationLayer.MainForm;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Users.Forms
{
    public partial class frmUserInfo : Form
    {
        private int _userID;

        public frmUserInfo(int UserID)
        {
            InitializeComponent();
            _userID = UserID;
        }
        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserCard1.LoadInfo(_userID);
            ctrlAddEditUserPermissions1.LoadPermissionsForDisplay(ctrlUserCard1.SelectedUser.Permissions);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
