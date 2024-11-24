namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyVersion
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public string? Name { get; set; }
    public DateTime DateEffective { get; set; }
    public string? PolicyPath { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual TruDatCoveragePolicy? Policy { get; set; }
    public virtual List<TruDatCoverageGroupPolicyVersionState> GroupPolicyVersionStates { get; set; } = new();
    public virtual List<TruDatCoveragePolicyDocumentInventory> PolicyDocumentInventories { get; set; } = new();
    public virtual List<TruDatCoveragePolicyVersionCoverageItem> PolicyVersionCoverageItems { get; set; } = new();
    public virtual List<TruDatCoveragePolicyVersionCoveragePackage> PolicyVersionCoveragePackages { get; set; } = new();
    public virtual List<TruDatCoveragePolicyVersionState> PolicyVersionStates { get; set; } = new();
    public virtual List<TruDatCoveragePolicyVersionWorkingPet> PolicyVersionWorkingPets { get; set; } = new();
}
