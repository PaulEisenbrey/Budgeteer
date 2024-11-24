namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceBatch
{
    public WFDboTaskInstanceBatch()
    {
        TaskInstanceBatchItems = new HashSet<WFDboTaskInstanceBatchItem>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TaskInstanceBatchConfigurationId { get; set; }
    public int TaskInstanceGroupId { get; set; }
    public int BatchProcessInstanceId { get; set; }
    public int TaskInstanceBatchStatusId { get; set; }

    public virtual WFDboProcessInstance? BatchProcessInstance { get; set; }
    public virtual WFDboTaskInstanceBatchConfiguration? TaskInstanceBatchConfiguration { get; set; }
    public virtual WFDboTaskInstanceBatchStatus? TaskInstanceBatchStatus { get; set; }
    public virtual WFDboTaskInstanceGroup? TaskInstanceGroup { get; set; }
    public virtual ICollection<WFDboTaskInstanceBatchItem> TaskInstanceBatchItems { get; set; }
}
