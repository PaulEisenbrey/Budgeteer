namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceStatusGroup
{
    public WFDboTaskInstanceStatusGroup()
    {
        TaskInstanceStatuses = new HashSet<WFDboTaskInstanceStatus>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboTaskInstanceStatus> TaskInstanceStatuses { get; set; }
}
