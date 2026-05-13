using System;
using System.Data;
using System.Data.SqlClient;


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
                    string query = "select * from TestTypes where TestTypeID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);

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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = @"update TestTypes
                                     set testTypeTitle = @Title, TestTypeDescription = @Description, TestTypeFees = @Fees
                                     where TestTypeID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                        command.Parameters.AddWithValue("@Title", testTypeTitle);
                        command.Parameters.AddWithValue("@Description", testTypeDescription);
                        command.Parameters.AddWithValue("@Fees", testTypeFees);

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

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from TestTypes;";

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
