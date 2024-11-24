namespace Database.Trupanion.Entity.Workflow;

public class WFDboVersionedDatum
{
    public int Id { get; set; }
    public string TableName { get; set; } = "";
    public long MaxVersionId { get; set; }
}
