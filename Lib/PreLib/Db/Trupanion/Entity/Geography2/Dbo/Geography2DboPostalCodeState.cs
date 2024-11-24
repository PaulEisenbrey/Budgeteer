namespace Database.Trupanion.Entity.Geography2.Dbo;

public  class Geography2DboPostalCodeState
{
    public int Id { get; set; }
    public int StateId { get; set; }
    public int PostalCodeId { get; set; }

    public virtual Geography2DboPostalCode? PostalCode { get; set; }
    public virtual Geography2DboState? State { get; set; }
}
