namespace Database.Trupanion.Entity.Clu.CLUDbo;

public  class CLUDboConceptType
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<CLUDboConcept> Concepts { get; set; } = new();
}
