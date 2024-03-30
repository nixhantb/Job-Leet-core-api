using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Core.Interfaces.Accounts.V1;
using JobLeet.WebApi.JobLeet.Infrastructure.Data.Contexts;

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
                var newUser = new RegisterUser
                {
                    UserName = entity.UserName,
                    Email = entity.Email,
                    Password = entity.Password,
                    ConfirmPassword = entity.ConfirmPassword,
                };

                _dbContext.RegisterUsers.Add(newUser);
                await _dbContext.SaveChangesAsync();
                entity.Id = newUser.Id; 
                return entity;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error occurred while Creating the user registration {ex.Message}");
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
