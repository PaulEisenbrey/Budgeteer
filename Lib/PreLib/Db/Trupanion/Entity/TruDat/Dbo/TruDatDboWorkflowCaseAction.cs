namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowCaseAction
{
    public int Id { get; set; }
    public int WorkflowCaseId { get; set; }
    public int CategoryId { get; set; }
    public int? EntityNoteId { get; set; }
    public double? ElapsedSeconds { get; set; }
    public bool SelfServe { get; set; }
    public DateTime Inserted { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboEntityTree? Category { get; set; }
    public virtual TruDatDboWorkflowCase? WorkflowCase { get; set; }
}
