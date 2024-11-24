namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyAttribute
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public string? Attribute { get; set; }
    public string? Value { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}
