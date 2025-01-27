using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1
{
    public static class ProjectsMapper
    {
        public static Project ToProjectDatabase(Project entity)
        {
            return new Project
            {
                Id = entity.Id,
                Title = entity.Title,
                Responsibilities = entity.Responsibilities,
                TechnologiesUsed = entity.TechnologiesUsed,
                Role = entity.Role,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                ProjectUrl = entity.ProjectUrl,
                GitHubUrl = entity.ProjectUrl,
            };
        }

        public static ProjectModel ToProjectModel(Project model)
        {
            return new ProjectModel
            {
                Id = model.Id,
                Title = model.Title,
                Responsibilities = model.Responsibilities,
                TechnologiesUsed = model.TechnologiesUsed,
                Role = model.Role,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                ProjectUrl = model.ProjectUrl,
                GitHubUrl = model.ProjectUrl,
            };
        }
    }
}
