namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstance
{
    public WFDboProcessInstance()
    {
        ProcessInstanceEvents = new HashSet<WFDboProcessInstanceEvent>();
        ProcessInstanceMonitorEvents = new HashSet<WFDboProcessInstanceMonitorEvent>();
        ProcessInstanceReferenceEntities = new HashSet<WFDboProcessInstanceReferenceEntity>();
        TaskInstances = new HashSet<WFDboTaskInstance>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ProcessDefinitionId { get; set; }
    public int ProcessInstanceStatusId { get; set; }
    public Guid? OwningUserId { get; set; }
    public int? ProcessInstancePriorityId { get; set; }
    public int? CurrentProcessDefinitionFlowId { get; set; }
    public int? SubjectEnterpriseEntityId { get; set; }
    public string SubjectEntityId { get; set; } = "";
    public string ProcessInstanceCreationArgs { get; set; } = "";

    public virtual WFDboProcessDefinition? ProcessDefinition { get; set; }
    public virtual WFDboProcessInstanceStatus? ProcessInstanceStatus { get; set; }
    public virtual WFDboActiveProcessInstance? ActiveProcessInstance { get; set; }
    public virtual WFDboTaskInstanceBatch? TaskInstanceBatch { get; set; }
    public virtual ICollection<WFDboProcessInstanceEvent> ProcessInstanceEvents { get; set; }
    public virtual ICollection<WFDboProcessInstanceMonitorEvent> ProcessInstanceMonitorEvents { get; set; }
    public virtual ICollection<WFDboProcessInstanceReferenceEntity> ProcessInstanceReferenceEntities { get; set; }
    public virtual ICollection<WFDboTaskInstance> TaskInstances { get; set; }
}
