namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboKnoticeDatum
{
    public int Id { get; set; }
    public string? EmailAddress { get; set; }
    public string? PolicyNumber { get; set; }
    public string? ActivePets { get; set; }
    public string? InactivePets { get; set; }
    public string? NewEmail { get; set; }
    public bool? NotInTruDat { get; set; }
    public bool? NewToKnotice { get; set; }
}
