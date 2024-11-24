namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboVoucherOverridePolicy
{
    public int Id { get; set; }
    public int VoucherId { get; set; }
    public int PolicyId { get; set; }
    public decimal? MaximumLifetimeBenefitsPayment { get; set; }
    public decimal? CoinsurancePercentage { get; set; }
    public int WaitingPeriodForAccident { get; set; }
    public int WaitingPeriodForIllness { get; set; }
}
