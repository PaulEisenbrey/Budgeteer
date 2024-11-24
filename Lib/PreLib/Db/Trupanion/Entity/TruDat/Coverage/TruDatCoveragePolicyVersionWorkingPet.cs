namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyVersionWorkingPet
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public int WorkingPetId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public int? NewWorkingPetId { get; set; }
    public bool? DecPageVisible { get; set; }

    public virtual TruDatCoveragePolicyVersion? PolicyVersion { get; set; }
}
