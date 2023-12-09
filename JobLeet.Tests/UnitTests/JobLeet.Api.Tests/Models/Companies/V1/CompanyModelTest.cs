using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.JobLeet.Api.Tests.Models.Companies.V1
{
    public class CompanyModelTest
    {
        [Fact]
        public void CompanyModel_ShouldInstantiateSuccessfully()
        {
            // Arrange 
            CompanyModel companyModel = new CompanyModel
            {
                CompanyName = "Azzle",
                
            };

            Assert.NotNull(companyModel);

        }
        
        public void CompanyModel_ShouldValidateAnnotation()
        {
            CompanyModel companyModel = new CompanyModel
            {
                CompanyName = null

            };

            var validationResults = ValidateAnnotationHelper.ValidateModel(companyModel);
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("CompanyName") && v.ErrorMessage.Contains("required")), "Company Name is required");
        }
    }
}
