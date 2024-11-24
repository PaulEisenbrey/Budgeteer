namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowQueueLock
{
    public int SubjectEntityTypeId { get; set; }
    public int SubjectEntityId { get; set; }
    public int WorkflowQueueId { get; set; }
    public int ChangeUserId { get; set; }
    public DateTime Inserted { get; set; }
}
