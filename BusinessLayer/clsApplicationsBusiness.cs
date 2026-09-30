using DataAccessLayer;
using System;
using System.Data;
using static BusinessLayer.clsApplicationTypesBusiness;

namespace BusinessLayer
{
    public class clsApplicationsBusiness
    {
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3}; 
        public enum enMode { eAddMode = 0, eUpdateMode = 1 };


        protected enMode _mode; // to use inside the derived class only
        public enApplicationStatus ApplicationStatus { set; get; } // will come from DB as numbers

        public int ApplicationID { get; protected set; }

        protected int _applicantPersonID;
        public int ApplicantPersonID
        {
            get
            {
                return _applicantPersonID;
            }
            set
            {
                if (_applicantPersonID == -1) // to prevent any modification and allow only new assignment from UI
                    _applicantPersonID = value;
            }
        }

        protected enApplicationTypes _applicationTypeID;
        public enApplicationTypes ApplicationTypeID
        {
            get
            {
                return _applicationTypeID;
            }
            set
            {
                if (_applicationTypeID == 0) // to prevent any modification and allow only new assignment from UI
                    _applicationTypeID = value;
            }
        }

        protected int _createdByUserID;
        public int CreatedByUserID
        {
            get
            {
                return _createdByUserID;
            }
            set
            {
                if (_createdByUserID == -1) // to prevent any modification and allow only new userID assignment
                    _createdByUserID = value;
            }
        }
        public DateTime LastStatusDate { get; protected set; }
        public float PaidFees { get; set; }
        public DateTime ApplicationDate { get; protected set; }

        public clsPeopleBusiness ApplicantPersonInfo 
        {
            get
            {
                return clsPeopleBusiness.FindPerson(ApplicantPersonID);
            }
        }
        public clsApplicationTypesBusiness ApplicationTypeInfo
        {
            get
            {
                return clsApplicationTypesBusiness.FindApplicationType((enApplicationTypes)ApplicationTypeID);
            }
        }
        public clsUserBusiness CreatedByUserInfo
        {
            get
            {
                return clsUserBusiness.FindUser(_createdByUserID);
            }
        }


        public clsApplicationsBusiness()
        {
            this.ApplicationID = -1;
            this._applicantPersonID = -1;
            this._applicationTypeID = 0;
            this.ApplicationDate = DateTime.MinValue;
            this.LastStatusDate = DateTime.MinValue;
            this.PaidFees = -1;
            this._createdByUserID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            _mode = enMode.eAddMode;
        }

        protected clsApplicationsBusiness(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, enApplicationTypes ApplicationTypeID, enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this._applicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this._applicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this._createdByUserID = CreatedByUserID;
            _mode = enMode.eUpdateMode;
        }

        // this is the base application, cuz will have derived applications of this 
        public static clsApplicationsBusiness FindBaseApplicationByID(int ApplicationID)
        {
            int applicantPersonID = -1, applicationTypeID = -1, createdByUserID = -1;
            byte applicationStatus = 1;
            DateTime applicationDate = DateTime.Now, lastStatusDate = DateTime.Now;
            float paidFees = -1;

            if (clsApplicationsDataAccess.FindApplicationByID(ApplicationID, ref applicantPersonID, ref applicationDate, ref applicationTypeID, ref applicationStatus, ref lastStatusDate, ref paidFees, ref createdByUserID))
                return new clsApplicationsBusiness(ApplicationID, applicantPersonID, applicationDate, (enApplicationTypes)applicationTypeID, (enApplicationStatus)applicationStatus, lastStatusDate, paidFees, createdByUserID);
            else
                return null;
        }


        private bool _AddNewApplication(clsDataTransaction transaction)
        {
            // date of creating application is taken from Business layer (server) not the UI
            this.ApplicationDate = DateTime.Now;
            this.LastStatusDate = DateTime.Now;
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate, (int)this.ApplicationTypeID,
                (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID, transaction);
            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication(clsDataTransaction transaction)
        {
            this.LastStatusDate = DateTime.Now;
            return clsApplicationsDataAccess.UpdateApplication(this.ApplicationID ,this.ApplicantPersonID, this.ApplicationDate, (int)this.ApplicationTypeID,
                                                                (byte)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID, transaction);
        }

        // base applications are not deletable alone, deletion will be in derived applications, which will handle deletion of both using transactions in DB
        // this method kept if needed in later development
        public virtual bool DeleteApplication()
        {
            return clsApplicationsDataAccess.DeleteBaseApplication(this.ApplicationID);
        }

      
        public virtual bool Save(clsDataTransaction transaction)
        {
            switch (_mode)
            {
                case enMode.eAddMode:
                    if (_AddNewApplication(transaction))
                    {
                        _mode = enMode.eUpdateMode;
                        return true;
                    }
                    else
                        return false;

                case enMode.eUpdateMode:
                    return _UpdateApplication(transaction);

                default: return false;
            }
        }

        public bool Cancel()
        {
            if (this.ApplicationStatus == enApplicationStatus.New)
                return clsApplicationsDataAccess.UpdateStatus(this.ApplicationID, (byte)enApplicationStatus.Cancelled, DateTime.Now);
            else
                return false;
        }

    }
}
