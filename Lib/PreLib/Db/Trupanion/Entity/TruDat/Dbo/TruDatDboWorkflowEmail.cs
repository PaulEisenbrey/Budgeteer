namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowEmail
{
    public int Id { get; set; }
    public int WorkflowCaseId { get; set; }
    public int EmailId { get; set; }

    public virtual TruDatDboWorkflowCase? WorkflowCase { get; set; }
}
