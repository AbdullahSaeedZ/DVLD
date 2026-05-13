using System;
using System.Data.SqlClient;


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
                    string query = "select * from UserTokens where UserID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", UserID);
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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = "select * from UserTokens where TokenID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TokenID);
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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = "select * from UserTokens where TokenValue = @Value and (getdate() < ExpirationDate);";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value", TokenValue);
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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = @"insert into UserTokens 
                                     values (@UserID, @TokenValue, @CreatedDate, @ExpirationDate);
                                     select scope_identity();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                        command.Parameters.AddWithValue("@TokenValue", TokenValue);
                        command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);

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

        public static bool SetTokenExpired(string TokenValue)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update UserTokens 
                                     set ExpirationDate = getdate()
                                     where TokenValue = @TokenValue;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TokenValue", TokenValue);

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


    }
}
