namespace RealPage.Diego.ApplyTest.BL.Utils
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Encryption Class
    /// </summary>
    public static class Encrypt
    {
        /// <summary>
        /// Gets the sh a256.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>String Encripted</returns>
        public static string GetSHA256(string str)
        {
            var sha256 = SHA256.Create();
            var encoding = new ASCIIEncoding();
            var sb = new StringBuilder();
            var stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);

            }
            
            return sb.ToString();
        }

        /// <summary>
        /// Base64s the encode.
        /// </summary>
        /// <param name="plainText">The plain text.</param>
        /// <returns>Encoded string</returns>
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Base64s the decode.
        /// </summary>
        /// <param name="base64EncodedData">The base64 encoded data.</param>
        /// <returns>Decoded String</returns>
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
