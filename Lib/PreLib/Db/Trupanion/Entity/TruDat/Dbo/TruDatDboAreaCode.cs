namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAreaCode
{
    public int Id { get; set; }
    public string? AreaCode1 { get; set; }
    public int StateId { get; set; }

    public virtual TruDatDboState? State { get; set; }
}
