namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPet
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int BreedId { get; set; }
    public string Name { get; set; } = "";
    public DateTime? DateOfBirth { get; set; }
    public string Gender { get; set; } = "";
    public int? WorkingPetId { get; set; }
    public int? PetFoodId { get; set; }
    public int? SoapLevelId { get; set; }
    public int? PawPrintStatusId { get; set; }
    public bool? Pilot { get; set; }
    public bool ParentClaimsValidated { get; set; }
    public int? LastPawPrintDocumentId { get; set; }
    public bool? WaitingPeriodReviewed { get; set; }
    public int? SoapStatusId { get; set; }
    public int? PawPrintHistoryId { get; set; }
    public DateTime? Edcdate { get; set; }
    public DateTime? StatusChangeDate { get; set; }
    public DateTime? AdoptionDate { get; set; }
    public bool PreX { get; set; }
    public bool SpayedNeutered { get; set; }
    public DateTime? SpayedNeuteredDate { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid ModifiedBy { get; set; }
    public bool? IntendToSpayNeuter { get; set; }
    public bool? IsSpayedNeuteredExists { get; set; }
    public bool? IsSpayedNeutered { get; set; }
    public int? PetPolicyId { get; set; }
    public Guid UniqueId { get; set; }
}
