namespace Database.Trupanion.Entity.Workflow;

public class WFDboEvent
{
    public WFDboEvent()
    {
        ProcessInstanceEvents = new HashSet<WFDboProcessInstanceEvent>();
        TaskInstanceEvents = new HashSet<WFDboTaskInstanceEvent>();
    }

    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string Name { get; set; } = "";

    public virtual ICollection<WFDboProcessInstanceEvent> ProcessInstanceEvents { get; set; }
    public virtual ICollection<WFDboTaskInstanceEvent> TaskInstanceEvents { get; set; }
}
