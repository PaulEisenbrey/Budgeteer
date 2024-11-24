namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationEventFilter
{
    public int Id { get; set; }
    public int EnterpriseApplicationEventHandlerId { get; set; }
    public int? ForEnterprisePlatformId { get; set; }
    public int? ForEnterpriseApplicationId { get; set; }
    public int? ForEnterpriseHostId { get; set; }
    public int? ForEnterpriseEventCategoryId { get; set; }
    public int? ForEnterpriseEventPlatformId { get; set; }
    public int? ForEnterpriseEventId { get; set; }
    public Guid? ForCurrentUserId { get; set; }
    public int? ForTargetEnterpriseApplicationId { get; set; }
    public string? ForCustomAttributes { get; set; }
    public int ConfigurationVersionId { get; set; }
    public byte[]? RowHash { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseApplicationEventHandler? EnterpriseApplicationEventHandler { get; set; }
}
