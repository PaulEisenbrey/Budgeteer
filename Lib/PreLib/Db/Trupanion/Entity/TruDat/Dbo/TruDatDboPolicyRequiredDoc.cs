namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyRequiredDoc
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public int PolicyDocTypeId { get; set; }

    public virtual TruDatDboPolicy? Policy { get; set; }
    public virtual TruDatDboPolicyDocType? PolicyDocType { get; set; }
}
