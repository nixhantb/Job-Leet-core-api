using JobLeet.WebApi.JobLeet.Api.Models.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1 {

    public static class EducationMapper{
        
        public static Education ToEducationDatabase (Education entity){

           return new Education {
                Id = entity.Id,
                Degree = entity.Degree,
                Major = entity.Major,
                Institution = entity.Institution,
                GraduationDate = entity.GraduationDate,
                Cgpa = entity.Cgpa
           };
        }

        public static EducationModel ToEducationModel(Education model){
            return new EducationModel {
                Id = model.Id,
                Degree = model.Degree,
                Major = model.Major,
                Institution = model.Institution,
                GraduationDate = model.GraduationDate,
                Cgpa = model.Cgpa
            };
        }
    }
}