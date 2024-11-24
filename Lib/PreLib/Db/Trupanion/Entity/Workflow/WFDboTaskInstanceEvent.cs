namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceEvent
{
    public WFDboTaskInstanceEvent()
    {
        TaskInstanceStatusTransitionEventResolutions = new HashSet<WFDboTaskInstanceStatusTransitionEventResolution>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int TaskInstanceId { get; set; }
    public int TriggeringEventId { get; set; }

    public virtual WFDboTaskInstance? TaskInstance { get; set; }
    public virtual WFDboEvent? TriggeringEvent { get; set; }
    public virtual WFDboTaskInstanceChangeAssignmentEvent? TaskInstanceChangeAssignmentEvent { get; set; }
    public virtual WFDboTaskInstanceStatusTransitionEvent? TaskInstanceStatusTransitionEvent { get; set; }
    public virtual ICollection<WFDboTaskInstanceStatusTransitionEventResolution> TaskInstanceStatusTransitionEventResolutions { get; set; }
}
