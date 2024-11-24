namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationEventHandler
{
    public int Id { get; set; }
    public int? EnterpriseApplicationId { get; set; }
    public string? EventHandlerClassName { get; set; }
    public bool SendImmediateStatistics { get; set; }
    public bool StatisticsDisabled { get; set; }
    public bool? RetryEnabled { get; set; }
    public bool? RequiresManualInterventionOnException { get; set; }
    public string? ManualInterventionService { get; set; }
    public int? SubscriptionType { get; set; }
    public bool? Transacted { get; set; }
    public string? Configuration { get; set; }
    public int InstanceCount { get; set; }
    public bool Lazy { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplicationGlobalEventHandler? EnterpriseApplicationGlobalEventHandler { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplicationSystemGlobalEventHandler? EnterpriseApplicationSystemGlobalEventHandler { get; set; }
    public virtual List<EnterpriseCatalogDboEnterpriseApplicationEventFilter> EnterpriseApplicationEventFilters { get; set; } = new();
    public virtual List<EnterpriseCatalogDboMessageIntervention> MessageInterventions { get; set; } = new();
    public virtual List<EnterpriseCatalogDboMessageRetry> MessageRetries { get; set; } = new();
}
