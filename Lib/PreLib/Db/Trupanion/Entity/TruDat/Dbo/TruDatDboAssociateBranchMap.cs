namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateBranchMap
{
    public int ParentId { get; set; }
    public int ChildId { get; set; }

    public virtual TruDatDboAssociate? Child { get; set; }
    public virtual TruDatDboAssociate? Parent { get; set; }
}
