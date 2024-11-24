namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection
{
    public int Id { get; set; }
    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public int InputConfigurationOptionItemId { get; set; }

    public virtual WFDboInputConfigurationOptionItem? InputConfigurationOptionItem { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEventResolutionOption? TaskInstanceStatusTransitionEventResolution { get; set; }
}
