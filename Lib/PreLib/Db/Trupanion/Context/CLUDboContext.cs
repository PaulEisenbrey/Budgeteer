using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Clu.CLUDbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class CLUDboContext : DbContext
{
    public CLUDboContext()
    {
    }

    public CLUDboContext(DbContextOptions<CLUDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CLUDboConcept> Concepts { get; set; }
    public virtual DbSet<CLUDboConceptHistory> ConceptHistories { get; set; }
    public virtual DbSet<CLUDboConceptType> ConceptTypes { get; set; }
    public virtual DbSet<CLUDboCondition> Conditions { get; set; }
    public virtual DbSet<CLUDboConditionHistory> ConditionHistories { get; set; }
    public virtual DbSet<CLUDboDeletedCondition> DeletedConditions { get; set; }
    public virtual DbSet<CLUDboDeletedLocation> DeletedLocations { get; set; }
    public virtual DbSet<CLUDboLocation> Locations { get; set; }
    public virtual DbSet<CLUDboLocationHistory> LocationHistories { get; set; }
    public virtual DbSet<CLUDboProposedCondition> ProposedConditions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.clu), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CLUDboConcept>(entity =>
        {
            entity.ToTable("Concept");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.ConceptType)
                .WithMany(p => p.Concepts)
                .HasForeignKey(d => d.ConceptTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ConditionType_Concept_ConditionTypeId");

            entity.HasOne(d => d.CustomerPreferredCondition)
                .WithMany(p => p.ConceptCustomerPreferredConditions)
                .HasForeignKey(d => d.CustomerPreferredConditionId)
                .HasConstraintName("fk_Condition_Concept_CustomerPreferredConditionId");

            entity.HasOne(d => d.VetPreferredCondition)
                .WithMany(p => p.ConceptVetPreferredConditions)
                .HasForeignKey(d => d.VetPreferredConditionId)
                .HasConstraintName("fk_Condition_Concept_VetPreferredConditionId");
        });

        modelBuilder.Entity<CLUDboConceptHistory>(entity =>
        {
            entity.ToTable("ConceptHistory");

            entity.HasIndex(e => e.ConceptId, "IX_ConceptHistory_ConceptId");

            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

            entity.Property(e => e.EffectiveTo).HasColumnType("datetime");
        });

        modelBuilder.Entity<CLUDboConceptType>(entity =>
        {
            entity.ToTable("ConceptType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CLUDboCondition>(entity =>
        {
            entity.ToTable("Condition");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);

            entity.HasOne(d => d.Concept)
                .WithMany(p => p.Conditions)
                .HasForeignKey(d => d.ConceptId)
                .HasConstraintName("fk_Concept_Condition_ConceptId");
        });

        modelBuilder.Entity<CLUDboConditionHistory>(entity =>
        {
            entity.ToTable("ConditionHistory");

            entity.HasIndex(e => e.ConditionId, "IX_ConditionHistory_ConditionId");

            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

            entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
        });

        modelBuilder.Entity<CLUDboDeletedCondition>(entity =>
        {
            entity.ToTable("DeletedCondition");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
        });

        modelBuilder.Entity<CLUDboDeletedLocation>(entity =>
        {
            entity.ToTable("DeletedLocation");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CLUDboLocation>(entity =>
        {
            entity.ToTable("Location");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_Location_Location_ParentId");
        });

        modelBuilder.Entity<CLUDboLocationHistory>(entity =>
        {
            entity.ToTable("LocationHistory");

            entity.HasIndex(e => e.LocationId, "IX_LocationHistory_LocationId");

            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

            entity.Property(e => e.EffectiveTo).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CLUDboProposedCondition>(entity =>
        {
            entity.ToTable("ProposedCondition");

            entity.Property(e => e.Comment).IsUnicode(false);

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}