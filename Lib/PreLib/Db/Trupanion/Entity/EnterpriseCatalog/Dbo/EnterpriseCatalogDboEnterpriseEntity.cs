namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseEntity
{
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string? Name { get; set; }
    public string? EntityType { get; set; }
    public int EnterpriseEntityTypeId { get; set; }
    public int? OwningEnterpriseApplicationId { get; set; }
    public string? ResourceRoute { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseEntityType? EnterpriseEntityType { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplication? OwningEnterpriseApplication { get; set; }
    public virtual List<EnterpriseCatalogDboEnterpriseEntityAlias> EnterpriseEntityAliases { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntityCachingConfiguration> EnterpriseEntityCachingConfigurations { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntityLock> EnterpriseEntityLocks { get; set; } = new();
}
