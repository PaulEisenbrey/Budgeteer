namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboNewYorkEligiblePolicy
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int OwnerId { get; set; }
    public DateTime PolicyDate { get; set; }
    public DateTime AddressInserted { get; set; }
    public DateTime AddressUpdated { get; set; }
    public DateTime? HistoryMoved { get; set; }
    public DateTime? CoverageEffective { get; set; }
    public bool? Reliable { get; set; }
    public bool? OldPolicy { get; set; }
    public bool? BeforeHistory { get; set; }
    public bool? UpdatedBeforeHistory { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public DateTime? NewDate { get; set; }
    public string? Note { get; set; }
    public DateTime? DropDate { get; set; }
    public int? CurrentVersionId { get; set; }
    public DateTime? EffectiveUpgrade { get; set; }
    public string? CoreRenewal { get; set; }
}
