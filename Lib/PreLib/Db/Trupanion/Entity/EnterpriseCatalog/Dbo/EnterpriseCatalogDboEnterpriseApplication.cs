namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplication
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? EnterprisePlatformId { get; set; }
    public int ApplicationHostId { get; set; }
    public bool BroadcastStatus { get; set; }
    public int PingInterval { get; set; }
    public string? EndPointUrl { get; set; }
    public bool IsClientApplication { get; set; }
    public string? EndpointPersistenceConnectionStringId { get; set; }
    public bool? CanHandleMessages { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboApplicationHost? ApplicationHost { get; set; }
    public virtual EnterpriseCatalogDboEnterprisePlatform? EnterprisePlatform { get; set; }
    public virtual List<EnterpriseCatalogDboEnterpriseApplicationEventHandler> EnterpriseApplicationEventHandlers { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseApplicationHostConfig> EnterpriseApplicationHostConfigs { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseApplicationHost> EnterpriseApplicationHosts { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntity> EnterpriseEntities { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntityAliasCachingConfiguration> EnterpriseEntityAliasCachingConfigurations { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntityAlias> EnterpriseEntityAliases { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntityCachingConfiguration> EnterpriseEntityCachingConfigurations { get; set; } = new();
    public virtual List<EnterpriseCatalogDboJobRun> JobRuns { get; set; } = new();
    public virtual List<EnterpriseCatalogDboMessageIntervention> MessageInterventions { get; set; } = new();
    public virtual List<EnterpriseCatalogDboMessageRetry> MessageRetries { get; set; } = new();
}
