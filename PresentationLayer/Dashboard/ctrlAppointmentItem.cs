using BusinessLayer;
using PresentationLayer.Applications.TestAppointments.Forms;
using PresentationLayer.Global_Classes;
using PresentationLayer.Properties;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataGrid;

namespace PresentationLayer.Dashboard
{
    public partial class ctrlAppointmentItem : UserControl
    {
        int _ID = -1;
        DateTime _Date = DateTime.MinValue;
        bool _IsLocked = false;
        bool _IsTestTaken = false;

        public int BorderThickness
        {
            set
            {
                pnlOuterBorder.BorderThickness = value;
            }
            get
            {
                return pnlOuterBorder.BorderThickness;
            }
        }
        public Color BorderColor
        {
            set
            {
                pnlOuterBorder.BorderColor = value;
            }
            get
            {
                return pnlOuterBorder.BorderColor;
            }
        }

        public ctrlAppointmentItem()
        {
            InitializeComponent();
        }

        public void LoadInfo(int ID, DateTime Date, bool IsLocked, bool IsTestTaken)
        {
            _ID = ID;
            _Date = Date;
            _IsLocked = IsLocked;
            _IsTestTaken = IsTestTaken;

            lblID.Text = "ID " + _ID.ToString();
            lblDate.Text = _Date.ToString();
            if (_IsLocked && _IsTestTaken)
            {
                lblStatus.Text = "Completed";
                lblStatus.ForeColor = Color.LimeGreen;
            }
            else if (_IsLocked && !_IsTestTaken) // appointment time has come and and sql server agent locked the appointment with no test record
            {
                lblStatus.Text = "Missed";
                lblStatus.ForeColor = Color.Crimson;
            }
            else
            {
                lblStatus.Text = "Upcoming";
                lblStatus.ForeColor = Color.Orange;
            }
            

        }

        private void pnlOuterBorder_MouseEnter(object sender, EventArgs e)
        {
            pnlOuterBorder.BorderThickness = 0;
            pnlOuterBorder.FillColor = Color.WhiteSmoke;
            guna2PictureBox6.Image = Resources.appointmentFill;   
        }

        private void pnlOuterBorder_MouseLeave(object sender, EventArgs e)
        {
            pnlOuterBorder.BorderThickness = 1;
            pnlOuterBorder.FillColor = Color.White;
            guna2PictureBox6.Image = Resources.appointmentNoFill;
        }

        private void pnlOuterBorder_Click(object sender, EventArgs e)
        {
            clsUtilities.AddToBreadcrumb("> Appointment Info");
            frmShowAppointmentInfo info = new frmShowAppointmentInfo(this._ID);
            info.ShowDialog();
            clsUtilities.RemoveFromBreadcrumb("> Appointment Info");

        }
    }
}
