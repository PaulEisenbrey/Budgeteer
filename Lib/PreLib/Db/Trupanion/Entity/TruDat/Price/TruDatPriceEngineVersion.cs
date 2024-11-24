namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceEngineVersion
{
    public int Id { get; set; }
    public int EngineId { get; set; }
    public string? Name { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? RetireDate { get; set; }
    public int? DeductibleFormulaCase { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatPriceEngine? Engine { get; set; }
    public virtual List<TruDatPriceAgeFactor> AgeFactors { get; set; } = new();
    public virtual List<TruDatPriceBreedFactorNoHd> BreedFactorNoHds { get; set; } = new();
    public virtual List<TruDatPriceBreedFactor> BreedFactors { get; set; } = new();
    public virtual List<TruDatPriceEngineVersionState> EngineVersionStates { get; set; } = new();
    public virtual List<TruDatPriceFoodFactor> FoodFactors { get; set; } = new();
    public virtual List<TruDatPriceHospitalFactor> HospitalFactors { get; set; } = new();
    public virtual List<TruDatPriceRateValue> RateValues { get; set; } = new();
    public virtual List<WorkingPetFactor> WorkingPetFactors { get; set; } = new();
    public virtual List<TruDatPriceZipcodeFactor> ZipcodeFactors { get; set; } = new();
}
