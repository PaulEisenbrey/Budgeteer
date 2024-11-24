namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboMdrefundDatum
{
    public double? Id { get; set; }
    public string? OwnerName { get; set; }
    public string? PolicyNumber { get; set; }
    public DateTime? PolicyDate { get; set; }
    public decimal? PreviousPremium { get; set; }
    public decimal? UpdatedPremium { get; set; }
    public DateTime? DateOfRefund { get; set; }
    public decimal? AmountOfRefund { get; set; }
    public double? Amount { get; set; }
}
