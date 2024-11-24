namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPartnerSignup
{
    public int PartnerId { get; set; }
    public DateTime SignupDate { get; set; }
    public string? Manager { get; set; }
    public DateTime? GoalStartDate { get; set; }
    public DateTime? TermDate { get; set; }
    public decimal? NewEnrollmentCommission { get; set; }
    public decimal? RecurringEnrollmentCommission { get; set; }
    public bool? EmailCommissions { get; set; }
    public decimal? BasePay { get; set; }
    public string? AdpId { get; set; }
}
