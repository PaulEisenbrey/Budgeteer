﻿using Database.Models;
using Microsoft.EntityFrameworkCore;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Context;

public partial class BudgeteerContext : DbContext
{
    public BudgeteerContext() : base()
	{
	}

	public BudgeteerContext(DbContextOptions<BudgeteerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountAprlookup> AccountAprlookups { get; set; } = default!;

    public virtual DbSet<AccountDatum> AccountData { get; set; } = default!;

    public virtual DbSet<AccountType> AccountTypes { get; set; } = default!;

    public virtual DbSet<Address> Addresses { get; set; } = default!;

    public virtual DbSet<AnnualPercentageRate> AnnualPercentageRates { get; set; } = default!;

    public virtual DbSet<Institution> Institutions { get; set; } = default!;

    public virtual DbSet<InstitutionAccountsLookup> InstitutionAccountsLookups { get; set; } = default!;

    public virtual DbSet<Transaction> Transactions { get; set; } = default!;

    public virtual DbSet<TransactionType> TransactionTypes { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.ConstructConnectionString(SqlDatabase.budgeteer), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountAprlookup>(entity =>
        {
            entity.ToTable("AccountAPRLookup", "Budget");

            entity.HasOne(d => d.AccountData).WithMany(p => p.AccountAprlookups)
                .HasForeignKey(d => d.AccountDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAPRLookup_AccountData");

            entity.HasOne(d => d.AnnualPercentageRate).WithMany(p => p.AccountAprlookups)
                .HasForeignKey(d => d.AnnualPercentageRateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountAPRLookup_AnnualPercentageRate");
        });

        modelBuilder.Entity<AccountDatum>(entity =>
        {
            entity.ToTable("AccountData", "Budget");

            entity.Property(e => e.AccountNumber).HasMaxLength(100);
            entity.Property(e => e.InitialBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Nickname).HasMaxLength(100);
            entity.Property(e => e.OpenDate).HasColumnType("datetime");
            entity.Property(e => e.RoutingNumber).HasMaxLength(100);

            entity.HasOne(d => d.AccountType).WithMany(p => p.AccountData)
                .HasForeignKey(d => d.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountData_AccountType");
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

            entity.Property(e => e.Apr)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APR");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
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

        modelBuilder.Entity<InstitutionAccountsLookup>(entity =>
        {
            entity.ToTable("InstitutionAccountsLookup", "Budget");

            entity.HasOne(d => d.AccountData).WithMany(p => p.InstitutionAccountsLookups)
                .HasForeignKey(d => d.AccountDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccountData_Lookup");

            entity.HasOne(d => d.Institution).WithMany(p => p.InstitutionAccountsLookups)
                .HasForeignKey(d => d.InstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Institution_Lookup");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transaction", "Budget");

            entity.Property(e => e.CheckNumber).HasMaxLength(100);
            entity.Property(e => e.TransactionAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_TransactionType");
        });

        modelBuilder.Entity<TransactionType>(entity =>
        {
            entity.ToTable("TransactionType", "Budget");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
