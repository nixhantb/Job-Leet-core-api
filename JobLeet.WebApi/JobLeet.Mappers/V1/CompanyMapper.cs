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

            var profile = entity?.Profile;
            return new Company
            {
                Id = profile.Id,
                CompanyName = entity.CompanyName,
                Profile = ToCompanyProfileDatabase(profile, profile?.ContactPhone, profile?.CompanyAddress, profile?.ContactEmail)
            };
        }
        public static CompanyProfile ToCompanyProfileDatabase(CompanyProfile entity, Phone phoneEntity, Address addressEntity, Email emailEntity)
        {

            if (entity == null)
            {
                return null;
            }
            return new CompanyProfile
            {
                Id = entity.Id,
                ProfileInfo = entity.ProfileInfo,
                ContactPhone = PhoneMapper.ToPhoneDatabase(phoneEntity),
                CompanyAddress = AddressMapper.ToAddressDatabase(addressEntity),
                ContactEmail = EmailMapper.ToEmailDatabase(emailEntity),
                Website = entity.Website,
                IndustryType = entity.IndustryType
            };
        }

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

        public static CompanyProfileModel ToCompanyProfileModel(CompanyProfile model, Phone phoneModel, Address addressModel, Email emailModel)
        {

            if (model == null)
            {
                return null;
            }
            return new CompanyProfileModel
            {
                Id = model.Id,
                ProfileInfo = model.ProfileInfo,
                ContactPhone = PhoneMapper.ToPhoneModel(phoneModel),
                CompanyAddress = AddressMapper.ToAddressModel(addressModel),
                ContactEmail = EmailMapper.ToEmailModel(emailModel),
                Website = model.Website,
                IndustryType = (Api.Models.Companies.V1.IndustryCategory?)model.IndustryType
            };
        }

    }
}