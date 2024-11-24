namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCost
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboPetPolicyCost> PetPolicyCosts { get; set; } = new();
    public virtual List<TruDatDboPolicyOptionType> PolicyOptionTypes { get; set; } = new();
}
