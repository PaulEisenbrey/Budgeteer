namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceSummary
{
    public int CampaignInstanceId { get; set; }
    public string? ProgramGeneral { get; set; }
    public string? ProgramSpecific { get; set; }
    public string? CampaignName { get; set; }
    public string? CampaignCode { get; set; }
    public bool HasSetupFeeDiscount { get; set; }
    public string? SetupFeeDiscountAmount { get; set; }
    public bool HasPremiumDiscount { get; set; }
    public decimal PremiumDiscountPercent { get; set; }
    public bool HasWaitingPeriodModification { get; set; }
    public int WaitingPeriodAccident { get; set; }
    public int WaitingPeriodIllness { get; set; }
    public bool HasTrialPeriod { get; set; }
    public int TrialNumberOfDays { get; set; }
    public string? Category { get; set; }
    public byte[]? RowChecksum { get; set; }
}
