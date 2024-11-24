using Database.Trupanion.Entity.TruDat.Dbo;
using Database.Trupanion.Entity.VisionMigration.Dbo;

namespace Database.Trupanion.Entity.Aggregates;

public class SegmentAndOwnerIds
{
    public SegmentAndOwnerIds(VmDboSegmentOwner sowner, TruDatDboOwner? owner)
    {
        this.segmentOwner = sowner;
        this.PersonId = owner?.PersonId ?? Guid.Empty;
        this.OwnerName = $"{owner?.FirstName} {owner?.LastName}";
        this.ClaimPaymentMethodId = owner?.ClaimPaymentMethodId;
        this.CorporateAccountId = owner?.CorporateAccountId;
    }

    public int? ClaimPaymentMethodId { get; private set; }

    public int? CorporateAccountId { get; private set; }

    public VmDboSegmentOwner? segmentOwner { get; private set; }

    public Guid? PersonId { get; private set; }

    public int? CustomerId { get; private set; } = null;

    public SegmentAndOwnerIds SetCustomerId(int customerId)
    {
        this.CustomerId = customerId;
        return this;
    }

    public int Id
    {
        get
        {
            _ = this.segmentOwner ?? throw new ArgumentNullException(nameof(this.segmentOwner));

            return this.segmentOwner.OwnerId;
        }
    }

    public string OwnerName { get; private set; }
}
