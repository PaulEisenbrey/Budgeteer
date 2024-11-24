namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboMigrationHistory
{
    public string? MigrationId { get; set; }
    public string? ContextKey { get; set; }
    public byte[]? Model { get; set; }
    public string? ProductVersion { get; set; }
}
