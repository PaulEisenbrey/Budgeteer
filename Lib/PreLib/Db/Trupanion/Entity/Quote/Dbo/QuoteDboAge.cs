namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboAge
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal AgeYearFrom { get; set; }
    public decimal AgeYearTo { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool ValidForEnrollment { get; set; }
    public Guid PetCharacteristicId { get; set; }

    public virtual QuoteDboPetCharacteristic? PetCharacteristic { get; set; }
}
