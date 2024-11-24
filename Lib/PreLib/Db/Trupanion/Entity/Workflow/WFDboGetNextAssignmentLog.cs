namespace Database.Trupanion.Entity.Workflow;

public class WFDboGetNextAssignmentLog
{
    public int TaskInstanceId { get; set; }
    public DateTime AssignedOn { get; set; }
    public Guid AssignedTo { get; set; }
    public int LoopsPerformed { get; set; }
    public string Skills { get; set; } = "";
}
