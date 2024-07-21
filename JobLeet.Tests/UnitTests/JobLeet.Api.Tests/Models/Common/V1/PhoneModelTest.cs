using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;

namespace UnitTests.JobLeet.Api.Tests.Models.Common.V1
{
    public class PhoneModelTest
    {
        [Fact]
        public void PhoneModel_Validation_Success()
        {
            // Arrange
            var phoneModel = new PhoneModel
            {
                CountryCode = 21,
                PhoneNumber = "1234567890"
            };

            // Act

            var validationResults = ValidateAnnotationHelper.ValidateModel(phoneModel);

            Assert.Empty(validationResults);
        }

        [Theory]
        [InlineData(-1, "123456789", "Country Code must be a positive number")]
        [InlineData(1, "abc", "Invalid Phone Number format. Use only digits.")]
        public void PhoneModel_Validation_Failure(int countryCode, string phoneNumber, string expectedErrorMessage)
        {
            var phoneModel = new PhoneModel
            {
                CountryCode = countryCode,
                PhoneNumber = phoneNumber
            };

            var validationResults = ValidateAnnotationHelper.ValidateModel(phoneModel);

            // Assert
            Assert.Equal(expectedErrorMessage, validationResults[0].ErrorMessage);
        }
    }
}
