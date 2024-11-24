using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboOwnerProjection : EntityIntId
{
    public string PolicyNumber { get; set; } = "";
                 
    public string? FirstName { get; set; }
                 
    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }
                 
    public string? HomePhone { get; set; }

    public int? UserId { get; set; }

    public int? EngineId { get; set; }

    public int? BillingDayOfMonth { get; set; }

    public DateTime? PolicyHolderUntil { get; set; }

    public DateTime? Inserted { get; set; }

    public DateTime? Updated { get; set; }

    public bool IsStateFarmRelated { get; set; }

    public Guid UniqueId { get; set; }

    public Guid PersonId { get; set; }
}