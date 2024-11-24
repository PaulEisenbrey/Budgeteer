namespace Database.Trupanion.Entity.TruDat.Dbo
{
    public class TruDatDboEntityTreeAttribute
    {
        public int Id { get; set; }
        public int EntityTreeId { get; set; }
        public string? Property { get; set; }
        public string? DataType { get; set; }
        public string? Value { get; set; }
        public int ChangeUserId { get; set; }
        public DateTime Inserted { get; set; }
        public DateTime Updated { get; set; }

        public virtual TruDatDboUser? ChangeUser { get; set; }
        public virtual TruDatDboEntityTree? EntityTree { get; set; }
    }
}
