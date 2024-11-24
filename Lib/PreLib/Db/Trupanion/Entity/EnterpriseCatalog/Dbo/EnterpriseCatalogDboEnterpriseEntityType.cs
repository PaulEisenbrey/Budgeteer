namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseEntityType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool SupportsRepository { get; set; }
    public bool SupportsProjectionAssembly { get; set; }

    public virtual List<EnterpriseCatalogDboEnterpriseEntity> EnterpriseEntities { get; set; } = new();
}
