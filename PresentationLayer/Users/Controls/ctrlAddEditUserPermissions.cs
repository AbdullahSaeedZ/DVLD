using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer.Users.Controls
{
    public partial class ctrlAddEditUserPermissions : UserControl
    {
        public int PermissionsCardBorderThickness
        {
            set
            {
                pnlPermissions.BorderThickness = value;
            }
            get
            {
                return pnlPermissions.BorderThickness;
            }
        }
        public Color PermissionsCardBorderColor
        {
            set
            {
                pnlPermissions.BorderColor = value;
            }
            get
            {
                return pnlPermissions.BorderColor;
            }
        }

        public ctrlAddEditUserPermissions()
        {
            InitializeComponent();
        }

        public void LoadPermissionsForUpdate(int Permissions)
        {
            if (Permissions == 0)
            {
                chbNone.Checked = true;
                return;
            }

            if (Permissions == -1)
            {
                chbAllPermissions.Checked = true;
                return;
            }

            foreach (Guna2CheckBox chb in pnlCheckboxes.Controls.OfType<Guna2CheckBox>())
            {
                if ( (Permissions & (1 << Convert.ToInt32(chb.Tag.ToString()))) != 0)
                    chb.Checked = true;
            }
        }

        public void LoadPermissionsForDisplay(int Permissions)
        {
            LoadPermissionsForUpdate(Permissions);
            pnlCheckboxes.Enabled = false;
            chbNone.Enabled = false;
            chbAllPermissions.Enabled = false;
        }

        public int GetSelectedPermissions()
        {
            if (chbNone.Checked)
                return 0;

            if (chbAllPermissions.Checked)
                return -1;

            int Permissions = 0;

            foreach (Guna2CheckBox chb in pnlCheckboxes.Controls.OfType<Guna2CheckBox>())
            {
                if (chb.Checked)
                    Permissions |=  1 << (Convert.ToInt32(chb.Tag));
            }

            return Permissions;
        }

        // to disable all boxes when all permissions or none selected
        private void NoneOrAllPermissions_CheckedChanged(object sender, EventArgs e)
        {

            foreach (Guna2CheckBox chb in pnlCheckboxes.Controls.OfType<Guna2CheckBox>())
            {
                chb.Checked = false;
            }
            chbNone.Enabled = !chbAllPermissions.Checked;
            chbAllPermissions.Enabled = !chbNone.Checked;
            pnlCheckboxes.Enabled = !(chbAllPermissions.Checked || chbNone.Checked);
        }
      
    }
}
