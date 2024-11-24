namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstance
{
    public WFDboTaskInstance()
    {
        Conversations = new HashSet<WFDboConversation>();
        TaskInstanceActiveTimes = new HashSet<WFDboTaskInstanceActiveTime>();
        TaskInstanceEvents = new HashSet<WFDboTaskInstanceEvent>();
        TaskInstanceGroupItems = new HashSet<WFDboTaskInstanceGroupItem>();
        TaskInstanceReferenceEntities = new HashSet<WFDboTaskInstanceReferenceEntity>();
        TaskInstanceRoutingBlacklists = new HashSet<WFDboTaskInstanceRoutingBlacklist>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public int? ParentTaskInstanceId { get; set; }
    public int AttemptNumber { get; set; }
    public int TaskDefinitionId { get; set; }
    public int ProcessInstanceId { get; set; }
    public int ProcessDefinitionFlowId { get; set; }
    public int TaskInstanceStatusId { get; set; }
    public int TaskInstancePriorityId { get; set; }
    public Guid? AssignedToUserId { get; set; }
    public bool HasConversation { get; set; }
    public bool HasActiveConversation { get; set; }
    public bool IsAutomated { get; set; }
    public bool IsBeingProcessed { get; set; }
    public DateTimeOffset? ExpireTime { get; set; }
    public int? TransitionedToEnterpriseApplicationId { get; set; }

    public virtual WFDboProcessDefinitionFlow? ProcessDefinitionFlow { get; set; }
    public virtual WFDboProcessInstance? ProcessInstance { get; set; }
    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
    public virtual WFDboTaskInstanceStatus? TaskInstanceStatus { get; set; }
    public virtual WFDboActiveUserTaskInstance? ActiveUserTaskInstance { get; set; }
    public virtual ICollection<WFDboConversation> Conversations { get; set; }
    public virtual ICollection<WFDboTaskInstanceActiveTime> TaskInstanceActiveTimes { get; set; }
    public virtual ICollection<WFDboTaskInstanceEvent> TaskInstanceEvents { get; set; }
    public virtual ICollection<WFDboTaskInstanceGroupItem> TaskInstanceGroupItems { get; set; }
    public virtual ICollection<WFDboTaskInstanceReferenceEntity> TaskInstanceReferenceEntities { get; set; }
    public virtual ICollection<WFDboTaskInstanceRoutingBlacklist> TaskInstanceRoutingBlacklists { get; set; }
}
