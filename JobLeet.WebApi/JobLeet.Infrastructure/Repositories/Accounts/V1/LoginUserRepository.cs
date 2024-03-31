using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Utilities;
using Microsoft.EntityFrameworkCore;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Accounts.V1
{
    public class LoginUserRepository : ILoginUserRepository
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        private readonly BaseDBContext _dbContext;

        public LoginUserRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        }
        #endregion
        public async Task<LoginUserModel> AddAsync(LoginUserModel entity)
        {
            try
            {
                if(entity.Role == Api.Models.Accounts.V1.RoleCategory.Admin)
                {
                    throw new ArgumentException("Sorry, you cannot register as an Admin. Please contact administration if you need help");
                }

                if (!PasswordValidation.ValidatePassword(entity.Password))
                {
                    throw new ArgumentException("Password must be between 8 and 100 characters and should match the regular expression pattern");
                }

                var registrationUser = await _dbContext.RegisterUsers.FirstOrDefaultAsync(u => u.Email == entity.EmailAddress);
                if (registrationUser == null)
                {
                    throw new Exception("Unregistered user found. Please try registering the User before Logging in");
                }
                string hashedPassword = GenerateHashedPassword.HashedPassword(entity.Password, registrationUser.Salt);


                // Compare the hashed password with the one stored in the database
                if (hashedPassword != registrationUser.Password)
                {
                    throw new Exception("Invalid credentials. Please check your email or password.");
                }
                
                var loginUser = new LoginUser
                {
                    EmailAddress = entity.EmailAddress,
                    Password = hashedPassword,
                    // opportunity to add local date time conversion
                    LoginTime = entity.LoginTime = DateTime.UtcNow,
                    IPAddress = entity.IPAddress,
                    Role = Core.Entities.Accounts.V1.RoleCategory.Users
                };
                _dbContext.LoginUsers.Add(loginUser);
                await _dbContext.SaveChangesAsync();

                var loginUserResponse = new LoginUserModel
                {
                    EmailAddress = loginUser.EmailAddress,
                    Password = hashedPassword,
                    // opportunity to add local date time conversion
                    LoginTime = loginUser.LoginTime = DateTime.UtcNow,
                    IPAddress = loginUser.IPAddress,
                    Role = Api.Models.Accounts.V1.RoleCategory.Users,
                    Id = loginUser.Id,
                    AccountCreated = true,
                    AccountStatus = Api.Models.Accounts.V1.AccountCategory.Active

                };



                return loginUserResponse;

            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred while logging in: {ex.Message}");
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LoginUserModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoginUserModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(LoginUserModel entity)
        {
            throw new NotImplementedException();
        }
        
    }

}
