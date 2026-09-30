using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsLicensesBusiness
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        // matching ApplicationTypeID in clsApplicationTypesBusiness.enApplicationTypes and DB
        public enum enIssueReason { FirstTime = 1, Renew = 2 , ReplacementForLost = 3, ReplacementForDamaged = 4};

        enMode _mode;
        

        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public clsLicenseClassesBusiness.enLicenseClass LicenseClassID { get; set; }
        public DateTime IssueDate { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public clsLicenseClassesBusiness LicenseCLassInfo
        {
            get
            {
                return clsLicenseClassesBusiness.Find(LicenseClassID);
            }
        }

        public clsDriversBusiness DriverInfo
        {
            get
            {
                return clsDriversBusiness.FindByDriverID(DriverID);
            }
        }

        public clsDetainedLicensesBusiness DetainedInfo
        {
            get
            {
                return clsDetainedLicensesBusiness.FindByLicenseID(this.LicenseID);
            }
        }



        public clsLicensesBusiness()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClassID = 0;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Notes = "";
            this.PaidFees = - 1;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
            this._mode = enMode.eAddMode;
        }

        clsLicensesBusiness(int LicenseID, int ApplicationID, int DriverID, clsLicenseClassesBusiness.enLicenseClass LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, 
            string Notes, float PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)
        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this._mode = enMode.eUpdateMode;
        }

        public static clsLicensesBusiness FindByLicenseID(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, CreatedByUserID = -1;
            byte IssueReason = 0, LicenseClassID = 0;
            DateTime IssueDate = DateTime.MinValue, ExpirationDate = DateTime.MinValue;
            string Notes = "";
            float PaidFees = -1;
            bool IsActive = false;

            if (clsLicensesDataAccess.FindByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate,
                                              ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicensesBusiness( LicenseID, ApplicationID, DriverID, (clsLicenseClassesBusiness.enLicenseClass)LicenseClassID, IssueDate, ExpirationDate,
                                                Notes, PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            }
            else
                return null;
        }


        private bool _AddNewLicense()
        {
            this.IssueDate = DateTime.Now;

            // when issueing a replacement, then old expiration date will be sent here and mustnt be changed
            if (this.ExpirationDate == DateTime.MinValue)
            {
                int LicenseValidityLength = (int)(clsLicenseClassesBusiness.Find(this.LicenseClassID)).DefaultValidityLength;
                this.ExpirationDate = DateTime.Now.AddYears(LicenseValidityLength);
            }
          
            this.LicenseID = clsLicensesDataAccess.AddNewLicense( this.ApplicationID, this.DriverID, (byte)this.LicenseClassID, this.IssueDate, this.ExpirationDate,
            this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLicensesDataAccess.UpdateLicense(this.LicenseID ,this.ApplicationID, this.DriverID, (byte)this.LicenseClassID, this.IssueDate, this.ExpirationDate,
            this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        public static DataTable GetAllLicenses()
        {
            return clsLicensesDataAccess.GetAllLicenses();
        }

        public static DataTable GetAllLocalLicenses(int PersonID)
        {
            return clsLicensesDataAccess.GetAllLocalLicensesByPersonID(PersonID);
        }


        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewLicense())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateLicense();

                default: return false;
            }
        }

        
        public static string GetIssueReasonText(enIssueReason IssueReason)
        {
            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "License Renew";
                case enIssueReason.ReplacementForDamaged:
                    return "Damaged Replacement";
                case enIssueReason.ReplacementForLost:
                    return "Lost Replacement";
                default: return "NA";
            }
        }
        public string GetIssueReasonText()
        {
            return GetIssueReasonText(this.IssueReason);
        }

        public bool IsLicenseDetained()
        {
            return clsDetainedLicensesDataAccess.IsLicenseDetained(this.LicenseID);
        }

        // will get license that was issued for first time by this local application
        public static int GetLicenseIDbyLocalApplicationID(int LocalLicenseApplicationID)
        {
            return clsLicensesDataAccess.GetLicenseIDbyLocalApplicationID(LocalLicenseApplicationID);
        }

        // will get only ACTIVE licenses
        public static int GetActiveLicenseIDByPersonID(int PersonID, clsLicenseClassesBusiness.enLicenseClass LicenseClassID)
        {
            return clsLicensesDataAccess.GetActiveLicenseIDByPersonID(PersonID, (byte)LicenseClassID);
        }

        public static bool DoesPersonHaveActiveLicense(int PersonID, clsLicenseClassesBusiness.enLicenseClass LicenseClassID)
        {
            return (GetActiveLicenseIDByPersonID(PersonID, LicenseClassID) != -1);
        }

        // whether active or not
        public static bool DidPersonIssueLicense(int PersonID, clsLicenseClassesBusiness.enLicenseClass LicenseClassID)
        {
            return clsLicensesDataAccess.DidPersonIssueLicense(PersonID, (byte)LicenseClassID);
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpirationDate < DateTime.Now);
        }
        
     
        public int IssueInternationalLicense(clsUserBusiness CreatedByUser)
        {
            if (CreatedByUser == null || !this.IsActive || this.IsLicenseDetained() || this.LicenseClassID != clsLicenseClassesBusiness.enLicenseClass.Class3Ordinary || 
                clsInternationalLicensesDataAccess.GetActiveInternationalLicenseIDByPersonID(this.DriverInfo.PersonID) != -1)
                return -1;

            if (!CreatedByUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
                throw new UnauthorizedAccessException("You do not have permission to issue licenses");

            clsInternationalLicensesBusiness NewInternationalLicense = new clsInternationalLicensesBusiness();
            NewInternationalLicense.DriverID = this.DriverID;
            NewInternationalLicense.IssuedUsingLicenseID = this.LicenseID;
            NewInternationalLicense.IsActive = true;
            NewInternationalLicense.CreatedByUserID = CreatedByUser.UserID;

            if (NewInternationalLicense.Save())
                return NewInternationalLicense.InternationalLicenseID;
            else
                return -1;
        }

        public int RenewLicense(string Notes, clsUserBusiness CreatedByUser)
        {
            // expired licenses are still active, we cant do any kind of operations on inactive licenses.
            if (!this.IsLicenseExpired() || this.IsLicenseDetained() || !this.IsActive || CreatedByUser == null)
                return -1;

            if (!CreatedByUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
                throw new UnauthorizedAccessException("You do not have permission to issue licenses");

            clsLicensesBusiness RenewedLicense = new clsLicensesBusiness();
            RenewedLicense.CreatedByUserID = CreatedByUser.UserID;
            RenewedLicense.Notes = Notes;
            RenewedLicense.DriverID = this.DriverID;
            RenewedLicense.IssueReason = enIssueReason.Renew;
            RenewedLicense.PaidFees = this.LicenseCLassInfo.ClassFees;
            RenewedLicense.LicenseClassID = this.LicenseClassID;
            RenewedLicense.IsActive = true;
            
            if (RenewedLicense.Save())
            {
                return RenewedLicense.LicenseID;
            }
            else
                return -1;
        }

        public int ReplaceLicense(enIssueReason issueReason, clsUserBusiness CreatedByUser)
        {
            if (this.IsLicenseExpired() || this.IsLicenseDetained() ||  !this.IsActive || CreatedByUser == null || (issueReason != enIssueReason.ReplacementForDamaged && issueReason != enIssueReason.ReplacementForLost))
                return -1;

            if (!CreatedByUser.HasPermission(clsBusinessSettings.enPermissions.eIssueLicense))
                throw new UnauthorizedAccessException("You do not have permission to issue licenses");

            clsLicensesBusiness ReplacementLicense = new clsLicensesBusiness();
            ReplacementLicense.CreatedByUserID = CreatedByUser.UserID;
            ReplacementLicense.Notes = this.Notes;
            ReplacementLicense.DriverID = this.DriverID;
            ReplacementLicense.IssueReason = issueReason;
            ReplacementLicense.PaidFees = 0; // no fees for replacement of the license itself
            ReplacementLicense.LicenseClassID = this.LicenseClassID;
            ReplacementLicense.IsActive = true;
            ReplacementLicense.ExpirationDate = this.ExpirationDate; // cuz this is a replacement not renewal, so we put same expiration date to be the same as current license

            if (ReplacementLicense.Save())
            {
                return ReplacementLicense.LicenseID;
            }
            else
                return -1;
        }

        // here i only need the id, so no need to return the whole object
        public int DetainLicense(float FineFees, clsUserBusiness CreatedByUser)
        {
            if (!CreatedByUser.HasPermission(clsBusinessSettings.enPermissions.eDetainLicense))
                throw new UnauthorizedAccessException("You do not have permission to detain licenses");

            if (this.IsLicenseDetained())
                return -1;

            clsDetainedLicensesBusiness NewDetainedLicense = new clsDetainedLicensesBusiness();
            NewDetainedLicense.LicenseID = this.LicenseID;
            NewDetainedLicense.FineFees = FineFees;
            NewDetainedLicense.CreatedByUserID = CreatedByUser.UserID;

            if (NewDetainedLicense.Save())
                return NewDetainedLicense.DetainID;
            else
                return -1;
        }


        public int ReleaseLicense(clsUserBusiness ReleasedByUser)
        {
            if (!ReleasedByUser.HasPermission(clsBusinessSettings.enPermissions.eReleaseLicense))
                throw new UnauthorizedAccessException("You do not have permission to release licenses");

            if (!this.IsLicenseDetained() || this.DetainedInfo == null)
                return -1;

            return this.DetainedInfo.ReleaseLicense(ReleasedByUser, this.DriverInfo.PersonID);
           
        }

       
    }
}
