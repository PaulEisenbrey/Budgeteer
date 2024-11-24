namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCharityState
{
    public int CharityId { get; set; }
    public int StateId { get; set; }

    public virtual TruDatDboCharity? Charity { get; set; }
    public virtual TruDatDboState? State { get; set; }
}
