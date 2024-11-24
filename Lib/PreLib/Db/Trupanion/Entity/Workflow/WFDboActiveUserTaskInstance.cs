namespace Database.Trupanion.Entity.Workflow;

public class WFDboActiveUserTaskInstance
{
    public WFDboActiveUserTaskInstance()
    {
        TaskInstanceRoutingKeys = new HashSet<WFDboTaskInstanceRoutingKey>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public DateTimeOffset? FinalizedOn { get; set; }
    public int ProcessDefinitionFlowId { get; set; }
    public int TaskInstanceStatusId { get; set; }
    public int TaskInstanceStatusGroupId { get; set; }
    public int TaskDefinitionId { get; set; }
    public int ProcessInstanceId { get; set; }
    public int ProcessDefinitionId { get; set; }
    public int TaskInstancePriorityId { get; set; }
    public bool IsAutomated { get; set; }
    public bool IsBeingProcessed { get; set; }
    public Guid? AssignedToUserId { get; set; }

    public virtual WFDboTaskInstance? IdNavigation { get; set; }
    public virtual ICollection<WFDboTaskInstanceRoutingKey> TaskInstanceRoutingKeys { get; set; }
}
