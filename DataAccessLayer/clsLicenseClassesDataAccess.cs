using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsLicenseClassesDataAccess
    {
        public static bool GetLicenseClassInfoByID(byte LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select * from LicenseClasses
                                 where LicenseClassID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseClassID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            ClassName = (string)reader["ClassName"];
                            ClassDescription = (string)reader["ClassDescription"];
                            MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                            DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                            ClassFees = Convert.ToSingle(reader["ClassFees"]);
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

        public static bool GetLicenseClassInfoByClassName(string ClassName, ref byte LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge, ref byte DefaultValidityLength, ref float ClassFees)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select * from LicenseClasses
                                 where ClassName = @Name;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", ClassName);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            LicenseClassID = Convert.ToByte(reader["LicenseClassID"]);
                            ClassDescription = (string)reader["ClassDescription"];
                            MinimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                            DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                            ClassFees = Convert.ToSingle(reader["ClassFees"]);
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

        public static bool UpdateLicenseClass(byte LicenseClassID, string ClassName, string ClassDescription, byte MinimumAllowedAge, byte DefaultValidityLength, float ClassFees)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update LicenseClasses
                                     set ClassName = @ClassName, ClassDescription = @ClassDescription, MinimumAllowedAge = @MinimumAllowedAge, DefaultValidityLength = @DefaultValidityLength, ClassFees = @ClassFees                                  
                                     where LicenseClassID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseClassID);
                        command.Parameters.AddWithValue("@ClassName", ClassName);
                        command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
                        command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
                        command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
                        command.Parameters.AddWithValue("@ClassFees", ClassFees);

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

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from LicenseClasses;";

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
