namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyOptionState
{
    public int Id { get; set; }
    public int? PolicyOptionId { get; set; }
    public int? StateId { get; set; }
    public DateTime? Inserted { get; set; }

    public virtual TruDatDboPolicyOptionType? PolicyOption { get; set; }
    public virtual TruDatDboState? State { get; set; }
}
