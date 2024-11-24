namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseErrorText
{
    public int Id { get; set; }
    public int EnterpriseErrorId { get; set; }
    public string? LanguageCode { get; set; }
    public string? Description { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseError? EnterpriseError { get; set; }
}
