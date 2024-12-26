using System;
using System.Collections.Generic;

using Database.POCO.Budgeteer;

using Microsoft.EntityFrameworkCore;

using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Context;

public partial class BudgeteerContext : DbContext
{
    public BudgeteerContext()
    {
    }

    public BudgeteerContext(DbContextOptions<BudgeteerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountDatum> AccountData { get; set; }

    public virtual DbSet<AccountType> AccountTypes { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AnnualPercentageRate> AnnualPercentageRates { get; set; }

    public virtual DbSet<BudgetCategory> BudgetCategories { get; set; }

    public virtual DbSet<Institution> Institutions { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<PostalCode> PostalCodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString.ConstructConnectionString(SqlDatabase.budgeteer), options => options.EnableRetryOnFailure().CommandTimeout(60));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountDatum>(entity =>
        {
            entity.ToTable("AccountData", "Budget");

            entity.HasIndex(e => e.AccountUniqueId, "UQ_AccountData_AccountUniqueId").IsUnique();

            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.InitialBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Nickname).HasMaxLength(100);
            entity.Property(e => e.OpenDate).HasColumnType("datetime");
            entity.Property(e => e.RoutingNumber).HasMaxLength(100);

            entity.HasOne(d => d.AccountType).WithMany(p => p.AccountData)
                .HasForeignKey(d => d.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountData_AccountType");

            entity.HasOne(d => d.Institution).WithMany(p => p.AccountData)
                .HasForeignKey(d => d.InstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountData_Institution");
        });

        modelBuilder.Entity<AccountType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Account");

            entity.ToTable("AccountType", "Budget");

            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address", "Budget");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(10);
            entity.Property(e => e.PostalCode).HasMaxLength(40);
            entity.Property(e => e.State).HasMaxLength(100);
            entity.Property(e => e.Street).HasMaxLength(100);
            entity.Property(e => e.UnitNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnualPercentageRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_APR");

            entity.ToTable("AnnualPercentageRate", "Budget");

            entity.Property(e => e.APR).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.HasOne(d => d.AccountDatum).WithMany(p => p.AnnualPercentageRates)
                .HasForeignKey(d => d.AccountDatumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnnualPercentageRate_AccountDatum");
        });

        modelBuilder.Entity<BudgetCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BudgetCategoriesR");

            entity.ToTable("BudgetCategories", "Budget");

            entity.Property(e => e.Description).HasMaxLength(100);
        });

        modelBuilder.Entity<Institution>(entity =>
        {
            entity.ToTable("Institution", "Budget");

            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Nickname).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);

            entity.HasOne(d => d.Address).WithMany(p => p.Institutions)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_Institution_Address");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transaction", "Budget");

            entity.HasIndex(e => e.TransactionId, "UQ_Transaction_TransactionId").IsUnique();

            entity.Property(e => e.CheckNumber).HasMaxLength(100);
            entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.AccountDatum).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.AccountDatumId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_AccountDatum");

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_TransactionType");
        });

        modelBuilder.Entity<TransactionType>(entity =>
        {
            entity.ToTable("TransactionType", "Budget");

            entity.Property(e => e.Description).HasMaxLength(50);
        });

        modelBuilder.Entity<PostalCode>(entity =>
        {
            entity.ToTable("PostalCodes", "Budget");

            entity.Property(e => e.StateProvince).HasMaxLength(10);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.PostalCodeValue).HasColumnName("PostalCode").HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
