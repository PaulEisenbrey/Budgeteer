using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.LegacyEmails;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationLegacyEmailContext : DbContext
{
    public VisionMigrationLegacyEmailContext()
    {
    }

    public VisionMigrationLegacyEmailContext(DbContextOptions<VisionMigrationLegacyEmailContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmLegacyEmailsCommunication> Communications { get; set; }
    public virtual DbSet<VmLegacyEmailsCommunicationDocument> CommunicationDocuments { get; set; }
    public virtual DbSet<VmLegacyEmailsInteraction> Interactions { get; set; }
    public virtual DbSet<VmLegacyEmailsInteractionPet> InteractionPets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.visionmigration), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<VmLegacyEmailsCommunication>(entity =>
        {
            entity.ToTable("Communications", "LegacyEmails");

            entity.Property(e => e.Id).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[CommunicationsSequence])");

            entity.Property(e => e.CommunicationAttachments).HasColumnName("_CommunicationAttachments");

            entity.Property(e => e.CommunicationDocumentBody)
                .IsRequired()
                .HasColumnName("_CommunicationDocumentBody");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.CustomerReference).HasColumnName("_CustomerReference");

            entity.Property(e => e.EmailRequestId).HasColumnName("_EmailRequestId");
        });

        modelBuilder.Entity<VmLegacyEmailsCommunicationDocument>(entity =>
        {
            entity.ToTable("CommunicationDocuments", "LegacyEmails");

            entity.Property(e => e.Id).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[CommunicationDocumentsSequence])");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.FilePath).HasMaxLength(200);
        });

        modelBuilder.Entity<VmLegacyEmailsInteraction>(entity =>
        {
            entity.ToTable("Interactions", "LegacyEmails");

            entity.Property(e => e.CommunicationId).HasColumnName("_CommunicationId");

            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.Property(e => e.EmailRequestId).HasColumnName("_EmailRequestId");
        });

        modelBuilder.Entity<VmLegacyEmailsInteractionPet>(entity =>
        {
            entity.HasKey(e => new { e.PetsId, e.InteractionsId })
                .HasName("pk_legacyEmailsInteractionPet");

            entity.ToTable("InteractionPet", "LegacyEmails");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}