namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseEntityAlias
{
    public int Id { get; set; }
    public int EnterpriseEntityId { get; set; }
    public string? EntityType { get; set; }
    public int? OwningEnterpriseApplicationId { get; set; }
    public string? ResourceRoute { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseEntity? EnterpriseEntity { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplication? OwningEnterpriseApplication { get; set; }
    public virtual List<EnterpriseCatalogDboEnterpriseEntityAliasCachingConfiguration> EnterpriseEntityAliasCachingConfigurations { get; set; } = new();
}
