namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedGuideCharacteristic
{
    public int Id { get; set; }
    public int BreedGuideId { get; set; }
    public int BreedCharacteristicId { get; set; }
    public int Value { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboBreedCharacteristic? BreedCharacteristic { get; set; }
    public virtual TruDatDboBreedGuide? BreedGuide { get; set; }
}
