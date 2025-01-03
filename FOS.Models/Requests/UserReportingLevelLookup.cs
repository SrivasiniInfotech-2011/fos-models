using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Requests
{
    public class UserReportingLevelLookup
    {


        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }

        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserId { get; set; }

        [JsonProperty(PropertyName = "prefixText", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PrefixText { get; set; }

        [JsonProperty(PropertyName = "lOBID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? LOB_ID { get; set; }

        [JsonProperty(PropertyName = "locationID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? location_ID { get; set; }
    }
}
