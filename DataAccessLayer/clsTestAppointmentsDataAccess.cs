using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class clsTestAppointmentsDataAccess
    {
        public static bool FindByTestAppointmentID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees,
                                     ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from TestAppointments where TestAppointmentID = @ID ;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestAppointmentID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TestTypeID = (int)reader["TestTypeID"];
                            LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                            AppointmentDate = (DateTime)reader["AppointmentDate"];
                            PaidFees = Convert.ToSingle(reader["PaidFees"]);
                            IsLocked = (bool)reader["IsLocked"];
                            RetakeTestApplicationID = reader["RetakeTestApplicationID"] == DBNull.Value ? -1 : (int)reader["RetakeTestApplicationID"];
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

        public static int AddNewTestAppointment(byte TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
                                     int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int NewID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"insert into TestAppointments 
                                     values (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                                     select scope_identity();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestApplicationID == -1)
                            command.Parameters.AddWithValue(@"RetakeTestApplicationID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);


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
        public static bool UpdateTestAppointment(int TestAppointmentID, byte TestTypeID, int LocalDrivingLicenseApplicationID, DateTime AppointmentDate, float PaidFees,
                                     int CreatedByUserID, bool IsLocked, int RetakeTestApplicationID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"update TestAppointments 
                                     set TestTypeID = @TestTypeID, LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID, AppointmentDate = @AppointmentDate, PaidFees = @PaidFees,
                                     CreatedByUserID = @CreatedByUserID, IsLocked = @IsLocked, RetakeTestApplicationID = @RetakeTestApplicationID
                                     where TestAppointmentID = @ID;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestApplicationID == -1)
                            command.Parameters.AddWithValue(@"RetakeTestApplicationID", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);

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

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select * from TestAppointments order by AppointmentDate desc;";
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
        public static DataTable GetTodaysAppointments()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select TestAppointmentID, AppointmentDate, IsLocked, IsTestTaken = 
                                    cast(
	                                    case 
                                            when EXISTS (select foud = 1 from Tests where Tests.TestAppointmentID = TestAppointments.TestAppointmentID) 
                                            then 1 
                                            else 0 
                                        end as bit)
                                    from TestAppointments 
                                    where cast(AppointmentDate as date) = cast(GETDATE() as date)
                                    order by TestAppointmentID desc;";
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

        public static DataTable GetAllTestAppointmentsByTestTypeID(int LocalDrivingLicenseApplicationID, byte TestTypeID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = @"select TestAppointments.TestAppointmentID, TestAppointments.AppointmentDate, TestAppointments.PaidFees, TestAppointments.IsLocked
                                     from TestAppointments
                                     where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID
                                     order by TestAppointments.AppointmentDate desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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

        // last test appointment that was scheduled for chosen test type of specific local application
        public static bool GetLastTestAppointmentByTestTypeID(ref int TestAppointmentID, byte TestTypeID, int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref float PaidFees,
                                     ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // top 1 cuz application might have multiple appointments for the same test type, and we need only the recent appointment that was scheduled
                    string query = @"select top 1 * from TestAppointments
                                     where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID 
                                     order by TestAppointmentID desc;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            TestAppointmentID = (int)reader["TestAppointmentID"];
                            AppointmentDate = (DateTime)reader["AppointmentDate"];
                            PaidFees = Convert.ToSingle(reader["PaidFees"]);
                            IsLocked = (bool)reader["IsLocked"];
                            RetakeTestApplicationID = reader["RetakeTestApplicationID"] == DBNull.Value ? -1 : (int)reader["RetakeTestApplicationID"];
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

        public static bool IsTestAppointmentLocked(int TestAppointmentID)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    string query = "select Found = 1 from TestAppointments where TestAppointmentID = @TestAppointmentID and IsLocked = 1;";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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


    }
}
