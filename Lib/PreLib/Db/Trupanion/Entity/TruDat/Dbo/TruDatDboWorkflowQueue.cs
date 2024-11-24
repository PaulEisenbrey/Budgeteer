namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowQueue
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboEntityTree? Category { get; set; }
    public virtual List<TruDatDboWorkflowCase> WorkflowCases { get; set; } = new();
    public virtual List<TruDatDboWorkflowQueueUser> WorkflowQueueUsers { get; set; } = new();
}
