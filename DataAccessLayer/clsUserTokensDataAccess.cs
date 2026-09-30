using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DataAccessLayer
{
    public class clsUserTokensDataAccess
    {

        public static bool FindByUserID(ref int TokenID, int UserID, ref string TokenValue, ref DateTime CreatedDate, ref DateTime ExpirationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindTokenByUserID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TokenID = (int)reader["TokenID"];
                            TokenValue = (string)reader["TokenValue"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
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
        public static bool FindByTokenID(int TokenID, ref int UserID, ref string TokenValue, ref DateTime CreatedDate, ref DateTime ExpirationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindTokenByTokenID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TokenID", TokenID);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            UserID = (int)reader["UserID"];
                            TokenValue = (string)reader["TokenValue"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
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

        public static bool FindByTokenValue(ref int TokenID, ref int UserID, string TokenValue, ref DateTime CreatedDate, ref DateTime ExpirationDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindTokenByTokenValue", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TokenValue", TokenValue);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TokenID = (int)reader["TokenID"];
                            UserID = (int)reader["UserID"];
                            CreatedDate = (DateTime)reader["CreatedDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
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


        public static int AddNewToken(int UserID, string TokenValue, DateTime CreatedDate, DateTime ExpirationDate)
        {
            int NewID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_AddNewToken", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@TokenValue", TokenValue);
                        command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        
                        SqlParameter newTokenIDParam = new SqlParameter("@NewTokenID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(newTokenIDParam);
                        
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (newTokenIDParam.Value is int id)
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

        public static bool SetTokenExpired(string TokenValue)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_SetTokenExpired", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TokenValue", TokenValue);
                        
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


    }
}
