using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FVrHirer
    {
        [JsonProperty(PropertyName = "prospectId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? ProspectId { get; set; } = default!;

        [JsonProperty(PropertyName = "fieldVerificationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? FieldVerificationId { get; set; } = default!;

        [JsonProperty(PropertyName = "visitedBy", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VisitedBy { get; set; }

        [JsonProperty(PropertyName = "dateVisited", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? DateVisited { get; set; }

        [JsonProperty(PropertyName = "timeStamp", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? TimeStamp { get; set; }

        [JsonProperty(PropertyName = "personType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? PersonType { get; set; }

        [JsonProperty(PropertyName = "houseAccessibility", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? HouseAccessibility { get; set; }

        [JsonProperty(PropertyName = "localityId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LocalityId { get; set; }

        [JsonProperty(PropertyName = "localityName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LocalityName { get; set; }

        [JsonProperty(PropertyName = "houseType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? HouseType { get; set; }

        [JsonProperty(PropertyName = "flooringType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? FlooringType { get; set; }

        [JsonProperty(PropertyName = "roofingType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? RoofingType { get; set; }

        [JsonProperty(PropertyName = "livingType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LivingType { get; set; }

        [JsonProperty(PropertyName = "entryPermittedType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? EntryPermittedType { get; set; }

        [JsonProperty(PropertyName = "houseArea", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? HouseArea { get; set; }

        [JsonProperty(PropertyName = "landMark", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? LandMark { get; set; }

        [JsonProperty(PropertyName = "recommendation", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? Recommendation { get; set; }

        [JsonProperty(PropertyName = "earlyVisitedType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? EarlyVisitedType { get; set; }

        [JsonProperty(PropertyName = "politicalAffiliation", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? PoliticalAffiliation { get; set; }

        [JsonProperty(PropertyName = "remarks", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Remarks { get; set; }

        [JsonProperty(PropertyName = "houseImagePath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? HouseImagePath { get; set; }

        [JsonProperty(PropertyName = "furnitures", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Furnitures { get; set; }

        [JsonProperty(PropertyName = "verifierId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VerifierId { get; set; }
    }
}
