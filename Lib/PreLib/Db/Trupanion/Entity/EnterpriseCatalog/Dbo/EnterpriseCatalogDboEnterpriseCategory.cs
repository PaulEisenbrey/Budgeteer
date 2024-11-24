namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseCategory
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public Guid UniqueId { get; set; }
    public string? Name { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseEvent> EnterpriseEvents { get; set; } = new();
}
