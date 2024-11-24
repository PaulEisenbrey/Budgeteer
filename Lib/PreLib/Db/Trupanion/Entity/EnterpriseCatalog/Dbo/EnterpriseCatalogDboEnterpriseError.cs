namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseError
{
    public int Id { get; set; }
    public int? PlatformId { get; set; }
    public int Code { get; set; }
    public string? UniqueCode { get; set; }
    public string? InternalDescription { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterprisePlatform? Platform { get; set; }
    public virtual List<EnterpriseCatalogDboEnterpriseErrorText> EnterpriseErrorTexts { get; set; } = new();
}
