namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseApplicationHost
{
    public int Id { get; set; }
    public int EnterpriseApplicationId { get; set; }
    public int EnterpriseHostId { get; set; }
    public int ApplicationEnvironmentId { get; set; }
    public string? StartupArgs { get; set; }
    public DateTimeOffset? ConnectTime { get; set; }
    public Guid? UserId { get; set; }
    public bool IsOnline { get; set; }
    public DateTimeOffset? DisconnectTime { get; set; }
    public DateTimeOffset? Heartbeat { get; set; }
    public int? Pid { get; set; }

    public virtual EnterpriseCatalogDboApplicationEnvironment? ApplicationEnvironment { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseApplication? EnterpriseApplication { get; set; }
    public virtual EnterpriseCatalogDboEnterpriseHost? EnterpriseHost { get; set; }
}
