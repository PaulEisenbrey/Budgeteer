namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionFollowup
{
    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public DateTimeOffset FollowupDate { get; set; }

    public virtual WFDboTaskInstanceStatusTransitionEventResolution? TaskInstanceStatusTransitionEventResolution { get; set; }
}
