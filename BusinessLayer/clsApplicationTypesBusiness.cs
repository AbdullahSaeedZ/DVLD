using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public class clsApplicationTypesBusiness
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 }; // no need for adding functionality for now, but might add later
        public enum enApplicationTypes { eNewLocalDrivingLicense = 1, eRenewDrivingLicense= 2 ,
                                         eLostDrivingLicenseReplacement = 3, eDamagedDrivingLicenseReplacement = 4,
                                         eReleaseDetainedDrivingLicense = 5, eNewInternationalLicense = 6,
                                         eRetakeTest = 7 };

        enMode _mode;

        public enApplicationTypes ApplicationTypeID { get; private set; }
        public string ApplicationTypeTitle { get; set; }
        public float ApplicationTypeFees { get; set; }

        clsApplicationTypesBusiness(enApplicationTypes ID, string Title, float Fees)
        {
            this.ApplicationTypeID = ID;
            this.ApplicationTypeTitle = Title;
            this.ApplicationTypeFees = Fees;
            _mode = enMode.eUpdateMode;
        }

        public static clsApplicationTypesBusiness FindApplicationType(enApplicationTypes ID)
        {
            string applicationTypeTitle = "";
            float applicationTypeFees = -1;

            if (clsApplicationTypesDataAccess.FindApplicationType((int)ID, ref applicationTypeTitle, ref applicationTypeFees))
                return new clsApplicationTypesBusiness(ID, applicationTypeTitle, applicationTypeFees);
            else
                return null;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypesDataAccess.UpdateApplicationType((int)this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationTypeFees);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    _mode = enMode.eUpdateMode;
                    return false; // to be added when needed

                case enMode.eUpdateMode:
                    return _UpdateApplicationType();

                default: return false;
            }
        }
    }
}
