using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.InteractionPolicyData;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationInteractionPolicyDataContext : DbContext
{
    public VisionMigrationInteractionPolicyDataContext()
    {
    }

    public VisionMigrationInteractionPolicyDataContext(DbContextOptions<VisionMigrationInteractionPolicyDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmInteractionPolicyDataCustomer> Customers { get; set; }
    public virtual DbSet<VmInteractionPolicyDataPet> Pets { get; set; }
    public virtual DbSet<VmInteractionPolicyDataPolicy> Policies { get; set; }

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

        modelBuilder.Entity<VmInteractionPolicyDataCustomer>(entity =>
        {
            entity.ToTable("Customer", "InteractionPolicyData");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<VmInteractionPolicyDataPet>(entity =>
        {
            entity.ToTable("Pet", "InteractionPolicyData");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer)
                .WithMany(p => p.Pets)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fk_interactionPolicyDataPet_CustomerId");
        });

        modelBuilder.Entity<VmInteractionPolicyDataPolicy>(entity =>
        {
            entity.ToTable("Policy", "InteractionPolicyData");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.HasOne(d => d.Pet)
                .WithMany(p => p.Policies)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("fk_interactionPolicyDataPolicy_PetId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}