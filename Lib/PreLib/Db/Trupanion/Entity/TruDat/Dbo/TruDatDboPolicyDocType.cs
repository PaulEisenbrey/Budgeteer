namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyDocType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }

    public virtual List<TruDatDboPolicyOptionRequiredDoc> PolicyOptionRequiredDocs { get; set; } = new();
    public virtual List<TruDatDboPolicyRequiredDoc> PolicyRequiredDocs { get; set; } = new();
    public virtual List<TruDatDboWorkingPet> WorkingPets { get; set; } = new();
}
