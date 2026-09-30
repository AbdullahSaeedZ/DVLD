using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DataAccessLayer
{
    public class clsPeopleDataAccess
    {

        public static bool FindPerson(int PersonID, ref string NationalID, ref string FirstName, ref string SecondName, ref string ThirdName,
                  ref string LastName, ref byte Gender, ref int NationalityCountryID, ref string Phone, ref string Email, ref string Address, ref string ImagePath, ref DateTime BirthDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindPersonByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            NationalID = (string)reader["NationalNo"];
                            FirstName = (string)reader["FirstName"];
                            SecondName = (string)reader["SecondName"];
                            ThirdName = reader["ThirdName"] == DBNull.Value ? string.Empty : (string)reader["ThirdName"];
                            LastName = (string)reader["LastName"];
                            Gender = (byte)reader["Gender"];
                            NationalityCountryID = (int)reader["NationalityCountryID"];
                            Phone = (string)reader["Phone"];
                            Email = reader["Email"] == DBNull.Value ? string.Empty : (string)reader["Email"];
                            Address = (string)reader["Address"];
                            BirthDate = (DateTime)reader["DateOfBirth"];
                            ImagePath = reader["ImagePath"] == DBNull.Value ? string.Empty : (string)reader["ImagePath"];

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
        public static bool FindPerson(ref int PersonID, string NationalID, ref string FirstName, ref string SecondName, ref string ThirdName,
                  ref string LastName, ref byte Gender, ref int NationalityCountryID, ref string Phone, ref string Email, ref string Address, ref string ImagePath, ref DateTime BirthDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_FindPersonByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;                
                        command.Parameters.AddWithValue("@@NationalNo", NationalID);
                        
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            PersonID = (int)reader["PersonID"];
                            FirstName = (string)reader["FirstName"];
                            SecondName = (string)reader["SecondName"];
                            ThirdName = reader["ThirdName"] == DBNull.Value ? string.Empty : (string)reader["ThirdName"];
                            LastName = (string)reader["LastName"];
                            Gender = (byte)reader["Gender"];
                            NationalityCountryID = (int)reader["NationalityCountryID"];
                            Phone = (string)reader["Phone"];
                            Email = reader["Email"] == DBNull.Value ? string.Empty : (string)reader["Email"];
                            Address = (string)reader["Address"];
                            BirthDate = (DateTime)reader["DateOfBirth"];
                            ImagePath = reader["ImagePath"] == DBNull.Value ? string.Empty : (string)reader["ImagePath"];

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

        public static int AddNewPerson( string NationalID,  string FirstName,  string SecondName,  string ThirdName,
                   string LastName,  byte Gender,  int NationalityCountryID,  string Phone,  string Email,  string Address,  string ImagePath,  DateTime BirthDate)
        {
            int newID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    
                    using (SqlCommand command = new SqlCommand("usp_AddNewPerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("@NationalNo", NationalID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);

                        if (string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue(@"ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue(@"ImagePath", ImagePath);

                        if (string.IsNullOrEmpty(ThirdName))
                            command.Parameters.AddWithValue(@"ThirdName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);

                        if (string.IsNullOrEmpty(Email))
                            command.Parameters.AddWithValue(@"Email", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Email", Email);

                        SqlParameter newPersonIDParameter = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(newPersonIDParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (newPersonIDParameter.Value is int id)
                            newID = id;
                    }
                }

            } 
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return newID;
        }


        public static bool UpdatePerson( int PersonID, string NationalID,  string FirstName,  string SecondName,  string ThirdName,
                   string LastName,  byte Gender,  int NationalityCountryID,  string Phone,  string Email,  string Address,  string ImagePath,  DateTime BirthDate)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_UpdatePerson", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@NationalNo", NationalID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@BirthDate", BirthDate);

                        if (string.IsNullOrEmpty(ImagePath))
                            command.Parameters.AddWithValue(@"ImagePath", DBNull.Value);
                        else
                            command.Parameters.AddWithValue(@"ImagePath", ImagePath);

                        if (string.IsNullOrEmpty(ThirdName))
                            command.Parameters.AddWithValue(@"ThirdName", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }
            return (rowsAffected > 0);
        }

        public static bool DeletePerson(int PersonID)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_DeletePersonByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                // referential integrity will cause exception
                return false;
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    using (SqlCommand command = new SqlCommand("usp_GetAllPeople", connection))
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
            catch (Exception e)
            {
                Log.LogEvent(EventLogEntryType.Error, e.Message, e.StackTrace);
            }
           
            return dt;
        }

        public static bool DoesPersonExist(int PersonID) 
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {

                    using (SqlCommand command = new SqlCommand("usp_DoesPersonExistByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        
                        SqlParameter isFoundParameter = new SqlParameter("@isFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(isFoundParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (isFoundParameter.Value is bool exists)
                            isFound = exists;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.LogEvent(EventLogEntryType.Error, ex.Message, ex.StackTrace);
                
            }

            return isFound;
        }
        public static bool DoesPersonExist(string NationalID) 
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {

                    using (SqlCommand command = new SqlCommand("usp_DoesPersonExistByNationalNo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@NationalNo", NationalID);
                        
                        SqlParameter isFoundParameter = new SqlParameter("@isFound", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(isFoundParameter);
                        
                        connection.Open();
                        command.ExecuteNonQuery();
                        if (isFoundParameter.Value is bool exists)
                            isFound = exists;
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
