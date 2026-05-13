using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {
        public static bool FindLocalLicenseApplicationByID(int LocalApplicationID, ref int baseApplicationID, ref byte licenseClassID, ref bool Vision, ref bool Written, ref bool Street)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select LocalDrivingLicenseApplications.*, 
                                    Vision  = max(case when TestAppointments.TestTypeID = 1 and Tests.TestResult = 1 then 1 else 0 end),
									Written = max(case when TestAppointments.TestTypeID = 2 and Tests.TestResult = 1 then 1 else 0 end),
									Street  = max(case when TestAppointments.TestTypeID = 3 and Tests.TestResult = 1 then 1 else 0 end)
                                    from LocalDrivingLicenseApplications
                                    left join TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                                    left join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                    where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @ID
                                    group by LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LocalApplicationID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            baseApplicationID = (int)reader["ApplicationID"];
                            licenseClassID = Convert.ToByte(reader["LicenseClassID"]);
                            Vision = Convert.ToBoolean(reader["Vision"]);
                            Written = Convert.ToBoolean(reader["Written"]);
                            Street = Convert.ToBoolean(reader["Street"]);
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

        public static bool FindLocalLicenseApplicationByApplicationID(ref int LocalApplicationID,  int baseApplicationID, ref byte licenseClassID, ref bool Vision, ref bool Written, ref bool Street)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select LocalDrivingLicenseApplications.*, 
                                    Vision  = max(case when TestAppointments.TestTypeID = 1 and Tests.TestResult = 1 then 1 else 0 end),
									Written = max(case when TestAppointments.TestTypeID = 2 and Tests.TestResult = 1 then 1 else 0 end),
									Street  = max(case when TestAppointments.TestTypeID = 3 and Tests.TestResult = 1 then 1 else 0 end)
                                    from LocalDrivingLicenseApplications
                                    left join TestAppointments on TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                                    left join Tests on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                    where LocalDrivingLicenseApplications.ApplicationID = @ID
                                    group by LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LocalDrivingLicenseApplications.ApplicationID,LocalDrivingLicenseApplications.LicenseClassID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", baseApplicationID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            LocalApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                            licenseClassID = Convert.ToByte(reader["LicenseClassID"]);
                            Vision = Convert.ToBoolean(reader["Vision"]);
                            Written = Convert.ToBoolean(reader["Written"]);
                            Street = Convert.ToBoolean(reader["Street"]);
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

        public static int AddLocalLicenseApplication(byte licenseClassID, int applicationID)
        {
            int newID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"insert into LocalDrivingLicenseApplications
                                     values ( @ApplicationID, @LicenseClassID);
                                     select scope_identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", applicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                            newID = id;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return newID;
        }

        public static bool UpdateLocalLicenseApplication( int LocalApplicationID, byte licenseClassID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update LocalDrivingLicenseApplications
                                     set LicenseClassID = @LicenseClassID
                                     where LocalDrivingLicenseApplicationID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LocalApplicationID);
                        command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteLocalDrivingLicenseApplication( int LocalApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"delete LocalDrivingLicenseApplications
                                     where LocalDrivingLicenseApplicationID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LocalApplicationID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                return false;
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from LocalDrivingLicenseApplications_View order by ApplicationDate desc;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                            dt.Load(reader);
                        else
                            dt = null;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return dt;
        }


        public static int GetActiveLocalApplicationID(int ApplicantPersonID, byte LicenseClassID)
        {
            int activeNewApplicationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // business requires that new application of same class is allowed if no NEW application or COMPLETED application with license in system
                    // here just check if there is new status

                    string query = @"select LocalDrivingLicenseApplicationID
                                     from LocalDrivingLicenseApplications 
                                     inner join Applications on LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                                     where LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID and Applications.ApplicantPersonID = @ApplicantPersonID and Applications.ApplicationStatus = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                            activeNewApplicationID = id;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return activeNewApplicationID;
        }

        public static int GetTotalTestTrialsPerTestType(int LocalApplicationID, int TestTypeID)
        {
            int TotalTrials = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select TestTrials = count(TestAppointmentID)
                                    from TestAppointments 
                                    where LocalDrivingLicenseApplicationID = @LocalApplicationID and TestTypeID = @TestTypeID and IsLocked = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int i))
                            TotalTrials = i;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return TotalTrials;
        }

        public static bool IsThereActiveTestAppointment(int LocalApplicationID, int TestTypeID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select top 1 Found = 1 from TestAppointments
                                    where LocalDrivingLicenseApplicationID = @LocalApplicationID and TestTypeID = @TestTypeID and IsLocked = 0
                                    order by TestAppointments.TestAppointmentID desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                            isFound = true;
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

        // this is checking if there is any appointments records related to the application to prevent editing data, whether active or not 
        public static bool DoesHaveAnyAppointmentsRecords(int LocalApplicationID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select top 1 Found = 1 from TestAppointments
                                    where LocalDrivingLicenseApplicationID = @LocalApplicationID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                            isFound = true;
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

        public static bool DidAttendAppointmentOfTestType(int LocalApplicationID, int TestTypeID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select top 1 Found = 1 from TestAppointments
                                    where LocalDrivingLicenseApplicationID = @LocalApplicationID and TestTypeID = @TestTypeID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                            isFound = true;
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
