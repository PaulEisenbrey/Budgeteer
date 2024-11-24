namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboApplicationHost
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsOwinCapable { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseApplication> EnterpriseApplications { get; set; } = new();
}
