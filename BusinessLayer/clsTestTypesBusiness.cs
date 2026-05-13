using DataAccessLayer;
using System.Data;


namespace BusinessLayer
{
    public class clsTestTypesBusiness
    {
        public enum enTestType { Vision = 1, Written = 2, Street = 3 };
        enum enMode { eAddMode = 0, eUpdateMode = 1 }; // no need for adding functionality for now, but might add later
        enMode _mode;
        public enTestType TestTypeID { get; private set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }

        clsTestTypesBusiness(enTestType ID, string Title, string Description, float Fees)
        {
            this.TestTypeID = ID;
            this.TestTypeTitle = Title;
            this.TestTypeDescription = Description;
            this.TestTypeFees = Fees;
            _mode = enMode.eUpdateMode;
        }

        public static clsTestTypesBusiness FindTestType(enTestType ID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            float TestTypeFees = -1;

            if (clsTestTypesDataAccess.FindTestType((int)ID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))
                return new clsTestTypesBusiness(ID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }

        private bool _UpdateTestType()
        {
            return clsTestTypesDataAccess.UpdateTestType((int)this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    _mode = enMode.eUpdateMode;
                    return false; // to be added when needed

                case enMode.eUpdateMode:
                    return _UpdateTestType();

                default: return false;
            }
        }
    }
}
