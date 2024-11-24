namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyText
{
    public int Id { get; set; }
    public DateTime PolicyDate { get; set; }
    public string? TagNumber { get; set; }
    public string? PetPolicyNumber { get; set; }
    public DateTime? PolicyPaidThru { get; set; }
    public string? PolicyName { get; set; }
    public int PetId { get; set; }
    public string? PetName { get; set; }
    public int BreedId { get; set; }
    public string? BreedName { get; set; }
    public int AnimalId { get; set; }
    public string? AnimalType { get; set; }
    public int OwnerId { get; set; }
    public string? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? SalesForceId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
