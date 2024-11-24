namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyTagNumber
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public string? TagNumber { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}
