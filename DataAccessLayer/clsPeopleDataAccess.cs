using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

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
                    connection.Open();
                    string query = $@"select * from People where PersonID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", PersonID);
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
            catch (Exception e)
            {
                throw;
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
                    connection.Open();
                    string query = $@"select * from People where NationalNo = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", NationalID);
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
            catch (Exception e)
            {
                throw;
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
                    string query = @"insert into People
                                values(@NationalID, @FirstName, @SecondName, @ThirdName, @LastName, @BirthDate, @Gender, @Address,  
                                @Phone, @Email, @NationalityCountryID, @ImagePath);
                                select scope_identity();";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalID", NationalID);
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


                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            newID = ID;
                    }
                }

            } 
            catch (Exception e)
            {
                throw;
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
                    string query = @"update People
                            set NationalNo = @NationalID, FirstName = @FirstName, SecondName = @SecondName, ThirdName = @ThirdName, LastName = @LastName, DateOfBirth = @BirthDate, 
                            Gender = @Gender, Address = @Address, Phone = @Phone, Email = @Email, NationalityCountryID = @CountryID, ImagePath = @ImagePath
                            where PersonID = @ID;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", PersonID);
                        command.Parameters.AddWithValue("@NationalID", NationalID);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@CountryID", NationalityCountryID);
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
            catch (Exception e)
            {
                throw;
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
                    string query = @"delete from People where PersonID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", PersonID);
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                // referential integrity will cause exception
                return false;
            }
            return (rowsAffected > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                string query = @"select PersonID,NationalNo, FirstName , SecondName, ThirdName , LastName , 
                                case 
                                    when People.Gender = 0 then 'Male' 
                                    else 'Female' 
                                end as Gender, DateOfBirth, Countries.CountryName, Phone, Email
                                from People
                                inner join Countries on Countries.CountryID = People.NationalityCountryID;";

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
            return dt;
        }

        public static bool DoesPersonExist(int PersonID) 
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"select A=1 from People where PersonID = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", PersonID);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
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
        public static bool DoesPersonExist(string NationalID) 
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
                {
                    connection.Open();
                    string query = @"select A=1 from People where NationalNo = @ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", NationalID);
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
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
