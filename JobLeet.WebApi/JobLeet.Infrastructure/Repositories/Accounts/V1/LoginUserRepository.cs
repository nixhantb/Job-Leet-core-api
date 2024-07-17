using JobLeet.WebApi.JobLeet.Api.Exceptions;
using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
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
        private readonly BaseDBContext _dbContext;

        public LoginUserRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
        #endregion

        public async Task<LoginUserModel> AddAsync(LoginUser entity)
        {
            try
            {
                #region Validate and Retrieve User Data

                var registrationUser = await ValidateUserAsync(entity);
                var personName = registrationUser.PersonName;
                if (personName == null)
                {
                    throw new Exception("PersonName not found.");
                }

                string hashedPassword = GenerateHashedPassword.HashedPassword(entity.Password, registrationUser.Salt);
                DateTime localDateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, TimeZoneInfo.Local);

                #endregion

                #region Create and Save LoginUser Entity

                var loginUser = new LoginUser
                {
                    EmailAddress = entity.EmailAddress,
                    Password = hashedPassword,
                    PersonName = personName,
                    LoginTime = localDateTime,
                    IPAddress = entity.IPAddress,
                    Role = Core.Entities.Accounts.V1.RoleCategory.Users,
                    AccountStatus = Core.Entities.Accounts.V1.AccountCategory.Active,
                    AccountCreated = true
                };
                _dbContext.LoginUsers.Add(loginUser);
                await _dbContext.SaveChangesAsync();

                #endregion

                #region Convert to API Response Model

                var loginUserResponse = new LoginUserModel
                {
                    Id = loginUser.Id,
                    EmailAddress = loginUser.EmailAddress,
                    PersonName = new PersonNameModel
                    {
                        Id = personName.Id,
                        FirstName = personName.FirstName,
                        MiddleName = personName.MiddleName,
                        LastName = personName.LastName
                    },
                    LoginTime = loginUser.LoginTime,
                   
                    Role = Api.Models.Accounts.V1.RoleCategory.Users,
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

        public Task UpdateAsync(LoginUser entity)
        {
            throw new NotImplementedException();
        }

        #region Helper Methods

        private async Task<RegisterUser> ValidateUserAsync(LoginUser entity)
        {
            bool validatePassword = PasswordValidation.ValidatePassword(entity.Password);
            var registrationUser = await _dbContext.RegisterUsers
                .Include(u => u.PersonName)
                .FirstOrDefaultAsync(u => u.UserEmail.EmailAddress == entity.EmailAddress);

            if (registrationUser == null)
            {
                throw new Exception(ErrorMessageManager.GetErrorMessage("Unregistered_User_Error"));
            }

            if (entity.Role == Core.Entities.Accounts.V1.RoleCategory.Admin)
            {
                throw new ArgumentException(ErrorMessageManager.GetErrorMessage("Invalid_Admin_Access"));
            }

            if (!validatePassword)
            {
                throw new ArgumentException(ErrorMessageManager.GetErrorMessage("Invalid_Password_Format"));
            }

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
