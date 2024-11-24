namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTrialPolicy
{
    public string? PolicyNumber { get; set; }
    public int OwnerId { get; set; }
    public string? OwnerFirstName { get; set; }
    public string? OwnerLastName { get; set; }
    public string? EmailAddress { get; set; }
    public int StateId { get; set; }
    public string? HomePhone { get; set; }
    public string? PetName { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime PolicyDate { get; set; }
    public int PolicyId { get; set; }
    public string? PetPolicyNumber { get; set; }
    public string? BreedName { get; set; }
    public int TrialDays { get; set; }
    public string? PromoCode { get; set; }
    public string? Description { get; set; }
    public int ReminderInterval { get; set; }
    public DateTime? DateReminderSent { get; set; }
    public int ReminderSentCount { get; set; }
    public int? RemainingTrialDays { get; set; }
    public int PetId { get; set; }
}
