namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityListAssociate
{
    public int EntityListId { get; set; }
    public int AssociateId { get; set; }

    public virtual TruDatDboAssociate? Associate { get; set; }
    public virtual TruDatDboEntityList? EntityList { get; set; }
}
