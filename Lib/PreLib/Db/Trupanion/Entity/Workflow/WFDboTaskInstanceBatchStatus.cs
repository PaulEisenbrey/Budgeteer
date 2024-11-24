namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceBatchStatus
{
    public WFDboTaskInstanceBatchStatus()
    {
        TaskInstanceBatches = new HashSet<WFDboTaskInstanceBatch>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboTaskInstanceBatch> TaskInstanceBatches { get; set; }
}
