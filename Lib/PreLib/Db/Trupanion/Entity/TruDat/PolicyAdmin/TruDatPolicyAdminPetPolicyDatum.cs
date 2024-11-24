namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPetPolicyDatum
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? DecPageDocumentId { get; set; }
    public string? PremiumCalculationProof { get; set; }
    public decimal? PremiumTaxAmount { get; set; }
    public Guid? PremiumCalculationId { get; set; }
    public string? Fees { get; set; }
    public string? Characteristics { get; set; }
    public bool? HasWaiveWaitingPeriodEndorsement { get; set; }
    public DateTime? CoverageEffectiveFrom { get; set; }
    public DateTime? PriceTermStartDate { get; set; }
    public DateTime? PolicyTermStartDate { get; set; }
    public bool? CurrentPlanIsCertificatePlan { get; set; }
    public string? PremiumCalculationNeighborhoodName { get; set; }
    public string? PremiumCalculationRegionName { get; set; }
    public string? WaitingPeriodOverride { get; set; }
    public decimal? DefaultCertificateConversionPremium { get; set; }
    public string? TaxItems { get; set; }
    public Guid? CurrentRevisionId { get; set; }
    public DateTime? PolicyTermExpirationDate { get; set; }
    public DateTime? PolicyTermNotificationDate { get; set; }
    public DateTime? PriceTermExpirationDate { get; set; }
    public DateTime? PriceTermNotificationDate { get; set; }
    public DateTime? PremiumFrozenUntil { get; set; }
    public DateTime? NextNotificationDate { get; set; }
    public DateTime? SignupDate { get; set; }
}
