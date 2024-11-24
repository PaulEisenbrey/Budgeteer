namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceGroupConfiguration
{
    public WFDboTaskInstanceGroupConfiguration()
    {
        TaskInstanceBatchConfigurations = new HashSet<WFDboTaskInstanceBatchConfiguration>();
        TaskInstanceGroups = new HashSet<WFDboTaskInstanceGroup>();
    }

    public int Id { get; set; }
    public int TaskDefinitionId { get; set; }
    public int GroupByEnterpriseEntityId { get; set; }

    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
    public virtual ICollection<WFDboTaskInstanceBatchConfiguration> TaskInstanceBatchConfigurations { get; set; }
    public virtual ICollection<WFDboTaskInstanceGroup> TaskInstanceGroups { get; set; }
}
