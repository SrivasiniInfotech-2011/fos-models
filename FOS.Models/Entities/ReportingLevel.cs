using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Entities
{
    public class ReportingLevel
    {


        /// <summary>
        /// userId.
        /// </summary>
        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserID { get; set; }

        /// <summary>
        /// userName
        /// </summary>
        [JsonProperty(PropertyName = "userName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserName { get; set; }
    }
}
