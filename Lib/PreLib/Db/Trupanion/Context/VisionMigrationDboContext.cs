using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationDboContext : DbContext
{
    public VisionMigrationDboContext()
    {
    }

    public VisionMigrationDboContext(DbContextOptions<VisionMigrationDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmDboAilments051823> Ailments051823s { get; set; }
    public virtual DbSet<VmDboBatchQueue> BatchQueues { get; set; }
    public virtual DbSet<VmDboConditionMapFinalImport> ConditionMapFinalImports { get; set; }
    public virtual DbSet<VmDboConditionWithLocationFinalImport> ConditionWithLocationFinalImports { get; set; }
    public virtual DbSet<VmDboCurrentBatch> CurrentBatches { get; set; }
    public virtual DbSet<VmDboDataQualityDefinition> DataQualityDefinitions { get; set; }
    public virtual DbSet<VmDboDataQualityDefinitionJobType> DataQualityDefinitionJobTypes { get; set; }
    public virtual DbSet<VmDboDataQualityExecution> DataQualityExecutions { get; set; }
    public virtual DbSet<VmDboDataQualityResult> DataQualityResults { get; set; }
    public virtual DbSet<VmDboDataQualityResultItem> DataQualityResultItems { get; set; }
    public virtual DbSet<VmDboJob> Jobs { get; set; }
    public virtual DbSet<VmDboJobLogEntry> JobLogEntries { get; set; }
    public virtual DbSet<VmDboJobParameter> JobParameters { get; set; }
    public virtual DbSet<VmDboJobStatus> JobStatuses { get; set; }
    public virtual DbSet<VmDboJobType> JobTypes { get; set; }
    public virtual DbSet<VmDboJobTypeParameter> JobTypeParameters { get; set; }
    public virtual DbSet<VmDboQrtzBlobTrigger> QrtzBlobTriggers { get; set; }
    public virtual DbSet<VmDboQrtzCalendar> QrtzCalendars { get; set; }
    public virtual DbSet<VmDboQrtzCronTrigger> QrtzCronTriggers { get; set; }
    public virtual DbSet<VmDboQrtzFiredTrigger> QrtzFiredTriggers { get; set; }
    public virtual DbSet<VmDboQrtzJobDetail> QrtzJobDetails { get; set; }
    public virtual DbSet<VmDboQrtzLock> QrtzLocks { get; set; }
    public virtual DbSet<VmDboQrtzPausedTriggerGrp> QrtzPausedTriggerGrps { get; set; }
    public virtual DbSet<VmDboQrtzSchedulerState> QrtzSchedulerStates { get; set; }
    public virtual DbSet<VmDboQrtzSimpleTrigger> QrtzSimpleTriggers { get; set; }
    public virtual DbSet<VmDboQrtzSimpropTrigger> QrtzSimpropTriggers { get; set; }
    public virtual DbSet<VmDboQrtzTrigger> QrtzTriggers { get; set; }
    public virtual DbSet<VmDboSegment> Segments { get; set; }
    public virtual DbSet<VmDboSegmentBatch> SegmentBatches { get; set; }
    public virtual DbSet<VmDboSegmentBatchClaim> SegmentBatchClaims { get; set; }
    public virtual DbSet<VmDboSegmentBatchClaimPayment> SegmentBatchClaimPayments { get; set; }
    public virtual DbSet<VmDboSegmentBatchClaimVersion> SegmentBatchClaimVersions { get; set; }
    public virtual DbSet<VmDboSegmentBatchOwner> SegmentBatchOwners { get; set; }
    public virtual DbSet<VmDboSegmentBatchPet> SegmentBatchPets { get; set; }
    public virtual DbSet<VmDboSegmentOwner> SegmentOwners { get; set; }
    public virtual DbSet<VmDboSegmentSelectionScript> SegmentSelectionScripts { get; set; }
    public virtual DbSet<VmDboSegmentType> SegmentTypes { get; set; }

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

        modelBuilder.Entity<VmDboAilments051823>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Ailments_051823");

            entity.Property(e => e.FirstCause)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.SecondCause)
                .IsRequired()
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmDboBatchQueue>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BatchQueue");

            entity.Property(e => e.FinishedOn).HasColumnType("datetime");

            entity.Property(e => e.QueuedOn).HasColumnType("datetime");

            entity.Property(e => e.ScheduledOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmDboConditionMapFinalImport>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ConditionMapFinal_import");

            entity.Property(e => e.CondType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.ConditionName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.VenomCondition).IsRequired();
        });

        modelBuilder.Entity<VmDboConditionWithLocationFinalImport>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("conditionWithLocationFinal_import");

            entity.Property(e => e.LegacyCond)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("legacy_cond");

            entity.Property(e => e.LegacyCondId).HasColumnName("legacy_cond_id");

            entity.Property(e => e.LegacyLoc)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("legacy_loc");

            entity.Property(e => e.LegacyLocId).HasColumnName("legacy_loc_id");

            entity.Property(e => e.ParentLocation).HasColumnName("parent_location");

            entity.Property(e => e.VenomCode)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("venom_code");

            entity.Property(e => e.VenomId).HasColumnName("venom_id");
        });

        modelBuilder.Entity<VmDboCurrentBatch>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CurrentBatch");
        });

        modelBuilder.Entity<VmDboDataQualityDefinition>(entity =>
        {
            entity.ToTable("DataQualityDefinition");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.FixQuery).IsRequired();

            entity.Property(e => e.Name).IsRequired();

            entity.Property(e => e.ResultQuery).IsRequired();
        });

        modelBuilder.Entity<VmDboDataQualityDefinitionJobType>(entity =>
        {
            entity.HasKey(e => new { e.DataQualityDefinitionId, e.JobTypeId });

            entity.ToTable("DataQualityDefinitionJobType");

            entity.HasOne(d => d.DataQualityDefinition)
                .WithMany(p => p.DataQualityDefinitionJobTypes)
                .HasForeignKey(d => d.DataQualityDefinitionId);

            entity.HasOne(d => d.JobType)
                .WithMany(p => p.DataQualityDefinitionJobTypes)
                .HasForeignKey(d => d.JobTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VmDboDataQualityExecution>(entity =>
        {
            entity.ToTable("DataQualityExecution");

            entity.HasIndex(e => e.JobId, "IX_DataQualityExecution_JobId");

            entity.HasIndex(e => e.SegmentId, "IX_DataQualityExecution_SegmentId");

            entity.HasOne(d => d.Job)
                .WithMany(p => p.DataQualityExecutions)
                .HasForeignKey(d => d.JobId);

            entity.HasOne(d => d.Segment)
                .WithMany(p => p.DataQualityExecutions)
                .HasForeignKey(d => d.SegmentId);
        });

        modelBuilder.Entity<VmDboDataQualityResult>(entity =>
        {
            entity.ToTable("DataQualityResult");

            entity.HasIndex(e => e.DefinitionId, "IX_DataQualityResult_DefinitionId");

            entity.HasIndex(e => e.ExecutionId, "IX_DataQualityResult_ExecutionId");

            entity.HasOne(d => d.Definition)
                .WithMany(p => p.DataQualityResults)
                .HasForeignKey(d => d.DefinitionId);

            entity.HasOne(d => d.Execution)
                .WithMany(p => p.DataQualityResults)
                .HasForeignKey(d => d.ExecutionId);
        });

        modelBuilder.Entity<VmDboDataQualityResultItem>(entity =>
        {
            entity.ToTable("DataQualityResultItem");

            entity.HasIndex(e => e.DataQualityResultId, "IX_DataQualityResultItem_DataQualityResultId");

            entity.HasOne(d => d.DataQualityResult)
                .WithMany(p => p.DataQualityResultItems)
                .HasForeignKey(d => d.DataQualityResultId);
        });

        modelBuilder.Entity<VmDboJob>(entity =>
        {
            entity.ToTable("Job");

            entity.HasIndex(e => e.SegmentId, "IX_Job_SegmentId");

            entity.Property(e => e.Complete).HasColumnType("datetime");

            entity.Property(e => e.SegmentId).HasDefaultValueSql("((1))");

            entity.Property(e => e.Start).HasColumnType("datetime");

            entity.Property(e => e.SuppressChildJobs)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.JobType)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.JobTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_jobtype");

            entity.HasOne(d => d.Segment)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.SegmentId);

            entity.HasOne(d => d.Status)
                .WithMany(p => p.Jobs)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_job_jobstatus");
        });

        modelBuilder.Entity<VmDboJobLogEntry>(entity =>
        {
            entity.ToTable("JobLogEntry");

            entity.HasIndex(e => e.JobId, "ix_joblogentry_jobid");

            entity.HasIndex(e => e.Level, "ix_joblogentry_level");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Level)
                .IsRequired()
                .HasMaxLength(20);

            entity.HasOne(d => d.Job)
                .WithMany(p => p.JobLogEntries)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("fk_joblogentry_job");
        });

        modelBuilder.Entity<VmDboJobParameter>(entity =>
        {
            entity.ToTable("JobParameter");

            entity.HasIndex(e => e.JobId, "IX_JobParameter_JobId");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Job)
                .WithMany(p => p.JobParameters)
                .HasForeignKey(d => d.JobId);
        });

        modelBuilder.Entity<VmDboJobStatus>(entity =>
        {
            entity.ToTable("JobStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<VmDboJobType>(entity =>
        {
            entity.ToTable("JobType");

            entity.HasIndex(e => e.RequiredSegmentTypeId, "IX_JobType_RequiredSegmentTypeId");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.RequiredSegmentTypeId).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.RequiredSegmentType)
                .WithMany(p => p.JobTypes)
                .HasForeignKey(d => d.RequiredSegmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VmDboJobTypeParameter>(entity =>
        {
            entity.ToTable("JobTypeParameter");

            entity.HasIndex(e => e.JobTypeId, "IX_JobTypeParameter_JobTypeId");

            entity.Property(e => e.DefaultValue)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.JobType)
                .WithMany(p => p.JobTypeParameters)
                .HasForeignKey(d => d.JobTypeId);
        });

        modelBuilder.Entity<VmDboQrtzBlobTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_BLOB_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");

            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");

            entity.Property(e => e.BlobData).HasColumnName("BLOB_DATA");
        });

        modelBuilder.Entity<VmDboQrtzCalendar>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.CalendarName });

            entity.ToTable("QRTZ_CALENDARS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.CalendarName)
                .HasMaxLength(200)
                .HasColumnName("CALENDAR_NAME");

            entity.Property(e => e.Calendar)
                .IsRequired()
                .HasColumnName("CALENDAR");
        });

        modelBuilder.Entity<VmDboQrtzCronTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_CRON_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");

            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");

            entity.Property(e => e.CronExpression)
                .IsRequired()
                .HasMaxLength(120)
                .HasColumnName("CRON_EXPRESSION");

            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(80)
                .HasColumnName("TIME_ZONE_ID");

            entity.HasOne(d => d.QrtzTrigger)
                .WithOne(p => p.QrtzCronTrigger)
                .HasForeignKey<VmDboQrtzCronTrigger>(d => new { d.SchedName, d.TriggerName, d.TriggerGroup })
                .HasConstraintName("FK_QRTZ_CRON_TRIGGERS_QRTZ_TRIGGERS");
        });

        modelBuilder.Entity<VmDboQrtzFiredTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.EntryId });

            entity.ToTable("QRTZ_FIRED_TRIGGERS");

            entity.HasIndex(e => new { e.SchedName, e.JobGroup, e.JobName }, "IDX_QRTZ_FT_G_J");

            entity.HasIndex(e => new { e.SchedName, e.TriggerGroup, e.TriggerName }, "IDX_QRTZ_FT_G_T");

            entity.HasIndex(e => new { e.SchedName, e.InstanceName, e.RequestsRecovery }, "IDX_QRTZ_FT_INST_JOB_REQ_RCVRY");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.EntryId)
                .HasMaxLength(140)
                .HasColumnName("ENTRY_ID");

            entity.Property(e => e.FiredTime).HasColumnName("FIRED_TIME");

            entity.Property(e => e.InstanceName)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("INSTANCE_NAME");

            entity.Property(e => e.IsNonconcurrent).HasColumnName("IS_NONCONCURRENT");

            entity.Property(e => e.JobGroup)
                .HasMaxLength(150)
                .HasColumnName("JOB_GROUP");

            entity.Property(e => e.JobName)
                .HasMaxLength(150)
                .HasColumnName("JOB_NAME");

            entity.Property(e => e.Priority).HasColumnName("PRIORITY");

            entity.Property(e => e.RequestsRecovery).HasColumnName("REQUESTS_RECOVERY");

            entity.Property(e => e.SchedTime).HasColumnName("SCHED_TIME");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(16)
                .HasColumnName("STATE");

            entity.Property(e => e.TriggerGroup)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");

            entity.Property(e => e.TriggerName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");
        });

        modelBuilder.Entity<VmDboQrtzJobDetail>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.JobName, e.JobGroup });

            entity.ToTable("QRTZ_JOB_DETAILS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.JobName)
                .HasMaxLength(150)
                .HasColumnName("JOB_NAME");

            entity.Property(e => e.JobGroup)
                .HasMaxLength(150)
                .HasColumnName("JOB_GROUP");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");

            entity.Property(e => e.IsDurable).HasColumnName("IS_DURABLE");

            entity.Property(e => e.IsNonconcurrent).HasColumnName("IS_NONCONCURRENT");

            entity.Property(e => e.IsUpdateData).HasColumnName("IS_UPDATE_DATA");

            entity.Property(e => e.JobClassName)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("JOB_CLASS_NAME");

            entity.Property(e => e.JobData).HasColumnName("JOB_DATA");

            entity.Property(e => e.RequestsRecovery).HasColumnName("REQUESTS_RECOVERY");
        });

        modelBuilder.Entity<VmDboQrtzLock>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.LockName });

            entity.ToTable("QRTZ_LOCKS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.LockName)
                .HasMaxLength(40)
                .HasColumnName("LOCK_NAME");
        });

        modelBuilder.Entity<VmDboQrtzPausedTriggerGrp>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerGroup });

            entity.ToTable("QRTZ_PAUSED_TRIGGER_GRPS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");
        });

        modelBuilder.Entity<VmDboQrtzSchedulerState>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.InstanceName });

            entity.ToTable("QRTZ_SCHEDULER_STATE");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.InstanceName)
                .HasMaxLength(200)
                .HasColumnName("INSTANCE_NAME");

            entity.Property(e => e.CheckinInterval).HasColumnName("CHECKIN_INTERVAL");

            entity.Property(e => e.LastCheckinTime).HasColumnName("LAST_CHECKIN_TIME");
        });

        modelBuilder.Entity<VmDboQrtzSimpleTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_SIMPLE_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");

            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");

            entity.Property(e => e.RepeatCount).HasColumnName("REPEAT_COUNT");

            entity.Property(e => e.RepeatInterval).HasColumnName("REPEAT_INTERVAL");

            entity.Property(e => e.TimesTriggered).HasColumnName("TIMES_TRIGGERED");

            entity.HasOne(d => d.QrtzTrigger)
                .WithOne(p => p.QrtzSimpleTrigger)
                .HasForeignKey<VmDboQrtzSimpleTrigger>(d => new { d.SchedName, d.TriggerName, d.TriggerGroup })
                .HasConstraintName("FK_QRTZ_SIMPLE_TRIGGERS_QRTZ_TRIGGERS");
        });

        modelBuilder.Entity<VmDboQrtzSimpropTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_SIMPROP_TRIGGERS");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");

            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");

            entity.Property(e => e.BoolProp1).HasColumnName("BOOL_PROP_1");

            entity.Property(e => e.BoolProp2).HasColumnName("BOOL_PROP_2");

            entity.Property(e => e.DecProp1)
                .HasColumnType("numeric(13, 4)")
                .HasColumnName("DEC_PROP_1");

            entity.Property(e => e.DecProp2)
                .HasColumnType("numeric(13, 4)")
                .HasColumnName("DEC_PROP_2");

            entity.Property(e => e.IntProp1).HasColumnName("INT_PROP_1");

            entity.Property(e => e.IntProp2).HasColumnName("INT_PROP_2");

            entity.Property(e => e.LongProp1).HasColumnName("LONG_PROP_1");

            entity.Property(e => e.LongProp2).HasColumnName("LONG_PROP_2");

            entity.Property(e => e.StrProp1)
                .HasMaxLength(512)
                .HasColumnName("STR_PROP_1");

            entity.Property(e => e.StrProp2)
                .HasMaxLength(512)
                .HasColumnName("STR_PROP_2");

            entity.Property(e => e.StrProp3)
                .HasMaxLength(512)
                .HasColumnName("STR_PROP_3");

            entity.Property(e => e.TimeZoneId)
                .HasMaxLength(80)
                .HasColumnName("TIME_ZONE_ID");

            entity.HasOne(d => d.QrtzTrigger)
                .WithOne(p => p.QrtzSimpropTrigger)
                .HasForeignKey<VmDboQrtzSimpropTrigger>(d => new { d.SchedName, d.TriggerName, d.TriggerGroup })
                .HasConstraintName("FK_QRTZ_SIMPROP_TRIGGERS_QRTZ_TRIGGERS");
        });

        modelBuilder.Entity<VmDboQrtzTrigger>(entity =>
        {
            entity.HasKey(e => new { e.SchedName, e.TriggerName, e.TriggerGroup });

            entity.ToTable("QRTZ_TRIGGERS");

            entity.HasIndex(e => new { e.SchedName, e.CalendarName }, "IDX_QRTZ_T_C");

            entity.HasIndex(e => new { e.SchedName, e.JobGroup, e.JobName }, "IDX_QRTZ_T_G_J");

            entity.HasIndex(e => new { e.SchedName, e.NextFireTime }, "IDX_QRTZ_T_NEXT_FIRE_TIME");

            entity.HasIndex(e => new { e.SchedName, e.TriggerState, e.NextFireTime }, "IDX_QRTZ_T_NFT_ST");

            entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime, e.TriggerState }, "IDX_QRTZ_T_NFT_ST_MISFIRE");

            entity.HasIndex(e => new { e.SchedName, e.MisfireInstr, e.NextFireTime, e.TriggerGroup, e.TriggerState }, "IDX_QRTZ_T_NFT_ST_MISFIRE_GRP");

            entity.HasIndex(e => new { e.SchedName, e.TriggerGroup, e.TriggerState }, "IDX_QRTZ_T_N_G_STATE");

            entity.HasIndex(e => new { e.SchedName, e.TriggerName, e.TriggerGroup, e.TriggerState }, "IDX_QRTZ_T_N_STATE");

            entity.HasIndex(e => new { e.SchedName, e.TriggerState }, "IDX_QRTZ_T_STATE");

            entity.Property(e => e.SchedName)
                .HasMaxLength(120)
                .HasColumnName("SCHED_NAME");

            entity.Property(e => e.TriggerName)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_NAME");

            entity.Property(e => e.TriggerGroup)
                .HasMaxLength(150)
                .HasColumnName("TRIGGER_GROUP");

            entity.Property(e => e.CalendarName)
                .HasMaxLength(200)
                .HasColumnName("CALENDAR_NAME");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("DESCRIPTION");

            entity.Property(e => e.EndTime).HasColumnName("END_TIME");

            entity.Property(e => e.JobData).HasColumnName("JOB_DATA");

            entity.Property(e => e.JobGroup)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("JOB_GROUP");

            entity.Property(e => e.JobName)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("JOB_NAME");

            entity.Property(e => e.MisfireInstr).HasColumnName("MISFIRE_INSTR");

            entity.Property(e => e.NextFireTime).HasColumnName("NEXT_FIRE_TIME");

            entity.Property(e => e.PrevFireTime).HasColumnName("PREV_FIRE_TIME");

            entity.Property(e => e.Priority).HasColumnName("PRIORITY");

            entity.Property(e => e.StartTime).HasColumnName("START_TIME");

            entity.Property(e => e.TriggerState)
                .IsRequired()
                .HasMaxLength(16)
                .HasColumnName("TRIGGER_STATE");

            entity.Property(e => e.TriggerType)
                .IsRequired()
                .HasMaxLength(8)
                .HasColumnName("TRIGGER_TYPE");

            entity.HasOne(d => d.QrtzJobDetail)
                .WithMany(p => p.QrtzTriggers)
                .HasForeignKey(d => new { d.SchedName, d.JobName, d.JobGroup })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QRTZ_TRIGGERS_QRTZ_JOB_DETAILS");
        });

        modelBuilder.Entity<VmDboSegment>(entity =>
        {
            entity.ToTable("Segment");

            entity.HasIndex(e => e.SegmentSelectionScriptId, "IX_Segment_SegmentSelectionScriptId");

            entity.HasIndex(e => e.SegmentTypeId, "IX_Segment_SegmentTypeId");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.SegmentSelectionScript)
                .WithMany(p => p.Segments)
                .HasForeignKey(d => d.SegmentSelectionScriptId);

            entity.HasOne(d => d.SegmentType)
                .WithMany(p => p.Segments)
                .HasForeignKey(d => d.SegmentTypeId);
        });

        modelBuilder.Entity<VmDboSegmentBatch>(entity =>
        {
            entity.ToTable("SegmentBatch");

            entity.HasIndex(e => e.SegmentId, "IX_SegmentBatch_SegmentId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Segment)
                .WithMany(p => p.SegmentBatches)
                .HasForeignKey(d => d.SegmentId);
        });

        modelBuilder.Entity<VmDboSegmentBatchClaim>(entity =>
        {
            entity.HasKey(e => e.ClaimId)
                .HasName("pk_SegmentBatchClaim_cid");

            entity.ToTable("SegmentBatchClaim");

            entity.Property(e => e.ClaimId).ValueGeneratedNever();

            entity.Property(e => e.Operation).HasMaxLength(50);
        });

        modelBuilder.Entity<VmDboSegmentBatchClaimPayment>(entity =>
        {
            entity.ToTable("SegmentBatchClaimPayment");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Last4).HasMaxLength(10);

            entity.Property(e => e.Response).HasMaxLength(256);
        });

        modelBuilder.Entity<VmDboSegmentBatchClaimVersion>(entity =>
        {
            entity.HasKey(e => new { e.ClaimId, e.AssessmentDataId })
                .HasName("pk_SegmentBatchClaimVersion_cid_adId");

            entity.ToTable("SegmentBatchClaimVersion");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Operation).HasMaxLength(50);
        });

        modelBuilder.Entity<VmDboSegmentBatchOwner>(entity =>
        {
            entity.HasKey(e => e.OwnerId);

            entity.ToTable("SegmentBatchOwner");

            entity.HasIndex(e => e.BatchId, "IX_SegmentBatchOwner_BatchId");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.HasOne(d => d.Batch)
                .WithMany(p => p.SegmentBatchOwners)
                .HasForeignKey(d => d.BatchId);
        });

        modelBuilder.Entity<VmDboSegmentBatchPet>(entity =>
        {
            entity.HasKey(e => e.PetId);

            entity.ToTable("SegmentBatchPet");

            entity.HasIndex(e => e.BatchId, "IX_SegmentBatchPet_BatchId");

            entity.Property(e => e.PetId).ValueGeneratedNever();

            entity.HasOne(d => d.Batch)
                .WithMany(p => p.SegmentBatchPets)
                .HasForeignKey(d => d.BatchId);
        });

        modelBuilder.Entity<VmDboSegmentOwner>(entity =>
        {
            entity.HasKey(e => new { e.OwnerId, e.SegmentId });

            entity.ToTable("SegmentOwner");

            entity.HasIndex(e => e.SegmentId, "IX_SegmentOwner_SegmentId");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Segment)
                .WithMany(p => p.SegmentOwners)
                .HasForeignKey(d => d.SegmentId);
        });

        modelBuilder.Entity<VmDboSegmentSelectionScript>(entity =>
        {
            entity.ToTable("SegmentSelectionScript");

            entity.HasIndex(e => e.Name, "AK_SegmentSelectionScript_Name")
                .IsUnique();

            entity.HasIndex(e => e.SegmentTypeId, "IX_SegmentSelectionScript_SegmentTypeId");

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.ScriptText).IsRequired();

            entity.HasOne(d => d.SegmentType)
                .WithMany(p => p.SegmentSelectionScripts)
                .HasForeignKey(d => d.SegmentTypeId);
        });

        modelBuilder.Entity<VmDboSegmentType>(entity =>
        {
            entity.ToTable("SegmentType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.HasSequence("CommunicationDocumentsSequence");

        modelBuilder.HasSequence("CommunicationsSequence");

        modelBuilder.HasSequence("InteractionPetsSequence");

        modelBuilder.HasSequence("InteractionsSequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}