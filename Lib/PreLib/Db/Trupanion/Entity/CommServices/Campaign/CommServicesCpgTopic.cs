namespace Database.Trupanion.Entity.CommServices.Campaign;

public  class CommServicesCpgTopic
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Guid PreferenceId { get; set; }
    public int? CategoryId { get; set; }
    public bool? IsCategoryDefault { get; set; }
}
