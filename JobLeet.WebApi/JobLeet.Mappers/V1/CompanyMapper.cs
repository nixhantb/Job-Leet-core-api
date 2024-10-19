using JobLeet.WebApi.JobLeet.Api.Models.Companies.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1;
namespace JobLeet.WebApi.JobLeet.Mappers.V1
{
    public static class CompanyMapper
    {
        public static CompanyModel ToCompanyModel(Company entity)
        {

            if (entity == null)
            {
                return null;
            }
            
            var profile = entity?.Profile;
            return new CompanyModel
            {
                Id = profile.Id,
                CompanyName = entity.CompanyName,
                Profile = ToCompanyProfileModel(profile, profile?.ContactPhone, profile?.CompanyAddress, profile?.ContactEmail)
            };
        }
        public static CompanyProfileModel ToCompanyProfileModel(CompanyProfile entity, Phone phoneEntity, Address addressEntity, Email emailEntity)
        {

            if (entity == null)
            {
                return null;
            }
            return new CompanyProfileModel
            {
                Id = entity.Id,
                ProfileInfo = entity.ProfileInfo,
                ContactPhone = PhoneMapper.ToPhoneModel(phoneEntity),
                CompanyAddress = AddressMapper.ToAddressModel(addressEntity),
                ContactEmail = EmailMapper.ToEmailModel(emailEntity),
                Website = entity.Website,
                IndustryType = (Api.Models.Companies.V1.IndustryCategory?)entity.IndustryType
            };
        }
    }
}