
using System.Security.Cryptography;
using System.Text;

namespace MultiplayerARPG
{
    public static partial class GenericUtils
    {
        public static string GetUniqueId(int length = 16, string mask = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-")
        {
            return Nanoid.Nanoid.Generate(mask, length);
        }

        public static string GetMD5(this string text)
        {
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(text);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            return System.BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }

        public static int GenerateHashId(this string id)
        {
            if (string.IsNullOrEmpty(id))
                return 0;

            unchecked
            {
                int hash1 = 5381;
                int hash2 = hash1;

                for (int i = 0; i < id.Length && id[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ id[i];
                    if (i == id.Length - 1 || id[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ id[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }
    }
}
