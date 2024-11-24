namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingUserDeductionLegacy
{
    public int DeductionTypeId { get; set; }
    public int? ClaimItemId { get; set; }
    public decimal? Amount { get; set; }
    public int ClaimId { get; set; }
    public Guid? BatchId { get; set; }
}
