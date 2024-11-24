using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Claims.PetStamp;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class ClaimsPetStampContext : DbContext
{
    public ClaimsPetStampContext()
    {
    }

    public ClaimsPetStampContext(DbContextOptions<ClaimsPetStampContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClaimsPetStampItem> Items { get; set; }
    public virtual DbSet<ClaimsPetStampPphx> Pphxes { get; set; }
    public virtual DbSet<ClaimsPetStampPphxHistory> PphxHistories { get; set; }
    public virtual DbSet<ClaimsPetStampPphxItem> PphxItems { get; set; }
    public virtual DbSet<ClaimsPetStampPphxItemSelection> PphxItemSelections { get; set; }
    public virtual DbSet<ClaimsPetStampPphxItemSelectionHistory> PphxItemSelectionHistories { get; set; }
    public virtual DbSet<ClaimsPetStampPphxType> PphxTypes { get; set; }
    public virtual DbSet<ClaimsPetStampProcess> Processes { get; set; }
    public virtual DbSet<ClaimsPetStampProcessVerification> ProcessVerifications { get; set; }
    public virtual DbSet<ClaimsPetStampProcessVerificationDateType> ProcessVerificationDateTypes { get; set; }
    public virtual DbSet<ClaimsPetStampProcessVerificationHistory> ProcessVerificationHistories { get; set; }
    public virtual DbSet<ClaimsPetStampProcessVerificationHospital> ProcessVerificationHospitals { get; set; }
    public virtual DbSet<ClaimsPetStampProcessVerificationHospitalHistory> ProcessVerificationHospitalHistories { get; set; }
    public virtual DbSet<ClaimsPetStampProcessVerificationStatus> ProcessVerificationStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.claims), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<ClaimsPetStampItem>(entity =>
        {
            entity.ToTable("Item", "PetStamp");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ClaimsPetStampPphx>(entity =>
        {
            entity.ToTable("PPHx", "PetStamp");

            entity.HasIndex(e => e.PetId, "uk_pphx_petid")
                .IsUnique();

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.Property(e => e.PphxTypeId).HasColumnName("PPHxTypeId");

            entity.HasOne(d => d.PphxType)
                .WithMany(p => p.Pphxes)
                .HasForeignKey(d => d.PphxTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PPHx_PPHxType");
        });

        modelBuilder.Entity<ClaimsPetStampPphxHistory>(entity =>
        {
            entity.ToTable("PPHxHistory", "PetStamp");

            entity.HasIndex(e => e.PphxId, "IX_PPHxHistory_PPHxId");

            entity.Property(e => e.Notes).IsUnicode(false);

            entity.Property(e => e.PphxId).HasColumnName("PPHxId");

            entity.Property(e => e.PphxTypeId).HasColumnName("PPHxTypeId");

            entity.HasOne(d => d.Pphx)
                .WithMany(p => p.PphxHistories)
                .HasForeignKey(d => d.PphxId)
                .HasConstraintName("FK_PPHxHistory_PPHx");
        });

        modelBuilder.Entity<ClaimsPetStampPphxItem>(entity =>
        {
            entity.ToTable("PPHxItem", "PetStamp");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PphxTypeId).HasColumnName("PPHxTypeId");
        });

        modelBuilder.Entity<ClaimsPetStampPphxItemSelection>(entity =>
        {
            entity.ToTable("PPHxItemSelection", "PetStamp");

            entity.HasIndex(e => new { e.PphxId, e.PphxItemId }, "UK_PPHxItemSelection_PPHxId_PPHxItemId")
                .IsUnique();

            entity.Property(e => e.PphxId).HasColumnName("PPHxId");

            entity.Property(e => e.PphxItemId).HasColumnName("PPHxItemId");

            entity.HasOne(d => d.Pphx)
                .WithMany(p => p.PphxItemSelections)
                .HasForeignKey(d => d.PphxId)
                .HasConstraintName("FK_PPHxItemSelection_PPHx");

            entity.HasOne(d => d.PphxItem)
                .WithMany(p => p.PphxItemSelections)
                .HasForeignKey(d => d.PphxItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PPHxItemSelection_PPHxItem");
        });

        modelBuilder.Entity<ClaimsPetStampPphxItemSelectionHistory>(entity =>
        {
            entity.ToTable("PPHxItemSelectionHistory", "PetStamp");

            entity.Property(e => e.PphxId).HasColumnName("PPHxId");

            entity.Property(e => e.PphxItemId).HasColumnName("PPHxItemId");

            entity.HasOne(d => d.Pphx)
                .WithMany(p => p.PphxItemSelectionHistories)
                .HasForeignKey(d => d.PphxId)
                .HasConstraintName("FK_PPHxItemSelectionHistory_PPHx");

            entity.HasOne(d => d.PphxItem)
                .WithMany(p => p.PphxItemSelectionHistories)
                .HasForeignKey(d => d.PphxItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PPHxItemSelectionHistory_PPHxItem");
        });

        modelBuilder.Entity<ClaimsPetStampPphxType>(entity =>
        {
            entity.ToTable("PPHxType", "PetStamp");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsPetStampProcess>(entity =>
        {
            entity.ToTable("Process", "PetStamp");

            entity.HasIndex(e => e.PetId, "uk_petstampprocess_petid")
                .IsUnique();

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ClaimsPetStampProcessVerification>(entity =>
        {
            entity.ToTable("ProcessVerification", "PetStamp");

            entity.HasIndex(e => e.ProcessId, "ix_petstamppprocessverification_processid");

            entity.HasIndex(e => new { e.ProcessId, e.ItemId }, "uk_processverification_processid_itemid")
                .IsUnique();

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.DateFrom).HasColumnType("date");

            entity.Property(e => e.DateOn).HasColumnType("date");

            entity.Property(e => e.DateTo).HasColumnType("date");

            entity.HasOne(d => d.DateType)
                .WithMany(p => p.ProcessVerifications)
                .HasForeignKey(d => d.DateTypeId)
                .HasConstraintName("fk_ProcessVerificationDateType_petstampprocessverification");

            entity.HasOne(d => d.Item)
                .WithMany(p => p.ProcessVerifications)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petstampitem_petstampprocessverification");

            entity.HasOne(d => d.Process)
                .WithMany(p => p.ProcessVerifications)
                .HasForeignKey(d => d.ProcessId)
                .HasConstraintName("fk_petstampprocess_petstampprocessverification");

            entity.HasOne(d => d.StatusNavigation)
                .WithMany(p => p.ProcessVerifications)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("fk_ProcessVerificationStatus_petstampprocessverification");
        });

        modelBuilder.Entity<ClaimsPetStampProcessVerificationDateType>(entity =>
        {
            entity.ToTable("ProcessVerificationDateType", "PetStamp");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ClaimsPetStampProcessVerificationHistory>(entity =>
        {
            entity.ToTable("ProcessVerificationHistory", "PetStamp");

            entity.HasIndex(e => e.ProcessVerificationId, "ix_petstampprocessverificationhistory_processverificationid");

            entity.Property(e => e.DateFrom).HasColumnType("date");

            entity.Property(e => e.DateOn).HasColumnType("date");

            entity.Property(e => e.DateTo).HasColumnType("date");

            entity.Property(e => e.VerifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.ProcessVerification)
                .WithMany(p => p.ProcessVerificationHistories)
                .HasForeignKey(d => d.ProcessVerificationId)
                .HasConstraintName("fk_petstampprocessverification_petstampprocessverificationhistory_processverificationid");
        });

        modelBuilder.Entity<ClaimsPetStampProcessVerificationHospital>(entity =>
        {
            entity.ToTable("ProcessVerificationHospital", "PetStamp");

            entity.HasIndex(e => new { e.ProcessVerificationId, e.HospitalId }, "uk_petstampprocessverificationhospital_processverificationid_hospitalid")
                .IsUnique();

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.ProcessVerification)
                .WithMany(p => p.ProcessVerificationHospitals)
                .HasForeignKey(d => d.ProcessVerificationId)
                .HasConstraintName("fk_petstampprocessverification_petstampprocessverificationhospital_processverificationid");
        });

        modelBuilder.Entity<ClaimsPetStampProcessVerificationHospitalHistory>(entity =>
        {
            entity.ToTable("ProcessVerificationHospitalHistory", "PetStamp");

            entity.HasOne(d => d.ProcessVerificationHistory)
                .WithMany(p => p.ProcessVerificationHospitalHistories)
                .HasForeignKey(d => d.ProcessVerificationHistoryId)
                .HasConstraintName("fk_petstampprocessverificationhistory_petstampprocessverificationhospitalhistory");
        });

        modelBuilder.Entity<ClaimsPetStampProcessVerificationStatus>(entity =>
        {
            entity.ToTable("ProcessVerificationStatus", "PetStamp");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}