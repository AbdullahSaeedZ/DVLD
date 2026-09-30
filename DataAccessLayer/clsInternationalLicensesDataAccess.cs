using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsInternationalLicensesDataAccess
    {

        public static bool Find(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate,
                                         ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindInternationalLicenseByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("InternationalLicenseID", InternationalLicenseID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            ApplicationID = (int)reader["ApplicationID"];
                            DriverID = (int)reader["DriverID"];
                            IssuedUsingLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                            IssueDate = (DateTime)reader["IssueDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            IsActive = (bool)reader["IsActive"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewInternationalLicense(int DriverID, int IssuedUsingLicenseID,  DateTime IssueDate,  DateTime ExpirationDate,
                                          bool IsActive,  int CreatedByUserID)
        {
            int NewID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_AddNewInternationalLicense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLicenseID", IssuedUsingLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        SqlParameter newIDParam = new SqlParameter("@NewInterNationalLicenseID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(newIDParam);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (newIDParam.Value is int id)
                            NewID = id;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
            }
            return NewID;
        }
        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLicenseID, DateTime IssueDate, DateTime ExpirationDate,
                                          bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_UpdateInternationalLicense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLicenseID", IssuedUsingLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static int GetActiveInternationalLicenseIDByPersonID(int PersonID)
        {
            int LicenseID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetActiveInternationalLicenseIDByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        SqlParameter idParam = new SqlParameter("@InterNationalLicenseID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(idParam);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (idParam.Value is int id)
                            LicenseID = id;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return LicenseID;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllInternationalLicenses", connection))
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

        public static DataTable GetAllInternationalLicensesByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllInternationalLicensesByPersonID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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


    }
}
