using System.Security.Cryptography;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Utilities
{
    public static class GenerateHashedPassword
    {
        private const int SaltSize = 128 / 8;

        // Generate a random salt value for a new password storage request
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        // Generate a hashed password using PBKDF2 with a provided salt
        public static string HashedPassword(string password, string salt)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(salt))
            {
                throw new ArgumentException("Salt cannot be null or empty.");
            }

            // Convert salt string to byte array
            byte[] saltBytes = Convert.FromBase64String(salt);

            // Generate hashed password
            byte[] hashedPasswordBytes = HashPasswordWithSalt(password, saltBytes);

            // Convert hashed password bytes to base64 string
            return Convert.ToBase64String(hashedPasswordBytes);
        }

        // Hash password with salt using PBKDF2
        private static byte[] HashPasswordWithSalt(string password, byte[] salt)
        {
            using (
                var pbkdf2 = new Rfc2898DeriveBytes(
                    password,
                    salt,
                    100000,
                    HashAlgorithmName.SHA256
                )
            )
            {
                return pbkdf2.GetBytes(256 / 8); // 256 bits
            }
        }
    }
}
