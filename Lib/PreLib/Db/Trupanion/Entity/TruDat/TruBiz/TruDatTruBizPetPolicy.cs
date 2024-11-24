namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPetPolicy
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int? PolicyId { get; set; }
    public DateTime PolicyDate { get; set; }
    public string? PolicyNumber { get; set; }
    public string? TagNumber { get; set; }
    public int PolicyAgeId { get; set; }
    public DateTime? PolicyPaidThru { get; set; }
    public bool PremiumFrozen { get; set; }
    public int? EngineVersionId { get; set; }
    public int? DocumentVersionId { get; set; }
    public int? SiteVisitorId { get; set; }
    public int? SiteVisitorSessionId { get; set; }
    public int? AdjustmentMonth { get; set; }
    public int? AdjustmentYear { get; set; }
    public DateTime? PetExamDate { get; set; }
    public string? PetRequireTreatmentDesc { get; set; }
    public string? PromoReferenceNumber { get; set; }
    public int? WaitingPeriodAccident { get; set; }
    public int? WaitingPeriodIllness { get; set; }
    public int? TerritoryPartnerPromoId { get; set; }
    public int? AssociateId { get; set; }
    public int? PetCoStoreId { get; set; }
    public int? CampaignInstanceId { get; set; }
    public string? PromoCode { get; set; }
    public int? ReferralId { get; set; }
    public int? TerritoryPartnerId { get; set; }
    public int? ReferralSourceId { get; set; }
    public int? BluePearlAccountId { get; set; }
    public int? PetProsId { get; set; }
    public int? CountryFinancialId { get; set; }
    public DateTime? CancelDate { get; set; }
    public int? CancelId { get; set; }
    public string? CancelNote { get; set; }
    public bool? Cancelled { get; set; }
    public int? HospitalId { get; set; }
    public int? EnrollmentStatusId { get; set; }
    public bool? HospitalFactorApplied { get; set; }
    public bool? Capped { get; set; }
    public int? VoucherId { get; set; }
    public Guid? PlanId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ProductId { get; set; }
    public decimal? CoinsurancePercentage { get; set; }
}
