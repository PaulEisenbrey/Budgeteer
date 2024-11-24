namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociatePolicy
{
    public int Id { get; set; }
    public int AssociateId { get; set; }
    public int PolicyId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboAssociate? Associate { get; set; }
    public virtual TruDatDboPolicy? Policy { get; set; }
}
