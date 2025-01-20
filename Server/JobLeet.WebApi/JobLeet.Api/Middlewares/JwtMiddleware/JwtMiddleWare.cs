using System.IdentityModel.Tokens.Jwt;
using JobLeet.WebApi.JobLeet.Api.Security.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace JobLeet.WebApi.JobLeet.Api.Middlewares.JwtMiddleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly byte[] _key;

        public JwtMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _key = JwtHelper.GetOrCreateJwtKey();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                var token = context
                    .Request.Headers["Authorization"]
                    .FirstOrDefault()
                    ?.Split(" ")
                    .Last();

                if (token != null)
                {
                    AttachUserToContext(context, token);
                }

                await _next(context);
            }
            catch (Exception ex)
            {
                throw new Exception("Error while Invoking the JWT Middleware ", ex);
            }
        }

        private void AttachUserToContext(HttpContext context, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                tokenHandler.ValidateToken(
                    token,
                    new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(_key),
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ClockSkew = TimeSpan.Zero,
                    },
                    out SecurityToken validatedToken
                );

                var jwtToken = (JwtSecurityToken)validatedToken;

                foreach (var claim in jwtToken.Claims)
                {
                    Console.WriteLine($"Claim Type: {claim.Type}, Value: {claim.Value}");
                }

                var userId = jwtToken.Claims.FirstOrDefault(x => x.Type == "nameid")?.Value;
                Console.WriteLine(userId + " is the userID");
                var email = jwtToken.Claims.FirstOrDefault(x => x.Type == "email")?.Value;

                if (userId == null || email == null)
                {
                    throw new Exception("Required claims are missing from the token.");
                }

                context.Items["User"] = new { UserId = userId, Email = email };
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong", ex);
            }
        }
    }
}
