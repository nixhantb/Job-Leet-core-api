
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
namespace UnitTests.JobLeet.Api.Tests.Models.Employers.V1
{
    public class EmployerModelTest
    {
        [Fact]
        public void EmployerModel_ShouldValidateRequiredAnnotations()
        {
            // Arrange
            EmployerModel employerModelRequiredValidation = new EmployerModel
            {  
                Name = null,
                Address = null,
                Phone = null,
                Profile = null,
                IndustryType = null,
            };
            // Assert
           
            Assert.Null(employerModelRequiredValidation.Name);
            Assert.Null(employerModelRequiredValidation.Address);
            Assert.Null(employerModelRequiredValidation.Phone);
            Assert.Null(employerModelRequiredValidation.Profile);
            Assert.Null(employerModelRequiredValidation.IndustryType);
           
           
            var validationResults = ValidateAnnotationHelper.ValidateModel(employerModelRequiredValidation);

            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Name") && v.ErrorMessage.Contains("required")), "Name should be marked as required");
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Address") && v.ErrorMessage.Contains("required")), "Address should be marked as required");
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Phone") && v.ErrorMessage.Contains("required")), "Phone should be marked as required");
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Profile") && v.ErrorMessage.Contains("required")), "Profile should be marked as required");
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("IndustryType") && v.ErrorMessage.Contains("required")), "IndustryType should be marked as required");
        }
        [Fact]
        public void EmployerModelTest_ShouldInstantiateSuccessfully()
        {
            // Arrange
            EmployerModel employerModel = CreateValidEmployerModel();
   
            // Assert
            Assert.Equal(null, employerModel.Name.MiddleName);
            Assert.NotNull(employerModel.Name);
            Assert.NotNull(employerModel.Address);
            Assert.NotNull(employerModel.Phone);
            Assert.NotNull(employerModel.Profile);
            
            var validationResults = ValidateAnnotationHelper.ValidateModel(employerModel);

            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Name") && v.ErrorMessage.Contains("required")), "Name should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Address") && v.ErrorMessage.Contains("required")), "Address should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Phone") && v.ErrorMessage.Contains("required")), "Phone should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("Profile") && v.ErrorMessage.Contains("required")), "Profile should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("EmployerType") && v.ErrorMessage.Contains("required")), "EmployerType should be marked as required");
            Assert.False(validationResults.Any(v => v.MemberNames.Contains("IndustryType") && v.ErrorMessage.Contains("required")), "IndustryType should be marked as required");
        }
        private EmployerModel CreateValidEmployerModel()
        {
            return new EmployerModel
            {
                // Arrange
                Name = new PersonNameModel { FirstName = "Nishant", MiddleName = null, LastName = "Banjade" },
                Address = new AddressModel { Street = "ST", City = "BLR", State = "KA", PostalCode = "560068", Country = "HI" },
                Phone = new PhoneModel { CountryCode = 91, PhoneNumber = "921212" },
                Profile = new CompanyProfileModel
                {
                    ProfileInfo = "AYZ company is the service-based company",
                    CompanyAddress = new AddressModel { Street = "ST", City = "BLR", State = "KA", PostalCode = null, Country = null },
                    ContactPhone = new PhoneModel { CountryCode = 91, PhoneNumber = "921212" },
                    ContactEmail = new EmailModel { EmailType = EmailCategory.Work, EmailAddress = "ayz.official@xyz.com" },
                    Website = "www.ayz.com",
                    IndustryType = new IndustryTypeModel { IndustryCategory = IndustryCategory.Technology }
                },
                IndustryType = new IndustryTypeModel { IndustryCategory = IndustryCategory.Technology },
            };
        }
        
    }
}
