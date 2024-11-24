namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyWebPartner
{
    public int PetPolicyId { get; set; }
    public int WebPartnerId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}
