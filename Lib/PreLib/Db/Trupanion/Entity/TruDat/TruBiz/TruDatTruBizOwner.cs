namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizOwner
{
    public int Id { get; set; }
    public int? CorporateAccountId { get; set; }
    public string PolicyNumber { get; set; } = "";
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string EmailAddress { get; set; } = "";
    public string HomePhone { get; set; } = "";
    public string CellPhone { get; set; } = "";
    public string WorkPhone { get; set; } = "";
    public string WorkExtension { get; set; } = "";
    public string FaxNumber { get; set; } = "";
    public int? DefaultPaymentMethod { get; set; }
    public int EngineId { get; set; }
    public int? BillingDayOfMonth { get; set; }
    public DateTime? BillingPastDue { get; set; }
    public decimal? BillingPastDueAmount { get; set; }
    public DateTime? PaymentFailedDate { get; set; }
    public DateTime? PolicyHolderUntil { get; set; }
    public int? UserId { get; set; }
    public string SecondaryEmailAddress { get; set; } = "";
    public int? ClaimPaymentMethodId { get; set; }
    public int? SiteVisitorId { get; set; }
    public int? SiteVisitorSessionId { get; set; }
    public int? CommunicationPreferenceId { get; set; }
    public bool? AdministrationFeeWaived { get; set; }
    public int? AdministrationFeeWaivedId { get; set; }
    public bool HostpitalEmployee { get; set; }
    public bool Vip { get; set; }
    public string EmployeeId { get; set; } = "";
    public int? BluePearlAccountId { get; set; }
    public int? CharityId { get; set; }
    public decimal? CharityValue { get; set; }
    public string AlternateFirstName { get; set; } = "";
    public string AlternateLastName { get; set; } = "";
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public string Language { get; set; } = "";
    public int? LanguageId { get; set; }
    public string PaymentFailedDefaultPaymentMethodId { get; set; } = "";
    public string PaymentFailedReason { get; set; } = "";
    public bool IsStateFarmRelated { get; set; }
}
