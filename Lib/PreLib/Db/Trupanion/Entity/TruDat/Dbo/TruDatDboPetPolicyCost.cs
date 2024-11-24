namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyCost
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int CostId { get; set; }
    public decimal Cost { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public DateTime? Effective { get; set; }

    public virtual TruDatDboCost? CostNavigation { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}
