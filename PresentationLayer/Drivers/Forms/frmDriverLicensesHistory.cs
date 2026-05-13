using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Drivers.Forms
{
    public partial class frmDriverLicensesHistory : Form
    {

        int _PersonID = -1;

        public frmDriverLicensesHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmDriverLicensesHistory_Load(object sender, EventArgs e)
        {
           if (_PersonID == -1)
           {
                MessageBox.Show("Could not receive Person ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
           }

            ctrlPersonCard1.LoadInfo(_PersonID);
            ctrlListDriverLicenses1.LoadInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
