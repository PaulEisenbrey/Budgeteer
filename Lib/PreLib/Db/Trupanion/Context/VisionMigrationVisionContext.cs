using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.Vision;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationVisionContext : DbContext
{
    public VisionMigrationVisionContext()
    {
    }

    public VisionMigrationVisionContext(DbContextOptions<VisionMigrationVisionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmVisionAilment> Ailments { get; set; }
    public virtual DbSet<VmVisionBrandMap> BrandMaps { get; set; }
    public virtual DbSet<VmVisionBreed> Breeds { get; set; }
    public virtual DbSet<VmVisionClaimMedicalRecordCondition> ClaimMedicalRecordConditions { get; set; }
    public virtual DbSet<VmVisionConditionVenOmMap> ConditionVenOmMaps { get; set; }
    public virtual DbSet<VmVisionJumpId> JumpIds { get; set; }
    public virtual DbSet<VmVisionLocationBodyPartMap> LocationBodyPartMaps { get; set; }
    public virtual DbSet<VmVisionMedicalRecordCondition> MedicalRecordConditions { get; set; }
    public virtual DbSet<VmVisionProductMap> ProductMaps { get; set; }
    public virtual DbSet<VmVisionStatusMap> StatusMaps { get; set; }
    public virtual DbSet<VmVisionVet> Vets { get; set; }

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

        modelBuilder.Entity<VmVisionAilment>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Ailment", "Vision");

            entity.Property(e => e.FirstCause)
                .IsRequired()
                .HasMaxLength(256);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.SecondCause)
                .IsRequired()
                .HasMaxLength(256);
        });

        modelBuilder.Entity<VmVisionBrandMap>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BrandMap", "Vision");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmVisionBreed>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Breed", "Vision");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<VmVisionClaimMedicalRecordCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimMedicalRecordCondition", "Vision");
        });

        modelBuilder.Entity<VmVisionConditionVenOmMap>(entity =>
        {
            entity.HasKey(e => new { e.RollupConditionId, e.VenomId })
                .HasName("PK_conditionvenomid");

            entity.ToTable("ConditionVenOmMap", "Vision");

            entity.Property(e => e.RollupConditionName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.VenOmCode)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmVisionJumpId>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("JumpIds", "Vision");

            entity.Property(e => e.Ailid).HasColumnName("ailid");

            entity.Property(e => e.BatchId).HasColumnName("batchId");

            entity.Property(e => e.Cadid).HasColumnName("cadid");

            entity.Property(e => e.Cid).HasColumnName("cid");

            entity.Property(e => e.Cpid).HasColumnName("cpid");

            entity.Property(e => e.Epgid).HasColumnName("epgid");

            entity.Property(e => e.Fqid).HasColumnName("fqid");

            entity.Property(e => e.Lcgid).HasColumnName("lcgid");

            entity.Property(e => e.Legacycpid).HasColumnName("legacycpid");

            entity.Property(e => e.Mdsid).HasColumnName("mdsid");

            entity.Property(e => e.Mrcid).HasColumnName("mrcid");

            entity.Property(e => e.Mrdid).HasColumnName("mrdid");

            entity.Property(e => e.Mrid).HasColumnName("mrid");

            entity.Property(e => e.PaId).HasColumnName("paId");

            entity.Property(e => e.Phid).HasColumnName("phid");

            entity.Property(e => e.Ppceid).HasColumnName("ppceid");
        });

        modelBuilder.Entity<VmVisionLocationBodyPartMap>(entity =>
        {
            entity.HasKey(e => new { e.LocationId, e.BodyPartId })
                .HasName("PK_locationbodyid");

            entity.ToTable("LocationBodyPartMap", "Vision");

            entity.Property(e => e.BodyAltLocation)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Other).HasMaxLength(50);

            entity.Property(e => e.RollupLocation).HasMaxLength(255);

            entity.Property(e => e.SecondaryVisLoc).HasMaxLength(50);
        });

        modelBuilder.Entity<VmVisionMedicalRecordCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MedicalRecordCondition", "Vision");
        });

        modelBuilder.Entity<VmVisionProductMap>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ProductMap", "Vision");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VmVisionStatusMap>(entity =>
        {
            entity.HasKey(e => new { e.StatusId, e.VisionStatusId })
                .HasName("PK_statusmapid");

            entity.ToTable("StatusMap", "Vision");

            entity.Property(e => e.StatusBreadCrumb)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.VisionCrumb)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmVisionVet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Vet", "Vision");

            entity.Property(e => e.Address1).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.City).HasMaxLength(60);

            entity.Property(e => e.ContactName).HasMaxLength(256);

            entity.Property(e => e.Email).HasMaxLength(256);

            entity.Property(e => e.Fax).HasMaxLength(256);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.IsoAlpha2CountryCode).HasMaxLength(256);

            entity.Property(e => e.PhoneNumber).HasMaxLength(256);

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.PracticeName).HasMaxLength(256);

            entity.Property(e => e.PreferredLanguageCode).HasMaxLength(256);

            entity.Property(e => e.StateCode).HasMaxLength(256);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}