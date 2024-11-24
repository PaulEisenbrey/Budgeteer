namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboVoucherText
{
    public string? WebPartner { get; set; }
    public int Id { get; set; }
    public string? PromoCode { get; set; }
    public string? Description { get; set; }
    public string? Name { get; set; }
    public DateTime? LiveDate { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int? WebPartnerId { get; set; }
    public string? SecurityKey { get; set; }
    public bool? ValidateRange { get; set; }
    public bool? ValidateUnique { get; set; }
    public bool? RequiresReference { get; set; }
    public long? NumericRangeStart { get; set; }
    public long? NumericRangeEnd { get; set; }
    public int? ValidForHours { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool WaiveSetupFee { get; set; }
    public int? DiscountId { get; set; }
    public bool? IsTrial { get; set; }
    public string? DiscountName { get; set; }
    public decimal DiscountValue { get; set; }
    public string? DiscountModificationTypeName { get; set; }
    public int? DiscountModificationTypeId { get; set; }
    public int? TrialDays { get; set; }
    public int? ReminderInterval { get; set; }
    public string? ValidAgeList { get; set; }
    public string? ValidCountryList { get; set; }
    public int? WaitingPeriodForAccident { get; set; }
    public int? WaitingPeriodForIllness { get; set; }
    public string? LandingPageName { get; set; }
    public bool? WebPartnerActive { get; set; }
    public int? DiscountTypeId { get; set; }
    public string? SalesForceId { get; set; }
}
