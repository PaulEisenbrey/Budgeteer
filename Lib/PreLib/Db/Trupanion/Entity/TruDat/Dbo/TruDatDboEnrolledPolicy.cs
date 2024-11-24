namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEnrolledPolicy
{
    public string? PolicyNumber { get; set; }
    public int OwnerId { get; set; }
    public int PetId { get; set; }
    public string? OwnerFirstName { get; set; }
    public string? OwnerLastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? HomePhone { get; set; }
    public string? PetName { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime PolicyDate { get; set; }
    public int PolicyId { get; set; }
    public string? PetPolicyNumber { get; set; }
    public string? BreedName { get; set; }
    public int? RemainingTrialDays { get; set; }
}
