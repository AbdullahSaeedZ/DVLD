using System;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsDashboardDataAccess
    {

        public static bool GetData(ref int TotalTests, ref int TotalPassedTests, ref int TotalApplications, ref int TotalApplicationsCompleted, ref int TotalDrivers,
                                ref int TotalPeople, ref int TotalUsers, ref int TotalLicenses, ref float TotalPaidFeesThisMonth, ref float TotalPaidFeesAllTime)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Dashboard_View;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TotalTests = (int)reader["TotalTests"];
                            TotalPassedTests = (int)reader["TotalPassedTests"];
                            TotalApplications = (int)reader["TotalApplications"];
                            TotalApplicationsCompleted = (int)reader["TotalApplicationsCompleted"];
                            TotalDrivers = (int)reader["TotalDrivers"];
                            TotalPeople = (int)reader["TotalPeople"];
                            TotalUsers = (int)reader["TotalUsers"];
                            TotalLicenses = (int)reader["TotalLicenses"];
                            TotalPaidFeesThisMonth = Convert.ToSingle(reader["TotalPaidFeesThisMonth"]);
                            TotalPaidFeesAllTime = Convert.ToSingle(reader["TotalPaidFeesAllTime"]);
                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return isFound;
        }
    }
}
