namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatus
{
    public WFDboProcessInstanceStatus()
    {
        ProcessInstanceStatusTransitionEventPostTransitionProcessInstanceStatuses = new HashSet<WFDboProcessInstanceStatusTransitionEvent>();
        ProcessInstanceStatusTransitionEventPreTransitionProcessInstanceStatuses = new HashSet<WFDboProcessInstanceStatusTransitionEvent>();
        ProcessInstanceStatusTransitionMapCanTransitionToProcessInstanceStatuses = new HashSet<WFDboProcessInstanceStatusTransitionMap>();
        ProcessInstanceStatusTransitionMapProcessInstanceStatuses = new HashSet<WFDboProcessInstanceStatusTransitionMap>();
        ProcessInstances = new HashSet<WFDboProcessInstance>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int ProcessInstanceStatusGroupId { get; set; }
    public long? VersionId { get; set; }
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboProcessInstanceStatusTransitionEvent> ProcessInstanceStatusTransitionEventPostTransitionProcessInstanceStatuses { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionEvent> ProcessInstanceStatusTransitionEventPreTransitionProcessInstanceStatuses { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionMap> ProcessInstanceStatusTransitionMapCanTransitionToProcessInstanceStatuses { get; set; }
    public virtual ICollection<WFDboProcessInstanceStatusTransitionMap> ProcessInstanceStatusTransitionMapProcessInstanceStatuses { get; set; }
    public virtual ICollection<WFDboProcessInstance> ProcessInstances { get; set; }
}
