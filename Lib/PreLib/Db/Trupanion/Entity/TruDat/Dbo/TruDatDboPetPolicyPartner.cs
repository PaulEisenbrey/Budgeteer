namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyPartner
{
    public int PetPolicyId { get; set; }
    public int PartnerId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboPartner? Partner { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}
