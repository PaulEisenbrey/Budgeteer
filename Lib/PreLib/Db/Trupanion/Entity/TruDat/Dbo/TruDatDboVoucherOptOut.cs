namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboVoucherOptOut
{
    public int? PetId { get; set; }
    public int Id { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPet? Pet { get; set; }
}
