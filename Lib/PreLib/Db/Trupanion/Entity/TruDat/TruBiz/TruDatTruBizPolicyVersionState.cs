namespace Database.Trupanion.Entity.TruDat.TruBiz;

public class TruDatTruBizPolicyVersionState
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public int StateId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
}
