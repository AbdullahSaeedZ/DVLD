using DataAccessLayer;
using System;
using System.Data;


namespace BusinessLayer
{
    public class clsTestAppointmentsBusiness
    {
        public enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _mode;

        public int TestAppointmentID { get; private set; }
        public clsTestTypesBusiness.enTestType TestTypeID { get; set; }  
        public int LocalDrivingLicenseApplicationID { get; set; }  
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }  
        public bool IsLocked { get; set; }  
        public int RetakeTestApplicationID { get; set; }
        public clsApplicationsBusiness RetakeTestAppInfo // this is a basic application with a test retake type
        {
            get
            {
                return clsApplicationsBusiness.FindBaseApplicationByID(RetakeTestApplicationID);
            }
        } 


        public clsTestAppointmentsBusiness()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = 0;
            this.LocalDrivingLicenseApplicationID = -1;
            this.AppointmentDate = DateTime.MinValue;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;
            _mode = enMode.eAddMode;
        }


        clsTestAppointmentsBusiness(int TestAppointmentID, clsTestTypesBusiness.enTestType TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
                                     int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = IsLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
            _mode = enMode.eUpdateMode;
        }


        public static clsTestAppointmentsBusiness FindByTestAppointmentID(int TestAppointmentID)
        {
            int LocalDrivingLicenseApplicationID = -1, RetakeTestApplicationID = -1, CreatedByUserID = -1, TestTypeID = 0;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = -1;
            bool IsLocked = false;

            if (clsTestAppointmentsDataAccess.FindByTestAppointmentID(TestAppointmentID, ref TestTypeID,ref LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees,
                                     ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointmentsBusiness(TestAppointmentID, (clsTestTypesBusiness.enTestType)TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees,
                                      CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }

        private bool _AddNewTestAppointment()
        {
            this.TestAppointmentID = clsTestAppointmentsDataAccess.AddNewTestAppointment((byte)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees,
                                     this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);

            return (this.TestAppointmentID != -1);
        }
        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentsDataAccess.UpdateTestAppointment(this.TestAppointmentID, (byte)this.TestTypeID, this.LocalDrivingLicenseApplicationID, this.AppointmentDate, this.PaidFees,
                                     this.CreatedByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public static DataTable GetAllTestAppointments()
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppointments();

        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewTestAppointment())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateTestAppointment();

                default: return false;
            }
        }


        public static DataTable GetAllTestAppointmentsByTestTypeID(int LocalDrivingLicenseApplicationID, clsTestTypesBusiness.enTestType TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppointmentsByTestTypeID(LocalDrivingLicenseApplicationID, (byte)TestTypeID);
        }
        public DataTable GetAllTestAppointmentsByTestTypeID(clsTestTypesBusiness.enTestType TestTypeID)
        {
            return clsTestAppointmentsDataAccess.GetAllTestAppointmentsByTestTypeID(this.LocalDrivingLicenseApplicationID, (byte)TestTypeID);
        }


        public static clsTestAppointmentsBusiness GetLastTestAppointmentByTestTypeID(int LocalDrivingLicenseApplicationID, clsTestTypesBusiness.enTestType TestTypeID)
        {

            int TestAppointmentID = -1, RetakeTestApplicationID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = -1;
            bool IsLocked = false;

            if (clsTestAppointmentsDataAccess.GetLastTestAppointmentByTestTypeID(ref TestAppointmentID, (byte)TestTypeID, LocalDrivingLicenseApplicationID, ref AppointmentDate, ref PaidFees,
                                     ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {
                return new clsTestAppointmentsBusiness(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees,
                                      CreatedByUserID, IsLocked, RetakeTestApplicationID);
            }
            else
                return null;
        }

        public int GetTestID()
        {
            return clsTestsDataAccess.GetTestIDByAppointmentID(this.TestAppointmentID);
        }

       


    }
}
