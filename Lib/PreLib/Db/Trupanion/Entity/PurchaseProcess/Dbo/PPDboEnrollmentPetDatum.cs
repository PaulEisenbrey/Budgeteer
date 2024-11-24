namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboEnrollmentPetDatum
{
    public int Id { get; set; }
    public int EnrollmentDataId { get; set; }
    public int? QuotePetId { get; set; }
    public int? LeadPetId { get; set; }
    public int? PetPolicyId { get; set; }
    public string? HospitalName { get; set; }
    public string? HospitalPostalCode { get; set; }
    public string? HospitalPhone { get; set; }
    public DateTime? LastExameDate { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? Premium { get; set; }
    public string? Name { get; set; }
    public int? AgeId { get; set; }
    public int? BreedId { get; set; }
    public string? Gender { get; set; }
    public bool? IsSpayedNeutered { get; set; }
    public int? HospitalId { get; set; }
    public string? CampaignCode { get; set; }
    public string? CampaignCodeReferenceNumber { get; set; }
    public string? CampaignInstanceSecurityKey { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public string? ExternalPetSubscriptionId { get; set; }
    public DateTime? AdoptionDate { get; set; }
    public int? PolicyId { get; set; }

    public virtual PPDboEnrollmentDatum? EnrollmentData { get; set; }
    public virtual List<PPDboSelectedPolicyOption> SelectedPolicyOptions { get; set; } = new();
    public virtual List<PPDboSelectedWorkingPet> SelectedWorkingPets { get; set; } = new();
}
