namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateAccount
{
    public int Id { get; set; }
    public int AssociateId { get; set; }
    public int PaymentDayOfMonth { get; set; }
    public int DefaultPaymentMethod { get; set; }
    public bool? AutomaticPayment { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
}
