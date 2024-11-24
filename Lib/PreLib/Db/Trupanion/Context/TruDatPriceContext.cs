using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.Price;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatPriceContext : DbContext
{
    public TruDatPriceContext()
    {
    }

    public TruDatPriceContext(DbContextOptions<TruDatPriceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatPriceAgeFactor> AgeFactors { get; set; }
    public virtual DbSet<TruDatPriceAutoConvertEngineVersionMapping> AutoConvertEngineVersionMappings { get; set; }
    public virtual DbSet<TruDatPriceBreedFactor> BreedFactors { get; set; }
    public virtual DbSet<TruDatPriceBreedFactorNoHd> BreedFactorNoHds { get; set; }
    public virtual DbSet<TruDatPriceEngine> Engines { get; set; }
    public virtual DbSet<TruDatPriceEngineVersion> EngineVersions { get; set; }
    public virtual DbSet<TruDatPriceEngineVersionComparison> EngineVersionComparisons { get; set; }
    public virtual DbSet<TruDatPriceEngineVersionState> EngineVersionStates { get; set; }
    public virtual DbSet<TruDatPriceFactor> Factors { get; set; }
    public virtual DbSet<TruDatPriceFoodFactor> FoodFactors { get; set; }
    public virtual DbSet<TruDatPriceHospitalFactor> HospitalFactors { get; set; }
    public virtual DbSet<TruDatPriceHospitalFactorRegionDefault> HospitalFactorRegionDefaults { get; set; }
    public virtual DbSet<TruDatPriceRate> Rates { get; set; }
    public virtual DbSet<TruDatPriceRateCardAgeFactor> RateCardAgeFactors { get; set; }
    public virtual DbSet<TruDatPriceRateCardBreedFactor> RateCardBreedFactors { get; set; }
    public virtual DbSet<TruDatPriceRateCardGeoFactor> RateCardGeoFactors { get; set; }
    public virtual DbSet<TruDatPriceRateValue> RateValues { get; set; }
    public virtual DbSet<TruDatPriceTagEngine> TagEngines { get; set; }
    public virtual DbSet<TruDatPriceTargetPrice> TargetPrices { get; set; }
    public virtual DbSet<WorkingPetFactor> WorkingPetFactors { get; set; }
    public virtual DbSet<TruDatPriceZipcodeFactor> ZipcodeFactors { get; set; }

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

        modelBuilder.Entity<TruDatPriceAgeFactor>(entity =>
        {
            entity.ToTable("AgeFactor", "Price");

            entity.HasIndex(e => e.AgeId, "ix_priceagefactor_aid");

            entity.HasIndex(e => e.AnimalId, "ix_priceagefactor_nid");

            entity.HasIndex(e => new { e.VersionId, e.AnimalId, e.AgeId, e.Factor }, "ix_priceagefactor_version");

            entity.HasIndex(e => e.UniqueId, "uk_priceagefactor_uid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Engine)
                .WithMany(p => p.AgeFactors)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_site_priceagefactor");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.AgeFactors)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_agefactor");
        });

        modelBuilder.Entity<TruDatPriceAutoConvertEngineVersionMapping>(entity =>
        {
            entity.ToTable("AutoConvertEngineVersionMapping", "Price");

            entity.HasIndex(e => new { e.StateId, e.CalculatedEngineVersionId }, "uk_priceautoconvertengineversionmapping_sid_eid")
                .IsUnique();

            entity.HasIndex(e => new { e.StateId, e.SubstituteEngineVersionId }, "uk_priceautoconvertengineversionmapping_sid_seid")
                .IsUnique();
        });

        modelBuilder.Entity<TruDatPriceBreedFactor>(entity =>
        {
            entity.ToTable("BreedFactor", "Price");

            entity.HasIndex(e => e.BreedId, "ix_pricebreedfactor_bid");

            entity.HasIndex(e => new { e.VersionId, e.BreedId, e.Factor }, "ix_pricebreedfactor_version");

            entity.HasIndex(e => e.UniqueId, "uk_pricebreedfactor_uid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.BreedFactors)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_pricebreedfactor");
        });

        modelBuilder.Entity<TruDatPriceBreedFactorNoHd>(entity =>
        {
            entity.ToTable("BreedFactorNoHD", "Price");

            entity.HasIndex(e => e.BreedId, "ix_pricebreedfactornohd_bid");

            entity.HasIndex(e => new { e.VersionId, e.BreedId, e.Factor }, "ix_pricebreedfactornohd_version");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.BreedFactorNoHds)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_pricebreedfactornohd");
        });

        modelBuilder.Entity<TruDatPriceEngine>(entity =>
        {
            entity.ToTable("Engine", "Price");

            entity.HasIndex(e => e.Name, "uk_engine_nme")
                .IsUnique();

            entity.HasIndex(e => e.PolicyPrefix, "uk_priceengine_pp")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPrefix)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPriceEngineVersion>(entity =>
        {
            entity.ToTable("EngineVersion", "Price");

            entity.HasIndex(e => e.UniqueId, "uk_dboengineversion_uid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RetireDate).HasColumnType("datetime");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Engine)
                .WithMany(p => p.EngineVersions)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengine_priceengineversion");
        });

        modelBuilder.Entity<TruDatPriceEngineVersionComparison>(entity =>
        {
            entity.ToTable("EngineVersionComparison", "Price");
        });

        modelBuilder.Entity<TruDatPriceEngineVersionState>(entity =>
        {
            entity.ToTable("EngineVersionState", "Price");

            entity.HasIndex(e => e.StateId, "ix_priceengineversionstate_sid");

            entity.HasIndex(e => e.UniqueId, "uk_priceengineversionstate_uid")
                .IsUnique();

            entity.HasIndex(e => new { e.EngineVersionId, e.StateId }, "uk_priceengineversionstate_vid_sid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.EngineVersion)
                .WithMany(p => p.EngineVersionStates)
                .HasForeignKey(d => d.EngineVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_priceengineversionstate");
        });

        modelBuilder.Entity<TruDatPriceFactor>(entity =>
        {
            entity.ToTable("Factor", "Price");

            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPriceFoodFactor>(entity =>
        {
            entity.ToTable("FoodFactor", "Price");

            entity.HasIndex(e => new { e.VersionId, e.PetFoodId }, "ix_pricefoodfactor_version");

            entity.HasIndex(e => new { e.PetFoodId, e.VersionId }, "ix_priceworkingpet_pfid_vid");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.FoodFactors)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_pricefoodfactor");
        });

        modelBuilder.Entity<TruDatPriceHospitalFactor>(entity =>
        {
            entity.ToTable("HospitalFactor", "Price");

            entity.HasIndex(e => new { e.Versionid, e.Active, e.ClinicId }, "ix_pricehospitalfactor_versionid_active_clinicid");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasColumnName("active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.ClinicId).HasColumnName("clinicId");

            entity.Property(e => e.Engineid).HasColumnName("engineid");

            entity.Property(e => e.Factor).HasColumnName("factor");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasColumnName("inserted")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Versionid).HasColumnName("versionid");

            entity.HasOne(d => d.Engine)
                .WithMany(p => p.HospitalFactors)
                .HasForeignKey(d => d.Engineid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengine_pricehospitalfactor");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.HospitalFactors)
                .HasForeignKey(d => d.Versionid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_hospitalfactor");
        });

        modelBuilder.Entity<TruDatPriceHospitalFactorRegionDefault>(entity =>
        {
            entity.ToTable("HospitalFactorRegionDefault", "Price");

            entity.HasIndex(e => new { e.Versionid, e.Active, e.RegionId }, "ix_pricehospitalfactor_versionid_active_clinicid");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasColumnName("active")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Factor).HasColumnName("factor");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasColumnName("inserted")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasColumnName("updated")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Versionid).HasColumnName("versionid");
        });

        modelBuilder.Entity<TruDatPriceRate>(entity =>
        {
            entity.ToTable("Rate", "Price");

            entity.HasIndex(e => e.Name, "uk_pricerate_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPriceRateCardAgeFactor>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateCardAgeFactor", "Price");

            entity.Property(e => e.Ab).HasColumnName("AB");

            entity.Property(e => e.AgeGroup)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Ak).HasColumnName("AK");

            entity.Property(e => e.Al).HasColumnName("AL");

            entity.Property(e => e.Ar).HasColumnName("AR");

            entity.Property(e => e.Az).HasColumnName("AZ");

            entity.Property(e => e.Bc).HasColumnName("BC");

            entity.Property(e => e.Ca).HasColumnName("CA");

            entity.Property(e => e.Co).HasColumnName("CO");

            entity.Property(e => e.Ct).HasColumnName("CT");

            entity.Property(e => e.Dc).HasColumnName("DC");

            entity.Property(e => e.De).HasColumnName("DE");

            entity.Property(e => e.Fl).HasColumnName("FL");

            entity.Property(e => e.Ga).HasColumnName("GA");

            entity.Property(e => e.Hi).HasColumnName("HI");

            entity.Property(e => e.Ia).HasColumnName("IA");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Il).HasColumnName("IL");

            entity.Property(e => e.In).HasColumnName("IN");

            entity.Property(e => e.Ks).HasColumnName("KS");

            entity.Property(e => e.Ky).HasColumnName("KY");

            entity.Property(e => e.La).HasColumnName("LA");

            entity.Property(e => e.Ma).HasColumnName("MA");

            entity.Property(e => e.Mb).HasColumnName("MB");

            entity.Property(e => e.Md).HasColumnName("MD");

            entity.Property(e => e.Me).HasColumnName("ME");

            entity.Property(e => e.Mi).HasColumnName("MI");

            entity.Property(e => e.Mn).HasColumnName("MN");

            entity.Property(e => e.Mo).HasColumnName("MO");

            entity.Property(e => e.Ms).HasColumnName("MS");

            entity.Property(e => e.Mt).HasColumnName("MT");

            entity.Property(e => e.Nb).HasColumnName("NB");

            entity.Property(e => e.Nc).HasColumnName("NC");

            entity.Property(e => e.Nd).HasColumnName("ND");

            entity.Property(e => e.Ne).HasColumnName("NE");

            entity.Property(e => e.Nh).HasColumnName("NH");

            entity.Property(e => e.Nj).HasColumnName("NJ");

            entity.Property(e => e.Nl).HasColumnName("NL");

            entity.Property(e => e.Nm).HasColumnName("NM");

            entity.Property(e => e.Ns).HasColumnName("NS");

            entity.Property(e => e.Nt).HasColumnName("NT");

            entity.Property(e => e.Nu).HasColumnName("NU");

            entity.Property(e => e.Nv).HasColumnName("NV");

            entity.Property(e => e.Ny).HasColumnName("NY");

            entity.Property(e => e.Oh).HasColumnName("OH");

            entity.Property(e => e.Ok).HasColumnName("OK");

            entity.Property(e => e.On).HasColumnName("ON");

            entity.Property(e => e.Or).HasColumnName("OR");

            entity.Property(e => e.Pa).HasColumnName("PA");

            entity.Property(e => e.Pe).HasColumnName("PE");

            entity.Property(e => e.Pr).HasColumnName("PR");

            entity.Property(e => e.Qc).HasColumnName("QC");

            entity.Property(e => e.RateCardName).HasMaxLength(1000);

            entity.Property(e => e.Ri).HasColumnName("RI");

            entity.Property(e => e.Sc).HasColumnName("SC");

            entity.Property(e => e.Sd).HasColumnName("SD");

            entity.Property(e => e.Sk).HasColumnName("SK");

            entity.Property(e => e.StandardFactorCa).HasColumnName("StandardFactorCA");

            entity.Property(e => e.StandardFactorUs).HasColumnName("StandardFactorUS");

            entity.Property(e => e.Tn).HasColumnName("TN");

            entity.Property(e => e.Tx).HasColumnName("TX");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Ut).HasColumnName("UT");

            entity.Property(e => e.Va).HasColumnName("VA");

            entity.Property(e => e.Vt).HasColumnName("VT");

            entity.Property(e => e.Wa).HasColumnName("WA");

            entity.Property(e => e.Wi).HasColumnName("WI");

            entity.Property(e => e.Wv).HasColumnName("WV");

            entity.Property(e => e.Wy).HasColumnName("WY");

            entity.Property(e => e.Yt).HasColumnName("YT");
        });

        modelBuilder.Entity<TruDatPriceRateCardBreedFactor>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateCardBreedFactor", "Price");

            entity.Property(e => e.Ab).HasColumnName("AB");

            entity.Property(e => e.Ak).HasColumnName("AK");

            entity.Property(e => e.Al).HasColumnName("AL");

            entity.Property(e => e.Ar).HasColumnName("AR");

            entity.Property(e => e.Az).HasColumnName("AZ");

            entity.Property(e => e.Bc).HasColumnName("BC");

            entity.Property(e => e.Ca).HasColumnName("CA");

            entity.Property(e => e.Co).HasColumnName("CO");

            entity.Property(e => e.Ct).HasColumnName("CT");

            entity.Property(e => e.Dc).HasColumnName("DC");

            entity.Property(e => e.De).HasColumnName("DE");

            entity.Property(e => e.Fl).HasColumnName("FL");

            entity.Property(e => e.Ga).HasColumnName("GA");

            entity.Property(e => e.Hi).HasColumnName("HI");

            entity.Property(e => e.Ia).HasColumnName("IA");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Il).HasColumnName("IL");

            entity.Property(e => e.In).HasColumnName("IN");

            entity.Property(e => e.Ks).HasColumnName("KS");

            entity.Property(e => e.Ky).HasColumnName("KY");

            entity.Property(e => e.La).HasColumnName("LA");

            entity.Property(e => e.Ma).HasColumnName("MA");

            entity.Property(e => e.Mb).HasColumnName("MB");

            entity.Property(e => e.Md).HasColumnName("MD");

            entity.Property(e => e.Me).HasColumnName("ME");

            entity.Property(e => e.Mi).HasColumnName("MI");

            entity.Property(e => e.Mn).HasColumnName("MN");

            entity.Property(e => e.Mo).HasColumnName("MO");

            entity.Property(e => e.Ms).HasColumnName("MS");

            entity.Property(e => e.Mt).HasColumnName("MT");

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.Property(e => e.Nb).HasColumnName("NB");

            entity.Property(e => e.Nc).HasColumnName("NC");

            entity.Property(e => e.Nd).HasColumnName("ND");

            entity.Property(e => e.Ne).HasColumnName("NE");

            entity.Property(e => e.Nh).HasColumnName("NH");

            entity.Property(e => e.Nj).HasColumnName("NJ");

            entity.Property(e => e.Nl).HasColumnName("NL");

            entity.Property(e => e.Nm).HasColumnName("NM");

            entity.Property(e => e.Ns).HasColumnName("NS");

            entity.Property(e => e.Nt).HasColumnName("NT");

            entity.Property(e => e.Nu).HasColumnName("NU");

            entity.Property(e => e.Nv).HasColumnName("NV");

            entity.Property(e => e.Ny).HasColumnName("NY");

            entity.Property(e => e.Oh).HasColumnName("OH");

            entity.Property(e => e.Ok).HasColumnName("OK");

            entity.Property(e => e.On).HasColumnName("ON");

            entity.Property(e => e.Or).HasColumnName("OR");

            entity.Property(e => e.Pa).HasColumnName("PA");

            entity.Property(e => e.Pe).HasColumnName("PE");

            entity.Property(e => e.Pr).HasColumnName("PR");

            entity.Property(e => e.Qc).HasColumnName("QC");

            entity.Property(e => e.RateCardName).HasMaxLength(1000);

            entity.Property(e => e.Ri).HasColumnName("RI");

            entity.Property(e => e.Sc).HasColumnName("SC");

            entity.Property(e => e.Sd).HasColumnName("SD");

            entity.Property(e => e.Sk).HasColumnName("SK");

            entity.Property(e => e.StandardFactorCa).HasColumnName("StandardFactorCA");

            entity.Property(e => e.StandardFactorUs).HasColumnName("StandardFactorUS");

            entity.Property(e => e.Tn).HasColumnName("TN");

            entity.Property(e => e.Tx).HasColumnName("TX");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Ut).HasColumnName("UT");

            entity.Property(e => e.Va).HasColumnName("VA");

            entity.Property(e => e.Vt).HasColumnName("VT");

            entity.Property(e => e.Wa).HasColumnName("WA");

            entity.Property(e => e.Wi).HasColumnName("WI");

            entity.Property(e => e.Wv).HasColumnName("WV");

            entity.Property(e => e.Wy).HasColumnName("WY");

            entity.Property(e => e.Yt).HasColumnName("YT");
        });

        modelBuilder.Entity<TruDatPriceRateCardGeoFactor>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateCardGeoFactor", "Price");

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.RateCardName).HasMaxLength(1000);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e.StateProvice).HasMaxLength(20);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPriceRateValue>(entity =>
        {
            entity.ToTable("RateValue", "Price");

            entity.HasIndex(e => e.AnimalId, "ix_priceratevalue_aid");

            entity.HasIndex(e => e.RateId, "ix_priceratevalue_rid");

            entity.HasIndex(e => new { e.VersionId, e.AnimalId, e.RateId, e.Rate }, "ix_priceratevalue_version");

            entity.HasIndex(e => e.UniqueId, "uk_priceratevalue_uid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Engine)
                .WithMany(p => p.RateValues)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengine_priceratevalue");

            entity.HasOne(d => d.RateNavigation)
                .WithMany(p => p.RateValues)
                .HasForeignKey(d => d.RateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricerate_priceratevalue");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.RateValues)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_priceratevalue");
        });

        modelBuilder.Entity<TruDatPriceTagEngine>(entity =>
        {
            entity.ToTable("TagEngine", "Price");

            entity.HasIndex(e => e.Name, "uk_tagengine_nme")
                .IsUnique();

            entity.HasIndex(e => e.TagPrefix, "uk_tagpriceengine_pp")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TagPrefix)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPriceTargetPrice>(entity =>
        {
            entity.ToTable("TargetPrice", "Price");

            entity.HasIndex(e => e.Label, "uk_targetprice_lbl")
                .IsUnique();

            entity.Property(e => e.Label)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TargetPrice1)
                .HasColumnType("smallmoney")
                .HasColumnName("TargetPrice");
        });

        modelBuilder.Entity<WorkingPetFactor>(entity =>
        {
            entity.ToTable("WorkingPetFactor", "Price");

            entity.HasIndex(e => new { e.VersionId, e.WorkingPetId }, "ix_priceworkingpet_version");

            entity.HasIndex(e => new { e.WorkingPetId, e.VersionId }, "ix_priceworkingpet_wpid_vid");

            entity.HasIndex(e => e.UniqueId, "uk_priceworkingpetfactor_uid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.WorkingPetFactors)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_priceworkingpetfactor");
        });

        modelBuilder.Entity<TruDatPriceZipcodeFactor>(entity =>
        {
            entity.ToTable("ZipcodeFactor", "Price");

            entity.HasIndex(e => new { e.VersionId, e.Zipcode, e.Factor }, "ix_pricezipcodefactor_version");

            entity.HasIndex(e => e.VersionId, "ix_pricezipcodefactor_vid");

            entity.HasIndex(e => new { e.VersionId, e.Active }, "ix_pricezipcodefactor_vid_a");

            entity.HasIndex(e => e.Zipcode, "ix_pricezipcodefactor_zc");

            entity.HasIndex(e => e.UniqueId, "uk_pricezipcodefactor_uid")
                .IsUnique();

            entity.HasIndex(e => new { e.VersionId, e.Zipcode }, "uk_pricezipcodefactor_vid_zc")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.Engine)
                .WithMany(p => p.ZipcodeFactors)
                .HasForeignKey(d => d.EngineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengine_pricezipcodefactor");

            entity.HasOne(d => d.Version)
                .WithMany(p => p.ZipcodeFactors)
                .HasForeignKey(d => d.VersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceversionengine_pricezipcodefactor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}