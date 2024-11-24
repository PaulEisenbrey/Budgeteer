namespace Database.Trupanion.Entity.TruDat.GroupPrice;

public class TruDatGroupPricePolicyVersionImplementationWorkingPet
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int PolicyVersionImplementationId { get; set; }
    public int WorkingPetId { get; set; }

    public virtual TruDatGroupPricePolicyVersionImplementation? PolicyVersionImplementation { get; set; }
}
