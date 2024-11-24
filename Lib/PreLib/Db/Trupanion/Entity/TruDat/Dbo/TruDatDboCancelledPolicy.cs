namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCancelledPolicy
{
    public string? PolicyNumber { get; set; }
    public int OwnerId { get; set; }
    public string? OwnerFirstName { get; set; }
    public string? OwnerLastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? HomePhone { get; set; }
    public string? PetName { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime PolicyDate { get; set; }
    public int PolicyId { get; set; }
    public string? PetPolicyNumber { get; set; }
    public string? BreedName { get; set; }
    public DateTime CancelRequestDate { get; set; }
    public string? RequestedBy { get; set; }
    public DateTime? CancelApprovalDate { get; set; }
    public string? ApprovedBy { get; set; }
    public DateTime? PolicyPaidThru { get; set; }
    public int? CancelReasonId { get; set; }
    public string? CancelReason { get; set; }
    public string? CancelNote { get; set; }
    public bool Cancelled { get; set; }
    public int? RemainingTrialDays { get; set; }
}
