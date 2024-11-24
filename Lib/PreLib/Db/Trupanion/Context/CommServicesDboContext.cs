using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.CommServices.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class CommServicesDboContext : DbContext
{
    public CommServicesDboContext()
    {
    }

    public CommServicesDboContext(DbContextOptions<CommServicesDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CommServicesDboBatchDeliveryConfiguration> BatchDeliveryConfigurations { get; set; }
    public virtual DbSet<CommServicesDboBatchDeliveryContentConfiguration> BatchDeliveryContentConfigurations { get; set; }
    public virtual DbSet<CommServicesDboCommunication> Communications { get; set; }
    public virtual DbSet<CommServicesDboCommunicationCampaignEntity> CommunicationCampaignEntities { get; set; }
    public virtual DbSet<CommServicesDboCommunicationStatus> CommunicationStatuses { get; set; }
    public virtual DbSet<CommServicesDboDeliveryAddress> DeliveryAddresses { get; set; }
    public virtual DbSet<CommServicesDboDeliveryAdminRecipientContentConfiguration> DeliveryAdminRecipientContentConfigurations { get; set; }
    public virtual DbSet<CommServicesDboDeliveryAttachment> DeliveryAttachments { get; set; }
    public virtual DbSet<CommServicesDboDeliveryContent> DeliveryContents { get; set; }
    public virtual DbSet<CommServicesDboDeliveryInfo> DeliveryInfos { get; set; }
    public virtual DbSet<CommServicesDboDeliveryInfoSendAttempt> DeliveryInfoSendAttempts { get; set; }
    public virtual DbSet<CommServicesDboDeliveryMedium> DeliveryMedia { get; set; }
    public virtual DbSet<CommServicesDboDeliverySenderContentConfiguration> DeliverySenderContentConfigurations { get; set; }
    public virtual DbSet<CommServicesDboDeliveryStatus> DeliveryStatuses { get; set; }
    public virtual DbSet<CommServicesDboDeliveryStrategyValidationStatus> DeliveryStrategyValidationStatuses { get; set; }
    public virtual DbSet<CommServicesDboExchangeService> ExchangeServices { get; set; }
    public virtual DbSet<CommServicesDboInboundCommunication> InboundCommunications { get; set; }
    public virtual DbSet<CommServicesDboInboundCommunicationSenderRecipient> InboundCommunicationSenderRecipients { get; set; }
    public virtual DbSet<CommServicesDboMailbox> Mailboxes { get; set; }
    public virtual DbSet<CommServicesDboTwilioAccount> TwilioAccounts { get; set; }
    public virtual DbSet<CommServicesDboTwilioSmsChannel> TwilioSmsChannels { get; set; }
    public virtual DbSet<CommServicesDboTwilioSmsChannelAction> TwilioSmsChannelActions { get; set; }
    public virtual DbSet<CommServicesDboTwilioSmsChannelActionResponse> TwilioSmsChannelActionResponses { get; set; }
    public virtual DbSet<CommServicesDboTwilioSmsChannelAddress> TwilioSmsChannelAddresses { get; set; }
    public virtual DbSet<CommServicesDboTwilioSmsChannelTemplate> TwilioSmsChannelTemplates { get; set; }

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

        modelBuilder.Entity<CommServicesDboBatchDeliveryConfiguration>(entity =>
        {
            entity.ToTable("BatchDeliveryConfiguration");

            entity.HasIndex(e => e.TaskInstanceBatchConfigurationId, "uk_batchdeliveryconfiguration_taskinstancebatchconfigurationid")
                .IsUnique();

            entity.Property(e => e.ConditionalSendAbandonOnBouncebackService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryRecipientProjectionTypeName)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.SendAbandonedDeliveryMediumChangedService)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CommServicesDboBatchDeliveryContentConfiguration>(entity =>
        {
            entity.ToTable("BatchDeliveryContentConfiguration");

            entity.HasIndex(e => e.BatchDeliveryConfigurationId, "ix_batchdeliverycontentconfiguration_batchdeliveryconfigurationid");

            entity.HasIndex(e => new { e.BatchDeliveryConfigurationId, e.DeliveryMediumId, e.ContentSectionId, e.TemplateDefinitionId }, "uk_batchdeliverycontentconfiguration_batchdeliveryconfigurationid_deliverymedium_contentsectionid_templatedefinitionid")
                .IsUnique();

            entity.Property(e => e.TemplateDataProjectionTypeName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.BatchDeliveryConfiguration)
                .WithMany(p => p.BatchDeliveryContentConfigurations)
                .HasForeignKey(d => d.BatchDeliveryConfigurationId)
                .HasConstraintName("fk_batchdeliveryconfiguration_batchdeliverycontentconfiguration_batchdeliveryconfigurationid");
        });

        modelBuilder.Entity<CommServicesDboCommunication>(entity =>
        {
            entity.ToTable("Communication");

            entity.HasIndex(e => new { e.RecipientId, e.CampaignId }, "ix_communication_recipientid_campaignid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ScheduledDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CommunicationStatus)
                .WithMany(p => p.Communications)
                .HasForeignKey(d => d.CommunicationStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communication_CommunicationStatus");

            entity.HasOne(d => d.DeliveryInfo)
                .WithMany(p => p.Communications)
                .HasForeignKey(d => d.DeliveryInfoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communication_DeliveryInfo");
        });

        modelBuilder.Entity<CommServicesDboCommunicationCampaignEntity>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_communicationcampaignentity_id")
                .IsClustered(false);

            entity.ToTable("CommunicationCampaignEntity");

            entity.HasIndex(e => new { e.CommunicationId, e.CampaignEntityId, e.EntityId }, "ix_communicationcampaignentity_communicationid_campaignentityid_entityid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.EntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.Communication)
                .WithMany(p => p.CommunicationCampaignEntities)
                .HasForeignKey(d => d.CommunicationId)
                .HasConstraintName("fk_communication_communicationcampaignentity_communicationid");
        });

        modelBuilder.Entity<CommServicesDboCommunicationStatus>(entity =>
        {
            entity.ToTable("CommunicationStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesDboDeliveryAddress>(entity =>
        {
            entity.ToTable("DeliveryAddress");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CommServicesDboDeliveryAdminRecipientContentConfiguration>(entity =>
        {
            entity.ToTable("DeliveryAdminRecipientContentConfiguration");

            entity.Property(e => e.SendToCc).HasColumnName("SendToCC");

            entity.HasOne(d => d.DeliveryAddress)
                .WithMany(p => p.DeliveryAdminRecipientContentConfigurations)
                .HasForeignKey(d => d.DeliveryAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_deliveryaddress_deliveryadminrecipientcontentconfiguration_deliveryaddressid");
        });

        modelBuilder.Entity<CommServicesDboDeliveryAttachment>(entity =>
        {
            entity.ToTable("DeliveryAttachment");

            entity.HasIndex(e => e.DeliveryInfoId, "ix_DeliveryAttachment_DeliveryInfoId");

            entity.Property(e => e.AttachmentContents).IsRequired();

            entity.Property(e => e.DeliveryInfoId).HasDefaultValueSql("((-1))");

            entity.HasOne(d => d.DeliveryInfo)
                .WithMany(p => p.DeliveryAttachments)
                .HasForeignKey(d => d.DeliveryInfoId)
                .HasConstraintName("fk_deliveryinfo_deliveryattachment_deliveryinfoid");
        });

        modelBuilder.Entity<CommServicesDboDeliveryContent>(entity =>
        {
            entity.ToTable("DeliveryContent");

            entity.HasIndex(e => e.DeliveryInfoId, "ix_deliverycontent_deliveryinfoid");

            entity.Property(e => e.Content).IsRequired();

            entity.HasOne(d => d.DeliveryInfo)
                .WithMany(p => p.DeliveryContents)
                .HasForeignKey(d => d.DeliveryInfoId)
                .HasConstraintName("fk_deliveryinfo_deliverycontent_deliveryinfoid");
        });

        modelBuilder.Entity<CommServicesDboDeliveryInfo>(entity =>
        {
            entity.ToTable("DeliveryInfo");

            entity.HasIndex(e => e.PreferredDeliveryMedium, "ix_delivery_deliverymedium");

            entity.HasIndex(e => e.DeliveryStatusId, "ix_deliveryinfo_deliverystatusid");

            entity.HasIndex(e => e.DeliveryStrategyValidationStatusId, "ix_deliveryinfo_deliverystrategyvalidationstatusid");

            entity.Property(e => e.ArchivedDocumentId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryRecipientProjectionTypeName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.EntityId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PreferredLanguageCode)
                .IsRequired()
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.DeliveryStatus)
                .WithMany(p => p.DeliveryInfos)
                .HasForeignKey(d => d.DeliveryStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_deliverystatus_deliveryinfo_deliverystatusid");

            entity.HasOne(d => d.DeliveryStrategyValidationStatus)
                .WithMany(p => p.DeliveryInfos)
                .HasForeignKey(d => d.DeliveryStrategyValidationStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_deliverystrategyvalidationstatus_deliveryinfo_deliverystrategyvalidationstatusid");

            entity.HasOne(d => d.PreferredDeliveryMediumNavigation)
                .WithMany(p => p.DeliveryInfos)
                .HasForeignKey(d => d.PreferredDeliveryMedium)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_deliverymedium_deliveryinfo_preferreddeliverymedium");
        });

        modelBuilder.Entity<CommServicesDboDeliveryInfoSendAttempt>(entity =>
        {
            entity.ToTable("DeliveryInfoSendAttempt");

            entity.HasIndex(e => e.DeliveryInfoId, "ix_deliveryinfosendattempt_deliveryinfoid");

            entity.HasIndex(e => e.StrategySpecificDeliveryId, "ix_deliveryinfosendattempt_strategyspecificdeliveryid");

            entity.Property(e => e.Message).IsUnicode(false);

            entity.Property(e => e.SentWithStrategy)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.SerializedException).IsUnicode(false);

            entity.Property(e => e.StatusCode)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StrategySpecificDeliveryId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.DeliveryInfo)
                .WithMany(p => p.DeliveryInfoSendAttempts)
                .HasForeignKey(d => d.DeliveryInfoId)
                .HasConstraintName("fk_deliveryinfo_deliveryinfosendattempt_deliveryinfoid");
        });

        modelBuilder.Entity<CommServicesDboDeliveryMedium>(entity =>
        {
            entity.ToTable("DeliveryMedium");

            entity.HasIndex(e => e.Name, "uk_deliverymedium_name")
                .IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesDboDeliverySenderContentConfiguration>(entity =>
        {
            entity.ToTable("DeliverySenderContentConfiguration");

            entity.HasOne(d => d.DeliveryAddress)
                .WithMany(p => p.DeliverySenderContentConfigurations)
                .HasForeignKey(d => d.DeliveryAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_deliveryaddress_deliverysendercontentconfiguration_deliveryaddressid");
        });

        modelBuilder.Entity<CommServicesDboDeliveryStatus>(entity =>
        {
            entity.ToTable("DeliveryStatus");

            entity.HasIndex(e => e.Name, "uk_deliverystatus_name")
                .IsUnique();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesDboDeliveryStrategyValidationStatus>(entity =>
        {
            entity.ToTable("DeliveryStrategyValidationStatus");

            entity.HasIndex(e => e.Name, "uk_deliverystrategyvalidationstatus")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesDboExchangeService>(entity =>
        {
            entity.ToTable("ExchangeService");

            entity.HasIndex(e => e.Url, "uk_exchangeservice_emailaddress")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_exchangeservice_uniqueid")
                .IsUnique();

            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CommServicesDboInboundCommunication>(entity =>
        {
            entity.ToTable("InboundCommunication");

            entity.Property(e => e.FromAddress).IsRequired();

            entity.Property(e => e.Message).IsRequired();

            entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

            entity.Property(e => e.ToAddress).IsRequired();
        });

        modelBuilder.Entity<CommServicesDboInboundCommunicationSenderRecipient>(entity =>
        {
            entity.ToTable("InboundCommunicationSenderRecipient");

            entity.HasIndex(e => e.InboundCommunicationId, "ix_inboundcommunicationsenderrecipient_inboundcommunicationid");
        });

        modelBuilder.Entity<CommServicesDboMailbox>(entity =>
        {
            entity.ToTable("Mailbox");

            entity.HasIndex(e => e.EmailAddress, "uk_mailbox_emailaddress")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_mailbox_uniqueid")
                .IsUnique();

            entity.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ExchangeService)
                .WithMany(p => p.Mailboxes)
                .HasForeignKey(d => d.ExchangeServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_mailbox_exchangeservice");
        });

        modelBuilder.Entity<CommServicesDboTwilioAccount>(entity =>
        {
            entity.ToTable("TwilioAccount");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AccountSid)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Token)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<CommServicesDboTwilioSmsChannel>(entity =>
        {
            entity.ToTable("TwilioSmsChannel");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.From)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesDboTwilioSmsChannelAction>(entity =>
        {
            entity.ToTable("TwilioSmsChannelAction");

            entity.HasIndex(e => e.ActionId, "Unq_TwilioSmsChannelAction_ActionId")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Keywords).HasMaxLength(500);

            entity.Property(e => e.Response).HasMaxLength(1000);
        });

        modelBuilder.Entity<CommServicesDboTwilioSmsChannelActionResponse>(entity =>
        {
            entity.ToTable("TwilioSmsChannelActionResponse");

            entity.HasIndex(e => new { e.TwilioSmsChannelActionId, e.IsoAlpha3CountryCode }, "Unq_TwilioSmsChannelActionResponse_TwilioSmsChannelActionId_IsoAlpha3CountryCode")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.HasOne(d => d.TwilioSmsChannelAction)
                .WithMany(p => p.TwilioSmsChannelActionResponses)
                .HasForeignKey(d => d.TwilioSmsChannelActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TwilioSmsChannelActionResponse_TwilioSmsChannelActionId");
        });

        modelBuilder.Entity<CommServicesDboTwilioSmsChannelAddress>(entity =>
        {
            entity.ToTable("TwilioSmsChannelAddress");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CommServicesDboTwilioSmsChannelTemplate>(entity =>
        {
            entity.ToTable("TwilioSmsChannelTemplate");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.TwilioSmsChannel)
                .WithMany(p => p.TwilioSmsChannelTemplates)
                .HasForeignKey(d => d.TwilioSmsChannelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TwilioSmsChannelTemplate_TwilioSmsChannel");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}