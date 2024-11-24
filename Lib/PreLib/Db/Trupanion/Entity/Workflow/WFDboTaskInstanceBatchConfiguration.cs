namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskInstanceBatchConfiguration
{
    public WFDboTaskInstanceBatchConfiguration()
    {
        TaskInstanceBatches = new HashSet<WFDboTaskInstanceBatch>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int TaskInstanceGroupConfigurationId { get; set; }
    public int BatchProcessDefinitionId { get; set; }
    public int BatchItemEnterpriseEntityId { get; set; }
    public bool AutomatedTaskInstanceOnly { get; set; }
    public int TimingType { get; set; }
    public string TimingInfo { get; set; } = "";
    public string CustomTimingService { get; set; } = "";
    public string BatchItemReleaseService { get; set; } = "";
    public string BatchItemCompleteService { get; set; } = "";
    public string Description { get; set; } = "";

    public virtual WFDboProcessDefinition? BatchProcessDefinition { get; set; }
    public virtual WFDboTaskInstanceGroupConfiguration? TaskInstanceGroupConfiguration { get; set; }
    public virtual ICollection<WFDboTaskInstanceBatch> TaskInstanceBatches { get; set; }
}
