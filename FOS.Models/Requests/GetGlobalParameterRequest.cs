using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Requests
{
    public class GetGlobalParameterRequest
    {
        /// <summary>
        /// Company Id.
        /// </summary>
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int Company_ID { get; set; }

        /// <summary>
        /// User_ID.
        /// </summary>
        [JsonProperty(PropertyName = "User_ID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int User_ID { get; set; }
    }
}
