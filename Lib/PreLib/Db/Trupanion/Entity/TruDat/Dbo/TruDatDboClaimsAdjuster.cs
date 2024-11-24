namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimsAdjuster
{
    public int UserId { get; set; }
    public bool? AllowAutoAssign { get; set; }
    public bool AutoEmailClaimHideUser { get; set; }
    public bool ClaimsExpressNotification { get; set; }
    public bool WaitingPeriodDenial { get; set; }
    public bool? Active { get; set; }
    public bool GreyhoundCriticalNotification { get; set; }
    public DateTime? AssignmentStamp { get; set; }

    public virtual TruDatDboUser? User { get; set; }
}
