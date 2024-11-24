namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboRateAdjustmentCorrection
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public decimal? UncapppedPremium { get; set; }
    public decimal? CorrectPremium { get; set; }
    public int? RateAdjustmentId { get; set; }
    public int? OrderItemId { get; set; }
    public int? OrderId { get; set; }
    public int? OrderStatusId { get; set; }
    public decimal? RefundAmount { get; set; }
    public int? RefundId { get; set; }
    public int? OwnerId { get; set; }
    public bool? Complete { get; set; }
    public string? Note { get; set; }
    public bool? HasEmail { get; set; }
}
