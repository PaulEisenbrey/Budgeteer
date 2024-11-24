namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboDeletedRow
{
    public int Id { get; set; }
    public string? DeletedType { get; set; }
    public int? DeletedId { get; set; }
    public int ConfigurationVersionId { get; set; }
}
