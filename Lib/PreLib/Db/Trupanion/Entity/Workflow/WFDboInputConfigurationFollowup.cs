namespace Database.Trupanion.Entity.Workflow;

public class WFDboInputConfigurationFollowup
{
    public int InputConfigurationId { get; set; }
    public string Label { get; set; } = "";
    public bool IncludeTime { get; set; }

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
}
