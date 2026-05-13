using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsApplicationsDataAccess
    {
        public static bool FindApplicationByID(int ApplicationID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID, ref  byte applicationStatus,
                                                ref DateTime lastStatusDate, ref float paidFees, ref int createdByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select * from Applications
                                 where ApplicationID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ApplicationID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            applicantPersonID = (int)reader["ApplicantPersonID"];
                            applicationDate = (DateTime)reader["ApplicationDate"];
                            applicationTypeID = (int)reader["ApplicationTypeID"];
                            applicationStatus = (byte)reader["ApplicationStatus"];
                            lastStatusDate = (DateTime)reader["LastStatusDate"];
                            paidFees = Convert.ToSingle(reader["PaidFees"]);
                            createdByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus,
                                                 DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            int newID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"insert into Applications
                                     values ( @ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID);
                                     select scope_identity();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                        command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                        command.Parameters.AddWithValue("@PaidFees", paidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

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

        public static bool UpdateApplication(int ApplicationID , int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus,
                                                 DateTime lastStatusDate, float paidFees, int createdByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update Applications
                                     set ApplicantPersonID = @ApplicantPersonID, ApplicationDate = @ApplicationDate, ApplicationTypeID = @ApplicationTypeID, ApplicationStatus = @ApplicationStatus,
                                     LastStatusDate = @LastStatusDate, PaidFees = @PaidFees, CreatedByUserID = @CreatedByUserID
                                     where ApplicationID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ApplicationID);
                        command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                        command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                        command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                        command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                        command.Parameters.AddWithValue("@PaidFees", paidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

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

        public static bool DeleteBaseApplication(int ApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "delete Applications where ApplicationID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ApplicationID);

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

        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Applications;";

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


        public static bool UpdateStatus(int ApplicationID, byte NewStatus, DateTime UpdateDate)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update Applications 
                                     set ApplicationStatus = @NewStatus, LastStatusDate = @UpdateDate
                                     where ApplicationID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ApplicationID);
                        command.Parameters.AddWithValue("@UpdateDate", UpdateDate);
                        command.Parameters.AddWithValue("@NewStatus", NewStatus);

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

        public static int GetActiveApplicationID(int ApplicantPersonID, byte ApplicationType)
        {
            int activeNewApplicationID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select ApplicationID
                                     from Applications 
                                     where ApplicantPersonID = @ApplicantPersonID and ApplicationType = @ApplicationType and ApplicationStatus = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationType", ApplicationType);

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


    }
}
