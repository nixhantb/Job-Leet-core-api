using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
namespace UnitTests.JobLeet.Api.Tests.Models.Common.V1
{
    public class AddressModelTest
    {
        [Fact]
        public void AddressModel_ShouldCorrectlyValidateAnnotations()
        {
            var Addressmodel = new AddressModel { Street = null, City = null, State = "KA", PostalCode = null, Country = null };

            Assert.NotNull(Addressmodel);
            var validationResults = ValidateAnnotationHelper.ValidateModel(Addressmodel);

            // Assert
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("PostalCode") && v.ErrorMessage.Contains("required")), "PostalCode property should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Country") && v.ErrorMessage.Contains("required")), "Country property should be marked as required");


            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Street") && v.ErrorMessage.Contains("required")), "Street property should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("City") && v.ErrorMessage.Contains("required")), "City property should be marked as required");
        }

        [Fact]
        public void AddressModel_ShouldInstantiateSuccessfully()
        {
            var Addressmodel = new AddressModel { Street = "KL", City = "Ktm", State = "KA", PostalCode = "32345", Country = "UAE" };

            Assert.Equal(Addressmodel.Street, "KL");
            Assert.Equal(Addressmodel.City, "Ktm");
            Assert.Equal(Addressmodel.State, "KA");
            Assert.Equal(Addressmodel.PostalCode, "32345");
            Assert.Equal(Addressmodel.Country, "UAE");
        }


        [Theory]
        [InlineData("1234", "Invalid Postal Code format")]
        [InlineData("123456", "Invalid Postal Code format")]
        [InlineData("abcd5", "Invalid Postal Code format")]
        [InlineData("12345-678", "Invalid Postal Code format")]
        public void PostalCode_ShouldFailForInvalidFormats(string postalCode, string expectedErrorMessage)
        {
            // Arrange
            var addressModel = new AddressModel { PostalCode = postalCode };

            // Act
            var validationResults = ValidateAnnotationHelper.ValidateModel(addressModel);

            // Assert
            Assert.Contains(validationResults, vr => vr.ErrorMessage == expectedErrorMessage);
        }

    }

}
