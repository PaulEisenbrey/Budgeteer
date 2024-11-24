namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinitionType
{
    public WFDboTaskDefinitionType()
    {
        TaskDefinitions = new HashSet<WFDboTaskDefinition>();
    }

    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }

    public virtual ICollection<WFDboTaskDefinition> TaskDefinitions { get; set; }
}
