﻿namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingPaymentAttempt
{
    public int Id { get; set; }
    public int ExecutionId { get; set; }
    public int PaymentMethodId { get; set; }
    public int StatusId { get; set; }
    public decimal PaymentAmount { get; set; }
    public string? Message { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? RefNum { get; set; }

    public virtual TruDatBillingPaymentMethod? PaymentMethod { get; set; }
    public virtual List<TruDatBillingPaymentAttemptOrder> PaymentAttemptOrders { get; set; } = new();
}
