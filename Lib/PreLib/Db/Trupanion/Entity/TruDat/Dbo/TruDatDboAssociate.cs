namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociate
{
    public int Id { get; set; }
    public int? ParentAssociateId { get; set; }
    public string? CompanyName { get; set; }
    public int? UserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? Active { get; set; }
    public int? ChangeUserId { get; set; }
    public int? ServiceCategoryId { get; set; }
    public string? ExternalId { get; set; }
    public Guid UniqueId { get; set; }
    public string? DefaultCampaignCode { get; set; }

    public virtual TruDatDboAssociate? ParentAssociate { get; set; }
    public virtual TruDatDboEntityList? ServiceCategory { get; set; }
    public virtual List<TruDatDboAssociateBranchMap> AssociateBranchMapChildren { get; set; } = new();
    public virtual List<TruDatDboAssociateBranchMap> AssociateBranchMapParents { get; set; } = new();
    public virtual List<TruDatDboAssociateDatum> AssociateData { get; set; } = new();
    public virtual List<TruDatDboAssociateGroupAssociate> AssociateGroupAssociates { get; set; } = new();
    public virtual List<TruDatDboAssociatePolicy> AssociatePolicies { get; set; } = new();
    public virtual List<TruDatDboAssociateSecurable> AssociateSecurables { get; set; } = new();
    public virtual List<TruDatDboAssociateWebsiteDatum> AssociateWebsiteData { get; set; } = new();
    public virtual List<TruDatDboEntityListAssociate> EntityListAssociates { get; set; } = new();
    public virtual List<TruDatDboAssociate> InverseParentAssociate { get; set; } = new();
}
