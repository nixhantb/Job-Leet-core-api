using JobLeet.WebApi.JobLeet.Api.Exceptions;
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
                #region ToJobLeetDB

                var registrationUser = await ValidateUserAsync(entity);
                string hashedPassword = GenerateHashedPassword.HashedPassword(entity.Password, registrationUser.Salt);
                DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.Local);

                var loginUser = new LoginUser
                {
                    EmailAddress = entity.EmailAddress,
                    Password = hashedPassword,
                    // opportunity to add local date time conversion
                    LoginTime = entity.LoginTime = localDateTime,
                    IPAddress = entity.IPAddress,
                    Role = Core.Entities.Accounts.V1.RoleCategory.Users,
                    AccountStatus = Core.Entities.Accounts.V1.AccountCategory.Active,
                    AccountCreated = true
                };
                _dbContext.LoginUsers.Add(loginUser);
                await _dbContext.SaveChangesAsync();

                #endregion

                #region  ToAPIResponse
                var loginUserResponse = new LoginUserModel
                {
                    EmailAddress = entity.EmailAddress,
                    Password = hashedPassword,
                    // opportunity to add local date time conversion
                    LoginTime = loginUser.LoginTime = localDateTime,
                    IPAddress = loginUser.IPAddress,
                    Role = Api.Models.Accounts.V1.RoleCategory.Users,
                    Id = loginUser.Id,
                    AccountCreated = true,
                    AccountStatus = Api.Models.Accounts.V1.AccountCategory.Active

                };
                return loginUserResponse;
                #endregion
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

        #region Helper Methods
        private async Task<RegisterUser> ValidateUserAsync(LoginUserModel entity)
        {

            bool validatePassword = PasswordValidation.ValidatePassword(entity.Password);
            var registrationUser = await _dbContext.RegisterUsers.FirstOrDefaultAsync(u => u.UserEmail.EmailAddress == entity.EmailAddress);
            if (entity.Role == Api.Models.Accounts.V1.RoleCategory.Admin)
            {
                throw new ArgumentException(ErrorMessageManager.GetErrorMessage("Invalid_Admin_Access"));
            }

            if (!validatePassword)
            {
                throw new ArgumentException(ErrorMessageManager.GetErrorMessage("Invalid_Password_Format"));
            }

            if (registrationUser == null)
            {
                throw new Exception(ErrorMessageManager.GetErrorMessage("Unregistered_User_Error"));
            }

            // Compare the hashed password with the one stored in the database
            string hashedPassword = GenerateHashedPassword.HashedPassword(entity.Password, registrationUser.Salt);
            if (hashedPassword != registrationUser.Password)
            {
                throw new Exception(ErrorMessageManager.GetErrorMessage("Invalid_Credentials_Error"));
            }
            return registrationUser;
        }
        #endregion
    }

}
