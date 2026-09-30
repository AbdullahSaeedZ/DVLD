using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DataAccessLayer
{
    public class clsTestTypesDataAccess
    {
        public static bool FindTestType(int ID, ref string testTypeTitle, ref string testTypeDescription, ref float testTypeFees)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindTestTypeByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestTypeID", ID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            testTypeTitle = (string)reader["TestTypeTitle"];
                            testTypeDescription = (string)reader["TestTypeDescription"];
                            testTypeFees = Convert.ToSingle(reader["TestTypeFees"]);
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

        public static bool UpdateTestType(int ID, string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_UpdateTestType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TestTypeID", ID);
                        command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
                        command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);
                        command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);
                  
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

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllTestTypes", connection))
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
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return dt;
        }
    }
}
