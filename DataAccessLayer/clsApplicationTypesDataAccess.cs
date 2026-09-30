using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace DataAccessLayer
{
    public class clsApplicationTypesDataAccess
    {
        public static bool FindApplicationType(int ID, ref string applicationTypeTitle, ref float applicationTypeFees)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindApplicationTypeByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@applicationTypeID", ID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            applicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                            applicationTypeFees = Convert.ToSingle(reader["ApplicationFees"]);
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
        public static bool UpdateApplicationType(int ID, string applicationTypeTitle, float applicationTypeFees)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_UpdateApplicationTypeByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@applicationTypeID", ID);
                        command.Parameters.AddWithValue("@applicationTypeTitle", applicationTypeTitle);
                        command.Parameters.AddWithValue("@applicationTypeFees", applicationTypeFees);

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
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllApplicationTypes", connection))
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
