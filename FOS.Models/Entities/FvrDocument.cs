using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FvrDocument
    {
        [JsonProperty(PropertyName = "fieldVerificationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int FieldVerificationId { get; set; }
        
        [JsonProperty(PropertyName = "documentTypeId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int DocumentTypeId { get; set; }
        
        [JsonProperty(PropertyName = "documentDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? DocumentDescription { get; set; }

        [JsonProperty(PropertyName = "documentPath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? DocumentPath { get; set; }
    }
}
