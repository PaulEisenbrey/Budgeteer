namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPet
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int BreedId { get; set; }
    public string? Name { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string Gender { get; set; } = "";
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? SalesForceId { get; set; }
    public int? ChangeUserId { get; set; }
    public int? WorkingPetId { get; set; }
    public int? PetFoodId { get; set; }
    public int? SoapLevelId { get; set; }
    public int? PawPrintStatusId { get; set; }
    public bool? Pilot { get; set; }
    public bool? ParentClaimsValidated { get; set; }
    public int? LastPawPrintDocumentId { get; set; }
    public bool? WaitingPeriodReviewed { get; set; }
    public int? SoapStatusId { get; set; }
    public int? PawPrintHistoryId { get; set; }
    public DateTime? Edcdate { get; set; }
    public DateTime? StatusChangeDate { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatDboBreed? Breed { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
    public virtual TruDatDboStatus? PawPrintHistory { get; set; }
    public virtual TruDatDboPetFood? PetFood { get; set; }
    public virtual TruDatDboStatus? SoapStatus { get; set; }
    public virtual TruDatDboWorkingPet? WorkingPet { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
    public virtual List<TruDatDboPetAttribute> PetAttributes { get; set; } = new();
}
