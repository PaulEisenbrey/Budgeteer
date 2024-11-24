namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyOption
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public int PolicyOptionId { get; set; }
    public double FixedCost { get; set; }
    public bool IsFree { get; set; }
    public bool IsOptional { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPolicy? Policy { get; set; }
    public virtual TruDatDboPolicyOptionType? PolicyOptionNavigation { get; set; }
}
