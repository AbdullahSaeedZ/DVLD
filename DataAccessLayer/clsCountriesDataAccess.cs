using System;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class clsCountriesDataAccess
    {

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select CountryName from Countries;";
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

            } catch (Exception e)
            {
                throw;
            }
            return dt;
        }

        public static bool GetCountry(int CountryID, ref string CountryName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select CountryName from Countries where CountryID = @CountryID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        connection.Open();
                        object result= command.ExecuteScalar();
                        
                        if (result != null)
                        {
                            CountryName = result.ToString();
                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return isFound;
        }

        public static bool GetCountry(ref int CountryID, string CountryName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select CountryID from Countries where CountryName = @CountryName;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryName", CountryName);
                        connection.Open();
                        object result= command.ExecuteScalar();
                        
                        if (result != null && int.TryParse(result.ToString() , out int ID))
                        {
                            CountryID = ID;
                            isFound = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return isFound;
        }

    }
}
