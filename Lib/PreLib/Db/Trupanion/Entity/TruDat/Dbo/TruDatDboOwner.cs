namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwner
{
    public int Id { get; set; }
    public int? CorporateAccountId { get; set; }
    public string PolicyNumber { get; set; } = "";
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? HomePhone { get; set; }
    public string? CellPhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? WorkExtension { get; set; }
    public string? FaxNumber { get; set; }
    public int? DefaultPaymentMethod { get; set; }
    public int EngineId { get; set; }
    public int? BillingDayOfMonth { get; set; }
    public DateTime? BillingPastDue { get; set; }
    public DateTime? PolicyHolderUntil { get; set; }
    public int? UserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? SalesForceId { get; set; }
    public string? SecondaryEmailAddress { get; set; }
    public int? ChangeUserId { get; set; }
    public int? SiteVisitorId { get; set; }
    public int? SiteVisitorSessionId { get; set; }
    public int? ClaimPaymentMethodId { get; set; }
    public DateTime? PaymentFailedDate { get; set; }
    public int? CommunicationPreferenceId { get; set; }
    public decimal? BillingPastDueAmount { get; set; }
    public bool IsStateFarmRelated { get; set; }
    public Guid UniqueId { get; set; }
    public bool AdministrationFeePaid { get; set; }
    public Guid PersonId { get; set; }
    public byte[]? ConcurrencyToken { get; set; }

    public virtual TruDatDboCommunicationPreference? CommunicationPreference { get; set; }
    public virtual TruDatDboCorporateAccount? CorporateAccount { get; set; }
    public virtual TruDatDboOwnerCharity? OwnerCharity { get; set; }
    public virtual TruDatDboOwnerFailedPaymentDatum? OwnerFailedPaymentDatum { get; set; }
    public virtual TruDatDboOwnerLanguagePreference? OwnerLanguagePreference { get; set; }
    public virtual TruDatDboOwnerPendingRateChange? OwnerPendingRateChange { get; set; }
    public virtual TruDatDboOwnerVisionClaimSyncStatus? OwnerVisionClaimSyncStatus { get; set; }
    public virtual TruDatDboOwnerVisionPolicyMigrationStatus? OwnerVisionPolicyMigrationStatus { get; set; }
    public virtual List<TruDatDboOwnerAddress> OwnerAddresses { get; set; } = new();
    public virtual List<TruDatDboOwnerAssociation> OwnerAssociations { get; set; } = new();
    public virtual List<TruDatDboOwnerAttribute> OwnerAttributes { get; set; } = new();
    public virtual List<TruDatDboOwnerCharityEffective> OwnerCharityEffectives { get; set; } = new();
    public virtual List<TruDatDboOwnerCorporateAccountHistory> OwnerCorporateAccountHistories { get; set; } = new();
    public virtual List<TruDatDboOwnerVisionClaimMigrationStatus> OwnerVisionClaimMigrationStatuses { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboPet> Pets { get; set; } = new();

    public override string ToString() => $"Owner [{this.Id} - {this.PolicyNumber}] {this.FirstName} {this.LastName}";
}
