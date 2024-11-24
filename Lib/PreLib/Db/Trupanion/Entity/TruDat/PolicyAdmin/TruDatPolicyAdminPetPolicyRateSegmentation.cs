namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPetPolicyRateSegmentation
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid PetPolicyId { get; set; }
    public string? PolicyNumber { get; set; }
    public string? FullName { get; set; }
    public string? PetName { get; set; }
    public string? Breed { get; set; }
    public string? AgeAtEnrollment { get; set; }
    public int LegacyPetId { get; set; }
    public int LegacyPetPolicyId { get; set; }
    public string? EmailAddress { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public decimal NewRate { get; set; }
    public decimal OldRate { get; set; }
    public decimal PercentChangeInRate { get; set; }
    public DateTime EffectiveDate { get; set; }
    public string? State { get; set; }
    public string? City { get; set; }
    public string? CurrentPolicyVersion { get; set; }
    public string? NewPolicyVersion { get; set; }
    public DateTime NotificationDate { get; set; }
    public decimal? LastYearsRateChange { get; set; }
    public decimal? LoyaltySavings { get; set; }
    public Guid? ProductId { get; set; }
    public decimal? LastYearsRateBefore { get; set; }
    public decimal? LastYearsRateAfter { get; set; }
}
