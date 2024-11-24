namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceBatchItem
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TaskInstanceBatchId { get; set; }
    public int TaskInstanceGroupItemId { get; set; }
    public int BatchEnterpriseEntityId { get; set; }
    public string BatchEntityId { get; set; } = "";
    public int TaskInstanceBatchItemStatusId { get; set; }

    public virtual WFDboTaskInstanceBatch? TaskInstanceBatch { get; set; }
    public virtual WFDboTaskInstanceBatchItemStatus? TaskInstanceBatchItemStatus { get; set; }
    public virtual WFDboTaskInstanceGroupItem? TaskInstanceGroupItem { get; set; }
}
