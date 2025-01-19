using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class AddressModel : BaseModel
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Postal Code format")]
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        [JsonIgnore]
        public override MetaDataModel MetaData { get => base.MetaData; set => base.MetaData = value; }
    }
}
