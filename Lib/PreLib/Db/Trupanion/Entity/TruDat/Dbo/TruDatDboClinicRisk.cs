namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClinicRisk
{
    public int Id { get; set; }
    public int RiskLevel { get; set; }
    public string? Name { get; set; }
    public int LowDeductible { get; set; }
    public int HighDeductible { get; set; }

    public virtual List<TruDatDboClinic> Clinics { get; set; } = new();
}
