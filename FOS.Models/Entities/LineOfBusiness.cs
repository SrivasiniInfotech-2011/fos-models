using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class LineOfBusiness
    {

        public int LineOfBusinessId { get; set; }
        [JsonProperty(PropertyName = "lineOfBusinessName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string LineOfBusinessName { get; set; }
    }
}
