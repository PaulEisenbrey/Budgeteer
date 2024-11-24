namespace Database.Trupanion.Entity.Workflow;

public class WFDboInputConfigurationOptionGroup
{
    public int InputConfigurationId { get; set; }
    public string GroupHeading { get; set; } = "";
    public int? MinimumOptionSelections { get; set; }
    public int? MaximumOptionSelections { get; set; }

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
}
