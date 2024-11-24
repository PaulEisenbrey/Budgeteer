namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboStatus
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? Name { get; set; }
    public bool Restricted { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid UniqueId { get; set; }

    public virtual TruDatDboStatus? Parent { get; set; }
    public virtual List<TruDatDboBankCheck> BankChecks { get; set; } = new();
    public virtual List<TruDatDboClaimBatchLetter> ClaimBatchLetters { get; set; } = new();
    public virtual List<TruDatDboClaimStatusLetter> ClaimStatusLetters { get; set; } = new();
    public virtual List<TruDatDboClaimWorkflowViewStatus> ClaimWorkflowViewStatuses { get; set; } = new();
    public virtual List<TruDatDboClaim> Claims { get; set; } = new();
    public virtual List<TruDatDboStatus> InverseParent { get; set; } = new();
    public virtual List<TruDatDboPet> PetPawPrintHistories { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAction> PetPolicyActions { get; set; } = new();
    public virtual List<TruDatDboPet> PetSoapStatuses { get; set; } = new();
    public virtual List<TruDatDboStatusGroup> StatusGroupGroups { get; set; } = new();
    public virtual List<TruDatDboStatusGroup> StatusGroupStatuses { get; set; } = new();
    public virtual List<TruDatDboWorkflowCaseConfig> WorkflowCaseConfigs { get; set; } = new();
    public virtual List<TruDatDboWorkflowCase> WorkflowCases { get; set; } = new();
}
