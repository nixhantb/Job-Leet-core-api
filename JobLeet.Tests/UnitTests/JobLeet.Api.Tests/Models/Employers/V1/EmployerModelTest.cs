
using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using Xunit;

namespace UnitTests.JobLeet.Api.Tests.Models.Employers.V1
{
    public class EmployerModelTest
    {
        [Fact]
        public void EmployerModelTest_ShouldInstantiateSuccessfully()
        {
            EmployerModel employerModel = new EmployerModel
            {
                // Arrange
                Name = new PersonNameModel { FirstName = "Nishant", MiddleName = null, LastName = "Banjade" },
                Address = new AddressModel { Street = "ST", City = "BLR", State = "KA", PostalCode = "560068", Country = "IND" },
                Phone = new PhoneModel { CountryCode = 91, PhoneNumber = "921212" },
                Profile = new  CompanyProfileModel{ 
                    
                    ProfileInfo = "AYZ company is the service based company",
                    CompanyAddress = new AddressModel { Street = "ST", City = "BLR", State = "KA", PostalCode = "560068", Country = "IND" },
                    ContactPhone = new PhoneModel { CountryCode = 91, PhoneNumber = "921212" },
                    ContactEmail = new EmailModel { EmailType = EmailType.Work, EmailAddress = "ayz.official@xyz.com"},
                    Website = "www.ayz.com",
                    IndustryType = new IndustryTypeModel { IndustryCategory = IndustryCategory.Technology}
                },
                EmployerType = EmployerTypeModel.MediumBusiness,
                IndustryType = new IndustryTypeModel { IndustryCategory = IndustryCategory.Technology},
            };
            // Assert

            Assert.Equal(null, employerModel.Name.MiddleName);
            Assert.NotNull(employerModel.Name);
            Assert.NotNull(employerModel.Address);
            Assert.NotNull(employerModel.Phone);
            Assert.NotNull(employerModel.Profile);
            Assert.Equal(EmployerTypeModel.MediumBusiness, employerModel.EmployerType);
            Assert.NotEqual(employerModel.EmployerType, EmployerTypeModel.LargeCorporation);

            Assert.Equal(employerModel.Profile.ContactEmail.EmailAddress, "ayz.official@xyz.com");
            Assert.NotEqual(employerModel.Profile.Website, "hello@acv.com");
            Assert.Equal(employerModel.IndustryType.IndustryCategory, IndustryCategory.Technology);

            Assert.IsType<int>(employerModel.Phone.CountryCode);
            Assert.IsType<string>(employerModel.Phone.PhoneNumber);


        }
    }
}
