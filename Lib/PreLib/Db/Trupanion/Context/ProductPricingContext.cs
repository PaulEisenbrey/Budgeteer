using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Product.Pricing;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class ProductPricingContext : DbContext
{
    public ProductPricingContext()
    {
    }

    public ProductPricingContext(DbContextOptions<ProductPricingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductPricingFormula> Formulas { get; set; }
    public virtual DbSet<ProductPricingFormulaInputFactorLink> FormulaInputFactorLinks { get; set; }
    public virtual DbSet<ProductPricingFormulaPriceFactorLink> FormulaPriceFactorLinks { get; set; }
    public virtual DbSet<ProductPricingInputFactor> InputFactors { get; set; }
    public virtual DbSet<ProductPricingPriceEngine> PriceEngines { get; set; }
    public virtual DbSet<ProductPricingPriceEngineArtifact> PriceEngineArtifacts { get; set; }
    public virtual DbSet<ProductPricingPriceFactor> PriceFactors { get; set; }
    public virtual DbSet<ProductPricingPriceFactorArgSet> PriceFactorArgSets { get; set; }
    public virtual DbSet<ProductPricingPriceFactorArgSetProductFactorInstanceLink> PriceFactorArgSetProductFactorInstanceLinks { get; set; }
    public virtual DbSet<ProductPricingPriceFactorProductFactorLink> PriceFactorProductFactorLinks { get; set; }
    public virtual DbSet<ProductPricingPriceFactorValue> PriceFactorValues { get; set; }
    public virtual DbSet<ProductPricingTestCase> TestCases { get; set; }
    public virtual DbSet<ProductPricingTestCaseResult> TestCaseResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.product), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<ProductPricingFormula>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingformula")
                .IsClustered(false);

            entity.ToTable("Formula", "Pricing");

            entity.HasIndex(e => e.Name, "uk_pricingformula_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.ScriptText).IsRequired();
        });

        modelBuilder.Entity<ProductPricingFormulaInputFactorLink>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingformulainputfactorlink")
                .IsClustered(false);

            entity.ToTable("FormulaInputFactorLink", "Pricing");

            entity.HasIndex(e => e.FactorId, "ix_pricingformulainputfactorlink_factor");

            entity.HasIndex(e => e.FormulaId, "ix_pricingformulainputfactorlink_formula");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Factor)
                .WithMany(p => p.FormulaInputFactorLinks)
                .HasForeignKey(d => d.FactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingformulainputfactorlink_factor");

            entity.HasOne(d => d.Formula)
                .WithMany(p => p.FormulaInputFactorLinks)
                .HasForeignKey(d => d.FormulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingformulainputfactorlink_formula");
        });

        modelBuilder.Entity<ProductPricingFormulaPriceFactorLink>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingformulapricefactorlink")
                .IsClustered(false);

            entity.ToTable("FormulaPriceFactorLink", "Pricing");

            entity.HasIndex(e => e.PriceFactorId, "ix_pricingformulapricefactorlink_factor");

            entity.HasIndex(e => e.PriceFactorId, "ix_pricingformulapricefactorlink_formula");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Formula)
                .WithMany(p => p.FormulaPriceFactorLinks)
                .HasForeignKey(d => d.FormulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingformulapricefactorlink_formula");

            entity.HasOne(d => d.PriceFactor)
                .WithMany(p => p.FormulaPriceFactorLinks)
                .HasForeignKey(d => d.PriceFactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingformulapricefactorlink_factor");
        });

        modelBuilder.Entity<ProductPricingInputFactor>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_inputfactor")
                .IsClustered(false);

            entity.ToTable("InputFactor", "Pricing");

            entity.HasIndex(e => e.Name, "uk_pricinginputfactor_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description).HasMaxLength(250);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductPricingPriceEngine>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingpriceengine")
                .IsClustered(false);

            entity.ToTable("PriceEngine", "Pricing");

            entity.HasIndex(e => e.FormulaId, "ix_pricingpriceengine_formula");

            entity.HasIndex(e => e.Name, "uk_pricingpriceengine_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Formula)
                .WithMany(p => p.PriceEngines)
                .HasForeignKey(d => d.FormulaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingpriceengine_formula");
        });

        modelBuilder.Entity<ProductPricingPriceEngineArtifact>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_Pricing.PriceEngineArtifact")
                .IsClustered(false);

            entity.ToTable("PriceEngineArtifact", "Pricing");

            entity.HasIndex(e => new { e.PriceEngineId, e.FileName }, "UK_PricingPriceEngineArtifact_PriceEngineId_FileName")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.FileData).IsRequired();

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(200);

            entity.HasOne(d => d.PriceEngine)
                .WithMany(p => p.PriceEngineArtifacts)
                .HasForeignKey(d => d.PriceEngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PriceEngi__Price__76177A41");
        });

        modelBuilder.Entity<ProductPricingPriceFactor>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingpricefactor")
                .IsClustered(false);

            entity.ToTable("PriceFactor", "Pricing");

            entity.HasIndex(e => e.Name, "uk_pricingpricefactor_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.DefaultValue).HasColumnType("decimal(19, 11)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ProductPricingPriceFactorArgSet>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingpricefactorargset")
                .IsClustered(false);

            entity.ToTable("PriceFactorArgSet", "Pricing");

            entity.HasIndex(e => e.Hash, "ix_pricingpricefactorargset_hash");

            entity.HasIndex(e => e.PriceFactorId, "ix_pricingpricefactorargset_pricefactor");

            entity.HasIndex(e => new { e.PriceFactorId, e.Hash }, "uk_pricingpricefactorargset_pfid_hash")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Hash)
                .HasMaxLength(64)
                .IsFixedLength(true);

            entity.HasOne(d => d.PriceFactor)
                .WithMany(p => p.PriceFactorArgSets)
                .HasForeignKey(d => d.PriceFactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingpricefactorargset_pricefactor");
        });

        modelBuilder.Entity<ProductPricingPriceFactorArgSetProductFactorInstanceLink>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingpricefactorargsetproductfactorinstancelink")
                .IsClustered(false);

            entity.ToTable("PriceFactorArgSetProductFactorInstanceLink", "Pricing");

            entity.HasIndex(e => e.PriceFactorArgSetId, "ix_pricingpricefactorargsetproductfactorinstancelink_pricefactorargsetid");

            entity.HasIndex(e => e.ProductFactorInstanceId, "ix_pricingpricefactorargsetproductfactorinstancelink_productfactorinstanceid");

            entity.HasIndex(e => new { e.PriceFactorArgSetId, e.ProductFactorInstanceId }, "uk_pricingpricefactorargsetproductfactorinstancelink_pfasi_pfii")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.PriceFactorArgSet)
                .WithMany(p => p.PriceFactorArgSetProductFactorInstanceLinks)
                .HasForeignKey(d => d.PriceFactorArgSetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingpricefactorargsetproductfactorinstancelink_pricefactorargset");
        });

        modelBuilder.Entity<ProductPricingPriceFactorProductFactorLink>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_Pricingpricefactorproductfactorlink")
                .IsClustered(false);

            entity.ToTable("PriceFactorProductFactorLink", "Pricing");

            entity.HasIndex(e => e.PriceFactorId, "ix_pricingpricefactorproductfactorlink_pricefactor");

            entity.HasIndex(e => e.ProductFactorId, "ix_pricingpricefactorproductfactorlink_productfactor");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsOptional)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.PriceFactor)
                .WithMany(p => p.PriceFactorProductFactorLinks)
                .HasForeignKey(d => d.PriceFactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingpricefactorproductfactorlink_pricefactor");
        });

        modelBuilder.Entity<ProductPricingPriceFactorValue>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingpricefactorvalue")
                .IsClustered(false);

            entity.ToTable("PriceFactorValue", "Pricing");

            entity.HasIndex(e => e.ArgsId, "ix_pricingpricefactorvalue_args");

            entity.HasIndex(e => new { e.PriceEngineId, e.ArgsId }, "ix_pricingpricefactorvalue_peid_argsid");

            entity.HasIndex(e => e.PriceEngineId, "ix_pricingpricefactorvalue_priceengine");

            entity.HasIndex(e => new { e.Value, e.ArgsId, e.PriceEngineId }, "uk_pricingpricefactorvalue_v_a_p")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Value).HasColumnType("decimal(19, 11)");

            entity.HasOne(d => d.Args)
                .WithMany(p => p.PriceFactorValues)
                .HasForeignKey(d => d.ArgsId)
                .HasConstraintName("fk_pricingpricefactorvalue_args");

            entity.HasOne(d => d.PriceEngine)
                .WithMany(p => p.PriceFactorValues)
                .HasForeignKey(d => d.PriceEngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingpricefactorvalue_priceengine");
        });

        modelBuilder.Entity<ProductPricingTestCase>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingtestcase")
                .IsClustered(false);

            entity.ToTable("TestCase", "Pricing");

            entity.HasIndex(e => e.PriceEngineId, "ix_pricingtestcase_priceengine");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ExpectedValue).HasColumnType("decimal(19, 5)");

            entity.Property(e => e.InputFactors)
                .IsRequired()
                .HasDefaultValueSql("('[]')");

            entity.Property(e => e.ProductFactorInstances).IsRequired();

            entity.Property(e => e.SelectedEndorsements).IsRequired();

            entity.HasOne(d => d.PriceEngine)
                .WithMany(p => p.TestCases)
                .HasForeignKey(d => d.PriceEngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingtestcase_priceengine");
        });

        modelBuilder.Entity<ProductPricingTestCaseResult>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_pricingtestcaseresult")
                .IsClustered(false);

            entity.ToTable("TestCaseResult", "Pricing");

            entity.HasIndex(e => e.TestCaseId, "ix_pricingtestcaseresult_testcase");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Diagnostics).IsRequired();

            entity.Property(e => e.ResultValue).HasColumnType("decimal(19, 5)");

            entity.Property(e => e.TestExecutedOn).HasColumnType("datetime");

            entity.HasOne(d => d.TestCase)
                .WithMany(p => p.TestCaseResults)
                .HasForeignKey(d => d.TestCaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricingtestcaseresult_testcase");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}