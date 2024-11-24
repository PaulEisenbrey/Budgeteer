namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusTransitionEventResolutionCancelWait
{
    public WFDboTaskInstanceStatusTransitionEventResolutionCancelWait()
    {
        TaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstances = new HashSet<WFDboTaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstance>();
    }

    public int TaskInstanceStatusTransitionEventResolutionId { get; set; }
    public bool Asynchronous { get; set; }

    public virtual WFDboTaskInstanceStatusTransitionEventResolution? TaskInstanceStatusTransitionEventResolution { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstance> TaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstances { get; set; }
}
