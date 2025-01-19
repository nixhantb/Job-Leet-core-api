using System.Security.Cryptography;

namespace JobLeet.WebApi.JobLeet.Api.Security.Jwt
{
public static class JwtHelper
{
    public static byte[] GetOrCreateJwtKey()
    {
        var keyFilePath = Path.Combine(Directory.GetCurrentDirectory(), "jwtkey.key");
        if (File.Exists(keyFilePath))
        {
            return File.ReadAllBytes(keyFilePath);
        }

        var key = new byte[32]; // Ensure key length is 32 bytes for HMAC-SHA256
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(key);
        }
        File.WriteAllBytes(keyFilePath, key);
        return key;
    }
}

}
