namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceGroup
{
    public WFDboTaskInstanceGroup()
    {
        TaskInstanceBatches = new HashSet<WFDboTaskInstanceBatch>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TaskInstanceGroupConfigurationId { get; set; }
    public int EnterpriseEntityId { get; set; }
    public string EntityId { get; set; } = "";
    public bool IsClosed { get; set; }

    public virtual WFDboTaskInstanceGroupConfiguration? TaskInstanceGroupConfiguration { get; set; }
    public virtual ICollection<WFDboTaskInstanceBatch> TaskInstanceBatches { get; set; }
}
