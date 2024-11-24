namespace Database.Trupanion.Entity.TruDat.Policy;

public partial class TruDatPolicyDeclarationPageOption
{
    public int Id { get; set; }
    public int DeclarationPageId { get; set; }
    public string? Name { get; set; }
    public string? EndorsementDocumentVersion { get; set; }
    public bool? HideWaitingPeriods { get; set; }
    public bool? Included { get; set; }
    public bool? Selected { get; set; }
    public DateTime? EffectiveFrom { get; set; }
    public decimal? Cost { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
}
