using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTestsDataAccess
    {

        public static bool FindByTestID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Tests where TestID = @ID ;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TestAppointmentID = (int)reader["TestAppointmentID"];
                            TestResult = (bool)reader["TestResult"];
                            Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static bool FindByTestAppointmentID(int TestAppointmentID, ref int TestID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Tests where TestAppointmentID = @AppID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AppID", TestAppointmentID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TestID = (int)reader["TestID"];
                                TestResult = (bool)reader["TestResult"];
                                Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];

                                isFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return isFound;
        }


        public static bool FindLastTestPerPersonAndLicenseClass(int ApplicantPersonID, byte LicenseClassID, int TestTypeID,
                                        ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select top 1 Tests.* from Tests
                                        inner join TestAppointments TA on TA.TestAppointmentID = Tests.TestAppointmentID 
                                        inner join LocalDrivingLicenseApplications LA on LA.LocalDrivingLicenseApplicationID =  TA.LocalDrivingLicenseApplicationID
                                        inner join Applications on Applications.ApplicationID = LA.ApplicationID
                                        where ApplicantPersonID = @ApplicantPersonID and LA.LicenseClassID = @LicenseClassID and TA.TestTypeID = @TestTypeID 
                                        order by TestID desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TestID = (int)reader["TestID"];
                            TestAppointmentID = (int)reader["TestAppointmentID"];
                            TestResult = (bool)reader["TestResult"];
                            Notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
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
       
        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // adding new test record (test taken) will have to lock the test appointment
                    // then if the test has an application of retake type then it will be set to completed, cuz test is retaken 
                    string query = @"insert into Tests 
                                     values (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
            
                                     update TestAppointments 
                                     set IsLocked=1 where TestAppointmentID = @TestAppointmentID;

                                     update Applications
                                     set ApplicationStatus = 3 from Applications 
                                     inner join TestAppointments on TestAppointments.ReTakeTestApplicationID = Applications.ApplicationID
                                     where TestAppointments.TestAppointmentID = @TestAppointmentID
                                     select scope_identity();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            NewID = ID;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return NewID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update Tests 
                                     set TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, Notes = @Notes, CreatedByUserID = @CreatedByUserID
                                     where TestID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestID);
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);


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

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Tests;";
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




        public static bool IsTestPassedByAppointmentId(int TestAppointmentID)
        {
            bool isPassed = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select Tests.TestResult from Tests 
                                     inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID 
                                     where TestAppointments.TestAppointmentID = @ID and Tests.TestResult = 1;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestAppointmentID);
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            isPassed = true;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return isPassed;
        }

        public static int GetTestIDByAppointmentID(int TestAppointmentID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select TestID from Tests where TestAppointmentID = @ID ;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestAppointmentID);
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            NewID = ID;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return NewID;
        }

    }
}
