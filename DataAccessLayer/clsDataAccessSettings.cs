using System;
using System.Text;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace DataAccessLayer
{
    internal static class clsDataAccessSettings
    {
        public static string DecryptPassword(string encryptedPassword)
        {
            byte[] dataToDecrypt = Convert.FromBase64String(encryptedPassword);
            byte[] decryptedData = ProtectedData.Unprotect(dataToDecrypt, null, DataProtectionScope.CurrentUser);

            return Encoding.UTF8.GetString(decryptedData);
        }

        public static string GetDBPasswordFromRegistry()
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string valueName = "DB Password";

            string value = "";
            try
            {
                value = Registry.GetValue(keyPath, valueName, null) as string;

                if (value != null)
                    value = DecryptPassword(value);
            }
            catch (Exception)
            {
                throw new Exception("Failed to read DB Password from registry.");
            }
            return value;
        }

       
        private static string _DBPassword { get { return GetDBPasswordFromRegistry(); } }
        public static string connectionString { get; } = $"Server=.;Database=DVLD;User Id=sa;Password={_DBPassword};";
    }
}
