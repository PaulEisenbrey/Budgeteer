namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboMdrefundParameter
{
    public double? RefundAmount { get; set; }
    public int PetPolicyId { get; set; }
    public int OwnerId { get; set; }
    public int StatusId { get; set; }
    public int ReasonId { get; set; }
    public int? OrderItemId { get; set; }
    public int? PaymentAttemptId { get; set; }
    public int? RefundId { get; set; }
    public int? RefundItemId { get; set; }
}
