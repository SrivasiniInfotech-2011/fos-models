using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS.Models.Entities
{
    public class InsertUserDetailsModel
    {
        /// <summary>
        ///CompanyId.
        /// </summary>
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// User_ID.
        /// </summary>
        [JsonProperty(PropertyName = "userID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserID { get; set; }

        /// <summary>
        /// UserCode.
        /// </summary>
        [JsonProperty(PropertyName = "userCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? UserCode { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        [JsonProperty(PropertyName = "userName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? UserName { get; set; }

        /// <summary>
        /// genderId.
        /// </summary>
        [JsonProperty(PropertyName = "genderId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? GenderId { get; set; }  
        
        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Password { get; set; }

        /// <summary>
        /// DOJ.
        /// </summary>
        [JsonProperty(PropertyName = "dOJ", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? DOJ { get; set; }

        /// <summary>
        /// mobileNumber.
        /// </summary>
        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// EmergencycontactNumber.
        /// </summary>
        [JsonProperty(PropertyName = "emergencycontactNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? EmergencycontactNumber { get; set; }

        /// <summary>
        /// Designation.
        /// </summary>
        [JsonProperty(PropertyName = "designation", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Designation { get; set; }

        /// <summary>
        /// UserLevelID.
        /// </summary>
        [JsonProperty(PropertyName = "userLevelID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserLevelID { get; set; }

        /// <summary>
        /// ReportingNextlevel.
        /// </summary>
        [JsonProperty(PropertyName = "reportingNextlevel", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ReportingNextlevel { get; set; }

        /// <summary>
        /// User_Group.
        /// </summary>
        [JsonProperty(PropertyName = "userGroup", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserGroup { get; set; }

        /// <summary>
        /// EmailID.
        /// </summary>
        [JsonProperty(PropertyName = "emailID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? EmailID { get; set; }

        /// <summary>
        /// Dateofbirth.
        /// </summary>
        [JsonProperty(PropertyName = "dateofbirth", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? Dateofbirth { get; set; }

        /// <summary>
        /// FatherName.
        /// </summary>
        [JsonProperty(PropertyName = "fatherName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FatherName { get; set; }

        /// <summary>
        /// MotherName.
        /// </summary>
        [JsonProperty(PropertyName = "motherName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MotherName { get; set; }

        /// <summary>
        /// SpouseName.
        /// </summary>
        [JsonProperty(PropertyName = "spouseName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? SpouseName { get; set; }

        /// <summary>
        /// Maritial_ID
        /// </summary>
        [JsonProperty(PropertyName = "maritialID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? MaritialID { get; set; }

        /// <summary>
        /// Aadhar_Number.
        /// </summary>
        [JsonProperty(PropertyName = "aadharNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? AadharNumber { get; set; }

      

       

        /// <summary>
        /// PAN Card Number.
        /// </summary>
        [JsonProperty(PropertyName = "panNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? PanNumber { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty(PropertyName = "address", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Address { get; set; }

        /// <summary>
        /// User_Imagepath.
        /// </summary>
        [JsonProperty(PropertyName = "userImagepath", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? UserImagepath { get; set; }


        /// <summary>
        /// Is_Active.
        /// </summary>
        [JsonProperty(PropertyName = "isActive", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? IsActive { get; set; }


        /// <summary>
        /// createdBy.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// errorCode.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? ErrorCode { get; set; }
    }
}
