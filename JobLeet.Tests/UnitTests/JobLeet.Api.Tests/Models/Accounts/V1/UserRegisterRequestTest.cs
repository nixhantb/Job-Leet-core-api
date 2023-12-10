using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.JobLeet.Api.Tests.Models.Accounts.V1
{
    public class UserRegisterRequestTest
    {
        [Theory]
     
        [InlineData("John Doe", "", "", "Password is required")]
        [InlineData("John Doe", "324dj#Dkfsl@", "12345678", "Password do not match")]
        public void UserRegisterRequest_ShouldSatisfyBasicValidation(
        string personName,
        string password, string confirmPassword, string expectedErrorMessage)
        {
            var userRegisterRequest = new UserRegisterRequest
            {
                PersonName = new PersonNameModel { FirstName = personName },
                Password = password,
                ConfirmPassword = confirmPassword,
            };

            var validationResults = ValidateAnnotationHelper.ValidateModel(userRegisterRequest);
            Assert.Contains(validationResults, result => result.ErrorMessage == expectedErrorMessage);

        }
    }
}
