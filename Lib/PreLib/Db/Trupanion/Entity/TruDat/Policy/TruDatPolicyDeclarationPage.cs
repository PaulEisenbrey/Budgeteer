namespace Database.Trupanion.Entity.TruDat.Policy;

public partial class TruDatPolicyDeclarationPage
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PolicyNumber { get; set; }
    public string? PolicyHolderName { get; set; }
    public string? FormattedPhone { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? ZipCode { get; set; }
    public DateTime? PolicyDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public bool? ForecastedDeclarationPage { get; set; }
    public string? PetName { get; set; }
    public string? SpeciesName { get; set; }
    public string? InceptionTimeZone { get; set; }
    public string? Gender { get; set; }
    public string? AgeAtEnroll { get; set; }
    public string? SpayedOrNeutered { get; set; }
    public string? Breed { get; set; }
    public int? PetId { get; set; }
    public string? PolicyPlanName { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? PolicyPlanCoinsurancePercentage { get; set; }
    public decimal? PolicyPlanCoinsuranceOwnerPercentage { get; set; }
    public int? WaitingPeriodForAccident { get; set; }
    public int? WaitingPeriodForIllness { get; set; }
    public decimal? Premium { get; set; }
    public decimal? PremiumBase { get; set; }
    public decimal? PremiumTax { get; set; }
    public decimal? PremiumTotal { get; set; }
    public DateTime? DatePremiumEffective { get; set; }
    public decimal? PremiumTotalWithFees { get; set; }
    public decimal? AdministrativeFeeAmount { get; set; }
    public decimal? AdministrativeFeeWaived { get; set; }
    public string? BoldDecPageLine1 { get; set; }
    public string? BoldDecPageLine2 { get; set; }
    public string? BoldDecPageLine3 { get; set; }
    public string? DecPageTaxMessage { get; set; }
    public string? PolicyVersionName { get; set; }
    public string? DocumentVersion { get; set; }
    public int? AttachmentId { get; set; }
    public byte[]? TemplateBlob { get; set; }
    public bool? Active { get; set; }
    public bool Processed { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public string? ExternalDmsId { get; set; }
    public DateTime? AnniversaryDate { get; set; }
    public DateTime? EffectiveDate { get; set; }
}
