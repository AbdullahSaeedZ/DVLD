using DataAccessLayer;
using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using static BusinessLayer.clsLicensesBusiness;

namespace BusinessLayer
{
    public class clsDetainedLicensesBusiness
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _mode;

        public int DetainID { get; private set; } 
        public int LicenseID { get; set; } 
        public DateTime DetainDate { get; private set; } 
        public float FineFees { get; set; } 
        public int CreatedByUserID { get; set; } 
        public bool IsReleased { get; private set; }
        public DateTime ReleaseDate { get; private set; } 
        public int ReleasedByUserID { get; private set; } 
        public int ReleaseApplicationID { get; private set; } 

        public clsDetainedLicensesBusiness()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.MinValue;
            this.FineFees = -1;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
            this._mode = enMode.eAddMode;
        }
        clsDetainedLicensesBusiness(int DetainID,  int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased,
                         DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this._mode = enMode.eUpdateMode;
        }

        public static clsDetainedLicensesBusiness FindByLicenseID(int LicenseID)
        {
            int DetainID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;
            float FineFees = -1;
            bool IsReleased = false;

            if (clsDetainedLicensesDataAccess.FindByLicenseID(ref DetainID, LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased,
                         ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicensesBusiness(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                         ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }

        public static clsDetainedLicensesBusiness FindByDetainID(int DetainID)
        {
            int LicenseID = -1, CreatedByUserID = -1, ReleasedByUserID = -1, ReleaseApplicationID = -1;
            DateTime DetainDate = DateTime.MinValue, ReleaseDate = DateTime.MinValue;
            float FineFees = -1;
            bool IsReleased = false;

            if (clsDetainedLicensesDataAccess.FindByDetainID( DetainID, ref LicenseID, ref DetainDate, ref FineFees, ref CreatedByUserID, ref IsReleased,
                         ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicensesBusiness(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                         ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }
            else
                return null;
        }

        private bool _AddNewDetainLicense()
        {
            if (this.LicenseID == -1)
                return false;

            this.DetainID = clsDetainedLicensesDataAccess.AddNewDetainLicense(this.LicenseID, DateTime.Now, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }


        private bool _UpdateDetainedLicense()
        {
            if (this.ReleaseApplicationID == -1)
                return false;

            return clsDetainedLicensesDataAccess.UpdateDetainedLicense(this.DetainID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }


        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.GetAllDetainedLicenses();
        }

        // releasing user is the one on the ui side, never depend on methods from ui, just receive data from ui
        public int ReleaseLicense(clsUserBusiness ReleasedByUser, int PersonID)
        {
            if (ReleasedByUser == null || this.IsReleased)
                return -1;

            clsApplicationsBusiness ReleaseLicenseApplication = new clsApplicationsBusiness();
            ReleaseLicenseApplication.ApplicationTypeID = clsApplicationTypesBusiness.enApplicationTypes.eReleaseDetainedDrivingLicense;
            ReleaseLicenseApplication.ApplicationStatus = clsApplicationsBusiness.enApplicationStatus.New;
            ReleaseLicenseApplication.ApplicantPersonID = PersonID;
            ReleaseLicenseApplication.CreatedByUserID = ReleasedByUser.UserID;
            ReleaseLicenseApplication.PaidFees = clsApplicationTypesBusiness.FindApplicationType(clsApplicationTypesBusiness.enApplicationTypes.eReleaseDetainedDrivingLicense).ApplicationTypeFees;

            if (!ReleaseLicenseApplication.Save())
                return -1;

            if (!clsDetainedLicensesDataAccess.ReleaseDetainedLicense(this.LicenseID, DateTime.Now, ReleasedByUser.UserID, ReleaseLicenseApplication.ApplicationID))
                return -1;

            this.IsReleased = true;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = ReleasedByUser.UserID;
            this.ReleaseApplicationID = ReleaseLicenseApplication.ApplicationID;

            return ReleaseLicenseApplication.ApplicationID;
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewDetainLicense())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateDetainedLicense(); 

                default: return false;
            }
        }



    }
}
