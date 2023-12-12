using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
namespace UnitTests.JobLeet.Api.Tests.Models.Common.V1
{
    public class EducationModelTest
    {
        [Fact]
        public void EducationModel_ShouldInstantiateSuccessfully()
        {
            EducationModel educationModel = new EducationModel
            {
                Degree = "CSE",
                Major = "Data science",
                Institution = "RV",
                GraduationDate = new DateOnly(2015, 12, 25),
                Cgpa = 2.5m
            };

            var validationResults = ValidateAnnotationHelper.ValidateModel(educationModel);

            Assert.True(validationResults.Count == 0, "Validation should pass for a valid EducationModel object");
           
        }

        [Fact]
        public void EducationModel_MustHaveValidCGPAWithValidRange()
        {
            EducationModel educationModel = new EducationModel();
            educationModel.Cgpa = 5.6m;

            var validationResults = ValidateAnnotationHelper.ValidateModel(educationModel);
            Assert.True(validationResults.Any(v => v.MemberNames.Contains("Cgpa") && v.ErrorMessage.Contains("CGPA must be between 0.0 and 4.0")), "Validation should fail for an invalid CGPA");
        }

        
    }
}
