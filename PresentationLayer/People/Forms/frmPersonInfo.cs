using BusinessLayer;
using PresentationLayer.MainForm;
using System;
using System.Windows.Forms;

namespace PresentationLayer.PeopleFormsAndControls
{
    public partial class frmPersonInfo : Form
    {
        public event Action PersonCardUpdatedInForm; // took refreshDGV method reference, to be invoked when personCard is updated

        private int _personID = -1;
        private string _nationalNo = null;
        public frmPersonInfo(int personID)
        {
            InitializeComponent();
            _personID = personID;
        }
        public frmPersonInfo(string NationalNo)
        {
            InitializeComponent();
            _nationalNo = NationalNo;
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_nationalNo))
                ctrlPersonCard1.LoadInfo(_nationalNo);
            else
                ctrlPersonCard1.LoadInfo(_personID);
        }

        private void frmPersonInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrlPersonCard1.Dispose(); // to remove bitmap object from ram when closing
        }

        private void ctrlPersonCard1_PersonCardUpdated() // custom event made inside personCard
        {
            PersonCardUpdatedInForm?.Invoke();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
