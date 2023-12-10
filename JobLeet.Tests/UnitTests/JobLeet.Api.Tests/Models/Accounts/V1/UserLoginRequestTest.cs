using JobLeet.WebApi.JobLeet.Api.Models.Accounts.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.JobLeet.Api.Tests.Models.Accounts.V1
{
    public class UserLoginRequestTest
    {
        [Theory]
        [InlineData("", "324dj#Dkfsl@", "Email Address is required")]
        [InlineData("Invalid-email-format", "324dj#Dkfsl@", "Invalid Email Address format")]
        [InlineData("hello@gmail.com", "", "Password is required")]
        [InlineData("hello@gmail.com", "324dj#D", "Password must be at least 8 characters")]
        [InlineData("xyz@gmail.com", "324djddfdfdf", "Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character.")]

        public void UserLoginRequest_ShouldSatisfyBasicAuthenticationParameters(string emailAddress, string password, string expectedErrorMessage)
        {
            var userLoginRequest = new UserLoginRequest
            {
                Email = new EmailModel { EmailAddress = emailAddress},
                Password = password,
            };


            var validationResults = ValidateAnnotationHelper.ValidateModel(userLoginRequest);
          
            // Check if any error message matches the expected error message
            Assert.Contains(validationResults, result => result.ErrorMessage == expectedErrorMessage);
        }

    }
}
