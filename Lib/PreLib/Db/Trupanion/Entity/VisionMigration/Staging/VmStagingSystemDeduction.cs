namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingSystemDeduction
{
    public int? ClaimItemId { get; set; }
    public decimal? Amount { get; set; }
    public string? DeductionType { get; set; }
    public int ClaimId { get; set; }
    public int ExtRef { get; set; }
    public Guid? BatchId { get; set; }
}
