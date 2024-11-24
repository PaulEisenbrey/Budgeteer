namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboGuruError
{
    public int Id { get; set; }
    public int ErrorType { get; set; }
    public string? GuruNumber { get; set; }
    public string? Xml { get; set; }
    public bool Handled { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
