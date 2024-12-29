using Newtonsoft.Json;

namespace FOS.Models.Entities
{
    public class FvrAssetDetail
    {
        [JsonProperty(PropertyName = "fieldVerificationId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? FieldVerificationId { get; set; }
        
        [JsonProperty(PropertyName = "prospectName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? ProspectName { get; set; }

        [JsonProperty(PropertyName = "taxType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? TaxType { get; set; }

        [JsonProperty(PropertyName = "taxExpiryDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime TaxExpiryDate { get; set; }

        [JsonProperty(PropertyName = "permitStatus", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? PermitStatus { get; set; }

        [JsonProperty(PropertyName = "permitType", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? PermitType { get; set; }

        [JsonProperty(PropertyName = "permitExpiryDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? PermitExpiryDate { get; set; }

        [JsonProperty(PropertyName = "insuranceExpiryDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? InsuranceExpiryDate { get; set; }

        [JsonProperty(PropertyName = "fieldExecutiveComment", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FieldExecutiveComment { get; set; }

        [JsonProperty(PropertyName = "registrationDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? RegistrationDate { get; set; }

        [JsonProperty(PropertyName = "inspectedValueAmount", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public decimal? InspectedValueAmount { get; set; }

        [JsonProperty(PropertyName = "frontTyreStatus", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? FrontTyreStatus { get; set; }

        [JsonProperty(PropertyName = "rearTyreStatus", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? RearTyreStatus { get; set; }

        [JsonProperty(PropertyName = "frontTyreStatusDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? FrontTyreStatusDescription { get; set; }

        [JsonProperty(PropertyName = "rearTyreStatusDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? RearTyreStatusDescription { get; set; }

        [JsonProperty(PropertyName = "vehicleColour", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleColour { get; set; }

        [JsonProperty(PropertyName = "vehicleCondition", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? VehicleCondition { get; set; }

        [JsonProperty(PropertyName = "vehicleConditionDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleConditionDescription { get; set; }

        [JsonProperty(PropertyName = "vehicleInspectionDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? VehicleInspectionDate { get; set; }

        [JsonProperty(PropertyName = "vehicleBody", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? VehicleBody { get; set; }

        [JsonProperty(PropertyName = "vehicleBodyDescription", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleBodyDescription { get; set; }

        [JsonProperty(PropertyName = "vehicleBodySize", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleBodySize { get; set; }

        [JsonProperty(PropertyName = "vehicleOwnerName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleOwnerName { get; set; }

        [JsonProperty(PropertyName = "vehicleEngineCondition", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleEngineCondition { get; set; }

        [JsonProperty(PropertyName = "visitDate", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public DateTime? VisitDate { get; set; }

        [JsonProperty(PropertyName = "duplicateKey", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? DuplicateKey { get; set; }

        [JsonProperty(PropertyName = "assetDocuments", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string[]? AssetDocuments { get; set; }

        [JsonProperty(PropertyName = "verifierCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VerifierCode { get; set; }

        [JsonProperty(PropertyName = "verifierName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VerifierName { get; set; }

        [JsonProperty(PropertyName = "verifierId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? VerifierId { get; set; }

        [JsonProperty(PropertyName = "verificationPlace", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VerificationPlace { get; set; }

        [JsonProperty(PropertyName = "vehicleRegistrationNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? VehicleRegistrationNumber { get; set; }

    }
}
