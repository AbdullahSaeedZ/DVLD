using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;



namespace BusinessLayer
{
    public static class clsBusinessSettings
    {

        // all permissions
        [Flags]
        public enum enPermissions
        {
            eAll = -1,          
            eNone = 0,          
            eListUsers = 1 << 0,   
            eAddUser = 1 << 1,     
            eUpdateUser = 1 << 2,  
            eDeleteUser = 1 << 3,  
            eListPeople = 1 << 4,  
            eAddPerson = 1 << 5,
            eUpdatePerson = 1 << 6,
            eDeletePerson = 1 << 7,
            eIssueLicense = 1 << 8,
            eDetainLicense = 1 << 9,
            eReleaseLicense = 1 << 10,
            eListApplications = 1 << 11,
            eAddApplications = 1 << 12,
            eUpdateApplications = 1 << 13,
            eDeleteApplications = 1 << 14,
            eUpdateApplicationType = 1 << 15,
            eUpdateTestType = 1 << 16
        };

        // Add/Edit person form
        public static  string  _ServerPicturesFolder = @"D:\UsersPictures\";
        public readonly static  string _defaultComboBoxCountry = "Saudi Arabia";
        public static DateTime _defaultMinAllowedAge = DateTime.Now.AddYears(-18);
        // User Login Info remember me
        public static string _RememberMeFile = @"D:\UserLogin.txt"; // later will be saved professionally


        // this is copying files from users computers to our server, so need business layer, not helper class in UI.
        public static string CopyImageToServer(string newPicPath, string oldPicPath) 
        {
            try
            {
                // scenario 1: user removed image to nothing
                if (string.IsNullOrEmpty(newPicPath))
                {
                    DeleteFileIfExists(oldPicPath);
                    return ""; // empty path to be sent to object then to DB
                }

                // setting up the directory
                if (!Directory.Exists(_ServerPicturesFolder))
                    Directory.CreateDirectory(_ServerPicturesFolder);


                // perform Copy
                // scenario 2: no old pic,then new pic added
                // scenario 3: remove old pic,then new pic added
                string destinationPath = Path.Combine(_ServerPicturesFolder, Guid.NewGuid() + Path.GetExtension(newPicPath));

                if (File.Exists(newPicPath))
                {
                    File.Copy(newPicPath, destinationPath, true);
                    DeleteFileIfExists(oldPicPath); // Clean up old after success
                    return destinationPath;
                }
            }
            catch (IOException i)
            {
                // logs
                return "";
            }

            return "";
        }

        private static void DeleteFileIfExists(string path)
        {
            try
            {
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    File.Delete(path);
            }
            catch (IOException i)
            {
                throw;
            }
        }


        // validations
        public static bool IsEmailFormatValid(string Email)
        {
            return Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]+$", RegexOptions.IgnoreCase); //RegularExpressions same as Java
        }

        public static bool IsPasswordFormatValid(string Password)
        {
            // at least one small, one capital, one number, one special character, min 8 max 20
            return Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#&*!._%+-]).{8,20}$"); 
        }


        public static bool IsValidInteger(string Number)
        {
            return int.TryParse(Number, out int test);
        }

        public static bool IsValidFloat(string Number)
        {
            return float.TryParse(Number, out float test);
        }

        public static bool IsValidNumber(string Number)
        {
            return double.TryParse(Number, out double test); // will return true if text is int or double
        }


        // keep me logged methods
        public static void SaveTokenToRegistry(string tokenValue)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string valueName = "Login Token";

            string encryptedTokenValue = clsBusinessSecurity.EncryptToken(tokenValue);

            try
            {
                Registry.SetValue(keyPath, valueName, encryptedTokenValue, RegistryValueKind.String);
            }
            catch (Exception)
            {
                throw new Exception("Failed to write token to registry");
            }
        }

        public static string GetTokenFromRegistry()
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string valueName = "Login Token";

            string value = "";
            try
            {
                value = Registry.GetValue(keyPath, valueName, null) as string;

                if (value != null)
                    value = clsBusinessSecurity.DecryptToken(value);
            }
            catch (Exception)
            {
                RemoveTokenFromRegistry();
                throw new Exception("Failed to read token from registry, registry is cleared now.");
            }

            return value;
        }

        public static void RemoveTokenFromRegistry()
        {
            string keyPath = @"SOFTWARE\DVLD";
            string valueName = "Login Token";
            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                    {
                        if (key != null)
                            key.DeleteValue(valueName);
                        else
                            throw new Exception("Failed to find token in registry");
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                throw new UnauthorizedAccessException("Run the program with administrative privileges to remove login info");
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete token from registry");
            }
        }



    }
}
