namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboRateAdjustmentCorrectionUnderBilled
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int PetPolicyId { get; set; }
    public decimal? CurrentPremium { get; set; }
    public decimal? CorrectPremium { get; set; }
    public int? RateAdjustmentId { get; set; }
    public int? OrderId { get; set; }
    public int? OrderStatusId { get; set; }
    public decimal? LossAmount { get; set; }
    public int? OrderItemId { get; set; }
    public int? OwnerId { get; set; }
    public bool? Complete { get; set; }
    public string? Note { get; set; }
    public bool? HasEmail { get; set; }
    public decimal? OptBenCost { get; set; }
    public decimal? AddBen { get; set; }
    public decimal? RiderA { get; set; }
    public decimal? RiderB { get; set; }
    public decimal? Loss { get; set; }
    public decimal? RatedPremium { get; set; }
}
