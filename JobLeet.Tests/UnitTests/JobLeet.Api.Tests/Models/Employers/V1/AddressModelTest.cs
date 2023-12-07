using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
namespace UnitTests.JobLeet.Api.Tests.Models.Employers.V1
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
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("PostalCode") && v.ErrorMessage.Contains("required")), "PostalCode property should be marked as required");
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Country") && v.ErrorMessage.Contains("required")), "Country property should be marked as required");


            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Street") && v.ErrorMessage.Contains("required")), "Street property should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("City") && v.ErrorMessage.Contains("required")), "City property should be marked as required");
        }

        [Fact]
        public void AddressModel_ShouldInstantiateSuccessfully ()
        {
            var Addressmodel = new AddressModel { Street = "KL", City = "Ktm", State = "KA", PostalCode = "32345", Country = "UAE" };

            Assert.Equal(Addressmodel.Street, "KL");
            Assert.Equal(Addressmodel.City, "Ktm");
            Assert.Equal(Addressmodel.State, "KA");
            Assert.Equal(Addressmodel.PostalCode, "32345");
            Assert.Equal(Addressmodel.Country, "UAE");
        }

        [Fact]
        public void PostalCode_ShouldNotAllowInvalidFormat()
        {
            // Arrange
            var AddressModel = new AddressModel { PostalCode = "Invalid-Format" };
            // Act
            var validateResults = ValidateAnnotationHelper.ValidateModel(AddressModel);
            // Assert
            Assert.NotEmpty(validateResults);
            
            Assert.Equal("Invalid Postal Code format", validateResults[0].ErrorMessage);
        }

        [Fact]
        public void PostalCode_ShouldPassExtendedValidFormat()
        {
            var AddressModel = new AddressModel { PostalCode = "12345-6789" };
            var validateResults = ValidateAnnotationHelper.ValidateModel(AddressModel);
            Assert.NotEqual("Invalid Postal Code format", validateResults[0].ErrorMessage);
        }

        [Fact]
        public void PostalCode_ShouldPassValidFormat()
        {
            var AddressModel = new AddressModel { PostalCode = "12345" };
            var validateResults = ValidateAnnotationHelper.ValidateModel(AddressModel);
            Assert.NotEqual("Invalid Postal Code format", validateResults[0].ErrorMessage);
        }

       
    }

}
