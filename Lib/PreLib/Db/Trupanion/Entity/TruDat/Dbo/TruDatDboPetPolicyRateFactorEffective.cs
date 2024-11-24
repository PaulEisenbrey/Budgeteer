namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyRateFactorEffective
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public int SpecieId { get; set; }
    public int BreedId { get; set; }
    public int PolicyAgeId { get; set; }
    public int? WorkingPetId { get; set; }
    public int? PetFoodId { get; set; }
    public string? Zipcode { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? Premium { get; set; }
    public string? CampaignCode { get; set; }
    public int CountryId { get; set; }
    public int PolicyId { get; set; }
    public string? SelectedPolicyOptions { get; set; }
    public int? EngineVersionId { get; set; }
    public bool PremiumFrozen { get; set; }
    public DateTime Inerted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboBreed? Breed { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboCountry? Country { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
    public virtual TruDatDboPetFood? PetFood { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
    public virtual TruDatDboPolicy? Policy { get; set; }
    public virtual TruDatDboAge? PolicyAge { get; set; }
    public virtual TruDatDboAnimal? Specie { get; set; }
    public virtual TruDatDboWorkingPet? WorkingPet { get; set; }
}
