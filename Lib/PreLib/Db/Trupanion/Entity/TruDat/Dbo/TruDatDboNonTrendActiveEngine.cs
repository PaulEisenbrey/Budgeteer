namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboNonTrendActiveEngine
{
    public int Id { get; set; }
    public int EngineId { get; set; }
    public string? Name { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime? RetireDate { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? DeductibleFormulaCase { get; set; }
    public int StateId { get; set; }
}
