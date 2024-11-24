namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboVersionedDatum
{
    public int Id { get; set; }
    public int CurrentVersionId { get; set; }
    public int? ResetVersionId { get; set; }
}
