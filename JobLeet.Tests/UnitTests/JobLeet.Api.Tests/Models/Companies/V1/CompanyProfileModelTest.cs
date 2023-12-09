using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;

namespace UnitTests.JobLeet.Api.Tests.Models.Companies.V1
{
    public class CompanyProfileModelTest
    {
        [Fact]
        public void CompanyProfileModel_ShouldInstantiateSuccessfully()
        {
            CompanyProfileModel companies = CreateCompanyModel();

            Assert.NotNull(companies);
        }

        [Fact]
        public void CompanyProfileModel_ShouldContainWorkEmailType()
        {
            CompanyProfileModel comapanies = CreateCompanyModel();

            Assert.Equal(comapanies.ContactEmail.EmailType, EmailType.Work);
        }

        private CompanyProfileModel CreateCompanyModel () 
        {
            return new CompanyProfileModel
            {
                ProfileInfo = "I am just a random profile info",
                CompanyAddress = new AddressModel
                {
                    Street = "ST",
                    City = "BLR",
                    State = "KA",
                    PostalCode = "44253",
                    Country = "JPN"
                },
                ContactPhone = new PhoneModel { CountryCode = 91, PhoneNumber = "92177212" },
                ContactEmail = new EmailModel { EmailType = EmailType.Work,EmailAddress  = "company@em.com"},
                Website = "www.website.com",
                IndustryType = new IndustryTypeModel { IndustryCategory = IndustryCategory.Technology },
            };
        }
    }
    
}
