using System;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public static class clsBusinessSecurity
    {
        // using SHA-256 (secured hashing algorithm) to hash users passwords + using users salt that was assigned in account creation
        public static string ComputeHash(string Input, string Salt)
        {
            Input += Salt;
            // creating an instance of sha256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // the SHA-256 algorithm deals with binaries (bits), not strings.
                // we convert input string to bytes (using UTF-8).
                // example, "ABC" becomes byte array [65, 66, 67] based on the UTF8 table.
                // then these bytes are stored in memory as Binary: [01000001, 01000010, 01000011].
                // then SHA-256 performs complex bitwise operations (And, Or, Xor, Shift) on these bits.

                // regardless of the input string length, whether we entered "ABC" which is 24 bits or a whole bool or whatever, the algorithm will always returns a new fixed-length 256-bit (32 bytes) hash value.
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));


                // then we convert the byte array to a lowercase hexadecimal string to be readable and easy to be saved in DB
                // cuz one hexadecimal is 4 bits, so for hash value of 256 bits, can be represented in 64 character of hexadecimal
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static string ComputeHash(string Input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));
                
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // to encrypt and decrypt token when saving in registry using DPAPI (data protection api)
        public static string EncryptToken(string rawToken)
        {
            byte[] tokenBytes = Encoding.UTF8.GetBytes(rawToken);
            byte[] encryptedTokenBytes = ProtectedData.Protect(tokenBytes, null, DataProtectionScope.CurrentUser);

            return Convert.ToBase64String(encryptedTokenBytes);
        }

        public static string DecryptToken(string encryptedToken)
        {
            byte[] dataToDecrypt = Convert.FromBase64String(encryptedToken);
            byte[] decryptedData = ProtectedData.Unprotect(dataToDecrypt, null, DataProtectionScope.CurrentUser);

            return Encoding.UTF8.GetString(decryptedData);
        }

    }
}
