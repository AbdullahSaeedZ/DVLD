using BusinessLayer;
using PresentationLayer.Global_Classes;
using PresentationLayer.MainForm;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.PeopleFormsAndControls
{
    public partial class ctrlPersonCardWithSearch : UserControl
    {
        public event Action<int> OnPersonSelected;
       

        public int FilterBorderThickness
        {
            set
            {
                pnlFilter.BorderThickness = value;
            }
            get
            {
                return pnlFilter.BorderThickness;
            }
        }
        public Color FilterBorderColor
        {
            set
            {
                pnlFilter.BorderColor = value;
            }
            get
            {
                return pnlFilter.BorderColor;
            }
        }
        public int CardBorderThickness
        {
            set
            {
                ctrlPersonCard1.BorderThickness = value;
            }
            get
            {
                return ctrlPersonCard1.BorderThickness;
            }
        }
        public Color CardBorderColor
        {
            set
            {
                ctrlPersonCard1.BorderColor = value;
            }
            get
            {
                return ctrlPersonCard1.BorderColor;
            }
        }
        public bool FilterEnabled 
        {
            set
            {
                pnlFilter.Enabled = value;
            }
            get
            {
                return pnlFilter.Enabled;
            }
        }
        public bool FilterVisible
        {
            set
            {
                pnlFilter.Visible = value;
            }
            get
            {
                return pnlFilter.Visible;
            }
        }

        public clsPeopleBusiness SelectedPerson { get { return ctrlPersonCard1.SelectedPersonInfo; } }
        public int PersonID { get { return ctrlPersonCard1.PersonID; } } // to use current personID outside the control

        public void LoadInfo(int PersonID) // to load person info when user is opened for update
        {
            ctrlPersonCard1.LoadInfo(PersonID);
        }

        public void FilterFocus()
        {
            tbSearch.Focus();
        }

        public ctrlPersonCardWithSearch()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson addEditPerson = new frmAddEditPerson(-1);
            addEditPerson.OnNewPersonAdded += AddEditPerson_OnNewPersonAdded;
            clsUtilities.AddToBreadcrumb("> Add-Edit Person");
            addEditPerson.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Add-Edit Person");

        }
        private void AddEditPerson_OnNewPersonAdded(int PersonID) // triggered when new person added
        {
            ctrlPersonCard1.LoadInfo(PersonID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                MessageBox.Show($"Please fill needed data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch(cbSearchBy.Text)
            {
                case "Person ID":
                    int ID = int.Parse(tbSearch.Text.Trim());

                    if (clsPeopleBusiness.DoesPersonExist(ID))
                        ctrlPersonCard1.LoadInfo(ID);
                    else
                    {
                        MessageBox.Show($"Person with PersonID {ID} was not found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // to skip invoking event when no Person found
                    }

                        break;
                case "National No":
                    string NationalNo = tbSearch.Text.Trim();

                    if (clsPeopleBusiness.DoesPersonExist(NationalNo))
                        ctrlPersonCard1.LoadInfo(NationalNo);
                    else
                    {
                        MessageBox.Show($"National No {NationalNo} was not found", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    break;

                default:
                    MessageBox.Show($"Please select a filter then fill needed data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            OnPersonSelected?.Invoke(ctrlPersonCard1.PersonID); // if needed, custom event invoked to send ID outside when person is selected 

        }
        private void cbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbSearchBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back; // if Handled == true then will prevent any action
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, EventArgs.Empty);
        }
    }
}
