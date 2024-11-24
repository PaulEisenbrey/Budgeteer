using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.CommService;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationCommServiceContext : DbContext
{
    public VisionMigrationCommServiceContext()
    {
    }

    public VisionMigrationCommServiceContext(DbContextOptions<VisionMigrationCommServiceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmCommServiceCommunication> Communications { get; set; }
    public virtual DbSet<VmCommServiceCommunicationDocument> CommunicationDocuments { get; set; }
    public virtual DbSet<VmCommServiceInteraction> Interactions { get; set; }
    public virtual DbSet<VmCommServiceInteractionPet> InteractionPets { get; set; }

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

        modelBuilder.Entity<VmCommServiceCommunication>(entity =>
        {
            entity.ToTable("Communications", "CommService");

            entity.Property(e => e.Id).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[CommunicationsSequence])");

            entity.Property(e => e.BodyContentItemId).HasColumnName("_BodyContentItemId");

            entity.Property(e => e.CommunicationAttachments).HasColumnName("_CommunicationAttachments");

            entity.Property(e => e.CommunicationDocumentBody)
                .IsRequired()
                .HasColumnName("_CommunicationDocumentBody");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.CustomerReference).HasColumnName("_CustomerReference");
        });

        modelBuilder.Entity<VmCommServiceCommunicationDocument>(entity =>
        {
            entity.ToTable("CommunicationDocuments", "CommService");

            entity.Property(e => e.Id).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[CommunicationDocumentsSequence])");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.FilePath).HasMaxLength(200);
        });

        modelBuilder.Entity<VmCommServiceInteraction>(entity =>
        {
            entity.ToTable("Interactions", "CommService");

            entity.HasIndex(e => e.CommunicationId, "ix_commServiceInteractions_communicationId");

            entity.HasIndex(e => e.CustomerId, "ix_commServiceInteractions_customerId");

            entity.Property(e => e.CommunicationId).HasColumnName("_CommunicationId");

            entity.Property(e => e.CustomerReference).HasColumnName("_CustomerReference");

            entity.Property(e => e.Description).HasMaxLength(2000);
        });

        modelBuilder.Entity<VmCommServiceInteractionPet>(entity =>
        {
            entity.HasKey(e => new { e.PetsId, e.InteractionsId })
                .HasName("pk_commServiceInteractionPet");

            entity.ToTable("InteractionPet", "CommService");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}