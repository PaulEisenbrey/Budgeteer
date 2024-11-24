namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboActiveClaim
{
    public int Id { get; set; }
    public int StatusId { get; set; }
    public int PetPolicyId { get; set; }
    public bool Deleted { get; set; }
    public DateTime ClaimInserted { get; set; }
    public int? AssignedToUserId { get; set; }
    public bool? PreApproval { get; set; }
    public bool? ClaimsExpress { get; set; }
    public int PetId { get; set; }
    public int OwnerId { get; set; }
    public int ClaimAssessmentId { get; set; }
    public int? LastAssessmentDataId { get; set; }
    public DateTime AssessmentDataInserted { get; set; }
}
