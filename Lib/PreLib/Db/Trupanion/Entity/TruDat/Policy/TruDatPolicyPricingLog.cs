namespace Database.Trupanion.Entity.TruDat.Policy;

public class TruDatPolicyPricingLog
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int? DeclarationPageid { get; set; }
    public DateTime? EffectiveDate { get; set; }
    public int StateId { get; set; }
    public string? ZipCode { get; set; }
    public string? Gender { get; set; }
    public int? SpecieId { get; set; }
    public int? BreedId { get; set; }
    public DateTime? PolicyDate { get; set; }
    public int? PolicyAgeId { get; set; }
    public int? ClinicId { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? Premium { get; set; }
    public bool? SpayedOrNeutered { get; set; }
    public int? WaitingPeriodForAccident { get; set; }
    public int? WaitingPeriodForIllness { get; set; }
    public int? PetFoodId { get; set; }
    public string? PromoCode { get; set; }
    public int? PolicyVersionId { get; set; }
    public int? EngineVersionId { get; set; }
    public bool? IntendToSpayNeuter { get; set; }
    public string? WorkingPetIds { get; set; }
    public string? SelectedOptions { get; set; }
    public decimal? RatePendingDeductible { get; set; }
    public DateTime? RatePendingEffectiveDate { get; set; }
    public int? RatePendingEngineVersionId { get; set; }
    public int? RatePendingPolicyVersionId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }
}
