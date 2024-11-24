namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerFailedPaymentDatum
{
    public int OwnerId { get; set; }
    public string? PaymentFailedReason { get; set; }
    public string? PaymentFailedDefaultPaymentMethodId { get; set; }

    public virtual TruDatDboOwner? Owner { get; set; }
}
