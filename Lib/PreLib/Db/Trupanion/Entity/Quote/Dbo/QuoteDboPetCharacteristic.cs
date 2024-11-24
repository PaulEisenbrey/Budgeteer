namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboPetCharacteristic
{
    public Guid Id { get; set; }
    public int IntId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }
    public Guid PetCharacteristicTypeId { get; set; }

    public virtual QuoteDboPetCharacteristicType? PetCharacteristicType { get; set; }
    public virtual List<QuoteDboAge> Ages { get; set; } = new();
    public virtual List<QuoteDboBreedAlias> BreedAliases { get; set; } = new();
}
