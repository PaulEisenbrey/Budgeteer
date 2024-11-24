namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyState
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public int StateId { get; set; }
    public DateTime DateEffective { get; set; }
    public DateTime? DateEffectiveEnd { get; set; }

    public virtual TruDatDboPolicyVersion? Policy { get; set; }
    public virtual TruDatDboState? State { get; set; }
}
