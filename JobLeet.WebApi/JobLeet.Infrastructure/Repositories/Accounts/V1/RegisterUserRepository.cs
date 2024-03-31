using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;
using JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Utilities;
using Microsoft.EntityFrameworkCore;


namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Accounts.V1
{
    public class RegisterUserRepository : IRegisterUserRepository
    {
        #region Initialization
        // <returns>The list of initializations</returns>
        private readonly BaseDBContext _dbContext;

        public RegisterUserRepository(BaseDBContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        }
        #endregion
        public async Task<RegisterUserModel> AddAsync(RegisterUserModel entity)
        {
            try
            {
                // Check if the email address is already registered
                bool emailExists = await _dbContext.RegisterUsers.AnyAsync(u => u.Email == entity.Email);
                if (emailExists)
                {
                    throw new Exception("This email address is already registered.");
                }

                if (!PasswordValidation.ValidatePassword(entity.Password))
                {
                    throw new ArgumentException("Password must be between 8 and 100 characters and should match the regular expression pattern");
                }

                byte[] salt = GenerateHashedPassword.GenerateSalt();
                string saltString = Convert.ToBase64String(salt);

                // Generate hashed password using the salt
                string hashedPasscode = GenerateHashedPassword.HashedPassword(entity.Password, saltString);
                var newUser = new RegisterUser
                {
                    UserName = entity.UserName,
                    Email = entity.Email,
                    Password = hashedPasscode,
                    ConfirmPassword = hashedPasscode,
                    Salt = saltString 
                };

                _dbContext.RegisterUsers.Add(newUser);
                await _dbContext.SaveChangesAsync();
                var responseEntity = new RegisterUserModel
                {
                    UserName = newUser.UserName,
                    Email = newUser.Email,
                    Password = hashedPasscode,
                    ConfirmPassword = hashedPasscode,
                    Id = newUser.Id,
                };

                return responseEntity;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException($"Error occurred while Creating the user registration {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch any other unexpected exceptions and rethrow
                throw new Exception($"An error occurred: {ex.Message}", ex);
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<RegisterUserModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RegisterUserModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(RegisterUserModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
