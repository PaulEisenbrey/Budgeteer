using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.CommServices.Campaign;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class CommServicesCpgContext : DbContext
{
    public CommServicesCpgContext()
    {
    }

    public CommServicesCpgContext(DbContextOptions<CommServicesCpgContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CommServicesCpgCampaign> Campaigns { get; set; }
    public virtual DbSet<CommServicesCpgCampaignEntity> CampaignEntities { get; set; }
    public virtual DbSet<CommServicesCpgCategory> Categories { get; set; }
    public virtual DbSet<CommServicesCpgClaimExperience> ClaimExperiences { get; set; }
    public virtual DbSet<CommServicesCpgTopic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.commservices), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CommServicesCpgCampaign>(entity =>
        {
            entity.ToTable("Campaign", "Campaign");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesCpgCampaignEntity>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_campaignentity_id")
                .IsClustered(false);

            entity.ToTable("CampaignEntity", "Campaign");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesCpgCategory>(entity =>
        {
            entity.ToTable("Category", "Campaign");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesCpgClaimExperience>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_ClaimExperience_Id")
                .IsClustered(false);

            entity.ToTable("ClaimExperience", "Campaign");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesCpgTopic>(entity =>
        {
            entity.ToTable("Topic", "Campaign");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description).HasMaxLength(500);

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}