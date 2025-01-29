using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Entities
{
    public class GlobalParameterRequest
    {
        /// <summary>
        /// Global_Parameters_ID.
        /// </summary>
        [JsonProperty(PropertyName = "Global_Parameters_ID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Global_Parameters_ID { get; set; }

        /// <summary>
        /// Currency_Name.
        /// </summary>
        [JsonProperty(PropertyName = "Currency_Name", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Currency_Name { get; set; }

        /// <summary>
        /// Currency_Max_Digit.
        /// </summary>
        [JsonProperty(PropertyName = "Currency_Max_Digit", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Currency_Max_Digit { get; set; }

        /// <summary>
        /// Currency_Max_Dec_Digit.
        /// </summary>
        [JsonProperty(PropertyName = "Currency_Max_Dec_Digit", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Currency_Max_Dec_Digit { get; set; }

        /// <summary>
        /// Currency_Effective_Date.
        /// </summary>
        [JsonProperty(PropertyName = "Currency_Effective_Date", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Currency_Effective_Date { get; set; }

        /// <summary>
        /// Display_Date_Format.
        /// </summary>
        [JsonProperty(PropertyName = "Display_Date_Format", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Display_Date_Format { get; set; }

        /// <summary>
        /// Force_Pwd_Change.
        /// </summary>
        [JsonProperty(PropertyName = "Force_Pwd_Change", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Force_Pwd_Change { get; set; }

        /// <summary>
        /// Days.
        /// </summary>
        [JsonProperty(PropertyName = "Days", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Days { get; set; }

        /// <summary>
        /// Disable_Access_Wrong_pwd.
        /// </summary>
        [JsonProperty(PropertyName = "Disable_Access_Wrong_pwd", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Disable_Access_Wrong_pwd { get; set; }

        /// <summary>
        /// Min_pwd_length.
        /// </summary>
        [JsonProperty(PropertyName = "Min_pwd_length", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Min_pwd_length { get; set; }

        /// <summary>
        /// Digits.
        /// </summary>
        [JsonProperty(PropertyName = "Digits", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Digits { get; set; }

        /// <summary>
        /// Field_Type.
        /// </summary>
        [JsonProperty(PropertyName = "Field_Type", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Field_Type { get; set; }

        /// <summary>
        /// Enforce_ini_change_pass.
        /// </summary>
        [JsonProperty(PropertyName = "Enforce_ini_change_pass", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Enforce_ini_change_pass { get; set; }

        /// <summary>
        /// Upper_Case_Character.
        /// </summary>
        [JsonProperty(PropertyName = "Upper_Case_Character", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Upper_Case_Character { get; set; }

        /// <summary>
        /// Number.
        /// </summary>
        [JsonProperty(PropertyName = "Number", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Number { get; set; }

        /// <summary>
        /// Special_Character.
        /// </summary>
        [JsonProperty(PropertyName = "Special_Character", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Special_Character { get; set; }

        /// <summary>
        /// Pwd_Recycle_Itr.
        /// </summary>
        [JsonProperty(PropertyName = "Pwd_Recycle_Itr", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Pwd_Recycle_Itr { get; set; }
    }
}
