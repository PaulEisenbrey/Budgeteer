namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceBatchItemStatus
{
    public WFDboTaskInstanceBatchItemStatus()
    {
        TaskInstanceBatchItems = new HashSet<WFDboTaskInstanceBatchItem>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboTaskInstanceBatchItem> TaskInstanceBatchItems { get; set; }
}
