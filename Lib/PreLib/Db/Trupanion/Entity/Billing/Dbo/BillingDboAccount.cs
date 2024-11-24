namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboAccount
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? ExternalId { get; set; }
    public int AccountTypeId { get; set; }
    public DateTime? BillingPastDue { get; set; }
    public decimal? BillingPastDueAmount { get; set; }
    public bool? IsAccountSetupFeeWaived { get; set; }
    public bool AllowProratedCharges { get; set; }
    public int? CharityId { get; set; }
    public int? PolicyGroupId { get; set; }
    public int? AccountSetupFeePetId { get; set; }
    public int? NonReferencedCreditMethodTypeId { get; set; }
    public Guid? PartyId { get; set; }
    public string? InvoiceOwnerId { get; set; }
    public Guid? PolicyId { get; set; }
    public string? PaymentFailedDefaultPaymentMethodId { get; set; }
    public string? PaymentFailedReason { get; set; }

    public virtual BillingDboAccountType? AccountType { get; set; }
    public virtual BillingDboAccount? InvoiceOwner { get; set; }
    public virtual BillingDboPaymentMethodType? NonReferencedCreditMethodType { get; set; }
    public virtual BillingDboBankAccount? BankAccount { get; set; }
    public virtual List<BillingDboAccountPolicyholder> AccountPolicyholders { get; set; } = new();
    public virtual List<BillingDboAccount> InverseInvoiceOwner { get; set; } = new();
    public virtual List<BillingDboPaymentMethodSnapshot> PaymentMethodSnapshots { get; set; } = new();
    public virtual List<BillingDboPaymentReschedulingRequest> PaymentReschedulingRequests { get; set; } = new();
}
