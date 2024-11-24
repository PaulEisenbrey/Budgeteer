namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboStatusGroup
{
    public int Id { get; set; }
    public int StatusId { get; set; }
    public int GroupId { get; set; }

    public virtual TruDatDboStatus? Group { get; set; }
    public virtual TruDatDboStatus? Status { get; set; }
}
