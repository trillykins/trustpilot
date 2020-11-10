using System;
using System.Text;

namespace Trustpilot
{
    public class MD5
    {
        /// Source: https://stackoverflow.com/questions/11454004/calculate-a-md5-hash-from-a-string
        public static string Create(string input)
		{
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(nameof(input));

            // Use input string to calculate MD5 hash
            using System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
	}
}
