using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace DataAccessLayer
{
    public class clsLicensesDataAccess
    {
        public static bool FindByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID, ref byte LicenseClassID, ref DateTime IssueDate, ref DateTime ExpirationDate,
                                              ref string Notes, ref float PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Licenses where LicenseID = @ID ;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            ApplicationID = (int)reader["ApplicationID"];
                            DriverID = (int)reader["DriverID"];
                            LicenseClassID = Convert.ToByte(reader["LicenseClass"]);
                            IssueDate = (DateTime)reader["IssueDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            Notes = reader["Notes"] == DBNull.Value? "": (string)reader["Notes"];
                            PaidFees = Convert.ToSingle(reader["PaidFees"]);
                            IsActive = (bool)reader["IsActive"];
                            IssueReason = (byte)reader["IssueReason"];
                            CreatedByUserID = (int)reader["CreatedByUserID"];
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

        public static int AddNewLicense(int ApplicationID, int DriverID, byte LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,
                                   string Notes, float PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // once a license is created, then application status directly becomes completed (represented as 3 in DB)
                    string query = @"insert into Licenses 
                                     values (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);

                                     update Applications
                                     set ApplicationStatus = 3 where ApplicationID = @ApplicationID;

                                     select scope_identity();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@IssueReason", IssueReason);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

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
        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, byte LicenseClassID, DateTime IssueDate, DateTime ExpirationDate,
                                   string Notes, float PaidFees, bool IsActive, byte IssueReason, int CreatedByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update Licenses 
                                     set ApplicationID = @ApplicationID, DriverID = @DriverID, LicenseClassID = @LicenseClassID, IssueDate = @IssueDate, 
                                     ExpirationDate = @ExpirationDate, Notes = @Notes, PaidFees = @PaidFees, IsActive = @IsActive, IssueReason = @IssueReason, CreatedByUserID = @CreatedByUserID
                                     where LicenseID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@IssueReason", IssueReason);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

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

        public static bool DidPersonIssueLicense(int PersonID, byte LicenseClassID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select Found = 1 from Licenses
                                     inner join Drivers on Drivers.DriverID = Licenses.DriverID
                                     where Drivers.PersonID = @ID and Licenses.LicenseClass = @LicenseClassID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", PersonID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
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

        public static bool DeactivateLicense(int LicenseID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update Licenses 
                                     set IsActive = 0 where LicenseID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", LicenseID);

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

        public static int GetActiveLicenseIDByPersonID(int PersonID, byte LicenseClassID)
        {
            int LicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select Licenses.LicenseID
                                     from Licenses 
                                     inner join Drivers on Licenses.DriverID = Drivers.DriverID
                                     where Licenses.LicenseClass = @LicenseClassID and Drivers.PersonID = @PersonID and IsActive = 1;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            LicenseID = ID;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return LicenseID;
        }

        public static int GetLicenseIDbyLocalApplicationID(int LocalApplicationID)
        {
            int LicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // gets the first time issued local license by LocalLicenseApplicationID
                    string query = @"select Licenses.LicenseID 
                                     from Licenses
                                     inner join LocalDrivingLicenseApplications as LA on LA.ApplicationID = Licenses.ApplicationID
                                     where LA.LocalDrivingLicenseApplicationID = @LocalApplicationID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            LicenseID = ID;
                    }
                }
            }
            catch (Exception e)
            {
                // logs
                throw;
            }
            return LicenseID;
        }

        public static DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from Licenses;";
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
        public static DataTable GetAllLocalLicensesByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                                     from Licenses 
                                     inner join Drivers on Drivers.DriverID = Licenses.DriverID
                                     inner join LicenseClasses on LicenseClasses.LicenseClassID = Licenses.LicenseClass
                                     where Drivers.PersonID = @PersonID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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
