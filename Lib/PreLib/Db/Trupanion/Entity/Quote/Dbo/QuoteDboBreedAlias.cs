namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboBreedAlias
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Alias { get; set; }
    public Guid PetCharacteristicId { get; set; }

    public virtual QuoteDboPetCharacteristic? PetCharacteristic { get; set; }
}
