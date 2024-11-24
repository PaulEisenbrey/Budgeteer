namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowQueueUser
{
    public int Id { get; set; }
    public int WorkflowQueueId { get; set; }
    public int UserId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboUser? User { get; set; }
    public virtual TruDatDboWorkflowQueue? WorkflowQueue { get; set; }
}
