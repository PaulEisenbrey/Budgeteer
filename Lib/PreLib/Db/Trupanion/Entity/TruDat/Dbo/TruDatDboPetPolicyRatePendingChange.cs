namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyRatePendingChange
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int FactorId { get; set; }
    public string? PendingValue { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}
