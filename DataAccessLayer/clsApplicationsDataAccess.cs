using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

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
                    using (SqlCommand command = new SqlCommand("usp_FindApplicationByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return isFound;
        }

        public static int AddNewApplication(int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus,
                                                 DateTime lastStatusDate, float paidFees, int createdByUserID, clsDataTransaction transaction)
        {
            int newID = -1;
            try
            {
                using (SqlCommand command = new SqlCommand("usp_AddNewApplication", transaction.Connection, transaction.Transaction))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                    command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                    command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                    command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                    command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                    command.Parameters.AddWithValue("@PaidFees", paidFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                    SqlParameter newIDParameter = new SqlParameter("@NewApplicationID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    
                    command.Parameters.Add(newIDParameter);
                    command.ExecuteNonQuery();

                    if (newIDParameter.Value is int id)
                        newID = id;
                }
                
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                throw;
            }
            return newID;
        }

        public static bool UpdateApplication(int ApplicationID , int applicantPersonID, DateTime applicationDate, int applicationTypeID, byte applicationStatus,
                                                 DateTime lastStatusDate, float paidFees, int createdByUserID , clsDataTransaction transaction)
        {
            int rowsAffected = 0;
            try
            {
               using (SqlCommand command = new SqlCommand("usp_UpdateApplication", transaction.Connection, transaction.Transaction))
               {
                   command.CommandType = CommandType.StoredProcedure;
                   command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                   command.Parameters.AddWithValue("@ApplicantPersonID", applicantPersonID);
                   command.Parameters.AddWithValue("@ApplicationDate", applicationDate);
                   command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
                   command.Parameters.AddWithValue("@ApplicationStatus", applicationStatus);
                   command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
                   command.Parameters.AddWithValue("@PaidFees", paidFees);
                   command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                   rowsAffected = command.ExecuteNonQuery();
               }
               
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
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
                    using (SqlCommand command = new SqlCommand("usp_DeleteBaseApplication", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
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
                    using (SqlCommand command = new SqlCommand("usp_GetAllApplications", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                            dt.Load(reader);
                        else
                            dt = null;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
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
                    using (SqlCommand command = new SqlCommand("usp_UpdateApplicationStatus", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@UpdateDate", UpdateDate);
                        command.Parameters.AddWithValue("@NewStatus", NewStatus);

                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return (rowsAffected > 0);
        }

        public static int GetActiveApplicationID(int ApplicantPersonID, byte ApplicationTypeID)
        {
            int activeNewApplicationID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetActiveApplicationID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                        SqlParameter idParameter = new SqlParameter("@ActiveApplicationID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(idParameter);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (idParameter.Value is int id)
                            activeNewApplicationID = id;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return activeNewApplicationID;
        }


    }
}
