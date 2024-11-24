namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentRequestSecondaryHospital
{
    public Guid Id { get; set; }
    public Guid EnrollmentRequestPetId { get; set; }
    public int? HospitalId { get; set; }
    public Guid? HospitalUniqueId { get; set; }
    public string? Name { get; set; }

    public virtual QuoteDboEnrollmentRequestPet? EnrollmentRequestPet { get; set; }
}
