namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationGlobalEventHandler
{
    public int Id { get; set; }
    public int EnterpriseApplicationEventHandlerId { get; set; }
    public bool? Targeted { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplicationEventHandler? EnterpriseApplicationEventHandler { get; set; }
}
