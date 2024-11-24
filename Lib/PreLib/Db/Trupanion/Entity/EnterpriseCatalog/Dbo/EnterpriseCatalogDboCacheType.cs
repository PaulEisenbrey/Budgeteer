namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboCacheType
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseEntityAliasCachingConfiguration> EnterpriseEntityAliasCachingConfigurations { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEntityCachingConfiguration> EnterpriseEntityCachingConfigurations { get; set; } = new();
}
