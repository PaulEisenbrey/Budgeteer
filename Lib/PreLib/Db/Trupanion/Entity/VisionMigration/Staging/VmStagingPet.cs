namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPet
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string? Name { get; set; }
    public byte[]? Photo { get; set; }
    public string? MicrochipNumber { get; set; }
    public int MicrohipStatus { get; set; }
    public bool? Neutered { get; set; }
    public int Gender { get; set; }
    public decimal? PurchasePrice { get; set; }
    public int? ColorId { get; set; }
    public int BreedId { get; set; }
    public bool? PreExistingConditions { get; set; }
    public DateTime? BirthDate { get; set; }
    public DateTime? DateOfDeath { get; set; }
    public int? UnderwriterStatusId { get; set; }
    public int PetExtId { get; set; }
    public Guid PetExtRef { get; set; }
    public DateTime? PurchaseAdoptionDate { get; set; }
    public Guid Ref { get; set; }
    public DateTime? ModifiedDateTime { get; set; }
    public bool? HasPreEnrollmentDentalExam { get; set; }
    public int? CareFlag { get; set; }
    public Guid ExtRef { get; set; }
    public Guid BatchId { get; set; }
}
