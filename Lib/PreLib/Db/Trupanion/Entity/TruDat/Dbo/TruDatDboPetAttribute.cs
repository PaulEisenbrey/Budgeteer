namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetAttribute
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public string? Attribute { get; set; }
    public string? Value { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboPet? Pet { get; set; }
}
