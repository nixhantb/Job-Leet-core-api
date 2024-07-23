using System.Security.Cryptography;

namespace JobLeet.WebApi.JobLeet.Api.Security.Jwt
{
    public static class JwtHelper
    {
        public static byte[] GetOrCreateJwtKey()
        {
            var keyFilePath = "jwtkey.key"; 
            if (File.Exists(keyFilePath))
            {
                return File.ReadAllBytes(keyFilePath);
            }

            var key = new byte[32]; 
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }
            File.WriteAllBytes(keyFilePath, key);
            return key;
        }
    }
}
