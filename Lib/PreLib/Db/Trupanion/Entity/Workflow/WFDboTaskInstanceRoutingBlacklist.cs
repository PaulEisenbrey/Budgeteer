namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceRoutingBlacklist
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public int TaskInstanceId { get; set; }
    public Guid ConflictingLockId { get; set; }
    public Guid ExpirationHandle { get; set; }

    public virtual WFDboTaskInstance? TaskInstance { get; set; }
}
