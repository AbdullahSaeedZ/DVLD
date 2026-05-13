using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsTestsBusiness
    {
        public enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _mode;

        public int TestID { get; private set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTestAppointmentsBusiness TestAppointmentInfo
        { 
            get { return clsTestAppointmentsBusiness.FindByTestAppointmentID(TestAppointmentID); }
        }


        public clsTestsBusiness()
        {
            this.TestID = -1;
            this.TestAppointmentID = -1;
            this.TestResult = false;
            this.Notes = "";
            this.CreatedByUserID = -1;
            _mode = enMode.eAddMode;
        }


        clsTestsBusiness(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            _mode = enMode.eUpdateMode;
        }


        public static clsTestsBusiness FindByTestID(int TestID)
        {
            int TestAppointmentID = -1, CreatedByUserID = -1;
            string Notes = "";
            bool TestResult = false;

            if (clsTestsDataAccess.FindByTestID(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTestsBusiness(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }

        public static clsTestsBusiness FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestID = -1, CreatedByUserID = -1;
            string Notes = "";
            bool TestResult = false;

            if (clsTestsDataAccess.FindByTestAppointmentID(TestAppointmentID, ref TestID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTestsBusiness(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestsDataAccess.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);
        }
        private bool _UpdateTest()
        {
            return clsTestsDataAccess.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }

        public static DataTable GetAllTests()
        {
            return clsTestsDataAccess.GetAllTests();
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewTest())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateTest();

                default: return false;
            }
        }

        // to be deleted
        public static bool IsTestPassedByAppointmentId(int TestAppointmentID)
        {
            return clsTestsDataAccess.IsTestPassedByAppointmentId(TestAppointmentID);
        }


        public static clsTestsBusiness FindLastTestPerPersonAndLicenseClass(int ApplicantPersonID, clsLicenseClassesBusiness.enLicenseClass LicenseClassID, clsTestTypesBusiness.enTestType TestTypeID)
        {
            int TestID = -1, TestAppointmentID = -1, CreatedByUserID = -1;
            string Notes = "";
            bool TestResult = false;

            if (clsTestsDataAccess.FindLastTestPerPersonAndLicenseClass( ApplicantPersonID,  (byte)LicenseClassID, (int)TestTypeID, ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTestsBusiness(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return null;
        }

    }
}
