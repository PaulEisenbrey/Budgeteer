namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessDefinition
{
    public WFDboProcessDefinition()
    {
        ProcessDefinitionConfigurations = new HashSet<WFDboProcessDefinitionConfiguration>();
        ProcessDefinitionFlows = new HashSet<WFDboProcessDefinitionFlow>();
        ProcessInstances = new HashSet<WFDboProcessInstance>();
        TaskInstanceBatchConfigurations = new HashSet<WFDboTaskInstanceBatchConfiguration>();
    }

    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public int? EnterpriseCategoryId { get; set; }
    public int? StandardStateTransitionResolutionGroupId { get; set; }

    public virtual WFDboStateTransitionResolutionGroup? StandardStateTransitionResolutionGroup { get; set; }
    public virtual ICollection<WFDboProcessDefinitionConfiguration> ProcessDefinitionConfigurations { get; set; }
    public virtual ICollection<WFDboProcessDefinitionFlow> ProcessDefinitionFlows { get; set; }
    public virtual ICollection<WFDboProcessInstance> ProcessInstances { get; set; }
    public virtual ICollection<WFDboTaskInstanceBatchConfiguration> TaskInstanceBatchConfigurations { get; set; }
}
