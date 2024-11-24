namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstance
{
    public int Id { get; set; }
    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public int TaskInstanceId { get; set; }

    public virtual WFDboTaskInstanceStatusTransitionEventResolutionCancelWait? TaskInstanceStatusTransitionEventResolution { get; set; }
}
