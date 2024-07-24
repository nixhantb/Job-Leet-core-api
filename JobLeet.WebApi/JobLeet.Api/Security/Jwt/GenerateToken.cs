using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Api.Exceptions;

namespace JobLeet.WebApi.JobLeet.Api.Security.Jwt
{
    public static class GenerateToken
    {
        public static string GenerateJwtToken(RegisterUser user, IConfiguration configuration)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = JwtHelper.GetOrCreateJwtKey(); // Use the same key generation method
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("email", user?.UserEmail?.EmailAddress ?? string.Empty),
                    new Claim("nameid", user?.Id.ToString() ?? string.Empty)
                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    Issuer = configuration["Jwt:Issuer"],
                    Audience = configuration["Jwt:Audience"],
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };



                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {
                throw new JwtTokenException("An error occurred while generating the JWT token.", ex);
            }
        }
    }

}
