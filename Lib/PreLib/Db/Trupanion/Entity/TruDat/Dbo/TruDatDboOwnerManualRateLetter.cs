namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerManualRateLetter
{
    public int Id { get; set; }
    public int? OwnerId { get; set; }
    public int? WorkflowCaseId { get; set; }
    public string? LetterText { get; set; }
    public DateTime? Inserted { get; set; }
    public int? ChangeUserId { get; set; }
    public int? PetPolicyId { get; set; }

    public virtual TruDatDboWorkflowCase? WorkflowCase { get; set; }
}
