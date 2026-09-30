using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DataAccessLayer
{
    public class clsLocalDrivingLicenseApplicationsDataAccess
    {
        public static bool FindLocalLicenseApplicationByID(int LocalApplicationID, ref int baseApplicationID, ref byte licenseClassID, ref bool Vision, ref bool Written, ref bool Street)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindLocalLicenseApplicationByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            baseApplicationID = (int)reader["ApplicationID"];
                            licenseClassID = Convert.ToByte(reader["LicenseClassID"]);
                            Vision = Convert.ToBoolean(reader["Vision"]);
                            Written = Convert.ToBoolean(reader["Written"]);
                            Street = Convert.ToBoolean(reader["Street"]);
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

        public static bool FindLocalLicenseApplicationByApplicationID(ref int LocalApplicationID,  int baseApplicationID, ref byte licenseClassID, ref bool Vision, ref bool Written, ref bool Street)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindLocalLicenseApplicationByApplicationID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@baseApplicationID", baseApplicationID);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            LocalApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                            licenseClassID = Convert.ToByte(reader["LicenseClassID"]);
                            Vision = Convert.ToBoolean(reader["Vision"]);
                            Written = Convert.ToBoolean(reader["Written"]);
                            Street = Convert.ToBoolean(reader["Street"]);
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

        public static int AddLocalLicenseApplication(byte licenseClassID, int applicationID, clsDataTransaction transaction)
        {
            int newID = -1;
            try
            {
                
                using (SqlCommand command = new SqlCommand("usp_AddLocalLicenseApplication", transaction.Connection, transaction.Transaction))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@baseApplicationID", applicationID);
                    command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                    SqlParameter newIDParam = new SqlParameter("@NewLocalLicenseApplicationID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(newIDParam);
                    command.ExecuteNonQuery();

                    if (newIDParam.Value is int id)
                        newID = id;
                }
                
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                throw;
            }
            return newID;
        }

        public static bool UpdateLocalLicenseApplication( int LocalApplicationID, byte licenseClassID, clsDataTransaction transaction)
        {
            int rowsAffected = 0;
            try
            {
               using (SqlCommand command = new SqlCommand("usp_UpdateLocalLicenseApplication", transaction.Connection, transaction.Transaction))
               {
                   command.CommandType = CommandType.StoredProcedure;
                   command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                   command.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                   rowsAffected = command.ExecuteNonQuery();
               }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                throw;
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteLocalDrivingLicenseApplication( int LocalApplicationID)
        {
            bool success = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_DeleteLocalDrivingLicenseApplication", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        SqlParameter returnParam = new SqlParameter("@ReturnValue", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        command.Parameters.Add(returnParam);

                        connection.Open();
                        command.ExecuteNonQuery(); // if executed with no exception, it means deletion was successful
                        success = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                Log.LogEvent(EventLogEntryType.Information, ex.Message, ex.StackTrace);
                if (ex.Number == 547) // threw due to linked data (FK)
                    throw new InvalidOperationException("Cannot delete the local driving license application because it has linked records to it", ex); // just to inform user in ui
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
            }
            return success;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllLocalDrivingLicenseApplications", connection))
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


        public static int GetActiveLocalApplicationID(int ApplicantPersonID, byte LicenseClassID)
        {
            int activeNewApplicationID = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    // business requires that new application of same class is allowed if no NEW application or COMPLETED application with license in system
                    // here just check if there is new status
                    using (SqlCommand command = new SqlCommand("usp_GetActiveLocalApplicationID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        SqlParameter activeIDParam = new SqlParameter("@ActiveLocalApplicationID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(activeIDParam);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (activeIDParam.Value is int id)
                            activeNewApplicationID = id;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return activeNewApplicationID;
        }

        public static int GetTotalTestTrialsPerTestType(int LocalApplicationID, int TestTypeID)
        {
            int TotalTrials = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetTotalTestTrialsPerTestType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        SqlParameter totalTrialsParam = new SqlParameter("@TotalTrials", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(totalTrialsParam);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (totalTrialsParam.Value is int id)
                            TotalTrials = id;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return TotalTrials;
        }

        public static bool IsThereActiveTestAppointment(int LocalApplicationID, int TestTypeID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_IsThereActiveTestAppointment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        SqlParameter isThereActiveParam = new SqlParameter("@isThereActiveAppointment", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(isThereActiveParam);
                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        if (isThereActiveParam.Value is bool active)
                            isFound = active;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return isFound;
        }

        // this is checking if there is any appointments records related to the application to prevent editing data, whether active or not 
        public static bool DoesHaveAnyAppointmentsRecords(int LocalApplicationID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_DoesHaveAnyAppointmentsRecords", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);

                        SqlParameter hasAnyAppointmentsParam = new SqlParameter("@hasAnyAppointment", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(hasAnyAppointmentsParam);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (hasAnyAppointmentsParam.Value is bool hasAny)
                            isFound = hasAny;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return isFound;
        }

        public static bool DidAttendAppointmentOfTestType(int LocalApplicationID, int TestTypeID)
        {
            bool isFound = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_DidAttendAppointmentOfTestType", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        SqlParameter didAttendParam = new SqlParameter("@didAttend", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(didAttendParam);
                        connection.Open();
                        command.ExecuteNonQuery();

                        if (didAttendParam.Value is bool didAttend)
                            isFound = didAttend;
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
