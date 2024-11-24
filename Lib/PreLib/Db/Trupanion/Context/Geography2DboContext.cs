using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Geography2.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class Geography2DboContext : DbContext
{
    public Geography2DboContext()
    {
    }

    public Geography2DboContext(DbContextOptions<Geography2DboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Geography2DboCity> Cities { get; set; }
    public virtual DbSet<Geography2DboCountry> Countries { get; set; }
    public virtual DbSet<Geography2DboCounty> Counties { get; set; }
    public virtual DbSet<Geography2DboPostalCode> PostalCodes { get; set; }
    public virtual DbSet<Geography2DboPostalCodeCity> PostalCodeCities { get; set; }
    public virtual DbSet<Geography2DboPostalCodeCounty> PostalCodeCounties { get; set; }
    public virtual DbSet<Geography2DboPostalCodeState> PostalCodeStates { get; set; }
    public virtual DbSet<Geography2DboState> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.geography2), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Geography2DboCity>(entity =>
        {
            entity.ToTable("City");

            entity.HasIndex(e => new { e.StateId, e.Name }, "uk_city_stateid_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.State)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_city_state");
        });

        modelBuilder.Entity<Geography2DboCountry>(entity =>
        {
            entity.ToTable("Country");

            entity.HasIndex(e => e.IsoAlpha2CountryCode, "uk_country_isoalpha2countrycode")
                .IsUnique();

            entity.HasIndex(e => e.IsoAlpha3CountryCode, "uk_country_isoalpha3countrycode")
                .IsUnique();

            entity.HasIndex(e => e.Name, "uk_country_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsoAlpha2CountryCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength(true);

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<Geography2DboCounty>(entity =>
        {
            entity.ToTable("County");

            entity.HasIndex(e => new { e.StateId, e.Name }, "uk_county_stateid_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.State)
                .WithMany(p => p.Counties)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_county_state");
        });

        modelBuilder.Entity<Geography2DboPostalCode>(entity =>
        {
            entity.ToTable("PostalCode");

            entity.HasIndex(e => new { e.CountryId, e.Code }, "ix_postalcode_countryid_code");

            entity.HasIndex(e => new { e.Code, e.CountryId }, "uk_postalcode_code_countryid")
                .IsUnique();

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.Latitude).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.Longitude).HasColumnType("numeric(18, 15)");

            entity.HasOne(d => d.Country)
                .WithMany(p => p.PostalCodes)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_postalcode_country");
        });

        modelBuilder.Entity<Geography2DboPostalCodeCity>(entity =>
        {
            entity.ToTable("PostalCodeCity");

            entity.HasIndex(e => e.PostalCodeId, "ix_postalcodecity_postalcodeid");

            entity.HasIndex(e => new { e.CityId, e.PostalCodeId }, "uk_postalcodecity_cityid_postalcodeid")
                .IsUnique();

            entity.HasOne(d => d.City)
                .WithMany(p => p.PostalCodeCities)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_postalcodecity_city");

            entity.HasOne(d => d.PostalCode)
                .WithMany(p => p.PostalCodeCities)
                .HasForeignKey(d => d.PostalCodeId)
                .HasConstraintName("fk_postalcodecity_postalcode");
        });

        modelBuilder.Entity<Geography2DboPostalCodeCounty>(entity =>
        {
            entity.ToTable("PostalCodeCounty");

            entity.HasIndex(e => new { e.CountyId, e.PostalCodeId }, "uk_postalcodecounty_countyid_postalcodeid")
                .IsUnique();

            entity.HasOne(d => d.County)
                .WithMany(p => p.PostalCodeCounties)
                .HasForeignKey(d => d.CountyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_postalcodecounty_county");

            entity.HasOne(d => d.PostalCode)
                .WithMany(p => p.PostalCodeCounties)
                .HasForeignKey(d => d.PostalCodeId)
                .HasConstraintName("fk_postalcodecounty_postalcode");
        });

        modelBuilder.Entity<Geography2DboPostalCodeState>(entity =>
        {
            entity.ToTable("PostalCodeState");

            entity.HasIndex(e => e.PostalCodeId, "ix_postalcodestate_postalcodeid");

            entity.HasIndex(e => new { e.StateId, e.PostalCodeId }, "uk_postalcodestate_stateid_postalcodeid")
                .IsUnique();

            entity.HasOne(d => d.PostalCode)
                .WithMany(p => p.PostalCodeStates)
                .HasForeignKey(d => d.PostalCodeId)
                .HasConstraintName("fk_postalcodestate_postalcode");

            entity.HasOne(d => d.State)
                .WithMany(p => p.PostalCodeStates)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_postalcodestate_state");
        });

        modelBuilder.Entity<Geography2DboState>(entity =>
        {
            entity.ToTable("State");

            entity.HasIndex(e => new { e.CountryId, e.StateCode }, "uk_state_countryid_statecode")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.HasOne(d => d.Country)
                .WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("fk_state_contry");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}