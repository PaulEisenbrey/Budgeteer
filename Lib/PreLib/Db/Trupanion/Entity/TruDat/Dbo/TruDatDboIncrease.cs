namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboIncrease
{
    public string? PolicyNumber { get; set; }
    public string? PetName { get; set; }
    public string? DateForNewPremium { get; set; }
    public double? CurrentRate { get; set; }
    public double? NewRate { get; set; }
    public double? NewRateDiscount { get; set; }
    public int? PetPolicyId { get; set; }
    public int? OwnerId { get; set; }
    public string? PostalCode { get; set; }
    public decimal? Deductible { get; set; }
    public decimal? Age { get; set; }
    public decimal? Breed { get; set; }
    public decimal? Postal { get; set; }
    public bool? IsHip { get; set; }
    public decimal? SystemRate { get; set; }
    public decimal? SystemDeductible { get; set; }
    public decimal? SystemHip { get; set; }
    public bool? Correct { get; set; }
    public bool? DoubleDiscount { get; set; }
    public bool? NoIncrease { get; set; }
    public bool NoPet { get; set; }
    public bool DeductibleDiffers { get; set; }
    public bool AgeFactorDiffers { get; set; }
    public bool BreedFactorDiffers { get; set; }
    public bool ZipFactorsDiffer { get; set; }
}
