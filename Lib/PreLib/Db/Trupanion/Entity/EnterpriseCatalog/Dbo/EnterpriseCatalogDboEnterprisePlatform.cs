namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterprisePlatform
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? CustomAttributeFormat { get; set; }
    public string? CustomAttributeDescription { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseApplication> EnterpriseApplications { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseError> EnterpriseErrors { get; set; } = new();
    public virtual List<EnterpriseCatalogDboEnterpriseEvent> EnterpriseEvents { get; set; } = new();
}
