
using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Api.Models.Employers.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Employers.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1
{

    public static class EmployerMapper
    {

        public static Employer ToEmployer(Employer entity)
        {

            if (entity == null)
            {
                return null;
            }
            var profile = entity.Profile;
            return new Employer
            {
                Id = entity.Id,
                Name = new() {
                     FirstName = entity.Name.FirstName,
                    MiddleName = entity.Name.MiddleName,
                    LastName = entity.Name.LastName
                },
                Address = AddressMapper.ToAddressDatabase(entity.Address),
                Phone = PhoneMapper.ToPhoneDatabase(entity.Phone),
                Profile = CompanyMapper.ToCompanyProfileDatabase(profile, profile.ContactPhone, profile.CompanyAddress, profile.ContactEmail),
                EmployerType = new(){
                    EmployerCategory = entity.EmployerType.EmployerCategory
                },
                IndustryType = new(){
                    IndustryCategory = entity.IndustryType.IndustryCategory
                }
            };
        }



        // API Response
        public static EmployerModel ToEmployerModel(Employer model)
        {
            if (model == null)
            {
                return null;
            }

            var profile = model.Profile;
            return new EmployerModel
            {
                Id = model.Id,
                Name = new()
                {
                    FirstName = model.Name.FirstName,
                    MiddleName = model.Name.MiddleName,
                    LastName = model.Name.LastName
                },
                Address = AddressMapper.ToAddressModel(model.Address),
                Phone = PhoneMapper.ToPhoneModel(model.Phone),
                Profile = CompanyMapper.ToCompanyProfileModel(profile, profile.ContactPhone, profile.CompanyAddress, profile.ContactEmail),

                EmployerType = new()
                {
                    EmployerCategory = (Api.Models.Employers.V1.EmployerCategory)model.EmployerType.EmployerCategory
                },

                IndustryType = new()
                {
                    IndustryCategory = (IndustryCategory)model.IndustryType.IndustryCategory
                }
            };
        }

    }
}