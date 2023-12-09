

using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;

namespace UnitTests.JobLeet.Api.Tests.Models.Companies.V1
{
    public class IndustryTypeModelTest
    {
        [Fact]
        public void IndustryTypeModel_ShouldInstantiateSuccessfully()
        {
            IndustryTypeModel model = new IndustryTypeModel
            {
                IndustryCategory = IndustryCategory.Technology,
            };

            Assert.Equal(IndustryCategory.Technology, model.IndustryCategory);
        }

    }
}
