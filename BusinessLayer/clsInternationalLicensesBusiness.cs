using DataAccessLayer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class clsInternationalLicensesBusiness
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _mode;


        public int InternationalLicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLicenseID { get; set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicensesBusiness LocalLicenseInfo
        {
            get
            {
                return clsLicensesBusiness.FindByLicenseID(this.IssuedUsingLicenseID);
            }
        }
        public clsApplicationsBusiness ApplicationInfo
        {
            get
            {
                return clsApplicationsBusiness.FindBaseApplicationByID(this.ApplicationID);
            }
        }

        public clsInternationalLicensesBusiness()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLicenseID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.IsActive = false;
            this.CreatedByUserID = -1;
            this._mode = enMode.eAddMode;
        }

        clsInternationalLicensesBusiness(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLicenseID, DateTime IssueDate, DateTime ExpirationDate,
                                         bool IsActive, int CreatedByUserID)
        {
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLicenseID = IssuedUsingLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
            this._mode = enMode.eUpdateMode;
        }

        public static clsInternationalLicensesBusiness Find(int InternationalLicenseID)
        {
            int ApplicationID = -1, DriverID = -1, IssuedUsingLicenseID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            bool IsActive = false;

            if (clsInternationalLicensesDataAccess.Find(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLicenseID, ref IssueDate, ref ExpirationDate,
                                         ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicensesBusiness(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLicenseID, IssueDate, ExpirationDate,
                                         IsActive, CreatedByUserID);
            }
            else
                return null;
        }


        private bool _AddNewInternationalLicense()
        {
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now.AddYears(1); // fixed validity length specified by business requirements

            this.InternationalLicenseID = clsInternationalLicensesDataAccess.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLicenseID, this.IssueDate, this.ExpirationDate,
                                         this.IsActive, this.CreatedByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicensesDataAccess.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID, this.IssuedUsingLicenseID, this.IssueDate, this.ExpirationDate,
                                         this.IsActive, this.CreatedByUserID);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesDataAccess.GetAllInternationalLicenses();
        }

        public static DataTable GetAllInternationalLicensesByPersonID(int PersonID)
        {
            return clsInternationalLicensesDataAccess.GetAllInternationalLicensesByPersonID(PersonID);
        }


        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewInternationalLicense())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateInternationalLicense();

                default: return false;
            }
        }

        public bool IsLicenseDetained()
        {
            return clsDetainedLicensesDataAccess.IsLicenseDetained(this.IssuedUsingLicenseID);
        }


        // will get only ACTIVE licenses
        public static int GetActiveInterNationalLicenseIDByPersonID(int PersonID)
        {
            return clsInternationalLicensesDataAccess.GetActiveInternationalLicenseIDByPersonID(PersonID);
        }


     
    }
}
