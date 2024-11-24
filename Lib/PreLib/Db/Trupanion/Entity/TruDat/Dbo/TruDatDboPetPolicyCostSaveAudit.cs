namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyCostSaveAudit
{
    public int Id { get; set; }
    public int? PetPolicyId { get; set; }
    public int? CostId { get; set; }
    public decimal? Cost { get; set; }
    public string? Note { get; set; }
    public int? Action { get; set; }
    public int? UserId { get; set; }
    public bool? InSqlTran { get; set; }
    public string? AdditionalInformation { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public DateTime? Effective { get; set; }
}
