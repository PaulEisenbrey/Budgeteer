namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPendingPetPolicyChange
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? CoinsurancePercentage { get; set; }
    public decimal? Premium { get; set; }
    public string? PremiumCalculationProof { get; set; }
    public DateTime? PremiumEffectiveDate { get; set; }
    public decimal? PremiumTaxAmount { get; set; }
    public Guid? PremiumCalculationId { get; set; }
    public string? OptionalEndorsements { get; set; }
    public string? Characteristics { get; set; }
    public string? PolicyholderPostalCode { get; set; }
    public string? PolicyholderStateCode { get; set; }
    public string? PolicyholderIsoAlpha3CountryCode { get; set; }
    public string? TagNumber { get; set; }
    public string? PetName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Guid? PetId { get; set; }
    public bool? HasWaiveWaitingPeriodEndorsement { get; set; }
    public Guid? PrimaryHospitalId { get; set; }
    public DateTime? CoverageEffectiveFrom { get; set; }
    public Guid? PlanId { get; set; }
    public string? PolicyNumber { get; set; }
}
