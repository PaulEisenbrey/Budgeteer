namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityTreeBranchMap
{
    public int ParentId { get; set; }
    public int ChildId { get; set; }

    public virtual TruDatDboEntityTree? Child { get; set; }
    public virtual TruDatDboEntityTree? Parent { get; set; }
}
