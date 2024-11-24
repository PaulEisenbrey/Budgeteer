namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatus
{
    public WFDboTaskInstanceStatus()
    {
        TaskDefinitionDisallowedStates = new HashSet<WFDboTaskDefinitionDisallowedState>();
        TaskDefinitions = new HashSet<WFDboTaskDefinition>();
        TaskInstanceStatusTransitionEventPostTransitionTaskInstanceStatuses = new HashSet<WFDboTaskInstanceStatusTransitionEvent>();
        TaskInstanceStatusTransitionEventPreTransitionTaskInstanceStatuses = new HashSet<WFDboTaskInstanceStatusTransitionEvent>();
        TaskInstanceStatusTransitionMapCanTransitionToTaskInstanceStatuses = new HashSet<WFDboTaskInstanceStatusTransitionMap>();
        TaskInstanceStatusTransitionMapTaskInstanceStatuses = new HashSet<WFDboTaskInstanceStatusTransitionMap>();
        TaskInstances = new HashSet<WFDboTaskInstance>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public int TaskInstanceStatusGroupId { get; set; }
    public string Description { get; set; } = "";

    public virtual WFDboTaskInstanceStatusGroup? TaskInstanceStatusGroup { get; set; }
    public virtual ICollection<WFDboTaskDefinitionDisallowedState> TaskDefinitionDisallowedStates { get; set; }
    public virtual ICollection<WFDboTaskDefinition> TaskDefinitions { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEvent> TaskInstanceStatusTransitionEventPostTransitionTaskInstanceStatuses { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEvent> TaskInstanceStatusTransitionEventPreTransitionTaskInstanceStatuses { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionMap> TaskInstanceStatusTransitionMapCanTransitionToTaskInstanceStatuses { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionMap> TaskInstanceStatusTransitionMapTaskInstanceStatuses { get; set; }
    public virtual ICollection<WFDboTaskInstance> TaskInstances { get; set; }
}
