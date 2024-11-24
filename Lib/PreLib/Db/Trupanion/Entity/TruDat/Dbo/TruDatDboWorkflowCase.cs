namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowCase
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? WorkflowQueueId { get; set; }
    public int? CategoryId { get; set; }
    public int? SubjectEntityTypeId { get; set; }
    public int? SubjectEntityId { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboEntityTree? Category { get; set; }
    public virtual TruDatDboWorkflowCase? Parent { get; set; }
    public virtual TruDatDboStatus? Status { get; set; }
    public virtual TruDatDboEntity? SubjectEntityType { get; set; }
    public virtual TruDatDboWorkflowQueue? WorkflowQueue { get; set; }
    public virtual List<TruDatDboWorkflowCase> InverseParent { get; set; } = new();
    public virtual List<TruDatDboOwnerManualRateLetter> OwnerManualRateLetters { get; set; } = new();
    public virtual List<TruDatDboWorkflowCaseAction> WorkflowCaseActions { get; set; } = new();
    public virtual List<TruDatDboWorkflowEmail> WorkflowEmails { get; set; } = new();
}
