namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowCaseConfig
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int? WorkflowGroupId { get; set; }
    public int? MoveToQueueId { get; set; }
    public int? ChangeToStatusId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboStatus? ChangeToStatus { get; set; }
    public virtual TruDatDboWorkflowGroup? WorkflowGroup { get; set; }
}
