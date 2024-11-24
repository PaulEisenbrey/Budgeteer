namespace Database.Trupanion.Entity.CommServices.Dbo;

public  class CommServicesDboBatchDeliveryContentConfiguration
{
    public int Id { get; set; }
    public int BatchDeliveryConfigurationId { get; set; }
    public int DeliveryMediumId { get; set; }
    public int ContentSectionId { get; set; }
    public int TemplateDefinitionId { get; set; }
    public string? TemplateDataProjectionTypeName { get; set; }

    public virtual CommServicesDboBatchDeliveryConfiguration? BatchDeliveryConfiguration { get; set; }
}
