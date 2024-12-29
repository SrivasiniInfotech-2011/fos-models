using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FvrAsset
    {
        [JsonProperty(PropertyName = "fvrAssetDetail", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public FvrAssetDetail? FvrAssetDetail { get; set; }

        [JsonProperty(PropertyName = "fvrDocuments", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public FvrDocument[]? FvrDocuments { get; set; }
    }
}
