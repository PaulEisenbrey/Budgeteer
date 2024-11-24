namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseHost
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseApplicationHostConfig> EnterpriseApplicationHostConfigs { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseApplicationHost> EnterpriseApplicationHosts { get; set; } = new();
}
