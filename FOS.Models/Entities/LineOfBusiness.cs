using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Entities
{
    public class LineOfBusiness
    {
        [JsonProperty(PropertyName = "lineOfBusinessId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]

        public int LineOfBusinessId { get; set; }
        [JsonProperty(PropertyName = "lineOfBusinessName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string LineOfBusinessName { get; set; }
    }
}
