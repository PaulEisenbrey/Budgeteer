namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboAttachmentDisposition> AttachmentDispositions { get; set; } = new();
    public virtual List<TruDatDboAttachmentEmailReference> AttachmentEmailReferences { get; set; } = new();
    public virtual List<TruDatDboEntityAddress> EntityAddresses { get; set; } = new();
    public virtual List<TruDatDboEntityBankAccount> EntityBankAccounts { get; set; } = new();
    public virtual List<TruDatDboEntityContact> EntityContacts { get; set; } = new();
    public virtual List<TruDatDboEntityList> EntityLists { get; set; } = new();
    public virtual List<TruDatDboEntityNote> EntityNotes { get; set; } = new();
    public virtual List<TruDatDboEntityReview> EntityReviews { get; set; } = new();
    public virtual List<TruDatDboEntityScore> EntityScores { get; set; } = new();
    public virtual List<TruDatDboOwnerAssociation> OwnerAssociations { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAssociation> PetPolicyAssociations { get; set; } = new();
    public virtual List<TruDatDboSecurableEntityRelation> SecurableEntityRelations { get; set; } = new();
    public virtual List<TruDatDboWorkflowCase> WorkflowCases { get; set; } = new();
}
