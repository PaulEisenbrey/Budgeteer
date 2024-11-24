using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.NameSource;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataNameSourceContext : DbContext
{
    public TestDataNameSourceContext()
    {
    }

    public TestDataNameSourceContext(DbContextOptions<TestDataNameSourceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataNameSourceLanguageSource> LanguageSources { get; set; }
    public virtual DbSet<TestDataNameSourceName> Names { get; set; }

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

        modelBuilder.Entity<TestDataNameSourceLanguageSource>(entity =>
        {
            entity.ToTable("LanguageSource", "NameSource");

            entity.Property(e => e.Language).HasMaxLength(40);
        });

        modelBuilder.Entity<TestDataNameSourceName>(entity =>
        {
            entity.ToTable("Name", "NameSource");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Name");

            entity.HasOne(d => d.Language)
                .WithMany(p => p.Names)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_name_lanugagesource");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}