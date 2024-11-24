namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClinicClaimForm
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int AssessmentDataId { get; set; }
    public bool? HasPreviouslyFiledClaim { get; set; }
    public DateTime? FirstSymptomDate { get; set; }
    public int SourceEnterpriseApplicationId { get; set; }
    public string? PresentingConditions { get; set; }
    public int? RelatedClaim { get; set; }
    public string? PresentingConditions2 { get; set; }
    public int? RelatedClaim2 { get; set; }
    public bool? PrescriptionFoodReview { get; set; }
    public string? SecondaryInsurance { get; set; }
    public bool? IsRealTimeProcessing { get; set; }
}
