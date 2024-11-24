namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionOption
{
    public WFDboTaskInstanceStatusTransitionEventResolutionOption()
    {
        TaskInstanceStatusTransitionEventResolutionOptionSelections = new HashSet<WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection>();
    }

    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }

    public virtual WFDboTaskInstanceStatusTransitionEventResolution? TaskInstanceStatusTransitionEventResolution { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection> TaskInstanceStatusTransitionEventResolutionOptionSelections { get; set; }
}
