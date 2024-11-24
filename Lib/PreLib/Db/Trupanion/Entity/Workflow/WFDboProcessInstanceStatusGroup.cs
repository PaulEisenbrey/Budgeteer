namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessInstanceStatusGroup
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public string Description { get; set; } = "";
}
