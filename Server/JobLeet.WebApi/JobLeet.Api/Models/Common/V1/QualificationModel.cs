using System.Text.Json.Serialization;

namespace JobLeet.WebApi.JobLeet.Api.Models.Common.V1
{
    public class QualificationModel : BaseModel
    {
        public QualificationCategory QualificationType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? QualificationInformation { get; set; }

        [JsonIgnore]
        public override MetaDataModel MetaData
        {
            get => base.MetaData;
            set => base.MetaData = value;
        }
    }
}
