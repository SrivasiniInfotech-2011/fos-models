using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FvrLeadProspectDetail
    {
        [JsonProperty(PropertyName = "leadId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? LeadId { get; set; } = default!;

        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? ProspectId { get; set; } = default!;

        [JsonProperty(PropertyName = "leadNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadNumber { get; set; } = default!;

        [JsonProperty(PropertyName = "leadDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? LeadDate { get; set; }

        [JsonProperty(PropertyName = "prospectName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectName { get; set; }

        [JsonProperty(PropertyName = "leadType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LeadType { get; set; }

        [JsonProperty(PropertyName = "leadTypeName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LeadTypeName { get; set; }

        [JsonProperty(PropertyName = "prospectAddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectAddress { get; set; }

        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        [JsonProperty(PropertyName = "vehicleNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleNumber { get; set; }

        [JsonProperty(PropertyName = "locationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LocationId { get; set; }

        [JsonProperty(PropertyName = "locationName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LocationName { get; set; }

        [JsonProperty(PropertyName = "assetDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AssetDescription { get; set; }
    }
}
