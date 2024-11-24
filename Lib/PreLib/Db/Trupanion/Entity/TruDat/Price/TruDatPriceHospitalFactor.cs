namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceHospitalFactor
{
    public int Id { get; set; }
    public int Engineid { get; set; }
    public int Versionid { get; set; }
    public int ClinicId { get; set; }
    public double Factor { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatPriceEngine? Engine { get; set; }
    public virtual TruDatPriceEngineVersion? Version { get; set; }
}
