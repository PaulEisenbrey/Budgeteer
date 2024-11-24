namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinitionDisallowedState
{
    public int Id { get; set; }
    public int TaskDefinitionId { get; set; }
    public int DisallowedTaskInstanceStatusId { get; set; }

    public virtual WFDboTaskInstanceStatus? DisallowedTaskInstanceStatus { get; set; }
    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
}
