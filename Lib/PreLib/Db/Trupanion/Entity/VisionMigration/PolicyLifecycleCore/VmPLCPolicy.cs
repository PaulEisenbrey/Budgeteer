namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPolicy
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int PolicyStatusId { get; set; }
    public DateTime InceptionDate { get; set; }
    public DateTime? TermsDate { get; set; }
    public int Type { get; set; }
    public string? Code { get; set; }
    public int PetId { get; set; }
    public int CustomerId { get; set; }
    public int? VoucherId { get; set; }

    public virtual List<VmPLCPolicyTerm> PolicyTerms { get; set; } = new();
}
