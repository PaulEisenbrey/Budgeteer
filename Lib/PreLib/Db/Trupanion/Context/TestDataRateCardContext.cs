using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.RateCard;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataRateCardContext : DbContext
{
    public TestDataRateCardContext()
    {
    }

    public TestDataRateCardContext(DbContextOptions<TestDataRateCardContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataRateCardColumnSet> ColumnSets { get; set; }
    public virtual DbSet<TestDataRateCardGroup> Groups { get; set; }
    public virtual DbSet<TestDataRateCardRowSet> RowSets { get; set; }
    public virtual DbSet<TestDataRateCardTab> Tabs { get; set; }

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

        modelBuilder.Entity<TestDataRateCardColumnSet>(entity =>
        {
            entity.ToTable("ColumnSet", "RateCard");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.ColumnSets)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_columnsetgroupid_groupid");
        });

        modelBuilder.Entity<TestDataRateCardGroup>(entity =>
        {
            entity.ToTable("Group", "RateCard");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80);

            entity.HasOne(d => d.Tab)
                .WithMany(p => p.InverseTab)
                .HasForeignKey(d => d.TabId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouptabid_tabid");
        });

        modelBuilder.Entity<TestDataRateCardRowSet>(entity =>
        {
            entity.ToTable("RowSet", "RateCard");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.RowSets)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rowsetgroupid_groupid");
        });

        modelBuilder.Entity<TestDataRateCardTab>(entity =>
        {
            entity.ToTable("Tab", "RateCard");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}