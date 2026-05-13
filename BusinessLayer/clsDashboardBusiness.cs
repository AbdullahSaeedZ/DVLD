using System;
using System.Data;
using DataAccessLayer;

namespace BusinessLayer
{
    public  class clsDashboardBusiness
    {

        public int TotalTests { get; private set; } = -1;
        public int TotalPassedTests { get; private set; } = -1;

        public int TotalApplications { get; private set; } = -1;
        public int TotalApplicationsCompleted { get; private set; } = -1;

        public int TotalDrivers { get; private set; } = -1;
        public int TotalPeople { get; private set; } = -1;
        public int TotalUsers { get; private set; } = -1;
        public int TotalLicenses { get; private set; } = -1;

        public float TotalPaidFeesThisMonth{ get; private set; } = -1;
        public float TotalPaidFeesAllTime{ get; private set; } = -1;


        clsDashboardBusiness(int TotalTests, int TotalPassedTests, int TotalApplications, int TotalApplicationsCompleted, int TotalDrivers, 
                                int TotalPeople, int TotalUsers, int TotalLicenses, float TotalPaidFeesThisMonth, float TotalPaidFeesAllTime)
        {
            this.TotalTests = TotalTests;
            this.TotalPassedTests = TotalPassedTests;
            this.TotalApplications = TotalApplications;
            this.TotalApplicationsCompleted = TotalApplicationsCompleted;
            this.TotalDrivers = TotalDrivers;
            this.TotalPeople = TotalPeople;
            this.TotalUsers = TotalUsers;
            this.TotalLicenses = TotalLicenses;
            this.TotalPaidFeesThisMonth = TotalPaidFeesThisMonth;
            this.TotalPaidFeesAllTime = TotalPaidFeesAllTime;

        }

        public static clsDashboardBusiness GetDashboardData()
        {
            int TotalTests = -1, TotalPassedTests = -1, TotalApplications = -1, TotalApplicationsCompleted = -1, TotalDrivers = -1,
             TotalPeople = -1, TotalUsers = -1, TotalLicenses = -1;
            float TotalPaidFeesThisMonth = -1, TotalPaidFeesAllTime = -1;

            if (clsDashboardDataAccess.GetData(ref TotalTests, ref TotalPassedTests, ref TotalApplications, ref TotalApplicationsCompleted, ref TotalDrivers,
                                ref TotalPeople, ref TotalUsers, ref TotalLicenses, ref TotalPaidFeesThisMonth, ref TotalPaidFeesAllTime))
                return new clsDashboardBusiness(TotalTests, TotalPassedTests, TotalApplications, TotalApplicationsCompleted, TotalDrivers,
                                TotalPeople, TotalUsers, TotalLicenses, TotalPaidFeesThisMonth, TotalPaidFeesAllTime);
            else
                return null;
        }

        public static DataTable GetTodaysAppointments()
        {
            return clsTestAppointmentsDataAccess.GetTodaysAppointments();
        }

    }
}
