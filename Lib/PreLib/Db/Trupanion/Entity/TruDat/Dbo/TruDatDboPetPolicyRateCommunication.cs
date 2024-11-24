namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyRateCommunication
{
    public int Id { get; set; }
    public int RateAdjustmentId { get; set; }
    public int FactorId { get; set; }
    public string? PreChangeValue { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboPetPolicyRateAdjustment? RateAdjustment { get; set; }
}
