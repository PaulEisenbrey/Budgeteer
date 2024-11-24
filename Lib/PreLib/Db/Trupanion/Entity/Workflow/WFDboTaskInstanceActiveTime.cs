namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceActiveTime
{
    public int Id { get; set; }
    public int TaskInstanceId { get; set; }
    public Guid UserId { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public DateTimeOffset StopTime { get; set; }

    public virtual WFDboTaskInstance? TaskInstance { get; set; }
}
