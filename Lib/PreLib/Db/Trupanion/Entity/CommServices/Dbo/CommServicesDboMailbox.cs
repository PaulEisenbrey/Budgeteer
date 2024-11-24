namespace Database.Trupanion.Entity.CommServices.Dbo
{
    public  class CommServicesDboMailbox
    {
        public int Id { get; set; }
        public int ExchangeServiceId { get; set; }
        public Guid UniqueId { get; set; }
        public string? EmailAddress { get; set; }
        public int EnterpriseCategoryId { get; set; }

        public virtual CommServicesDboExchangeService? ExchangeService { get; set; }
    }
}
