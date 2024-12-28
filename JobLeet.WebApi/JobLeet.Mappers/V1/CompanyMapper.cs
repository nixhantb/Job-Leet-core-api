using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;

namespace JobLeet.WebApi.JobLeet.Mappers.V1
{
    public static class CompanyMapper
    {
        public static Company ToCompanyDataBase(Company entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new Company
            {
                Id = entity.Id,
                CompanyName = entity.CompanyName,
                Profile = entity.Profile == null ? null : new CompanyProfile
                {
                    Id = entity.Profile.Id,
                    ProfileInfo = entity.Profile.ProfileInfo,
                    ContactPhone = entity.Profile.ContactPhone != null
                        ? PhoneMapper.ToPhoneDatabase(entity.Profile.ContactPhone)
                        : null,
                    CompanyAddress = entity.Profile.CompanyAddress != null
                        ? AddressMapper.ToAddressDatabase(entity.Profile.CompanyAddress)
                        : null,
                    ContactEmail = entity.Profile.ContactEmail != null
                        ? EmailMapper.ToEmailDatabase(entity.Profile.ContactEmail)
                        : null,
                    Website = entity.Profile.Website,
                    IndustryType = entity.Profile.IndustryType != null
                        ? new IndustryType { IndustryCategory = entity.Profile.IndustryType.IndustryCategory }
                        : null
                }
            };
        }

        public static CompanyModel ToCompanyModel(Company entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new CompanyModel
            {
                Id = entity.Id,
                CompanyName = entity.CompanyName,
                Profile = entity.Profile == null ? null : new CompanyProfileModel
                {
                    Id = entity.Profile.Id,
                    ProfileInfo = entity.Profile.ProfileInfo,
                    ContactPhone = entity.Profile.ContactPhone != null
                        ? PhoneMapper.ToPhoneModel(entity.Profile.ContactPhone)
                        : null,
                    CompanyAddress = entity.Profile.CompanyAddress != null
                        ? AddressMapper.ToAddressModel(entity.Profile.CompanyAddress)
                        : null,
                    ContactEmail = entity.Profile.ContactEmail != null
                        ? EmailMapper.ToEmailModel(entity.Profile.ContactEmail)
                        : null,
                    Website = entity.Profile.Website,
                    IndustryType = entity.Profile.IndustryType != null
                        ? new IndustryTypeModel
                        {
                            IndustryCategory = (Api.Models.Companies.V1.IndustryCategory)
                                entity.Profile.IndustryType.IndustryCategory
                        }
                        : null
                }
            };
        }
    }
}
