using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


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
                    using (SqlCommand command = new SqlCommand("usp_GetAllCountries", connection))
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

            } catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
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
                    using (SqlCommand command = new SqlCommand("usp_GetCountryByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryID", CountryID);
                        
                        SqlParameter countryNameParameter = new SqlParameter("@CountryName", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(countryNameParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (countryNameParameter.Value is string name)
                        {
                            CountryName = name;
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

        public static bool GetCountry(ref int CountryID, string CountryName)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetCountryByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@CountryName", CountryName);
                        
                        SqlParameter countryIDParameter = new SqlParameter("@CountryID", SqlDbType.VarChar, 100)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(countryIDParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (countryIDParameter.Value is int id)
                        {
                            CountryID = id;
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

    }
}
