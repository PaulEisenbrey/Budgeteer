namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowGroupUser
{
    public int GroupId { get; set; }
    public int UserId { get; set; }

    public virtual TruDatDboWorkflowGroup? Group { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
