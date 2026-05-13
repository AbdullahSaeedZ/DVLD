using System;
using System.Data;
using System.Data.SqlClient;


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
                    string query = "select * from ApplicationTypes where ApplicationTypeID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);

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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = @"update ApplicationTypes
                                     set ApplicationTypeTitle = @Title, ApplicationFees = @Fees
                                     where ApplicationTypeID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Title", applicationTypeTitle);
                        command.Parameters.AddWithValue("@Fees", applicationTypeFees);

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



        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from ApplicationTypes;";

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


    }
}
