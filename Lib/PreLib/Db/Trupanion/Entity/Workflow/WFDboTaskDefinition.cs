namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinition
{
    public WFDboTaskDefinition()
    {
        ProcessDefinitionFlows = new HashSet<WFDboProcessDefinitionFlow>();
        TaskDefinitionConfigurations = new HashSet<WFDboTaskDefinitionConfiguration>();
        TaskDefinitionConversationTopics = new HashSet<WFDboTaskDefinitionConversationTopic>();
        TaskDefinitionDisallowedStates = new HashSet<WFDboTaskDefinitionDisallowedState>();
        TaskDefinitionFlowSpecificResolutions = new HashSet<WFDboTaskDefinitionFlowSpecificResolution>();
        TaskDefinitionWaitOnCompletions = new HashSet<WFDboTaskDefinitionWaitOnCompletion>();
        TaskInstanceGroupConfigurations = new HashSet<WFDboTaskInstanceGroupConfiguration>();
        TaskInstances = new HashSet<WFDboTaskInstance>();
    }

    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public int TaskDefinitionTypeId { get; set; }
    public int InitialTaskInstanceStatusId { get; set; }
    public bool IsAutomated { get; set; }
    public bool HasRoutingConfiguration { get; set; }
    public int? StandardStateTransitionResolutionGroupId { get; set; }

    public virtual WFDboTaskInstanceStatus? InitialTaskInstanceStatus { get; set; }
    public virtual WFDboStateTransitionResolutionGroup? StandardStateTransitionResolutionGroup { get; set; }
    public virtual WFDboTaskDefinitionType? TaskDefinitionType { get; set; }
    public virtual ICollection<WFDboProcessDefinitionFlow> ProcessDefinitionFlows { get; set; }
    public virtual ICollection<WFDboTaskDefinitionConfiguration> TaskDefinitionConfigurations { get; set; }
    public virtual ICollection<WFDboTaskDefinitionConversationTopic> TaskDefinitionConversationTopics { get; set; }
    public virtual ICollection<WFDboTaskDefinitionDisallowedState> TaskDefinitionDisallowedStates { get; set; }
    public virtual ICollection<WFDboTaskDefinitionFlowSpecificResolution> TaskDefinitionFlowSpecificResolutions { get; set; }
    public virtual ICollection<WFDboTaskDefinitionWaitOnCompletion> TaskDefinitionWaitOnCompletions { get; set; }
    public virtual ICollection<WFDboTaskInstanceGroupConfiguration> TaskInstanceGroupConfigurations { get; set; }
    public virtual ICollection<WFDboTaskInstance> TaskInstances { get; set; }
}
