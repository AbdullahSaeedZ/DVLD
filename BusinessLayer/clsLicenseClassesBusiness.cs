using System;
using System.Data;
using DataAccessLayer;


namespace BusinessLayer
{
    public class clsLicenseClassesBusiness
    {
        public enum enMode { eAddMode = 0, eUpdateMode = 1 };
        public enum enLicenseClass { Class1SmallMotorcycle = 1, Class2HeavyMotorcycle = 2, Class3Ordinary = 3 , Class4Commercial = 4,
                                     Class5Agricultural = 5, Class6SmallMediumBus = 6, Class7TruckHeavyVehicle = 7};

        private enMode _mode = enMode.eAddMode;

        public enLicenseClass LicenseClassID { get; private set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; } = 18;
        public byte DefaultValidityLength { get; set; } = 10;
        public float ClassFees { get; set; }

        clsLicenseClassesBusiness(enLicenseClass LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            _mode = enMode.eUpdateMode;
        }

        private bool _UpdateLicenseClass()
        {
            return clsLicenseClassesDataAccess.UpdateLicenseClass((byte)this.LicenseClassID, this.ClassName, this.ClassDescription, this.MinimumAllowedAge, this.DefaultValidityLength, this.ClassFees);
        }

        public static clsLicenseClassesBusiness Find(enLicenseClass LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18, DefaultValidityLength = 10; 
            float ClassFees = -1;

            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByID((byte)LicenseClassID, ref ClassName, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClassesBusiness(LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        public static clsLicenseClassesBusiness Find(string ClassName)
        {
            byte LicenseClassID = 0; string ClassDescription = "";
            byte MinimumAllowedAge = 18, DefaultValidityLength = 10;
            float ClassFees = -1;

            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByClassName(ClassName, ref LicenseClassID, ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
                return new clsLicenseClassesBusiness((enLicenseClass)LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;
        }

        public static DataTable GetAllLicenseClasses()
        {
            return clsLicenseClassesDataAccess.GetAllLicenseClasses();
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    _mode = enMode.eUpdateMode;
                    return false; // to be added when needed

                case enMode.eUpdateMode:
                    return _UpdateLicenseClass();

                default: return false;
            }
        }
    }
}
