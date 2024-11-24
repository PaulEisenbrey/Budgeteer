namespace Database.Trupanion.Entity.Workflow;

public class WFDboUser
{
    public Guid Id { get; set; }
    public int LegacyId { get; set; }
    public string DisplayName { get; set; } = "";
    public int Status { get; set; }
    public bool IsServiceAccount { get; set; }
    public string Skills { get; set; } = "";
    public string Skillsets { get; set; } = "";
    public string Attributes { get; set; } = "";
}
