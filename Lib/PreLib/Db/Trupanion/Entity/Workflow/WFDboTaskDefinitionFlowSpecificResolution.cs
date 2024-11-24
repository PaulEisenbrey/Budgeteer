namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinitionFlowSpecificResolution
{
    public int Id { get; set; }
    public int TaskDefinitionId { get; set; }
    public int ProcessDefinitionFlowId { get; set; }
    public int? StateTransitionResolutionGroupId { get; set; }

    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
}
