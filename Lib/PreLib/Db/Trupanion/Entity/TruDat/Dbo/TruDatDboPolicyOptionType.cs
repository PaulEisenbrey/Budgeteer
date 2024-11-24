namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyOptionType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? CostId { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? RateId { get; set; }
    public string? PolicyDocumentHref { get; set; }
    public int? Sequence { get; set; }
    public string? DisplayName { get; set; }

    public virtual TruDatDboCost? Cost { get; set; }
    public virtual List<TruDatDboPolicyOptionRequiredDoc> PolicyOptionRequiredDocs { get; set; } = new();
    public virtual List<TruDatDboPolicyOptionState> PolicyOptionStates { get; set; } = new();
    public virtual List<TruDatDboPolicyOption> PolicyOptions { get; set; } = new();
}
