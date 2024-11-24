using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.RateCardConfig;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataRateCardConfigContext : DbContext
{
    public TestDataRateCardConfigContext()
    {
    }

    public TestDataRateCardConfigContext(DbContextOptions<TestDataRateCardConfigContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataRateCardConfigRateCardColumn> RateCardColumns { get; set; }
    public virtual DbSet<TestDataRateCardConfigRateCardRowset> RateCardRowsets { get; set; }
    public virtual DbSet<TestDataRateCardConfigRateCardSection> RateCardSections { get; set; }
    public virtual DbSet<TestDataRateCardConfigRateCardTab> RateCardTabs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.testdata), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TestDataRateCardConfigRateCardColumn>(entity =>
        {
            entity.ToTable("RateCardColumn", "RateCardConfig");

            entity.Property(e => e.CcRateCardSectionId).HasColumnName("CC_RateCardSectionId");

            entity.Property(e => e.RateCardColumnName)
                .IsRequired()
                .HasMaxLength(80);

            entity.HasOne(d => d.CcRateCardSection)
                .WithMany(p => p.RateCardColumns)
                .HasForeignKey(d => d.CcRateCardSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ratecardcolumn_ratecardsection");
        });

        modelBuilder.Entity<TestDataRateCardConfigRateCardRowset>(entity =>
        {
            entity.ToTable("RateCardRowset", "RateCardConfig");

            entity.Property(e => e.RatecardRowsetName)
                .IsRequired()
                .HasMaxLength(80);

            entity.Property(e => e.RsRateCardSectionId).HasColumnName("RS_RateCardSectionId");

            entity.HasOne(d => d.RsRateCardSection)
                .WithMany(p => p.RateCardRowsets)
                .HasForeignKey(d => d.RsRateCardSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ratecardrowset_ratecardsection");
        });

        modelBuilder.Entity<TestDataRateCardConfigRateCardSection>(entity =>
        {
            entity.ToTable("RateCardSection", "RateCardConfig");

            entity.Property(e => e.CsRateCardTabId).HasColumnName("CS_RateCardTabId");

            entity.Property(e => e.RateCardSectionName)
                .IsRequired()
                .HasMaxLength(80);

            entity.HasOne(d => d.CsRateCardTab)
                .WithMany(p => p.RateCardSections)
                .HasForeignKey(d => d.CsRateCardTabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ratecardsection_ratecardtab");
        });

        modelBuilder.Entity<TestDataRateCardConfigRateCardTab>(entity =>
        {
            entity.ToTable("RateCardTab", "RateCardConfig");

            entity.Property(e => e.RateCardTabName)
                .IsRequired()
                .HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}