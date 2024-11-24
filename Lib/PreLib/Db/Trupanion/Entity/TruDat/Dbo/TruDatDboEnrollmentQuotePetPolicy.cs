namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEnrollmentQuotePetPolicy
{
    public int Id { get; set; }
    public int EnrollmentQuoteId { get; set; }
    public int? PetPolicyId { get; set; }
    public int PolicyId { get; set; }
    public int BreedId { get; set; }
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime? LastExamDate { get; set; }
    public DateTime? AdoptionDate { get; set; }
    public bool? IsSpayedNeutered { get; set; }
    public DateTime? SpayedNeuteredDate { get; set; }
    public bool? RequiredTreatment { get; set; }
    public string? TreatmentNotes { get; set; }
    public string? Gender { get; set; }
    public int PolicyAgeId { get; set; }
    public int? ClinicId { get; set; }
    public decimal Deductible { get; set; }
    public decimal Premium { get; set; }
    public string? SelectedPolicyOptions { get; set; }
    public string? SelectedPolicyOptionCosts { get; set; }
    public string? PromoCode { get; set; }
    public string? EntityTypeListIds { get; set; }
    public string? EntityTypeListItemIds { get; set; }
    public int? ReferralId { get; set; }
    public string? ReferralDescription { get; set; }

    public virtual TruDatDboEnrollmentQuote? EnrollmentQuote { get; set; }
}
