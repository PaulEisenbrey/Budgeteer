using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.EnterpriseCatalog.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class EnterpriseCatalogDboContext : DbContext
{
    public EnterpriseCatalogDboContext()
    {
    }

    public EnterpriseCatalogDboContext(DbContextOptions<EnterpriseCatalogDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EnterpriseCatalogDboApplicationEnvironment> ApplicationEnvironments { get; set; }
    public virtual DbSet<EnterpriseCatalogDboApplicationHost> ApplicationHosts { get; set; }
    public virtual DbSet<EnterpriseCatalogDboCacheType> CacheTypes { get; set; }
    public virtual DbSet<EnterpriseCatalogDboDeletedRow> DeletedRows { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplication> EnterpriseApplications { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationEventFilter> EnterpriseApplicationEventFilters { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationEventHandler> EnterpriseApplicationEventHandlers { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationGlobalEventHandler> EnterpriseApplicationGlobalEventHandlers { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationHost> EnterpriseApplicationHosts { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationHostConfig> EnterpriseApplicationHostConfigs { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationStatisticConfig> EnterpriseApplicationStatisticConfigs { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseApplicationSystemGlobalEventHandler> EnterpriseApplicationSystemGlobalEventHandlers { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseCategory> EnterpriseCategories { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEntity> EnterpriseEntities { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEntityAlias> EnterpriseEntityAliases { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEntityAliasCachingConfiguration> EnterpriseEntityAliasCachingConfigurations { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEntityCachingConfiguration> EnterpriseEntityCachingConfigurations { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEntityLock> EnterpriseEntityLocks { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEntityType> EnterpriseEntityTypes { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseError> EnterpriseErrors { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseErrorText> EnterpriseErrorTexts { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseEvent> EnterpriseEvents { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterpriseHost> EnterpriseHosts { get; set; }
    public virtual DbSet<EnterpriseCatalogDboEnterprisePlatform> EnterprisePlatforms { get; set; }
    public virtual DbSet<EnterpriseCatalogDboJobRun> JobRuns { get; set; }
    public virtual DbSet<EnterpriseCatalogDboJobType> JobTypes { get; set; }
    public virtual DbSet<EnterpriseCatalogDboMessageIntervention> MessageInterventions { get; set; }
    public virtual DbSet<EnterpriseCatalogDboMessageInterventionArchive> MessageInterventionArchives { get; set; }
    public virtual DbSet<EnterpriseCatalogDboMessageInterventionExceptionInfo> MessageInterventionExceptionInfos { get; set; }
    public virtual DbSet<EnterpriseCatalogDboMessageRetry> MessageRetries { get; set; }
    public virtual DbSet<EnterpriseCatalogDboStatisticString> StatisticStrings { get; set; }
    public virtual DbSet<EnterpriseCatalogDboVersionedDatum> VersionedData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.enterprisecatalog), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<EnterpriseCatalogDboApplicationEnvironment>(entity =>
        {
            entity.ToTable("ApplicationEnvironment");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_applicationenvironment_configurationversionid");

            entity.HasIndex(e => e.Name, "uk_applicationenvironment_name")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',[Name]+CONVERT([varchar],[IsProduction])))", true);
        });

        modelBuilder.Entity<EnterpriseCatalogDboApplicationHost>(entity =>
        {
            entity.ToTable("ApplicationHost");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_applicationhost_configurationversionid");

            entity.HasIndex(e => e.Name, "uk_applicationhost_name")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',[Name]+CONVERT([varchar],[IsOwinCapable])))", true);
        });

        modelBuilder.Entity<EnterpriseCatalogDboCacheType>(entity =>
        {
            entity.ToTable("CacheType");

            entity.HasIndex(e => e.Name, "uk_cachetype_name")
                .IsUnique();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EnterpriseCatalogDboDeletedRow>(entity =>
        {
            entity.HasIndex(e => e.ConfigurationVersionId, "ix_deletedrows_configurationversionid");

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.DeletedType).HasMaxLength(100);
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplication>(entity =>
        {
            entity.ToTable("EnterpriseApplication");

            entity.HasIndex(e => e.ApplicationHostId, "ix_enterpriseapplication_applicationhostid");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplication_configurationversionid");

            entity.HasIndex(e => e.EnterprisePlatformId, "ix_enterpriseapplication_enterpriseplatformid");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplicationhostconfig_configurationversionid");

            entity.HasIndex(e => e.Name, "uk_enterpriseapplication_name")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.EndPointUrl).HasMaxLength(100);

            entity.Property(e => e.EndpointPersistenceConnectionStringId)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PingInterval).HasDefaultValueSql("((60))");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((((((([Name]+isnull(CONVERT([varchar],[EnterprisePlatformId]),'na'))+CONVERT([varchar],[ApplicationHostId]))+CONVERT([varchar],[BroadcastStatus]))+CONVERT([varchar],[PingInterval]))+CONVERT([varchar],[IsClientApplication]))+isnull([EndPointUrl],'na'))+isnull([EndpointPersistenceConnectionStringId],'na'))+isnull(CONVERT([varchar],[CanHandleMessages]),'na')))", true);

            entity.HasOne(d => d.ApplicationHost)
                .WithMany(p => p.EnterpriseApplications)
                .HasForeignKey(d => d.ApplicationHostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_applicationhost_enterpriseapplication_applicationhostid");

            entity.HasOne(d => d.EnterprisePlatform)
                .WithMany(p => p.EnterpriseApplications)
                .HasForeignKey(d => d.EnterprisePlatformId)
                .HasConstraintName("fk_enterpriseplatform_enterpriseapplication_enterpriseplatformid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationEventFilter>(entity =>
        {
            entity.ToTable("EnterpriseApplicationEventFilter");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplicationeventfilter_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationEventHandlerId, "ix_enterpriseapplicationeventfilter_enterpriseapplicationeventhandlerid");

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.ForCustomAttributes)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((((((((CONVERT([varchar],[EnterpriseApplicationEventHandlerId])+isnull(CONVERT([varchar],[ForEnterprisePlatformId]),'na'))+isnull(CONVERT([varchar],[ForEnterpriseApplicationId]),'na'))+isnull(CONVERT([varchar],[ForEnterpriseHostId]),'na'))+isnull(CONVERT([varchar],[ForEnterpriseEventCategoryId]),'na'))+isnull(CONVERT([varchar],[ForEnterpriseEventPlatformId]),'na'))+isnull(CONVERT([varchar],[ForEnterpriseEventId]),'na'))+isnull(CONVERT([varchar](50),[ForCurrentUserId]),'na'))+isnull(CONVERT([varchar],[ForTargetEnterpriseApplicationId]),'na'))+isnull([ForCustomAttributes],'na')))", true);

            entity.HasOne(d => d.EnterpriseApplicationEventHandler)
                .WithMany(p => p.EnterpriseApplicationEventFilters)
                .HasForeignKey(d => d.EnterpriseApplicationEventHandlerId)
                .HasConstraintName("fk_enterpriseapplicationeventhandler_enterpriseapplicationeventfilter_enterpriseapplicationeventhandlerid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationEventHandler>(entity =>
        {
            entity.ToTable("EnterpriseApplicationEventHandler");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplicationeventhandler_configurationversionid");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.ConfigurationVersionId }, "ix_enterpriseapplicationeventhandler_enterpriseapplicationid");

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.EventHandlerClassName)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.InstanceCount).HasDefaultValueSql("((1))");

            entity.Property(e => e.ManualInterventionService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.RequiresManualInterventionOnException)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.RetryEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((((((((((isnull(CONVERT([varchar],[EnterpriseApplicationId]),'na')+[EventHandlerClassName])+CONVERT([varchar],[SendImmediateStatistics]))+CONVERT([varchar],[StatisticsDisabled]))+CONVERT([varchar],[RetryEnabled]))+CONVERT([varchar],[RequiresManualInterventionOnException]))+isnull([ManualInterventionService],'na'))+isnull(CONVERT([varchar],[SubscriptionType]),'na'))+CONVERT([varchar],[Transacted]))+isnull([Configuration],'na'))+CONVERT([varchar],[InstanceCount]))+CONVERT([varchar],[Lazy])))", true);

            entity.Property(e => e.Transacted)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.EnterpriseApplicationEventHandlers)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_enterpriseapplicationeventhandler_enterpriseapplicationid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationGlobalEventHandler>(entity =>
        {
            entity.ToTable("EnterpriseApplicationGlobalEventHandler");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplicationglobaleventhandler_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationEventHandlerId, "uk_enterpriseapplicationglobaleventhandler_enterpriseapplicationeventhandlerid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',CONVERT([varchar],[EnterpriseApplicationEventHandlerId])+CONVERT([varchar],[Targeted])))", true);

            entity.Property(e => e.Targeted)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.EnterpriseApplicationEventHandler)
                .WithOne(p => p.EnterpriseApplicationGlobalEventHandler)
                .HasForeignKey<EnterpriseCatalogDboEnterpriseApplicationGlobalEventHandler>(d => d.EnterpriseApplicationEventHandlerId)
                .HasConstraintName("fk_enterpriseapplicationglobaleventhandler_enterpriseapplicationeventhandler_enterpriseapplicationeventhandlerid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationHost>(entity =>
        {
            entity.ToTable("EnterpriseApplicationHost");

            entity.HasIndex(e => new { e.Heartbeat, e.IsOnline }, "ix_enterpriseapplicationhost");

            entity.HasIndex(e => e.EnterpriseApplicationId, "ix_enterpriseapplicationhost_enterpriseapplicationid");

            entity.HasIndex(e => e.ApplicationEnvironmentId, "ix_enterpriseapplicationhost_environment");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.EnterpriseHostId, e.ApplicationEnvironmentId, e.Pid }, "uk_enterpriseapplicationhost_enterprisehostid_enterpriseapplicationid_applicationenvironmentid_pid")
                .IsUnique();

            entity.Property(e => e.StartupArgs).IsUnicode(false);

            entity.HasOne(d => d.ApplicationEnvironment)
                .WithMany(p => p.EnterpriseApplicationHosts)
                .HasForeignKey(d => d.ApplicationEnvironmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enterpriseapplicationhost_environment_enterpriseapplicationhost_applicationenvironmentid");

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.EnterpriseApplicationHosts)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enterpriseapplicationhost_enterpriseapplication_enterpriseapplicationhost_enterpriseapplicationid");

            entity.HasOne(d => d.EnterpriseHost)
                .WithMany(p => p.EnterpriseApplicationHosts)
                .HasForeignKey(d => d.EnterpriseHostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enterpriseapplicationhost_enterprisehost_enterpriseapplicationhost_enterprisehostid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationHostConfig>(entity =>
        {
            entity.ToTable("EnterpriseApplicationHostConfig");

            entity.HasIndex(e => e.EndPointUrl, "ix_enterpriseapplicationhostconfig_endpointurl")
                .IsUnique()
                .HasFilter("([EndPointUrl] IS NOT NULL)");

            entity.HasIndex(e => e.EnterpriseApplicationId, "ix_enterpriseapplicationhostconfig_enterpriseapplicationid");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.EnterpriseHostId }, "uk_enterpriseapplicationhostconfig_eaid_ehid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.EndPointUrl).HasMaxLength(100);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(CONVERT([varchar],[EnterpriseApplicationId])+CONVERT([varchar],[EnterpriseHostId]))+isnull([EndPointUrl],'na')))", true);

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.EnterpriseApplicationHostConfigs)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplicationhostconfig_enterpriseapplication");

            entity.HasOne(d => d.EnterpriseHost)
                .WithMany(p => p.EnterpriseApplicationHostConfigs)
                .HasForeignKey(d => d.EnterpriseHostId)
                .HasConstraintName("fk_enterpriseapplicationhostconfig_enterprisehost");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationStatisticConfig>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EnterpriseApplicationStatisticConfig");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplicationstatisticconfig_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationId, "ix_enterpriseapplicationstatisticconfig_enterpriseapplicationid");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.StatisticSource }, "uk_enterpriseapplicationstatisticconfig_enterpriseapplicationid_statisticsource")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(CONVERT([varchar],[EnterpriseApplicationId])+[StatisticSource])+CONVERT([varchar],[Disabled])))", true);

            entity.Property(e => e.StatisticSource)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany()
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_enterpriseapplicationstatisticconfig_enterpriseapplicationid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseApplicationSystemGlobalEventHandler>(entity =>
        {
            entity.ToTable("EnterpriseApplicationSystemGlobalEventHandler");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseapplicationsystemglobaleventhandler_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationEventHandlerId, "uk_enterpriseapplicationsystemglobaleventhandler_enterpriseapplicationeventhandlerid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',CONVERT([varchar],[EnterpriseApplicationEventHandlerId])))", true);

            entity.HasOne(d => d.EnterpriseApplicationEventHandler)
                .WithOne(p => p.EnterpriseApplicationSystemGlobalEventHandler)
                .HasForeignKey<EnterpriseCatalogDboEnterpriseApplicationSystemGlobalEventHandler>(d => d.EnterpriseApplicationEventHandlerId)
                .HasConstraintName("fk_enterpriseapplicationsystemglobaleventhandler_enterpriseapplicationeventhandler_enterpriseapplicationeventhandlerid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseCategory>(entity =>
        {
            entity.ToTable("EnterpriseCategory");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterprisecategory_configurationversionid");

            entity.HasIndex(e => e.ParentId, "ix_enterprisecategory_parentid");

            entity.HasIndex(e => e.Name, "uk_enterprisecategory_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_enterprisecategory_uniqueid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(isnull(CONVERT([varchar],[ParentId]),'na')+CONVERT([varchar](50),[UniqueId]))+[Name]))", true);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEntity>(entity =>
        {
            entity.ToTable("EnterpriseEntity");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseentity_configurationversionid");

            entity.HasIndex(e => e.EnterpriseEntityTypeId, "ix_enterpriseentity_enterpriseentitytypeid");

            entity.HasIndex(e => e.OwningEnterpriseApplicationId, "ix_enterpriseentity_owningenterpriseapplicationid");

            entity.HasIndex(e => e.EntityType, "uk_enterpriseentity_entitytype")
                .IsUnique();

            entity.HasIndex(e => e.Name, "uk_enterpriseentity_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_enterpriseentity_uniqueid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.EnterpriseEntityTypeId).HasDefaultValueSql("((1))");

            entity.Property(e => e.EntityType)
                .IsRequired()
                .HasMaxLength(256);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.ResourceRoute).HasMaxLength(256);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(((CONVERT([varchar](50),[UniqueId])+[Name])+[EntityType])+isnull(CONVERT([varchar],[OwningEnterpriseApplicationId]),'na'))+isnull([ResourceRoute],'na')))", true);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.EnterpriseEntityType)
                .WithMany(p => p.EnterpriseEntities)
                .HasForeignKey(d => d.EnterpriseEntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enterpriseentitytype_enterpriseentity");

            entity.HasOne(d => d.OwningEnterpriseApplication)
                .WithMany(p => p.EnterpriseEntities)
                .HasForeignKey(d => d.OwningEnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_enterpriseentity_owningenterpriseapplicationid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEntityAlias>(entity =>
        {
            entity.ToTable("EnterpriseEntityAlias");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseentityalias_configurationversionid");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityType }, "ix_enterpriseentityalias_enterpriseentityid_entitytype");

            entity.HasIndex(e => new { e.EntityType, e.EnterpriseEntityId }, "ix_enterpriseentityalias_entitytype_enterpriseentityid");

            entity.HasIndex(e => e.EntityType, "uk_enterpriseentityalias_entitytype")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.EntityType)
                .IsRequired()
                .HasMaxLength(256);

            entity.Property(e => e.ResourceRoute).HasMaxLength(256);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((CONVERT([varchar],[EnterpriseEntityId])+[EntityType])+isnull(CONVERT([varchar],[OwningEnterpriseApplicationId]),'na'))+isnull([ResourceRoute],'na')))", true);

            entity.HasOne(d => d.EnterpriseEntity)
                .WithMany(p => p.EnterpriseEntityAliases)
                .HasForeignKey(d => d.EnterpriseEntityId)
                .HasConstraintName("fk_enterpriseentityalias_enterpriseentityid");

            entity.HasOne(d => d.OwningEnterpriseApplication)
                .WithMany(p => p.EnterpriseEntityAliases)
                .HasForeignKey(d => d.OwningEnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_enterpriseentityalias_owningenterpriseapplicationid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEntityAliasCachingConfiguration>(entity =>
        {
            entity.ToTable("EnterpriseEntityAliasCachingConfiguration");

            entity.HasIndex(e => e.CacheTypeId, "ix_enterpriseentityaliascachingconfiguration_cachetypeid");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseentityaliascachingconfiguration_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationId, "ix_enterpriseentityaliascachingconfiguration_enterpriseapplicationid");

            entity.HasIndex(e => new { e.EnterpriseEntityAliasId, e.CacheTypeId, e.EnterpriseApplicationId }, "uk_enterpriseentityaliascachingconfiguration_cachetypeid_enterpriseapplicationid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((CONVERT([varchar],[EnterpriseEntityAliasId])+CONVERT([varchar],[CacheTypeId]))+isnull(CONVERT([varchar],[EnterpriseApplicationId]),'na'))+isnull([ServiceConfiguration],'na')))", true);

            entity.HasOne(d => d.CacheType)
                .WithMany(p => p.EnterpriseEntityAliasCachingConfigurations)
                .HasForeignKey(d => d.CacheTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cachetype_enterpriseentityaliascachingconfiguration_cachetypeid");

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.EnterpriseEntityAliasCachingConfigurations)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_enterpriseentityaliascachingconfiguration_enterpriseappalicationid");

            entity.HasOne(d => d.EnterpriseEntityAlias)
                .WithMany(p => p.EnterpriseEntityAliasCachingConfigurations)
                .HasForeignKey(d => d.EnterpriseEntityAliasId)
                .HasConstraintName("fk_enterpriseentityalias_enterpriseentityaliascachingconfiguration_enterpriseentityaliasid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEntityCachingConfiguration>(entity =>
        {
            entity.ToTable("EnterpriseEntityCachingConfiguration");

            entity.HasIndex(e => e.CacheTypeId, "ix_enterpriseentitycachingconfiguration_cachetypeid");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseentitycachingconfiguration_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationId, "ix_enterpriseentitycachingconfiguration_enterpriseapplicationid");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.CacheTypeId, e.EnterpriseApplicationId }, "uk_enterpriseentitycachingconfiguration_cachetypeid_enterpriseapplicationid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((CONVERT([varchar],[EnterpriseEntityId])+CONVERT([varchar],[CacheTypeId]))+isnull(CONVERT([varchar],[EnterpriseApplicationId]),'na'))+isnull([ServiceConfiguration],'na')))", true);

            entity.HasOne(d => d.CacheType)
                .WithMany(p => p.EnterpriseEntityCachingConfigurations)
                .HasForeignKey(d => d.CacheTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cachetype_enterpriseentitycachingconfiguration_cachetypeid");

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.EnterpriseEntityCachingConfigurations)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_enterpriseentitycachingconfiguration_enterpriseappalicationid");

            entity.HasOne(d => d.EnterpriseEntity)
                .WithMany(p => p.EnterpriseEntityCachingConfigurations)
                .HasForeignKey(d => d.EnterpriseEntityId)
                .HasConstraintName("fk_enterpriseentity_enterpriseentitycachingconfiguration_enterpriseentityid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEntityLock>(entity =>
        {
            entity.ToTable("EnterpriseEntityLock");

            entity.HasIndex(e => e.HeartbeatBrokerHandle, "ix_enterpriseentitylock_brokerconversationhandle");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityId, e.EntityScope, e.LockMode }, "ix_enterpriseentitylock_eeid_eid_es_lm");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityId, e.LockOwner, e.LockOwnerId }, "ix_enterpriseentitylock_eeid_eid_lo_loid");

            entity.HasIndex(e => new { e.LockOwner, e.LockOwnerId }, "ix_enterpriseentitylock_lo_loid");

            entity.HasIndex(e => e.UniqueId, "ix_enterpriseentitylock_uniqueid");

            entity.HasIndex(e => e.UniqueId, "uk_enterpriseentitylock_uniqueid")
                .IsUnique();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getutcdate())");

            entity.Property(e => e.EntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EntityScope)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            entity.Property(e => e.LockOwnerId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.EnterpriseEntity)
                .WithMany(p => p.EnterpriseEntityLocks)
                .HasForeignKey(d => d.EnterpriseEntityId)
                .HasConstraintName("fk_enterpriseentitylock_enterpriseentity");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEntityType>(entity =>
        {
            entity.ToTable("EnterpriseEntityType");

            entity.HasIndex(e => e.Name, "uk_enterpriseentitytype_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseError>(entity =>
        {
            entity.ToTable("EnterpriseError");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseerror_configurationversionid");

            entity.HasIndex(e => e.UniqueCode, "ux_enterpriseerror_uniquecode")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.InternalDescription)
                .IsRequired()
                .HasMaxLength(2000);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(isnull(CONVERT([varchar],[PlatformId]),'na')+CONVERT([varchar],[Code]))+[InternalDescription]))", true);

            entity.Property(e => e.UniqueCode)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasComputedColumnSql("(case when [PlatformId] IS NULL then CONVERT([varchar],[Code]) else (CONVERT([varchar],[PlatformId])+'.')+CONVERT([varchar],[Code]) end)", true);

            entity.HasOne(d => d.Platform)
                .WithMany(p => p.EnterpriseErrors)
                .HasForeignKey(d => d.PlatformId)
                .HasConstraintName("fk_enterpriseerror_enterpriseplatform");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseErrorText>(entity =>
        {
            entity.ToTable("EnterpriseErrorText");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseerrortext_configurationversionid");

            entity.HasIndex(e => new { e.EnterpriseErrorId, e.LanguageCode }, "ix_enterpriseerrortext_enterpriseerrorid_languagecode");

            entity.HasIndex(e => new { e.EnterpriseErrorId, e.LanguageCode }, "uk_enterpriseerrortext_enterpriseerrorid_languagecode")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(CONVERT([varchar],[EnterpriseErrorId])+[LanguageCode])+[Description]))", true);

            entity.HasOne(d => d.EnterpriseError)
                .WithMany(p => p.EnterpriseErrorTexts)
                .HasForeignKey(d => d.EnterpriseErrorId)
                .HasConstraintName("fk_enterpriseerrortext_enterpriseerror");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseEvent>(entity =>
        {
            entity.ToTable("EnterpriseEvent");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseevent_configurationversionid");

            entity.HasIndex(e => e.EnterprisePlatformId, "ix_enterpriseevent_enterpriseplatform");

            entity.HasIndex(e => e.EventCategoryId, "ix_enterpriseevent_eventcategory");

            entity.HasIndex(e => e.Name, "uk_enterpriseevent_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_enterpriseevent_uniqueid")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',((([Name]+CONVERT([varchar](50),[UniqueId]))+isnull(CONVERT([varchar],[EventCategoryId]),'na'))+isnull(CONVERT([varchar],[EnterprisePlatformId]),'na'))+isnull([Description],'na')))", true);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.EnterprisePlatform)
                .WithMany(p => p.EnterpriseEvents)
                .HasForeignKey(d => d.EnterprisePlatformId)
                .HasConstraintName("fk_enterpriseplatform_enterpriseevent_enterpriseplatformid");

            entity.HasOne(d => d.EventCategory)
                .WithMany(p => p.EnterpriseEvents)
                .HasForeignKey(d => d.EventCategoryId)
                .HasConstraintName("fk_enterprisecategory_enterpriseevent_eventcategoryid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterpriseHost>(entity =>
        {
            entity.ToTable("EnterpriseHost");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterprisehost_configurationversionid");

            entity.HasIndex(e => e.Name, "uk_enterprisehost_name")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',[Name]))", true);
        });

        modelBuilder.Entity<EnterpriseCatalogDboEnterprisePlatform>(entity =>
        {
            entity.ToTable("EnterprisePlatform");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_enterpriseplatform_configurationversionid");

            entity.HasIndex(e => e.Name, "uk_enterpriseplatform_name")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.CustomAttributeDescription).IsUnicode(false);

            entity.Property(e => e.CustomAttributeFormat).IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',([Name]+isnull([CustomAttributeFormat],'na'))+isnull([CustomAttributeDescription],'na')))", true);
        });

        modelBuilder.Entity<EnterpriseCatalogDboJobRun>(entity =>
        {
            entity.ToTable("JobRun");

            entity.Property(e => e.MachineName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.JobRuns)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_jobrun_enterpriseapplication_enterpriseapplicationid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboJobType>(entity =>
        {
            entity.ToTable("JobType");

            entity.HasIndex(e => e.Name, "uk_jobtype_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnterpriseCatalogDboMessageIntervention>(entity =>
        {
            entity.ToTable("MessageIntervention");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.EnterpriseHandlerId, e.ResumeComplete }, "ix_messageintervention_enterpriseapplicationid_enterprisehandlerid");

            entity.HasIndex(e => e.EnterpriseHandlerId, "ix_messageintervention_enterprisehandlerid");

            entity.HasIndex(e => e.LocalId, "ix_messageintervention_localid");

            entity.HasIndex(e => e.ProcessInstanceId, "ix_messageintervention_processinstanceid");

            entity.HasIndex(e => e.ResumeComplete, "ix_messageintervention_resumcomplete");

            entity.HasIndex(e => new { e.MessageId, e.EnterpriseHandlerId }, "uk_messageintervention_messageid_enterprisehandlerid")
                .IsUnique();

            entity.Property(e => e.CurrentException).IsUnicode(false);

            entity.Property(e => e.HandlerType)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.MessageId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ResumeNote).IsUnicode(false);

            entity.Property(e => e.SerializedMessage)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.TriggeringMessageId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.MessageInterventions)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enterpriseapplication_messageintervention_enterpriseapplicationid");

            entity.HasOne(d => d.EnterpriseHandler)
                .WithMany(p => p.MessageInterventions)
                .HasForeignKey(d => d.EnterpriseHandlerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enterpriseapplicationeventhandler_messageintervention_enterprisehandlerid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboMessageInterventionArchive>(entity =>
        {
            entity.ToTable("MessageInterventionArchive");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.HandlerType)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.InterventionCreatedOn).HasColumnType("datetime");

            entity.Property(e => e.MessageId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ResolvedException).IsUnicode(false);

            entity.Property(e => e.ResumeNote).IsUnicode(false);

            entity.Property(e => e.SerializedMessage)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.TriggeringMessageId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnterpriseCatalogDboMessageInterventionExceptionInfo>(entity =>
        {
            entity.ToTable("MessageInterventionExceptionInfo");

            entity.HasIndex(e => e.MessageInterventionId, "ix_dbomessageinterventionexceptioninfo");

            entity.Property(e => e.SerializedException)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.SerializedMessage)
                .IsRequired()
                .IsUnicode(false);

            entity.HasOne(d => d.MessageIntervention)
                .WithMany(p => p.MessageInterventionExceptionInfos)
                .HasForeignKey(d => d.MessageInterventionId)
                .HasConstraintName("fk_messageintervention_messageinterventionexceptioninfo_messageinterventionid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboMessageRetry>(entity =>
        {
            entity.ToTable("MessageRetry");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.EnterpriseHandlerId }, "ix_messageretry_enterpriseapplicationid_enterprisehandlerid");

            entity.HasIndex(e => e.EnterpriseHandlerId, "ix_messageretry_enterprisehandlerid");

            entity.HasIndex(e => new { e.MessageId, e.EnterpriseHandlerId }, "uk_messageretry_messageid_enterprisehandlerid")
                .IsUnique();

            entity.Property(e => e.MessageId)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SerializedMessage)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.TriggeringMessageId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.EnterpriseApplication)
                .WithMany(p => p.MessageRetries)
                .HasForeignKey(d => d.EnterpriseApplicationId)
                .HasConstraintName("fk_enterpriseapplication_messageretry_enterpriseapplicationid");

            entity.HasOne(d => d.EnterpriseHandler)
                .WithMany(p => p.MessageRetries)
                .HasForeignKey(d => d.EnterpriseHandlerId)
                .HasConstraintName("fk_enterpriseapplicationeventhandler_messageretry_enterprisehandlerid");
        });

        modelBuilder.Entity<EnterpriseCatalogDboStatisticString>(entity =>
        {
            entity.ToTable("StatisticString");

            entity.HasIndex(e => e.ConfigurationVersionId, "ix_statisticstring_configurationversionid");

            entity.HasIndex(e => e.EnterpriseApplicationId, "ix_statisticstring_enterpriseapplicationid");

            entity.HasIndex(e => new { e.EnterpriseApplicationId, e.StatisticSource, e.String }, "uk_statisticstring_statisticsource_string")
                .IsUnique();

            entity.Property(e => e.ConfigurationVersionId).HasDefaultValueSql("(NEXT VALUE FOR [dbo].[VersionSequence])");

            entity.Property(e => e.RowHash)
                .IsRequired()
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('SHA2_512',(CONVERT([varchar],[EnterpriseApplicationId])+[StatisticSource])+[String]))", true);

            entity.Property(e => e.StatisticSource)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.String)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EnterpriseCatalogDboVersionedDatum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.HasSequence<int>("VersionSequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}