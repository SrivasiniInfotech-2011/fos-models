using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FvrNeighbourHood
    {
        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? ProspectId { get; set; } = default!;

        [JsonProperty(PropertyName = "leadid", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Leadid { get; set; } = default!;

        [JsonProperty(PropertyName = "fieldVerificationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? FieldVerificationId { get; set; } = default!;

        [JsonProperty(PropertyName = "visitedBy", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VisitedBy { get; set; }

        [JsonProperty(PropertyName = "dateVisited", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? DateVisited { get; set; }

        [JsonProperty(PropertyName = "personType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? PersonType { get; set; }

        [JsonProperty(PropertyName = "hirerStayType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? HirerStayType { get; set; }

        [JsonProperty(PropertyName = "houseStatusType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? HouseStatusType { get; set; }

        [JsonProperty(PropertyName = "residenceId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ResidenceId { get; set; }

        [JsonProperty(PropertyName = "noOfYears", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? NoOfYears { get; set; }

        [JsonProperty(PropertyName = "neighbourName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? NeighbourName { get; set; }

        [JsonProperty(PropertyName = "neighbourHoodAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? NeighbourHoodAddress { get; set; }

        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        [JsonProperty(PropertyName = "comments", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Comments { get; set; }
    }
}
