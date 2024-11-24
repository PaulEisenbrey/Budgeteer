namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityNoteOrigin
{
    public int Id { get; set; }
    public int EntityNoteId { get; set; }
    public int PlatformId { get; set; }
    public DateTime CreatedOn { get; set; }

    public virtual TruDatDboEntityNote? EntityNote { get; set; }
}
