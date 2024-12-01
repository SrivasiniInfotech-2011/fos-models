using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class DocumentCategory
    {
        /// <summary>
        /// Lookup Type Id.
        /// </summary>
        [JsonProperty(PropertyName = "documentCategoryId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? DocumentCategoryId { get; set; }

        /// <summary>
        /// Lookup Type Description
        /// </summary>
        [JsonProperty(PropertyName = "documentCategoryDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? DocumentCategoryDescription { get; set; }
    }
}
