namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboApplicationEnvironment
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsProduction { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseApplicationHost> EnterpriseApplicationHosts { get; set; } = new();
}
