using JobLeet.WebApi.JobLeet.Core.Entities.Common.V1.Shared;
using JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.IndustryTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobLeet.WebApi.JobLeet.Core.Entities.Companies.V1.Profiles
{
    public class CompanyProfile : BaseEntity
    {
        public string ProfileInfo { get; set; }
        [ForeignKey("Address")]
        public Address CompanyAddress {  get; set; }
        [ForeignKey("Phone")]
        public Phone ContactPhone {  get; set; }
        [ForeignKey("Email")]
        public Email ContactEmail {  get; set; }
        /// <summary>
        /// Website can be extended in future based on the requirements
        /// </summary>
        public string Website {  get; set; }
        [ForeignKey("IndustryType")]
        public IndustryType IndustryType { get; set; }



    }
}
