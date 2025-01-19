using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.JobLeet.Api.Tests.Models.Common.V1
{
    public class SkillModelTest
    {
        [Fact]
        public void SkillModel_Validation_Success()
        {
            // Arrange
            var skillModel = new SkillModel
            {
                Title = ["Programming"],
                Description = ["Excellent coding skills."]
            };

            
            Assert.NotNull(skillModel);
        }
    }
}
