namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimConditionDataPreferred
{
    public Int64 ConceptId { get; set; }

    public int InternalPreferredId { get; set; }

    public int CustomerPreferredId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

}
