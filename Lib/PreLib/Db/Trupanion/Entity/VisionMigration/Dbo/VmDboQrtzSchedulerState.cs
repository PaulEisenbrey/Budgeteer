namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboQrtzSchedulerState
{
    public string? SchedName { get; set; }
    public string? InstanceName { get; set; }
    public long LastCheckinTime { get; set; }
    public long CheckinInterval { get; set; }
}
