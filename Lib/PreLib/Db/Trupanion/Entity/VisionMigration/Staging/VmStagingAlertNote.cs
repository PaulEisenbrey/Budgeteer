namespace Database.Trupanion.Entity.VisionMigration.Staging
{
    public class VmStagingAlertNote
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public Guid UpdatedById { get; set; }
        public int? PetId { get; set; }
        public int? OwnerId { get; set; }
        public string? Details { get; set; }
        public string? Title { get; set; }
        public Guid? BatchId { get; set; }
    }
}
