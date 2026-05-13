using System;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccessLayer
{
    public class clsInternationalLicensesDataAccess
    {

        public static bool Find(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate,
                                         ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from InternationalLicenses where InternationalLicenseID = @ID ;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", InternationalLicenseID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            ApplicationID = (int)reader["ApplicationID"];
                            DriverID = (int)reader["DriverID"];
                            IssuedUsingLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                            IssueDate = (DateTime)reader["IssueDate"];
                            ExpirationDate = (DateTime)reader["ExpirationDate"];
                            IsActive = (bool)reader["IsActive"];
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

        public static int AddNewInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLicenseID,  DateTime IssueDate,  DateTime ExpirationDate,
                                          bool IsActive,  int CreatedByUserID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // once a license is created, then application status directly becomes completed (represented as 3 in DB)
                    // and first we have to deactivate any other active international license as system allows only one active per person 
                    string query = @"update InternationalLicenses set IsActive = 0 where DriverID = @DriverID;

                                     insert into InternationalLicenses 
                                     values (@ApplicationID, @DriverID, @IssuedUsingLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);

                                     update Applications
                                     set ApplicationStatus = 3 where ApplicationID = @ApplicationID;
                                     select scope_identity();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLicenseID", IssuedUsingLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLicenseID, DateTime IssueDate, DateTime ExpirationDate,
                                          bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update InternationalLicenses 
                                     set ApplicationID = @ApplicationID, DriverID = @DriverID, IssuedUsingLicenseID = @IssuedUsingLicenseID, IssueDate = @IssueDate, 
                                     ExpirationDate = @ExpirationDate, IsActive = @IsActive, CreatedByUserID = @CreatedByUserID
                                     where InternationalLicenseID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", InternationalLicenseID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLicenseID", IssuedUsingLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static bool DoesLicenseExistByLocalLicenseID(int LicenseID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select Found = 1 from InternationalLicenses where IssuedUsingLocalLicenseID = @ID;";
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
        public static int GetActiveInternationalLicenseIDByPersonID(int PersonID)
        {
            int LicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select InternationalLicenses.InternationalLicenseID
                                     from InternationalLicenses 
                                     inner join Drivers on InternationalLicenses.DriverID = Drivers.DriverID
                                     where Drivers.PersonID = @PersonID and IsActive = 1;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
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


        public static int GetLicenseIDbyBaseApplicationID(int BaseApplicationID)
        {
            int LicenseID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // gets the first time issued local license by LocalLicenseApplicationID
                    string query = @"select InternationalLicenses.InternationalLicenseID 
                                     from InternationalLicenses
                                     inner join Applications on Applications.ApplicationID = InternationalLicenses.ApplicationID
                                     where Applications.ApplicationID = @BaseApplicationID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BaseApplicationID", BaseApplicationID);
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

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                                     from InternationalLicenses order by IssueDate desc;";
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

        public static DataTable GetAllInternationalLicensesByPersonID(int PersonID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select InternationalLicenses.InternationalLicenseID, InternationalLicenses.ApplicationID, InternationalLicenses.IssuedUsingLocalLicenseID,
                                    InternationalLicenses.IssueDate, InternationalLicenses.ExpirationDate, InternationalLicenses.IsActive
                                    from InternationalLicenses 
                                    inner join Drivers on Drivers.DriverID = InternationalLicenses.DriverID
                                    where Drivers.PersonID = @PersonID";
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
