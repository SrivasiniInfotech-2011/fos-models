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
        public long? companyId { get; set; }

        /// <summary>
        /// Company Code.
        /// </summary>
        [JsonProperty(PropertyName = "companycode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? companyCode { get; set; }

        /// <summary>
        /// Company Name.
        /// </summary>
        [JsonProperty(PropertyName = "companyname", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? companyName { get; set; }

        /// <summary>
        /// Company Address.
        /// </summary>
        [JsonProperty(PropertyName = "companyaddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? companyAddress { get; set; }

        /// <summary>
        /// City.
        /// </summary>
        [JsonProperty(PropertyName = "city", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? city { get; set; }

        /// <summary>
        /// State.
        /// </summary>
        [JsonProperty(PropertyName = "state", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? state { get; set; }

        /// <summary>
        /// Country.
        /// </summary>
        [JsonProperty(PropertyName = "country", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? country { get; set; }

        /// <summary>
        /// Zip_Code.
        /// </summary>
        [JsonProperty(PropertyName = "zipcode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? zipCode { get; set; }

        /// <summary>
        /// Constitutional_Status_Id.
        /// </summary>
        [JsonProperty(PropertyName = "constitutionalstatusid", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? constitutionalStatusId { get; set; }

        /// <summary>
        /// CD_CEO_Head_Name.
        /// </summary>
        [JsonProperty(PropertyName = "cdceoheadname", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? cdCeoHeadName { get; set; }

        /// <summary>
        /// CD_Telephone_Number.
        /// </summary>
        [JsonProperty(PropertyName = "cdtelephonenumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? cdTelephoneNumber { get; set; }

        /// <summary>
        /// CD_Mobile_Number.
        /// </summary>
        [JsonProperty(PropertyName = "cdmobilenumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? cdMobileNumber { get; set; }

        /// <summary>
        /// CD_Email_ID.
        /// </summary>
        [JsonProperty(PropertyName = "cdemailid", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? cdEmailId { get; set; }

        /// <summary>
        /// CD_Website.
        /// </summary>
        [JsonProperty(PropertyName = "cdwebsite", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? cdWebsite { get; set; }

        /// <summary>
        /// CD_Sys_Admin_User_Code.
        /// </summary>
        [JsonProperty(PropertyName = "cdsysadminusercode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? cdSysAdminUserCode { get; set; }

        /// <summary>
        /// CD_Sys_Admin_User_Password.
        /// </summary>
        [JsonProperty(PropertyName = "cdsysadminuserpassword", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? cdSysAdminUserPassword { get; set; }

        /// <summary>
        /// OD_Communication_Address.
        /// </summary>
        [JsonProperty(PropertyName = "odcommunicationaddress", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odCommunicationAddress { get; set; }

        /// <summary>
        /// OD_Address1.
        /// </summary>
        [JsonProperty(PropertyName = "odaddress1", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odAddress1 { get; set; }

        /// <summary>
        /// OD_City.
        /// </summary>
        [JsonProperty(PropertyName = "odcity", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odCity { get; set; }

        /// <summary>
        /// OD_State.
        /// </summary>
        [JsonProperty(PropertyName = "odstate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odState { get; set; }

        /// <summary>
        /// OD_Country.
        /// </summary>
        [JsonProperty(PropertyName = "odcountry", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odCountry { get; set; }

        /// <summary>
        /// OD_Zip_Code.
        /// </summary>
        [JsonProperty(PropertyName = "odzipcode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? odZipCode { get; set; }

        /// <summary>
        /// OD_Date_Of_Incorporation.
        /// </summary>
        [JsonProperty(PropertyName = "oddateofincorporation", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? odDateOfIncorporation { get; set; }

        /// <summary>
        /// OD_Reg_Lic_Number.
        /// </summary>
        [JsonProperty(PropertyName = "odreglicnumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? odRegLicNumber { get; set; }

        /// <summary>
        /// OD_Validity_Of_Reg_Lic_Number.
        /// </summary>
        [JsonProperty(PropertyName = "odvalidityofreglicnumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? odValidityOfRegLicNumber { get; set; }

        /// <summary>
        /// OD_Income_Tax_PAN_Number.
        /// </summary>
        [JsonProperty(PropertyName = "odincometaxpannumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odIncomeTaxPanNumber { get; set; }

        /// <summary>
        /// No_Column_Name.
        /// </summary>
        [JsonProperty(PropertyName = "isnull", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? currency { get; set; }

        /// <summary>
        /// OD_Remarks.
        /// </summary>
        [JsonProperty(PropertyName = "odremarks", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? odRemarks { get; set; }

        /// <summary>
        /// Active.
        /// </summary>
        [JsonProperty(PropertyName = "active", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? active { get; set; }

        /// <summary>
        /// gstNumber.
        /// </summary>
        [JsonProperty(PropertyName = "gstNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? gstNumber { get; set; }

        /// <summary>
        /// Constitutional_Status.
        /// </summary>
        [JsonProperty(PropertyName = "constitutionalstatus", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? constitutionalStatus { get; set; }
    }
}
