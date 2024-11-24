namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboQrtzJobDetail
{
    public string? SchedName { get; set; }
    public string? JobName { get; set; }
    public string? JobGroup { get; set; }
    public string? Description { get; set; }
    public string? JobClassName { get; set; }
    public bool IsDurable { get; set; }
    public bool IsNonconcurrent { get; set; }
    public bool IsUpdateData { get; set; }
    public bool RequestsRecovery { get; set; }
    public byte[]? JobData { get; set; }

    public virtual List<VmDboQrtzTrigger> QrtzTriggers { get; set; } = new();
}
