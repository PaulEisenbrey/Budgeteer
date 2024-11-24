namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboPetCharacteristicType
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }

    public virtual List<QuoteDboPetCharacteristic> PetCharacteristics { get; set; } = new();
}
