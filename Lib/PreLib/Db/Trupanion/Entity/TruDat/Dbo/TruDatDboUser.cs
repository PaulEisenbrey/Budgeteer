namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUser
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int RoleId { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? SalesForceId { get; set; }
    public Guid ExternalId { get; set; }

    public virtual TruDatDboRole? Role { get; set; }
    public virtual TruDatDboActiveDirectoryUser? ActiveDirectoryUser { get; set; }
    public virtual TruDatDboClaimsAdjuster? ClaimsAdjuster { get; set; }
    public virtual List<TruDatDboAssociateDatum> AssociateData { get; set; } = new();
    public virtual List<TruDatDboAssociateGroupAssociate> AssociateGroupAssociates { get; set; } = new();
    public virtual List<TruDatDboAssociateGroupSecurable> AssociateGroupSecurables { get; set; } = new();
    public virtual List<TruDatDboAssociateGroup> AssociateGroups { get; set; } = new();
    public virtual List<TruDatDboAssociateSecurable> AssociateSecurables { get; set; } = new();
    public virtual List<TruDatDboAttachmentDisposition> AttachmentDispositionAssignedUsers { get; set; } = new();
    public virtual List<TruDatDboAttachmentDisposition> AttachmentDispositionUsers { get; set; } = new();
    public virtual List<TruDatDboAttachmentEmailReference> AttachmentEmailReferences { get; set; } = new();
    public virtual List<TruDatDboBankCheck> BankCheckCancelledByUsers { get; set; } = new();
    public virtual List<TruDatDboBankCheck> BankCheckIssuedByUsers { get; set; } = new();
    public virtual List<TruDatDboBankCheck> BankCheckRequestedByUsers { get; set; } = new();
    public virtual List<TruDatDboBreedShadow> BreedShadows { get; set; } = new();
    public virtual List<TruDatDboClaim> ClaimAssignedToUsers { get; set; } = new();
    public virtual List<TruDatDboClaimBatchLetter> ClaimBatchLetters { get; set; } = new();
    public virtual List<TruDatDboClaim> ClaimCreateUsers { get; set; } = new();
    public virtual List<TruDatDboClaimDisposition> ClaimDispositionAssignedUsers { get; set; } = new();
    public virtual List<TruDatDboClaimDisposition> ClaimDispositionUsers { get; set; } = new();
    public virtual List<TruDatDboClaimPrintHistory> ClaimPrintHistories { get; set; } = new();
    public virtual List<TruDatDboClaimProcess> ClaimProcesses { get; set; } = new();
    public virtual List<TruDatDboClaimStatusLetter> ClaimStatusLetters { get; set; } = new();
    public virtual List<TruDatDboEntityReview> EntityReviews { get; set; } = new();
    public virtual List<TruDatDboEntityTreeAttribute> EntityTreeAttributes { get; set; } = new();
    public virtual List<TruDatDboOwnerAssociation> OwnerAssociations { get; set; } = new();
    public virtual List<TruDatDboOwnerAttribute> OwnerAttributes { get; set; } = new();
    public virtual List<TruDatDboOwnerCharityEffective> OwnerCharityEffectives { get; set; } = new();
    public virtual List<TruDatDboOwnerLanguagePreference> OwnerLanguagePreferences { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAction> PetPolicyActions { get; set; } = new();
    public virtual List<TruDatDboPetPolicyAssociation> PetPolicyAssociations { get; set; } = new();
    public virtual List<TruDatDboPetPolicyPartner> PetPolicyPartners { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboSecurableEntityRelation> SecurableEntityRelations { get; set; } = new();
    public virtual List<TruDatDboSecurable> Securables { get; set; } = new();
    public virtual List<TruDatDboSession> Sessions { get; set; } = new();
    public virtual List<TruDatDboShadowAnimalImage> ShadowAnimalImages { get; set; } = new();
    public virtual List<TruDatDboState> States { get; set; } = new();
    public virtual List<TruDatDboTask> TaskCancelledByUsers { get; set; } = new();
    public virtual List<TruDatDboTask> TaskUsers { get; set; } = new();
    public virtual List<TruDatDboUserSecurable> UserSecurables { get; set; } = new();
    public virtual List<TruDatDboUsersGroup> UsersGroups { get; set; } = new();
    public virtual List<TruDatDboWorkflowGroupUser> WorkflowGroupUsers { get; set; } = new();
    public virtual List<TruDatDboWorkflowQueueUser> WorkflowQueueUsers { get; set; } = new();
}
