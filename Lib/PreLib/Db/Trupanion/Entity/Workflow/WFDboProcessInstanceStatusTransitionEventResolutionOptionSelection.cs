namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection
{
    public int Id { get; set; }
    public int ProcessInstanceStatusTransitionEventResolutionId { get; set; }
    public int InputConfigurationOptionItemId { get; set; }

    public virtual WFDboInputConfigurationOptionItem? InputConfigurationOptionItem { get; set; }
    public virtual WFDboProcessInstanceStatusTransitionEventResolutionOption? ProcessInstanceStatusTransitionEventResolution { get; set; }
}
