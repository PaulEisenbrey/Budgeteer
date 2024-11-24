namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboQrtzSimpleTrigger
{
    public string? SchedName { get; set; }
    public string? TriggerName { get; set; }
    public string? TriggerGroup { get; set; }
    public int RepeatCount { get; set; }
    public long RepeatInterval { get; set; }
    public int TimesTriggered { get; set; }

    public virtual VmDboQrtzTrigger? QrtzTrigger { get; set; }
}
