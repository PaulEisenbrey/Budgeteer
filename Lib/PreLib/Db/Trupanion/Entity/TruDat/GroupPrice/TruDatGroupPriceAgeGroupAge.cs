namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPriceAgeGroupAge
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int AgeGroupId { get; set; }
    public int AgeId { get; set; }

    public virtual TruDatGroupPriceAgeGroup? AgeGroup { get; set; }
}
