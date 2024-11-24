using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.CommServices.Recipient;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class CommServicesRecipientContext : DbContext
{
    public CommServicesRecipientContext()
    {
    }

    public CommServicesRecipientContext(DbContextOptions<CommServicesRecipientContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CommServicesRecipientAddressClassification> AddressClassifications { get; set; }
    public virtual DbSet<CommServicesRecipientAddressOptChange> AddressOptChanges { get; set; }
    public virtual DbSet<CommServicesRecipientAddressType> AddressTypes { get; set; }
    public virtual DbSet<CommServicesRecipientPreference> Preferences { get; set; }
    public virtual DbSet<CommServicesRecipientRecipient> Recipients { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientBrand> RecipientBrands { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientEmailAddress> RecipientEmailAddresses { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientEmailAddressDeliveryMedium> RecipientEmailAddressDeliveryMedia { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientEmailAddressPreference> RecipientEmailAddressPreferences { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPhoneNumber> RecipientPhoneNumbers { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPhoneNumberDeliveryMedium> RecipientPhoneNumberDeliveryMedia { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPhoneNumberPreference> RecipientPhoneNumberPreferences { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPostalAddress> RecipientPostalAddresses { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPostalAddressDeliveryMedium> RecipientPostalAddressDeliveryMedia { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPostalAddressPreference> RecipientPostalAddressPreferences { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPreference> RecipientPreferences { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPushNotificationAddress> RecipientPushNotificationAddresses { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPushNotificationAddressDeliveryMedium> RecipientPushNotificationAddressDeliveryMedia { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientPushNotificationAddressPreference> RecipientPushNotificationAddressPreferences { get; set; }
    public virtual DbSet<CommServicesRecipientRecipientType> RecipientTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.commservices), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<CommServicesRecipientAddressClassification>(entity =>
        {
            entity.ToTable("AddressClassification", "Recipient");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<CommServicesRecipientAddressOptChange>(entity =>
        {
            entity.ToTable("AddressOptChange", "Recipient");

            entity.Property(e => e.Address).IsRequired();

            entity.Property(e => e.ChangeSource)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesRecipientAddressType>(entity =>
        {
            entity.ToTable("AddressType", "Recipient");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<CommServicesRecipientPreference>(entity =>
        {
            entity.ToTable("Preference", "Recipient");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<CommServicesRecipientRecipient>(entity =>
        {
            entity.ToTable("Recipient", "Recipient");

            entity.HasIndex(e => new { e.RecipientEntityTypeId, e.RecipientEntityId }, "UK_Recipient_RecipientEntityTypeIdRecipientEntityId")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.LanguageCode).HasMaxLength(5);

            entity.Property(e => e.RecipientEntityId)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RecipientEntityType)
                .WithMany(p => p.Recipients)
                .HasForeignKey(d => d.RecipientEntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Recipient_RecipientType");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientBrand>(entity =>
        {
            entity.ToTable("RecipientBrand", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Recipient)
                .WithMany(p => p.RecipientBrands)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK_RecipientBrand_Recipient");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientEmailAddress>(entity =>
        {
            entity.ToTable("RecipientEmailAddress", "Recipient");

            entity.HasIndex(e => new { e.RecipientId, e.AddressClassificationId }, "UK_RecipientEmailAddress_RecipientAddressTypeClassification")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(320);

            entity.HasOne(d => d.AddressClassification)
                .WithMany(p => p.RecipientEmailAddresses)
                .HasForeignKey(d => d.AddressClassificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientEmailAddress_AddressClassification");

            entity.HasOne(d => d.Recipient)
                .WithMany(p => p.RecipientEmailAddresses)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK_RecipientEmailAddress_Recipient");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientEmailAddressDeliveryMedium>(entity =>
        {
            entity.ToTable("RecipientEmailAddressDeliveryMedium", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.RecipientEmailAddress)
                .WithMany(p => p.RecipientEmailAddressDeliveryMedia)
                .HasForeignKey(d => d.RecipientEmailAddressId)
                .HasConstraintName("FK_RecipientEmailAddressDeliveryMedium_RecipientAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientEmailAddressPreference>(entity =>
        {
            entity.ToTable("RecipientEmailAddressPreference", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Preference)
                .WithMany(p => p.RecipientEmailAddressPreferences)
                .HasForeignKey(d => d.PreferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientEmailAddressPreference_Preference");

            entity.HasOne(d => d.RecipientEmailAddress)
                .WithMany(p => p.RecipientEmailAddressPreferences)
                .HasForeignKey(d => d.RecipientEmailAddressId)
                .HasConstraintName("FK_RecipientEmailAddressPreference_RecipientAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPhoneNumber>(entity =>
        {
            entity.ToTable("RecipientPhoneNumber", "Recipient");

            entity.HasIndex(e => e.InternationalNumber, "ix_recipient_recipientphonenumber_internationalNumber");

            entity.HasIndex(e => e.RecipientId, "ix_recipient_recipientphonenumber_recipientid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.CountryCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.Extension)
                .HasMaxLength(10)
                .IsFixedLength(true);

            entity.Property(e => e.InternationalNumber)
                .IsRequired()
                .HasMaxLength(16);

            entity.Property(e => e.NationalSignificantNumber)
                .IsRequired()
                .HasMaxLength(15);

            entity.HasOne(d => d.AddressClassification)
                .WithMany(p => p.RecipientPhoneNumbers)
                .HasForeignKey(d => d.AddressClassificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPhoneNumber_AddressClassification");

            entity.HasOne(d => d.Recipient)
                .WithMany(p => p.RecipientPhoneNumbers)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK_RecipientPhoneNumber_Recipient");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPhoneNumberDeliveryMedium>(entity =>
        {
            entity.ToTable("RecipientPhoneNumberDeliveryMedium", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.RecipientPhoneNumber)
                .WithMany(p => p.RecipientPhoneNumberDeliveryMedia)
                .HasForeignKey(d => d.RecipientPhoneNumberId)
                .HasConstraintName("FK_RecipientPhoneNumberDeliveryMedium_RecipientAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPhoneNumberPreference>(entity =>
        {
            entity.ToTable("RecipientPhoneNumberPreference", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Preference)
                .WithMany(p => p.RecipientPhoneNumberPreferences)
                .HasForeignKey(d => d.PreferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPhoneNumberPreference_Preference");

            entity.HasOne(d => d.RecipientPhoneNumber)
                .WithMany(p => p.RecipientPhoneNumberPreferences)
                .HasForeignKey(d => d.RecipientPhoneNumberId)
                .HasConstraintName("FK_RecipientPhoneNumberPreference_RecipientAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPostalAddress>(entity =>
        {
            entity.ToTable("RecipientPostalAddress", "Recipient");

            entity.HasIndex(e => new { e.RecipientId, e.AddressClassificationId }, "UK_RecipientPostalAddress_RecipientClassification")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address1)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.CountryCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.StateCode).HasMaxLength(5);

            entity.HasOne(d => d.AddressClassification)
                .WithMany(p => p.RecipientPostalAddresses)
                .HasForeignKey(d => d.AddressClassificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPostalAddress_AddressClassification");

            entity.HasOne(d => d.Recipient)
                .WithMany(p => p.RecipientPostalAddresses)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK_RecipientPostalAddress_Recipient");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPostalAddressDeliveryMedium>(entity =>
        {
            entity.ToTable("RecipientPostalAddressDeliveryMedium", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.RecipientPostalAddress)
                .WithMany(p => p.RecipientPostalAddressDeliveryMedia)
                .HasForeignKey(d => d.RecipientPostalAddressId)
                .HasConstraintName("FK_RecipientPostalAddressDeliveryMedium_RecipientPostalAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPostalAddressPreference>(entity =>
        {
            entity.ToTable("RecipientPostalAddressPreference", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Preference)
                .WithMany(p => p.RecipientPostalAddressPreferences)
                .HasForeignKey(d => d.PreferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPostalAddressPreference_Preference");

            entity.HasOne(d => d.RecipientPostalAddress)
                .WithMany(p => p.RecipientPostalAddressPreferences)
                .HasForeignKey(d => d.RecipientPostalAddressId)
                .HasConstraintName("FK_RecipientPostalAddressPreference_RecipientPostalAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPreference>(entity =>
        {
            entity.ToTable("RecipientPreference", "Recipient");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Preference)
                .WithMany(p => p.RecipientPreferences)
                .HasForeignKey(d => d.PreferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPreference_Preference");

            entity.HasOne(d => d.Recipient)
                .WithMany(p => p.RecipientPreferences)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK_RecipientPreference_Recipient");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPushNotificationAddress>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_RecipientPushNotificationAddress_Id")
                .IsClustered(false);

            entity.ToTable("RecipientPushNotificationAddress", "Recipient");

            entity.HasIndex(e => e.RecipientId, "ix_recipient_recipientpushnotificationaddress_recipientid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(320);

            entity.HasOne(d => d.AddressClassification)
                .WithMany(p => p.RecipientPushNotificationAddresses)
                .HasForeignKey(d => d.AddressClassificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPushNotificationAddress_AddressClassification");

            entity.HasOne(d => d.Recipient)
                .WithMany(p => p.RecipientPushNotificationAddresses)
                .HasForeignKey(d => d.RecipientId)
                .HasConstraintName("FK_RecipientPushNotificationAddress_Recipient");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPushNotificationAddressDeliveryMedium>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_RecipientPushNotificationAddressDeliveryMedium_Id")
                .IsClustered(false);

            entity.ToTable("RecipientPushNotificationAddressDeliveryMedium", "Recipient");

            entity.HasIndex(e => e.RecipientPushNotificationAddressId, "ix_recipient_recipientpushnotificationaddressdeliverymedium_recipientpushnotificationaddressid");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.RecipientPushNotificationAddress)
                .WithMany(p => p.RecipientPushNotificationAddressDeliveryMedia)
                .HasForeignKey(d => d.RecipientPushNotificationAddressId)
                .HasConstraintName("FK_RecipientPushNotificationAddressDeliveryMedium_RecipientAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientPushNotificationAddressPreference>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("PK_RecipientPushNotificationAddressPreference_Id")
                .IsClustered(false);

            entity.ToTable("RecipientPushNotificationAddressPreference", "Recipient");

            entity.HasIndex(e => e.RecipientPushNotificationAddressId, "ix_recipient_recipientpushnotificationaddresspreference_recipientpushnotificationaddressid");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Preference)
                .WithMany(p => p.RecipientPushNotificationAddressPreferences)
                .HasForeignKey(d => d.PreferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RecipientPushNotificationAddressPreference_Preference");

            entity.HasOne(d => d.RecipientPushNotificationAddress)
                .WithMany(p => p.RecipientPushNotificationAddressPreferences)
                .HasForeignKey(d => d.RecipientPushNotificationAddressId)
                .HasConstraintName("FK_RecipientPushNotificationAddressPreference_RecipientAddress");
        });

        modelBuilder.Entity<CommServicesRecipientRecipientType>(entity =>
        {
            entity.ToTable("RecipientType", "Recipient");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}