using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.ClaimBot;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatClaimBotContext : DbContext
{
    public TruDatClaimBotContext()
    {
    }

    public TruDatClaimBotContext(DbContextOptions<TruDatClaimBotContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatClaimBotCcilimapDaily> CcilimapDailies { get; set; }
    public virtual DbSet<TruDatClaimBotConditionLocationMap20230508> ConditionLocationMap20230508s { get; set; }
    public virtual DbSet<TruDatClaimBotConditionLocationMapDev> ConditionLocationMapDevs { get; set; }
    public virtual DbSet<TruDatClaimBotMedicalRecordToCondLoc> MedicalRecordToCondLocs { get; set; }
    public virtual DbSet<TruDatClaimBotRollupCondition> RollupConditions { get; set; }
    public virtual DbSet<TruDatClaimBotRollupConditionMap> RollupConditionMaps { get; set; }
    public virtual DbSet<TruDatClaimBotStageMedicalRecordToCondLoc> StageMedicalRecordToCondLocs { get; set; }
    public virtual DbSet<TruDatClaimBotStageRollupCondition> StageRollupConditions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.trudat), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TruDatClaimBotCcilimapDaily>(entity =>
        {
            entity.ToTable("ccilimap_daily", "ClaimBot");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");

            entity.Property(e => e.CciliId).HasColumnName("cciliId");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.UploadedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatClaimBotConditionLocationMap20230508>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ConditionLocationMap_2023-05-08", "ClaimBot");

            entity.Property(e => e.ConditionLocation).IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LocName).IsUnicode(false);

            entity.Property(e => e.ProposedLocation).IsUnicode(false);

            entity.Property(e => e.RollupConditionName).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.UpdatedCondition).IsUnicode(false);

            entity.Property(e => e.UpdatedLocation).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatClaimBotConditionLocationMapDev>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ConditionLocationMap_dev", "ClaimBot");

            entity.Property(e => e.ConditionLocation).IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LocName).IsUnicode(false);

            entity.Property(e => e.ProposedLocation).IsUnicode(false);

            entity.Property(e => e.RollupConditionName).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.UpdatedCondition).IsUnicode(false);

            entity.Property(e => e.UpdatedLocation).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatClaimBotMedicalRecordToCondLoc>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MedicalRecordToCondLoc", "ClaimBot");
        });

        modelBuilder.Entity<TruDatClaimBotRollupCondition>(entity =>
        {
            entity.ToTable("RollupCondition", "ClaimBot");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetime())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysdatetime())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatClaimBotRollupConditionMap>(entity =>
        {
            entity.ToTable("RollupConditionMap", "ClaimBot");

            entity.HasIndex(e => e.ConditionId, "ix_ClaimbotRollupConditionMap_ConditionId");

            entity.HasIndex(e => e.RollupConditionId, "ix_ClaimbotRollupConditionMap_RollupConditionId");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetime())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysdatetime())");
        });

        modelBuilder.Entity<TruDatClaimBotStageMedicalRecordToCondLoc>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("stage_MedicalRecordToCondLoc", "ClaimBot");

            entity.Property(e => e.Etlaction)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ETLAction")
                .IsFixedLength(true);

            entity.Property(e => e.SysChangeVersion).HasColumnName("Sys_Change_Version");
        });

        modelBuilder.Entity<TruDatClaimBotStageRollupCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("StageRollupCondition", "ClaimBot");

            entity.HasIndex(e => e.Id, "ix_ClaimbotStageRollupCondition_Id")
                .IsClustered();

            entity.Property(e => e.CondName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ConditionId)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.CreatedOnStg)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Deleted)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Id)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.RollupName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}