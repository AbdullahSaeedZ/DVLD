using DataAccessLayer;
using System;
using System.Data;

namespace BusinessLayer
{
    public class clsDriversBusiness
    {
        enum enMode { eAddMode = 0, eUpdateMode = 1 };
        enMode _mode;

        public int DriverID { get; private set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; private set; }

        public clsPeopleBusiness PersonInfo
        {
            get
            {
                return clsPeopleBusiness.FindPerson(PersonID);
            }
        }

        public clsDriversBusiness()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.MinValue;
            this._mode = enMode.eAddMode;
        }


        clsDriversBusiness(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
            this._mode = enMode.eUpdateMode;
        }


        public static clsDriversBusiness FindByDriverID(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriversDataAccess.FindByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriversBusiness(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }

        public static clsDriversBusiness FindByPersonID(int PersonID)
        {
            int DriverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriversDataAccess.FindByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriversBusiness(PersonID, DriverID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }


        private bool _AddNewDriver()
        {
            this.DriverID = clsDriversDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID, DateTime.Now);

            return (this.DriverID != -1);
        }
        private bool _UpdateDriver()
        {
            return clsDriversDataAccess.UpdateDriver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriversDataAccess.GetAllDrivers();
        }

        public bool Save()
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewDriver())
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateDriver();

                default: return false;
            }
        }

    }
}
