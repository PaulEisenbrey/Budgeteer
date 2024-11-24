namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationSystemGlobalEventHandler
{
    public int Id { get; set; }
    public int EnterpriseApplicationEventHandlerId { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplicationEventHandler? EnterpriseApplicationEventHandler { get; set; }
}
