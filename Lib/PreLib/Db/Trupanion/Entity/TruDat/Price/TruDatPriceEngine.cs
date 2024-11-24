namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceEngine
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? PolicyPrefix { get; set; }
    public int PolicySeed { get; set; }
    public int PolicyNumberLength { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatPriceAgeFactor> AgeFactors { get; set; } = new();
    public virtual List<TruDatPriceEngineVersion> EngineVersions { get; set; } = new();
    public virtual List<TruDatPriceHospitalFactor> HospitalFactors { get; set; } = new();
    public virtual List<TruDatPriceRateValue> RateValues { get; set; } = new();
    public virtual List<TruDatPriceZipcodeFactor> ZipcodeFactors { get; set; } = new();
}
