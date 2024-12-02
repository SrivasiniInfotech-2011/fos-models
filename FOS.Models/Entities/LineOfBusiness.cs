using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LineOfBusiness
    {

        [JsonProperty(PropertyName = "lineOfBusinessId", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public int LineOfBusinessId { get; set; }
        [JsonProperty(PropertyName = "lineOfBusinessName", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public string? LineOfBusinessName { get; set; }
    }
}
