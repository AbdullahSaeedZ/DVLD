using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DataAccessLayer
{
    public class clsDetainedLicensesDataAccess
    {
        public static bool FindByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, 
                         ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindByDetainID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            LicenseID = (int)reader["LicenseID"];
                            DetainDate = (DateTime)reader["DetainDate"];
                            FineFees = Convert.ToSingle(reader["FineFees"]);
                            CreatedByUserID = reader["CreatedByUserID"] == DBNull.Value ? -1 : (int)reader["CreatedByUserID"]; 
                            IsReleased = Convert.ToBoolean(reader["IsReleased"]);
                            ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["ReleaseDate"];
                            ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value ? -1 : (int)reader["ReleasedByUserID"];
                            ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value ? -1 : (int)reader["ReleaseApplicationID"];
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
        public static bool FindByLicenseID(ref int DetainID, int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased,
                         ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // to get last detention record of this license, a license might have multiple detention records
                    using (SqlCommand command = new SqlCommand("usp_FindDetainedLicenseByLicenseID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            DetainID = (int)reader["DetainID"];
                            DetainDate = (DateTime)reader["DetainDate"];
                            FineFees = Convert.ToSingle(reader["FineFees"]);
                            CreatedByUserID = reader["CreatedByUserID"] == DBNull.Value ? -1 : (int)reader["CreatedByUserID"];
                            IsReleased = Convert.ToBoolean(reader["IsReleased"]);
                            ReleaseDate = reader["ReleaseDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["ReleaseDate"];
                            ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value ? -1 : (int)reader["ReleasedByUserID"];
                            ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value ? -1 : (int)reader["ReleaseApplicationID"];
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


        public static int AddNewDetainLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int NewID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_AddNewDetainLicense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        SqlParameter newIDParam = new SqlParameter("@NewDetainID", SqlDbType.Int)
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


        public static bool UpdateDetainedLicense(int DetainID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_UpdateDetainedLicense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@IsReleased", IsReleased);

                        if (ReleaseDate == DateTime.MinValue)
                            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);

                        if (ReleasedByUserID == -1)
                            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ReleaseDate", ReleasedByUserID);

                        if (ReleaseApplicationID == -1)
                            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ReleaseDate", ReleaseApplicationID);

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

        public static int ReleaseDetainedLicense(int LicenseID, DateTime ReleaseDate, int ReleasedByUserID)
        {
            int newApplicationID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_ReleaseDetainedLicense", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        SqlParameter newApplicationIDParameter = new SqlParameter("@NewReleaseApplicationID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(newApplicationIDParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (newApplicationIDParameter.Value is int newIDValue)
                            newApplicationID = newIDValue;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
            }
            return newApplicationID;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_IsLicenseDetained", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        SqlParameter isDetainedParameter = new SqlParameter("@IsDetained", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(isDetainedParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (isDetainedParameter.Value is bool isDetained)
                            isFound = isDetained;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return isFound;
        }
      
      
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllDetainedLicenses", connection))
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



    }
}
