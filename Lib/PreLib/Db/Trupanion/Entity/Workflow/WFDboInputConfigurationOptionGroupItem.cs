namespace Database.Trupanion.Entity.Workflow;

public class WFDboInputConfigurationOptionGroupItem
{
    public int Id { get; set; }
    public int InputConfigurationId { get; set; }
    public int InputConfigurationOptionItemId { get; set; }
    public int SelectionOrder { get; set; }
    public string SelectionEffectConfiguration { get; set; } = "";

    public virtual WFDboInputConfiguration? InputConfiguration { get; set; }
    public virtual WFDboInputConfigurationOptionItem? InputConfigurationOptionItem { get; set; }
}
