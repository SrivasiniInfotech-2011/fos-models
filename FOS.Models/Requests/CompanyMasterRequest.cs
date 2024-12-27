using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Requests
{
    public class CompanyMasterRequest
    {
        /// <summary>
        /// Company Id.
        /// </summary>
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// Company Code.
        /// </summary>
        [JsonProperty(PropertyName = "companycode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Company_Code { get; set; }

        /// <summary>
        /// Company Name.
        /// </summary>
        [JsonProperty(PropertyName = "companyname", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Company_Name { get; set; }

        /// <summary>
        /// Company Address.
        /// </summary>
        [JsonProperty(PropertyName = "companyaddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Company_Address { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty(PropertyName = "city", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? City { get; set; }

        /// <summary>
        /// State.
        /// </summary>
        [JsonProperty(PropertyName = "state", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? State { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        [JsonProperty(PropertyName = "country", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Country { get; set; }

        /// <summary>
        /// Zip_Code.
        /// </summary>
        [JsonProperty(PropertyName = "zipcode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Zip_Code { get; set; }

        /// <summary>
        /// Constitutional_Status_Id.
        /// </summary>
        [JsonProperty(PropertyName = "constitutionalstatusid", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Constitutional_Status_Id { get; set; }

        /// <summary>
        /// CD_CEO_Head_Name.
        /// </summary>
        [JsonProperty(PropertyName = "cdceoheadname", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CD_CEO_Head_Name { get; set; }

        /// <summary>
        /// CD_Telephone_Number.
        /// </summary>
        [JsonProperty(PropertyName = "cdtelephonenumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? CD_Telephone_Number { get; set; }

        /// <summary>
        /// CD_Mobile_Number.
        /// </summary>
        [JsonProperty(PropertyName = "cdmobilenumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? CD_Mobile_Number { get; set; }

        /// <summary>
        /// CD_Email_ID.
        /// </summary>
        [JsonProperty(PropertyName = "cdemailid", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CD_Email_ID { get; set; }

        /// <summary>
        /// CD_Website.
        /// </summary>
        [JsonProperty(PropertyName = "cdwebsite", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CD_Website { get; set; }

        /// <summary>
        /// CD_Sys_Admin_User_Code.
        /// </summary>
        [JsonProperty(PropertyName = "cdsysadminusercode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CD_Sys_Admin_User_Code { get; set; }

        /// <summary>
        /// CD_Sys_Admin_User_Password.
        /// </summary>
        [JsonProperty(PropertyName = "cdsysadminuserpassword", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? CD_Sys_Admin_User_Password { get; set; }

        /// <summary>
        /// OD_Communication_Address.
        /// </summary>
        [JsonProperty(PropertyName = "odcommunicationaddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_Communication_Address { get; set; }

        /// <summary>
        /// OD_Address1.
        /// </summary>
        [JsonProperty(PropertyName = "odaddress1", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_Address1 { get; set; }

        /// <summary>
        /// OD_City.
        /// </summary>
        [JsonProperty(PropertyName = "odcity", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_City { get; set; }

        /// <summary>
        /// OD_State.
        /// </summary>
        [JsonProperty(PropertyName = "odstate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_State { get; set; }

        /// <summary>
        /// OD_Country.
        /// </summary>
        [JsonProperty(PropertyName = "odcountry", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_Country { get; set; }

        /// <summary>
        /// OD_Zip_Code.
        /// </summary>
        [JsonProperty(PropertyName = "odzipcode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? OD_Zip_Code { get; set; }

        /// <summary>
        /// OD_Date_Of_Incorporation.
        /// </summary>
        [JsonProperty(PropertyName = "oddateofincorporation", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? OD_Date_Of_Incorporation { get; set; }

        /// <summary>
        /// OD_Reg_Lic_Number.
        /// </summary>
        [JsonProperty(PropertyName = "odreglicnumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? OD_Reg_Lic_Number { get; set; }

        /// <summary>
        /// OD_Validity_Of_Reg_Lic_Number.
        /// </summary>
        [JsonProperty(PropertyName = "odvalidityofreglicnumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? OD_Validity_Of_Reg_Lic_Number { get; set; }

        /// <summary>
        /// OD_Income_Tax_PAN_Number.
        /// </summary>
        [JsonProperty(PropertyName = "odincometaxpannumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_Income_Tax_PAN_Number { get; set; }

        /// <summary>
        /// No_Column_Name.
        /// </summary>
        [JsonProperty(PropertyName = "isnull", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Inr { get; set; }

        /// <summary>
        /// OD_Remarks.
        /// </summary>
        [JsonProperty(PropertyName = "odremarks", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? OD_Remarks { get; set; }

        /// <summary>
        /// Active.
        /// </summary>
        [JsonProperty(PropertyName = "active", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? Active { get; set; }

        /// <summary>
        /// Constitutional_Status.
        /// </summary>
        [JsonProperty(PropertyName = "constitutionalstatus", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Constitutional_Status { get; set; }
    }
}
