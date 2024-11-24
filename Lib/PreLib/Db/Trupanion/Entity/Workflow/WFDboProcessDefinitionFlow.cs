namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessDefinitionFlow
{
    public WFDboProcessDefinitionFlow()
    {
        InverseParent = new HashSet<WFDboProcessDefinitionFlow>();
        ProcessDefinitionFlowConfigurations = new HashSet<WFDboProcessDefinitionFlowConfiguration>();
        TaskInstances = new HashSet<WFDboTaskInstance>();
    }

    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public int ProcessDefinitionId { get; set; }
    public int ProcessDefinitionFlowTypeId { get; set; }
    public int? ParentId { get; set; }
    public int? TaskDefinitionId { get; set; }

    public virtual WFDboProcessDefinitionFlow? Parent { get; set; }
    public virtual WFDboProcessDefinition? ProcessDefinition { get; set; }
    public virtual WFDboProcessDefinitionFlowType? ProcessDefinitionFlowType { get; set; }
    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
    public virtual ICollection<WFDboProcessDefinitionFlow> InverseParent { get; set; }
    public virtual ICollection<WFDboProcessDefinitionFlowConfiguration> ProcessDefinitionFlowConfigurations { get; set; }
    public virtual ICollection<WFDboTaskInstance> TaskInstances { get; set; }
}
