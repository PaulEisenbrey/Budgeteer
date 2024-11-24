namespace Database.Trupanion.Entity.EnterpriseCatalog.Dbo;

public class EnterpriseCatalogDboEnterpriseEntityLock
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid UniqueId { get; set; }
    public int EnterpriseEntityId { get; set; }
    public string? EntityId { get; set; }
    public string? EntityScope { get; set; }
    public int LockMode { get; set; }
    public int LockOwner { get; set; }
    public string? LockOwnerId { get; set; }
    public DateTimeOffset? LockExpiration { get; set; }
    public Guid? HeartbeatBrokerHandle { get; set; }
    public int LockRefreshInterval { get; set; }
    public int LockRefreshCheckInterval { get; set; }

    public virtual EnterpriseCatalogDboEnterpriseEntity? EnterpriseEntity { get; set; }
}
