using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Api.Exceptions;
namespace JobLeet.WebApi.JobLeet.Api.Secutiy.Jwt
{
    public static class GenerateToken
    {
        public static string GenerateJwtToken(RegisterUser user, IConfiguration configuration)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Convert.FromBase64String(configuration["Jwt:Key"]);
                if (key.Length < 32)
                {
                    throw new JwtTokenException(ErrorMessageManager.GetErrorMessage("Invalid_JWT_TokenLength_Error"));
                }
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                    new Claim(ClaimTypes.Email, user?.UserEmail?.EmailAddress),
                    new Claim(ClaimTypes.NameIdentifier, user?.Id.ToString())
                }),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (ArgumentNullException ex)
            {
                throw new JwtTokenException("A required argument was null.", ex);
            }
            catch (ArgumentException ex)
            {
                throw new JwtTokenException("An argument was invalid.", ex);
            }

            catch (Exception ex)
            {
                throw new JwtTokenException("An error occurred while generating the JWT token.", ex);
            }

        }
    }
}