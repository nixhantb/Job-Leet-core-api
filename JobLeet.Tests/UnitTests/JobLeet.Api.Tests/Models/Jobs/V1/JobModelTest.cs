
using JobLeet.WebApi.JobLeet.Api.Models.Jobs.V1;

namespace UnitTests.JobLeet.Api.Tests.Models.Jobs.V1
{
    public class JobModelTest
    {
        [Fact]
        public void JobModel_ShouldInstantiateSuccessfully()
        {
            JobModel jobModel = new JobModel
            {

                JobTitle = "SDE",
                JobDescription = "Description",
                Vacancies = 1,
                BasicPay = 1234.66m,
                FunctionalArea = "CA",
                PostingDate = new DateTime(),

            };

            Assert.NotNull(jobModel);
        }
    }
}
