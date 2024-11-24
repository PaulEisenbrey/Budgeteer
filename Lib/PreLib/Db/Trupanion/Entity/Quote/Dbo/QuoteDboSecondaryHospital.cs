namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboSecondaryHospital
{
    public int Id { get; set; }
    public int? QuotePetId { get; set; }
    public Guid? EnrollmentRequestPetId { get; set; }
    public int? HospitalId { get; set; }
    public Guid? HospitalUniqueId { get; set; }
    public string? Name { get; set; }

    public virtual QuoteDboEnrollmentRequestPet? EnrollmentRequestPet { get; set; }
    public virtual QuoteDboQuotePet? QuotePet { get; set; }
}
