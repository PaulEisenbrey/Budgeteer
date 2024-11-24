namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceRoutingKey
{
    public int Id { get; set; }
    public int TaskInstanceId { get; set; }
    public Guid RoutingKey { get; set; }

    public virtual WFDboActiveUserTaskInstance? TaskInstance { get; set; }
}
