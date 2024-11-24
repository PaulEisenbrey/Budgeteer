namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboQrtzCronTrigger
{
    public string? SchedName { get; set; }
    public string? TriggerName { get; set; }
    public string? TriggerGroup { get; set; }
    public string? CronExpression { get; set; }
    public string? TimeZoneId { get; set; }

    public virtual VmDboQrtzTrigger? QrtzTrigger { get; set; }
}
