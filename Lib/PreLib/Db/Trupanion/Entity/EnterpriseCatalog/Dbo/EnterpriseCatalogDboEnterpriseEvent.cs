namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseEvent
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Guid UniqueId { get; set; }
    public int? EventCategoryId { get; set; }
    public int? EnterprisePlatformId { get; set; }
    public string? Description { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterprisePlatform? EnterprisePlatform { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseCategory? EventCategory { get; set; }
}
