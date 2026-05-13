using System;
using System.Data;
using System.Data.SqlClient;


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
                    string query = "select * from DetainedLicenses where DetainID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", DetainID);
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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = "select top 1 * from DetainedLicenses where LicenseID = @ID order by DetainID desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseID);
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
            catch (Exception e)
            {
                // logs
                throw;
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
                    string query = @"insert into DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                                     values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0)
                                     select scope_identity();";
                                     
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@DetainDate", DetainDate);
                        command.Parameters.AddWithValue("@FineFees", FineFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


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


        public static bool UpdateDetainedLicense(int DetainID, bool IsReleased, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update DetainedLicenses 
                                     set IsReleased = @IsReleased, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                                     where DetainID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                       
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
            catch (Exception e)
            {
                // logs
                throw;
            }
            return (rowsAffected > 0);
        }

        public static bool ReleaseDetainedLicense(int LicenseID, DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update DetainedLicenses 
                                     set IsReleased = 1, ReleaseDate = @ReleaseDate, ReleasedByUserID = @ReleasedByUserID, ReleaseApplicationID = @ReleaseApplicationID
                                     where LicenseID = @ID;

                                     update Applications set ApplicationStatus = 3
                                     where ApplicationID = @ReleaseApplicationID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseID);
                        command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

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

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select Found = 1 from DetainedLicenses where LicenseID = @ID and IsReleased = 0;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseID);
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null)
                            isFound = true;
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
      
      
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.DetainDate, DetainedLicenses.FineFees,
                                     DetainedLicenses.IsReleased, DetainedLicenses.ReleaseDate, People.NationalNo,
                                     FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName, '') + People.LastName, DetainedLicenses.ReleaseApplicationID
                                     from DetainedLicenses
                                     inner join Licenses on Licenses.LicenseID = DetainedLicenses.LicenseID
                                     inner join Drivers on Drivers.DriverID = Licenses.DriverID
                                     inner join People on People.PersonID = Drivers.PersonID
                                     order by DetainDate desc;";
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
