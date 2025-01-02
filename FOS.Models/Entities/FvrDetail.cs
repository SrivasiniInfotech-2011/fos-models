using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FvrDetail
    {
        [JsonProperty(PropertyName = "fvrProspectDetail", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public FvrLeadProspectDetail? FvrProspectDetail { get; set; }

        [JsonProperty(PropertyName = "fvrHirerDetail", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public FVrHirer? FvrHirerDetail { get; set; }

        [JsonProperty(PropertyName = "fvrNeighbourHood", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public FvrNeighbourHood? FvrNeighbourHood { get; set; }

        [JsonProperty(PropertyName = "fvrDocuments", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public FvrDocument[]? FvrDocuments { get; set; }
    }
}
