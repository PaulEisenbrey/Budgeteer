namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCommissionModelTiming
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool CancelledPolicyPaybackRequired { get; set; }
    public int AcquisitionPaymentDelay { get; set; }
}
