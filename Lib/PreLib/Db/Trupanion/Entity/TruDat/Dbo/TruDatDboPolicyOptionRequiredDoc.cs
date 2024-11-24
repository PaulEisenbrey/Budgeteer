namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyOptionRequiredDoc
{
    public int Id { get; set; }
    public int PolicyOptionTypeId { get; set; }
    public int PolicyDocTypeId { get; set; }

    public virtual TruDatDboPolicyDocType? PolicyDocType { get; set; }
    public virtual TruDatDboPolicyOptionType? PolicyOptionType { get; set; }
}
