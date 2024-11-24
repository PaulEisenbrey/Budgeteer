namespace Database.Trupanion.Entity.Workflow;

public partial class WFDboInputConfigurationText
{
    public int InputConfigurationId { get; set; }
    public string Label { get; set; } = "";

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
}
