namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityTree
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? CategoryId { get; set; }
    public string? ListValue { get; set; }
    public string? ListDescription { get; set; }
    public int SortValue { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboEntityCategory? Category { get; set; }
    public virtual TruDatDboEntityTree? Parent { get; set; }
    public virtual List<TruDatDboAssociateDatum> AssociateData { get; set; } = new();
    public virtual List<TruDatDboEntityTreeAttribute> EntityTreeAttributes { get; set; } = new();
    public virtual List<TruDatDboEntityTreeBranchMap> EntityTreeBranchMapChildren { get; set; } = new();
    public virtual List<TruDatDboEntityTreeBranchMap> EntityTreeBranchMapParents { get; set; } = new();
    public virtual List<TruDatDboEntityTree> InverseParent { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateAdjustment> PetPolicyRateAdjustments { get; set; } = new();
    public virtual List<TruDatDboWorkflowCaseAction> WorkflowCaseActions { get; set; } = new();
    public virtual List<TruDatDboWorkflowCase> WorkflowCases { get; set; } = new();
    public virtual List<TruDatDboWorkflowQueue> WorkflowQueues { get; set; } = new();
}
