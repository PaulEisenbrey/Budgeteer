using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Workflow;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class WorkflowDboContext : DbContext
{
    public WorkflowDboContext()
    {
    }

    public WorkflowDboContext(DbContextOptions<WorkflowDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WFDboActionableConversationForUser> ActionableConversationForUsers { get; set; }
    public virtual DbSet<WFDboActiveConversation> ActiveConversations { get; set; }
    public virtual DbSet<WFDboActiveConversationForUser> ActiveConversationForUsers { get; set; }
    public virtual DbSet<WFDboActiveProcessInstance> ActiveProcessInstances { get; set; }
    public virtual DbSet<WFDboActiveUserTaskInstance> ActiveUserTaskInstances { get; set; }
    public virtual DbSet<WFDboActiveUserTaskInstanceForAssignment> ActiveUserTaskInstanceForAssignments { get; set; }
    public virtual DbSet<WFDboAttribute> Attributes { get; set; }
    public virtual DbSet<WFDboConversation> Conversations { get; set; }
    public virtual DbSet<WFDboConversationAction> ConversationActions { get; set; }
    public virtual DbSet<WFDboConversationActivity> ConversationActivities { get; set; }
    public virtual DbSet<WFDboConversationExchange> ConversationExchanges { get; set; }
    public virtual DbSet<WFDboConversationParticipant> ConversationParticipants { get; set; }
    public virtual DbSet<WFDboConversationState> ConversationStates { get; set; }
    public virtual DbSet<WFDboConversationTopic> ConversationTopics { get; set; }
    public virtual DbSet<WFDboConversationTopicList> ConversationTopicLists { get; set; }
    public virtual DbSet<WFDboEvent> Events { get; set; }
    public virtual DbSet<WFDboFriendlyProcessDefinitionFlow> FriendlyProcessDefinitionFlows { get; set; }
    public virtual DbSet<WFDboGetNextAssignmentLog> GetNextAssignmentLogs { get; set; }
    public virtual DbSet<WFDboInputConfiguration> InputConfigurations { get; set; }
    public virtual DbSet<WFDboInputConfigurationFollowup> InputConfigurationFollowups { get; set; }
    public virtual DbSet<WFDboInputConfigurationOptionGroup> InputConfigurationOptionGroups { get; set; }
    public virtual DbSet<WFDboInputConfigurationOptionGroupItem> InputConfigurationOptionGroupItems { get; set; }
    public virtual DbSet<WFDboInputConfigurationOptionItem> InputConfigurationOptionItems { get; set; }
    public virtual DbSet<WFDboInputConfigurationText> InputConfigurationTexts { get; set; }
    public virtual DbSet<WFDboProcessDefinition> ProcessDefinitions { get; set; }
    public virtual DbSet<WFDboProcessDefinitionConfiguration> ProcessDefinitionConfigurations { get; set; }
    public virtual DbSet<WFDboProcessDefinitionFlow> ProcessDefinitionFlows { get; set; }
    public virtual DbSet<WFDboProcessDefinitionFlowConfiguration> ProcessDefinitionFlowConfigurations { get; set; }
    public virtual DbSet<WFDboProcessDefinitionFlowType> ProcessDefinitionFlowTypes { get; set; }
    public virtual DbSet<WFDboProcessInstance> ProcessInstances { get; set; }
    public virtual DbSet<WFDboProcessInstanceChangeOwnerEvent> ProcessInstanceChangeOwnerEvents { get; set; }
    public virtual DbSet<WFDboProcessInstanceEvent> ProcessInstanceEvents { get; set; }
    public virtual DbSet<WFDboProcessInstanceMonitorEvent> ProcessInstanceMonitorEvents { get; set; }
    public virtual DbSet<WFDboProcessInstanceReferenceEntity> ProcessInstanceReferenceEntities { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatus> ProcessInstanceStatuses { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusGroup> ProcessInstanceStatusGroups { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionEvent> ProcessInstanceStatusTransitionEvents { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionEventResolution> ProcessInstanceStatusTransitionEventResolutions { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionEventResolutionAsync> ProcessInstanceStatusTransitionEventResolutionAsyncs { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionEventResolutionOption> ProcessInstanceStatusTransitionEventResolutionOptions { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection> ProcessInstanceStatusTransitionEventResolutionOptionSelections { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionEventResolutionText> ProcessInstanceStatusTransitionEventResolutionTexts { get; set; }
    public virtual DbSet<WFDboProcessInstanceStatusTransitionMap> ProcessInstanceStatusTransitionMaps { get; set; }
    public virtual DbSet<WFDboSkillset> Skillsets { get; set; }
    public virtual DbSet<WFDboStateTransitionResolutionGroup> StateTransitionResolutionGroups { get; set; }
    public virtual DbSet<WFDboStateTransitionResolutionGroupMember> StateTransitionResolutionGroupMembers { get; set; }
    public virtual DbSet<WFDboSystemCleanup> SystemCleanups { get; set; }
    public virtual DbSet<WFDboTaskDefinition> TaskDefinitions { get; set; }
    public virtual DbSet<WFDboTaskDefinitionConfiguration> TaskDefinitionConfigurations { get; set; }
    public virtual DbSet<WFDboTaskDefinitionConversationTopic> TaskDefinitionConversationTopics { get; set; }
    public virtual DbSet<WFDboTaskDefinitionDisallowedState> TaskDefinitionDisallowedStates { get; set; }
    public virtual DbSet<WFDboTaskDefinitionFlowSpecificResolution> TaskDefinitionFlowSpecificResolutions { get; set; }
    public virtual DbSet<WFDboTaskDefinitionType> TaskDefinitionTypes { get; set; }
    public virtual DbSet<WFDboTaskDefinitionWaitOnCompletion> TaskDefinitionWaitOnCompletions { get; set; }
    public virtual DbSet<WFDboTaskInstance> TaskInstances { get; set; }
    public virtual DbSet<WFDboTaskInstanceActiveTime> TaskInstanceActiveTimes { get; set; }
    public virtual DbSet<WFDboTaskInstanceBatch> TaskInstanceBatches { get; set; }
    public virtual DbSet<WFDboTaskInstanceBatchConfiguration> TaskInstanceBatchConfigurations { get; set; }
    public virtual DbSet<WFDboTaskInstanceBatchItem> TaskInstanceBatchItems { get; set; }
    public virtual DbSet<WFDboTaskInstanceBatchItemStatus> TaskInstanceBatchItemStatuses { get; set; }
    public virtual DbSet<WFDboTaskInstanceBatchStatus> TaskInstanceBatchStatuses { get; set; }
    public virtual DbSet<WFDboTaskInstanceBatchTiming> TaskInstanceBatchTimings { get; set; }
    public virtual DbSet<WFDboTaskInstanceChangeAssignmentEvent> TaskInstanceChangeAssignmentEvents { get; set; }
    public virtual DbSet<WFDboTaskInstanceEvent> TaskInstanceEvents { get; set; }
    public virtual DbSet<WFDboTaskInstanceGroup> TaskInstanceGroups { get; set; }
    public virtual DbSet<WFDboTaskInstanceGroupConfiguration> TaskInstanceGroupConfigurations { get; set; }
    public virtual DbSet<WFDboTaskInstanceGroupItem> TaskInstanceGroupItems { get; set; }
    public virtual DbSet<WFDboTaskInstanceReferenceEntity> TaskInstanceReferenceEntities { get; set; }
    public virtual DbSet<WFDboTaskInstanceRoutingBlacklist> TaskInstanceRoutingBlacklists { get; set; }
    public virtual DbSet<WFDboTaskInstanceRoutingKey> TaskInstanceRoutingKeys { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatus> TaskInstanceStatuses { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusGroup> TaskInstanceStatusGroups { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEvent> TaskInstanceStatusTransitionEvents { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolution> TaskInstanceStatusTransitionEventResolutions { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionAsync> TaskInstanceStatusTransitionEventResolutionAsyncs { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionCancelWait> TaskInstanceStatusTransitionEventResolutionCancelWaits { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstance> TaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstances { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing> TaskInstanceStatusTransitionEventResolutionFinalizeProcessings { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstance> TaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstances { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionFollowup> TaskInstanceStatusTransitionEventResolutionFollowups { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionOption> TaskInstanceStatusTransitionEventResolutionOptions { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection> TaskInstanceStatusTransitionEventResolutionOptionSelections { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionEventResolutionText> TaskInstanceStatusTransitionEventResolutionTexts { get; set; }
    public virtual DbSet<WFDboTaskInstanceStatusTransitionMap> TaskInstanceStatusTransitionMaps { get; set; }
    public virtual DbSet<WFDboUser> Users { get; set; }
    public virtual DbSet<WFDboVersionedDatum> VersionedData { get; set; }
    public virtual DbSet<WFDboWorkflowOperation> WorkflowOperations { get; set; }
    public virtual DbSet<WFDboWorkflowOperationException> WorkflowOperationExceptions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.workflow), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<WFDboActionableConversationForUser>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ActionableConversationForUser");

            entity.Property(e => e.ConversationTopicIdList).IsUnicode(false);
        });

        modelBuilder.Entity<WFDboActiveConversation>(entity =>
        {
            entity.HasKey(e => e.ConversationId)
                .HasName("pk_activeconversation_conversationid");

            entity.ToTable("ActiveConversation");

            entity.HasIndex(e => e.HeartbeatBrokerHandle, "ix_activeconversation_brokerconversationhandle");

            entity.HasIndex(e => new { e.ConversationPriority, e.ConversationId }, "ix_activeconversation_conversationpriority_conversationid");

            entity.HasIndex(e => new { e.ConversationStateId, e.ConversationPriority, e.ConversationId }, "ix_activeconversation_conversationstateid_conversationpriority_conversationid");

            entity.HasIndex(e => e.TaskInstanceId, "ix_activeconversation_taskinstanceid");

            entity.Property(e => e.ConversationId).ValueGeneratedNever();

            entity.Property(e => e.ConversationTopicIdList).IsUnicode(false);

            entity.HasOne(d => d.Conversation)
                .WithOne(p => p.ActiveConversation)
                .HasForeignKey<WFDboActiveConversation>(d => d.ConversationId)
                .HasConstraintName("fk_activeconversations_conversationid");
        });

        modelBuilder.Entity<WFDboActiveConversationForUser>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ActiveConversationForUser");

            entity.Property(e => e.ConversationTopicIdList).IsUnicode(false);
        });

        modelBuilder.Entity<WFDboActiveProcessInstance>(entity =>
        {
            entity.ToTable("ActiveProcessInstance");

            entity.HasIndex(e => new { e.OwningUserId, e.ProcessInstancePriorityId, e.CreatedOn }, "ix_activeprocessinstance_owninguserid");

            entity.HasIndex(e => e.ProcessDefinitionId, "ix_activeprocessinstance_processdefinitionid");

            entity.HasIndex(e => new { e.ProcessDefinitionId, e.ProcessInstanceStatusId }, "ix_activeprocessinstance_processdefinitionid_processinstancestatus");

            entity.HasIndex(e => e.ProcessInstanceStatusGroupId, "ix_activeprocessinstance_processinstancestatusgroupid");

            entity.HasIndex(e => e.ProcessInstanceStatusId, "ix_activeprocessinstance_processinstancestatusid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation)
                .WithOne(p => p.ActiveProcessInstance)
                .HasForeignKey<WFDboActiveProcessInstance>(d => d.Id)
                .HasConstraintName("fk_processinstance_activeprocessinstance_id");
        });

        modelBuilder.Entity<WFDboActiveUserTaskInstance>(entity =>
        {
            entity.ToTable("ActiveUserTaskInstance");

            entity.HasIndex(e => new { e.AssignedToUserId, e.TaskInstancePriorityId, e.CreatedOn }, "ix_activeusertaskinstance_assignedtouserid");

            entity.HasIndex(e => new { e.AssignedToUserId, e.TaskInstanceStatusGroupId, e.TaskInstancePriorityId, e.CreatedOn }, "ix_activeusertaskinstance_assignedtouserid_taskinstancestatusgroupid_taskinstancepriorityid");

            entity.HasIndex(e => new { e.IsAutomated, e.IsBeingProcessed, e.AssignedToUserId, e.TaskInstanceStatusGroupId }, "ix_activeusertaskinstance_getnext");

            entity.HasIndex(e => new { e.ModifiedOn, e.TaskInstanceStatusGroupId }, "ix_activeusertaskinstance_modifiedon_taskinstancestatusgroupid");

            entity.HasIndex(e => e.ProcessDefinitionId, "ix_activeusertaskinstance_processdefinitionid");

            entity.HasIndex(e => e.ProcessInstanceId, "ix_activeusertaskinstance_processinstanceid");

            entity.HasIndex(e => e.TaskDefinitionId, "ix_activeusertaskinstance_taskdefinitionid");

            entity.HasIndex(e => e.TaskInstancePriorityId, "ix_activeusertaskinstance_taskinstancepriority");

            entity.HasIndex(e => e.TaskInstanceStatusGroupId, "ix_activeusertaskinstance_taskinstancestatusgroupid");

            entity.HasIndex(e => new { e.TaskInstanceStatusGroupId, e.ProcessInstanceId }, "ix_activeusertaskinstance_taskinstancestatusgroupid_processinstanceid");

            entity.HasIndex(e => e.TaskInstanceStatusId, "ix_activeusertaskinstance_taskinstancestatusid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation)
                .WithOne(p => p.ActiveUserTaskInstance)
                .HasForeignKey<WFDboActiveUserTaskInstance>(d => d.Id)
                .HasConstraintName("fk_taskinstance_activeusertaskinstance_id");
        });

        modelBuilder.Entity<WFDboActiveUserTaskInstanceForAssignment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ActiveUserTaskInstanceForAssignment");
        });

        modelBuilder.Entity<WFDboAttribute>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_attribute_id")
                .IsClustered(false);

            entity.ToTable("Attribute");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboConversation>(entity =>
        {
            entity.ToTable("Conversation");

            entity.HasIndex(e => e.ConversationStateId, "ix_conversation_conversationstateid");

            entity.HasIndex(e => e.CreatedBy, "ix_conversation_createdby");

            entity.HasIndex(e => e.TaskInstanceId, "ix_conversation_taskinstanceid");

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.ConversationState)
                .WithMany(p => p.Conversations)
                .HasForeignKey(d => d.ConversationStateId)
                .HasConstraintName("fk_conversationstate_conversation_conversationstateid");

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.Conversations)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_taskinstance_conversation_taskinstanceid");
        });

        modelBuilder.Entity<WFDboConversationAction>(entity =>
        {
            entity.ToTable("ConversationAction");

            entity.HasIndex(e => e.VersionId, "ix_conversationaction_versionid");

            entity.HasIndex(e => e.Name, "uk_conversationaction_name")
                .IsUnique();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboConversationActivity>(entity =>
        {
            entity.ToTable("ConversationActivity");

            entity.HasIndex(e => e.ConversationActionId, "ix_conversationactivity_conversationactionid");

            entity.HasIndex(e => e.ConversationId, "ix_conversationactivity_conversationid");

            entity.HasOne(d => d.ConversationAction)
                .WithMany(p => p.ConversationActivities)
                .HasForeignKey(d => d.ConversationActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_conversationaction_conversationactivity_conversationactionid");

            entity.HasOne(d => d.Conversation)
                .WithMany(p => p.ConversationActivities)
                .HasForeignKey(d => d.ConversationId)
                .HasConstraintName("fk_conversation_conversationactivity_conversationid");
        });

        modelBuilder.Entity<WFDboConversationExchange>(entity =>
        {
            entity.ToTable("ConversationExchange");

            entity.HasIndex(e => e.ConversationId, "ix_conversationexchange_conversationid");

            entity.Property(e => e.Content).IsRequired();

            entity.HasOne(d => d.Conversation)
                .WithMany(p => p.ConversationExchanges)
                .HasForeignKey(d => d.ConversationId)
                .HasConstraintName("fk_conversation_conversationexchange_conversationid");
        });

        modelBuilder.Entity<WFDboConversationParticipant>(entity =>
        {
            entity.ToTable("ConversationParticipant");

            entity.HasIndex(e => e.ConversationId, "ix_conversationparticipant_conversationid");

            entity.HasIndex(e => e.UserId, "ix_conversationparticipant_userid");

            entity.HasOne(d => d.Conversation)
                .WithMany(p => p.ConversationParticipants)
                .HasForeignKey(d => d.ConversationId)
                .HasConstraintName("fk_conversation_conversationparticipant_conversationid");
        });

        modelBuilder.Entity<WFDboConversationState>(entity =>
        {
            entity.ToTable("ConversationState");

            entity.HasIndex(e => e.VersionId, "ix_conversationstate_versionid");

            entity.HasIndex(e => e.Name, "uk_conversationstate_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboConversationTopic>(entity =>
        {
            entity.ToTable("ConversationTopic");

            entity.HasIndex(e => e.VersionId, "ix_conversationtopic_versionid");

            entity.HasIndex(e => e.Name, "uk_conversationtopic_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboConversationTopicList>(entity =>
        {
            entity.ToTable("ConversationTopicList");

            entity.HasIndex(e => e.ConversationTopicId, "ix_conversationtopiclist_conversationtopicid");

            entity.HasIndex(e => new { e.ConversationId, e.ConversationTopicId }, "uk_conversationtopiclist_conversationid_conversationtopicid")
                .IsUnique();

            entity.HasOne(d => d.Conversation)
                .WithMany(p => p.ConversationTopicLists)
                .HasForeignKey(d => d.ConversationId)
                .HasConstraintName("fk_conversation_conversationtopiclist_conversationid");

            entity.HasOne(d => d.ConversationTopic)
                .WithMany(p => p.ConversationTopicLists)
                .HasForeignKey(d => d.ConversationTopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_conversationtopic_conversationtopiclist_conversationtopicid");
        });

        modelBuilder.Entity<WFDboEvent>(entity =>
        {
            entity.ToTable("Event");

            entity.HasIndex(e => e.Name, "uk_event_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_event_uniqueid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<WFDboFriendlyProcessDefinitionFlow>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("FriendlyProcessDefinitionFlow");

            entity.Property(e => e.ProcessName).HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboGetNextAssignmentLog>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GetNextAssignmentLog");

            entity.Property(e => e.AssignedOn).HasColumnType("datetime");

            entity.Property(e => e.Skills).IsUnicode(false);
        });

        modelBuilder.Entity<WFDboInputConfiguration>(entity =>
        {
            entity.ToTable("InputConfiguration");

            entity.HasIndex(e => e.VersionId, "ix_inputconfiguration_versionid");
        });

        modelBuilder.Entity<WFDboInputConfigurationFollowup>(entity =>
        {
            entity.HasKey(e => e.InputConfigurationId)
                .HasName("pk_inputconfigurationfollowup_inputconfigurationid");

            entity.ToTable("InputConfigurationFollowup");

            entity.Property(e => e.InputConfigurationId).ValueGeneratedNever();

            entity.Property(e => e.Label)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.InputConfiguration)
                .WithOne(p => p.InputConfigurationFollowup)
                .HasForeignKey<WFDboInputConfigurationFollowup>(d => d.InputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_inputconfigurationfollowup_inputconfigurationid");
        });

        modelBuilder.Entity<WFDboInputConfigurationOptionGroup>(entity =>
        {
            entity.HasKey(e => e.InputConfigurationId)
                .HasName("pk_inputconfigurationoptiongroup_inputconfigurationid");

            entity.ToTable("InputConfigurationOptionGroup");

            entity.Property(e => e.InputConfigurationId).ValueGeneratedNever();

            entity.Property(e => e.GroupHeading).HasMaxLength(100);

            entity.HasOne(d => d.InputConfiguration)
                .WithOne(p => p.InputConfigurationOptionGroup)
                .HasForeignKey<WFDboInputConfigurationOptionGroup>(d => d.InputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_inputconfigurationoptiongroup_inputconfigurationid");
        });

        modelBuilder.Entity<WFDboInputConfigurationOptionGroupItem>(entity =>
        {
            entity.ToTable("InputConfigurationOptionGroupItem");

            entity.HasIndex(e => e.InputConfigurationOptionItemId, "ix_inputconfigurationoptiongroupitem_inputconfigurationoptionitemid");

            entity.HasIndex(e => new { e.InputConfigurationId, e.InputConfigurationOptionItemId }, "uk_inputconfigurationoptiongroupitem_inputconfigurationid_inputconfigurationoptionitemid")
                .IsUnique();

            entity.HasIndex(e => new { e.InputConfigurationId, e.SelectionOrder }, "uk_inputconfigurationoptiongroupitem_inputconfigurationid_selectionorder")
                .IsUnique();

            entity.Property(e => e.SelectionEffectConfiguration).IsUnicode(false);

            entity.HasOne(d => d.InputConfiguration)
                .WithMany(p => p.InputConfigurationOptionGroupItems)
                .HasForeignKey(d => d.InputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_inputconfigurationoptiongroupitem_inputconfigurationid");

            entity.HasOne(d => d.InputConfigurationOptionItem)
                .WithMany(p => p.InputConfigurationOptionGroupItems)
                .HasForeignKey(d => d.InputConfigurationOptionItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inputconfigurationoptionitem_inputconfigurationoptiongroupitem_inputconfigurationoptionitemid");
        });

        modelBuilder.Entity<WFDboInputConfigurationOptionItem>(entity =>
        {
            entity.ToTable("InputConfigurationOptionItem");

            entity.HasIndex(e => e.VersionId, "ix_inputconfigurationoptionitem_versionid");

            entity.Property(e => e.SelectionText).IsRequired();
        });

        modelBuilder.Entity<WFDboInputConfigurationText>(entity =>
        {
            entity.HasKey(e => e.InputConfigurationId)
                .HasName("pk_inputconfigurationtext_inputconfigurationid");

            entity.ToTable("InputConfigurationText");

            entity.Property(e => e.InputConfigurationId).ValueGeneratedNever();

            entity.Property(e => e.Label)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.InputConfiguration)
                .WithOne(p => p.InputConfigurationText)
                .HasForeignKey<WFDboInputConfigurationText>(d => d.InputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_inputconfigurationtetx");
        });

        modelBuilder.Entity<WFDboProcessDefinition>(entity =>
        {
            entity.ToTable("ProcessDefinition");

            entity.HasIndex(e => e.EnterpriseCategoryId, "ix_processdefinition_enterprisecategoryid");

            entity.HasIndex(e => e.StandardStateTransitionResolutionGroupId, "ix_processdefinition_standardstatetransitionresolutiongroupid");

            entity.HasIndex(e => e.VersionId, "ix_processdefinition_versionid");

            entity.HasIndex(e => new { e.EnterpriseCategoryId, e.Name }, "uk_processdefinition_processcategoryid_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_processdefinition_uniqueid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.StandardStateTransitionResolutionGroup)
                .WithMany(p => p.ProcessDefinitions)
                .HasForeignKey(d => d.StandardStateTransitionResolutionGroupId)
                .HasConstraintName("fk_statetransitionresolutiongroup_processdefinition_standardstatetransitionresolutiongroupid");
        });

        modelBuilder.Entity<WFDboProcessDefinitionConfiguration>(entity =>
        {
            entity.ToTable("ProcessDefinitionConfiguration");

            entity.HasIndex(e => e.ConfigKey, "ix_processdefinitionconfiguration_configkey");

            entity.HasIndex(e => e.ProcessDefinitionId, "ix_processdefinitionconfiguration_processdefinitionid");

            entity.HasIndex(e => new { e.ProcessDefinitionId, e.ConfigKey }, "uk_processdefinitionconfiguration_processdefinitionid_configkey")
                .IsUnique();

            entity.Property(e => e.ConfigData).IsRequired();

            entity.Property(e => e.ConfigKey)
                .IsRequired()
                .HasMaxLength(200);

            entity.HasOne(d => d.ProcessDefinition)
                .WithMany(p => p.ProcessDefinitionConfigurations)
                .HasForeignKey(d => d.ProcessDefinitionId)
                .HasConstraintName("fk_processdefinition_processdefinitionconfiguration");
        });

        modelBuilder.Entity<WFDboProcessDefinitionFlow>(entity =>
        {
            entity.ToTable("ProcessDefinitionFlow");

            entity.HasIndex(e => e.ProcessDefinitionFlowTypeId, "ix_processdefinitionflow_processdefinitionflowtypeid");

            entity.HasIndex(e => e.ProcessDefinitionId, "ix_processdefinitionflow_processdefinitionid");

            entity.HasIndex(e => e.TaskDefinitionId, "ix_processdefinitionflow_taskdefinitionid");

            entity.HasIndex(e => e.UniqueId, "uk_processdefinitionflow_uniqueid")
                .IsUnique();

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_processdefinitionflow_processdefinitionflow_startprocessdefinitionid");

            entity.HasOne(d => d.ProcessDefinitionFlowType)
                .WithMany(p => p.ProcessDefinitionFlows)
                .HasForeignKey(d => d.ProcessDefinitionFlowTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processdefinitionflowtype_processdefinitionflow_processdefinitionflowtypeid");

            entity.HasOne(d => d.ProcessDefinition)
                .WithMany(p => p.ProcessDefinitionFlows)
                .HasForeignKey(d => d.ProcessDefinitionId)
                .HasConstraintName("fk_processdefinition_processdefinitionflow_processdefinitionid");

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.ProcessDefinitionFlows)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_processdefinitionflow_taskdefinitionid");
        });

        modelBuilder.Entity<WFDboProcessDefinitionFlowConfiguration>(entity =>
        {
            entity.ToTable("ProcessDefinitionFlowConfiguration");

            entity.HasIndex(e => new { e.ProcessDefinitionFlowId, e.ConfigKey }, "uk_processdefinitionflowconfiguration_processdefinitionflowid_configkey")
                .IsUnique();

            entity.Property(e => e.ConfigData).IsRequired();

            entity.Property(e => e.ConfigKey)
                .IsRequired()
                .HasMaxLength(200);

            entity.HasOne(d => d.ProcessDefinitionFlow)
                .WithMany(p => p.ProcessDefinitionFlowConfigurations)
                .HasForeignKey(d => d.ProcessDefinitionFlowId)
                .HasConstraintName("fk_processdefinitionflow_processdefinitionflowconfiguration");
        });

        modelBuilder.Entity<WFDboProcessDefinitionFlowType>(entity =>
        {
            entity.ToTable("ProcessDefinitionFlowType");

            entity.HasIndex(e => e.VersionId, "ix_processdefinitionflowtype_versionid");

            entity.HasIndex(e => e.Name, "uk_processdefinitionflowtype_name")
                .IsUnique();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.DesignerVisible)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboProcessInstance>(entity =>
        {
            entity.ToTable("ProcessInstance");

            entity.HasIndex(e => e.CreatedOn, "ix_processinstance_createdon");

            entity.HasIndex(e => e.ProcessDefinitionId, "ix_processinstance_processdefinitionid");

            entity.HasIndex(e => new { e.ProcessDefinitionId, e.SubjectEnterpriseEntityId, e.SubjectEntityId, e.ProcessInstanceStatusId }, "ix_processinstance_processdefinitionid_subjectenterpriseentityid_uniquebyentityid");

            entity.HasIndex(e => e.ProcessInstanceStatusId, "ix_processinstance_processinstancestatusid");

            entity.Property(e => e.SubjectEntityId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.ProcessDefinition)
                .WithMany(p => p.ProcessInstances)
                .HasForeignKey(d => d.ProcessDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processdefinition_processinstance_processdefinitionid");

            entity.HasOne(d => d.ProcessInstanceStatus)
                .WithMany(p => p.ProcessInstances)
                .HasForeignKey(d => d.ProcessInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processinstancestatus_processinstance_processinstancestatusid");
        });

        modelBuilder.Entity<WFDboProcessInstanceChangeOwnerEvent>(entity =>
        {
            entity.HasKey(e => e.ProcessInstanceEventId)
                .HasName("pk_processinstancechangeownerevent_processinstanceeventid");

            entity.ToTable("ProcessInstanceChangeOwnerEvent");

            entity.Property(e => e.ProcessInstanceEventId).ValueGeneratedNever();

            entity.HasOne(d => d.ProcessInstanceEvent)
                .WithOne(p => p.ProcessInstanceChangeOwnerEvent)
                .HasForeignKey<WFDboProcessInstanceChangeOwnerEvent>(d => d.ProcessInstanceEventId)
                .HasConstraintName("fk_processinstanceevent_processinstancechangeownerevent_processinstanceeventid");
        });

        modelBuilder.Entity<WFDboProcessInstanceEvent>(entity =>
        {
            entity.ToTable("ProcessInstanceEvent");

            entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn }, "ix_processinstanceevent_createdby_createdon");

            entity.HasIndex(e => new { e.CreatedOn, e.CreatedBy }, "ix_processinstanceevent_createdon_createdby");

            entity.HasIndex(e => e.ProcessInstanceId, "ix_processinstanceevent_processkinstanceid");

            entity.HasIndex(e => e.TriggeringEventId, "ix_processinstanceevent_triggeringeventid");

            entity.HasOne(d => d.ProcessInstance)
                .WithMany(p => p.ProcessInstanceEvents)
                .HasForeignKey(d => d.ProcessInstanceId)
                .HasConstraintName("fk_processinstance_processinstanceevent_processinstanceid");

            entity.HasOne(d => d.TriggeringEvent)
                .WithMany(p => p.ProcessInstanceEvents)
                .HasForeignKey(d => d.TriggeringEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_event_processinstanceevent");
        });

        modelBuilder.Entity<WFDboProcessInstanceMonitorEvent>(entity =>
        {
            entity.ToTable("ProcessInstanceMonitorEvent");

            entity.HasIndex(e => e.CreatedOn, "ix_processinstancemonitorevent_createdon");

            entity.HasIndex(e => e.ProcessInstanceId, "ix_processinstancemonitorevent_processinstanceid");

            entity.Property(e => e.SerializedEvent)
                .IsRequired()
                .IsUnicode(false);

            entity.HasOne(d => d.ProcessInstance)
                .WithMany(p => p.ProcessInstanceMonitorEvents)
                .HasForeignKey(d => d.ProcessInstanceId)
                .HasConstraintName("fk_processinstance_processinstancemonitorevent_processinstanceid");
        });

        modelBuilder.Entity<WFDboProcessInstanceReferenceEntity>(entity =>
        {
            entity.ToTable("ProcessInstanceReferenceEntity");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityId }, "ix_processinstancereferenceentity_enterpriseentityid_entityid");

            entity.HasIndex(e => new { e.ProcessInstanceId, e.EnterpriseEntityId, e.EntityId }, "uk_processinstancereferenceentity_processinstanceid_enterpriseentityid_entityid")
                .IsUnique();

            entity.Property(e => e.EntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.ProcessInstance)
                .WithMany(p => p.ProcessInstanceReferenceEntities)
                .HasForeignKey(d => d.ProcessInstanceId)
                .HasConstraintName("fk_process_processinstancereferenceentity_processinstanceid");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatus>(entity =>
        {
            entity.ToTable("ProcessInstanceStatus");

            entity.HasIndex(e => e.ProcessInstanceStatusGroupId, "ix_processinstancestatus_processinstancestatusgroupid");

            entity.HasIndex(e => e.VersionId, "ix_processinstancestatus_versionid");

            entity.HasIndex(e => e.Name, "uk_processinstancestatus_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusGroup>(entity =>
        {
            entity.ToTable("ProcessInstanceStatusGroup");

            entity.HasIndex(e => e.VersionId, "ix_processinstancestatusgroup_versionid");

            entity.HasIndex(e => e.Name, "uk_processinstancestatusgroup_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionEvent>(entity =>
        {
            entity.HasKey(e => e.ProcessInstanceEventId)
                .HasName("pk_processinstancestatustransitionevent_processinstanceeventid");

            entity.ToTable("ProcessInstanceStatusTransitionEvent");

            entity.Property(e => e.ProcessInstanceEventId).ValueGeneratedNever();

            entity.HasOne(d => d.PostTransitionProcessInstanceStatus)
                .WithMany(p => p.ProcessInstanceStatusTransitionEventPostTransitionProcessInstanceStatuses)
                .HasForeignKey(d => d.PostTransitionProcessInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processinstancestatustransitionevent_processinstancestatus_posttransitionprocessinstancestatusid");

            entity.HasOne(d => d.PreTransitionProcessInstanceStatus)
                .WithMany(p => p.ProcessInstanceStatusTransitionEventPreTransitionProcessInstanceStatuses)
                .HasForeignKey(d => d.PreTransitionProcessInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processinstancestatustransitionevent_processinstancestatus_pretransitionprocessinstancestatusid");

            entity.HasOne(d => d.ProcessInstanceEvent)
                .WithOne(p => p.ProcessInstanceStatusTransitionEvent)
                .HasForeignKey<WFDboProcessInstanceStatusTransitionEvent>(d => d.ProcessInstanceEventId)
                .HasConstraintName("fk_processinstanceevent_processinstancestatustransitionevent_processinstanceid");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionEventResolution>(entity =>
        {
            entity.ToTable("ProcessInstanceStatusTransitionEventResolution");

            entity.HasIndex(e => e.InputConfigurationId, "ix_processinstancestatustransitioneventresolution_inputconfigurationid");

            entity.HasIndex(e => e.ProcessInstanceEventId, "ix_processinstancestatustransitioneventresolution_processinstanceeventid");

            entity.HasOne(d => d.InputConfiguration)
                .WithMany(p => p.ProcessInstanceStatusTransitionEventResolutions)
                .HasForeignKey(d => d.InputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_processInstancestatustransitioneventresolution_inputconfigurationid");

            entity.HasOne(d => d.ProcessInstanceEvent)
                .WithMany(p => p.ProcessInstanceStatusTransitionEventResolutions)
                .HasForeignKey(d => d.ProcessInstanceEventId)
                .HasConstraintName("fk_processinstancestatustransitionevent_processInstancestatustransitioneventresolution_processinstanceeventid");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionEventResolutionAsync>(entity =>
        {
            entity.HasKey(e => e.ProcessInstanceStatusTransitionEventResolutionId)
                .HasName("pk_processstatustransitioneventresolutionasync_id");

            entity.ToTable("ProcessInstanceStatusTransitionEventResolutionAsync");

            entity.Property(e => e.ProcessInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.Property(e => e.EventArgs).IsUnicode(false);

            entity.Property(e => e.MessageId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TriggeringMessageId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.ProcessInstanceStatusTransitionEventResolution)
                .WithOne(p => p.ProcessInstanceStatusTransitionEventResolutionAsync)
                .HasForeignKey<WFDboProcessInstanceStatusTransitionEventResolutionAsync>(d => d.ProcessInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_processinstancestatustransitioneventresolution_processInstancestatustransitioneventresolutionasync");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionEventResolutionOption>(entity =>
        {
            entity.HasKey(e => e.ProcessInstanceStatusTransitionEventResolutionId)
                .HasName("pk_processstatustransitioneventresolutionoption_id");

            entity.ToTable("ProcessInstanceStatusTransitionEventResolutionOption");

            entity.Property(e => e.ProcessInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.HasOne(d => d.ProcessInstanceStatusTransitionEventResolution)
                .WithOne(p => p.ProcessInstanceStatusTransitionEventResolutionOption)
                .HasForeignKey<WFDboProcessInstanceStatusTransitionEventResolutionOption>(d => d.ProcessInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_processinstancestatustransitioneventresolution_processInstancestatustransitioneventresolutionoption");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionEventResolutionOptionSelection>(entity =>
        {
            entity.ToTable("ProcessInstanceStatusTransitionEventResolutionOptionSelection");

            entity.HasIndex(e => e.InputConfigurationOptionItemId, "ix_processinstancestatustransitioneventresolutionoptionselection_inputconfigurationoptionitemid");

            entity.HasIndex(e => e.ProcessInstanceStatusTransitionEventResolutionId, "ix_processinstancestatustransitioneventresolutionoptionselection_processinstancestatustransitioneventresolutionid");

            entity.HasOne(d => d.InputConfigurationOptionItem)
                .WithMany(p => p.ProcessInstanceStatusTransitionEventResolutionOptionSelections)
                .HasForeignKey(d => d.InputConfigurationOptionItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inputconfigurationoptionitem_processInstancestatustransitioneventresolutionoptionselection_inputconfigurationoptionitemid");

            entity.HasOne(d => d.ProcessInstanceStatusTransitionEventResolution)
                .WithMany(p => p.ProcessInstanceStatusTransitionEventResolutionOptionSelections)
                .HasForeignKey(d => d.ProcessInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_processinstancestatustransitioneventresolutionoption_processInstancestatustransitioneventresolutionoptionselection");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionEventResolutionText>(entity =>
        {
            entity.HasKey(e => e.ProcessInstanceStatusTransitionEventResolutionId)
                .HasName("pk_processstatustransitioneventresolutiontext_processinstancestatustransitioneventresolutionid");

            entity.ToTable("ProcessInstanceStatusTransitionEventResolutionText");

            entity.Property(e => e.ProcessInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.Property(e => e.ResolutionText).IsRequired();

            entity.HasOne(d => d.ProcessInstanceStatusTransitionEventResolution)
                .WithOne(p => p.ProcessInstanceStatusTransitionEventResolutionText)
                .HasForeignKey<WFDboProcessInstanceStatusTransitionEventResolutionText>(d => d.ProcessInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_processinstancestatustransitioneventresolution_processInstancestatustransitioneventresolutiontext");
        });

        modelBuilder.Entity<WFDboProcessInstanceStatusTransitionMap>(entity =>
        {
            entity.ToTable("ProcessInstanceStatusTransitionMap");

            entity.HasIndex(e => e.CanTransitionToProcessInstanceStatusId, "ix_processinstancestatustransitionmap_cantransitiontoprocessinstancestatusid");

            entity.HasIndex(e => e.RequiredInputConfigurationId, "ix_processinstancestatustransitionmap_requiredinputconfigurationid");

            entity.HasIndex(e => new { e.ProcessInstanceStatusId, e.CanTransitionToProcessInstanceStatusId }, "uk_processinstancestatustransitionmap_processinstancestatusid_cantransitiontoprocessinstancestatusid")
                .IsUnique();

            entity.Property(e => e.TransitionVerb)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.CanTransitionToProcessInstanceStatus)
                .WithMany(p => p.ProcessInstanceStatusTransitionMapCanTransitionToProcessInstanceStatuses)
                .HasForeignKey(d => d.CanTransitionToProcessInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processinstancestatus_processinstancestatustransitionmap_cantransitiontoprocessinstancestatusid");

            entity.HasOne(d => d.ProcessInstanceStatus)
                .WithMany(p => p.ProcessInstanceStatusTransitionMapProcessInstanceStatuses)
                .HasForeignKey(d => d.ProcessInstanceStatusId)
                .HasConstraintName("fk_processinstancestatus_processinstancestatustransitionmap_processinstancestatusid");

            entity.HasOne(d => d.RequiredInputConfiguration)
                .WithMany(p => p.ProcessInstanceStatusTransitionMaps)
                .HasForeignKey(d => d.RequiredInputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_processinstancestatustransitionmap_requiredinputconfiguration");
        });

        modelBuilder.Entity<WFDboSkillset>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_skillset_id")
                .IsClustered(false);

            entity.ToTable("Skillset");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Definition).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboStateTransitionResolutionGroup>(entity =>
        {
            entity.ToTable("StateTransitionResolutionGroup");

            entity.HasIndex(e => e.VersionId, "ix_statetransitionresolutiongroup_versionid");
        });

        modelBuilder.Entity<WFDboStateTransitionResolutionGroupMember>(entity =>
        {
            entity.ToTable("StateTransitionResolutionGroupMember");

            entity.HasIndex(e => e.InputConfigurationId, "ix_statetransitionresolutiongroupmember_inputconfigurationid");

            entity.HasIndex(e => new { e.StateTransitionResolutionGroupId, e.InputConfigurationId, e.TransitionFromStatusId, e.TransitionToStatusId }, "uk_statetransitionresolutiongroupmember_gmid_icid_tfsid_ttsid")
                .IsUnique();

            entity.HasIndex(e => new { e.StateTransitionResolutionGroupId, e.TransitionFromStatusId, e.TransitionToStatusId, e.ResolutionOrder }, "uk_statetransitionresolutiongroupmember_statetransitionresolutiongroupmember_resolutionorder")
                .IsUnique();

            entity.Property(e => e.IsVisibleByDefault)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.InputConfiguration)
                .WithMany(p => p.StateTransitionResolutionGroupMembers)
                .HasForeignKey(d => d.InputConfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inputconfiguration_statetransitionresolutiongroupmember_inputconfigurationid");

            entity.HasOne(d => d.StateTransitionResolutionGroup)
                .WithMany(p => p.StateTransitionResolutionGroupMembers)
                .HasForeignKey(d => d.StateTransitionResolutionGroupId)
                .HasConstraintName("fk_statetransitionresolutiongroupmember_statetransitionresolutiongroupmember_statetransitionresolutiongroupid");
        });

        modelBuilder.Entity<WFDboSystemCleanup>(entity =>
        {
            entity.ToTable("SystemCleanup");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.LastCleanupDate).HasDefaultValueSql("(getutcdate())");
        });

        modelBuilder.Entity<WFDboTaskDefinition>(entity =>
        {
            entity.ToTable("TaskDefinition");

            entity.HasIndex(e => e.InitialTaskInstanceStatusId, "ix_taskdefinition_initialtaskinstancestatusid");

            entity.HasIndex(e => e.StandardStateTransitionResolutionGroupId, "ix_taskdefinition_standardstatetransitionresolutiongroup");

            entity.HasIndex(e => e.TaskDefinitionTypeId, "ix_taskdefinition_taskdefinitiontypeid");

            entity.HasIndex(e => e.VersionId, "ix_taskdefinition_versionid");

            entity.HasIndex(e => new { e.TaskDefinitionTypeId, e.Name }, "uk_taskdefinition_taskdefinitiontypeid_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_taskdefinition_uniqueid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.InitialTaskInstanceStatus)
                .WithMany(p => p.TaskDefinitions)
                .HasForeignKey(d => d.InitialTaskInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancestatus_taskdefinition_initialtaskstatusid");

            entity.HasOne(d => d.StandardStateTransitionResolutionGroup)
                .WithMany(p => p.TaskDefinitions)
                .HasForeignKey(d => d.StandardStateTransitionResolutionGroupId)
                .HasConstraintName("fk_statetransitionresolutiongroup_taskdefinition_standardstatetransitionresolutiongroupid");

            entity.HasOne(d => d.TaskDefinitionType)
                .WithMany(p => p.TaskDefinitions)
                .HasForeignKey(d => d.TaskDefinitionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskdefinitiontype_taskdefinition_taskdefinitiontypeid");
        });

        modelBuilder.Entity<WFDboTaskDefinitionConfiguration>(entity =>
        {
            entity.ToTable("TaskDefinitionConfiguration");

            entity.HasIndex(e => e.ConfigKey, "ix_taskdefinitionconfiguration_configkey");

            entity.HasIndex(e => e.TaskDefinitionId, "ix_taskdefinitionconfiguration_taskdefinitionid");

            entity.HasIndex(e => new { e.TaskDefinitionId, e.ConfigKey }, "uk_taskdefinitionconfiguration_taskdefinitionid_configkey")
                .IsUnique();

            entity.Property(e => e.ConfigData).IsRequired();

            entity.Property(e => e.ConfigKey)
                .IsRequired()
                .HasMaxLength(200);

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskDefinitionConfigurations)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_taskdefinitionconfiguration");
        });

        modelBuilder.Entity<WFDboTaskDefinitionConversationTopic>(entity =>
        {
            entity.ToTable("TaskDefinitionConversationTopic");

            entity.HasIndex(e => e.ConversationTopicId, "ix_taskdefinitionconversationtopic_conversationtopicid");

            entity.HasIndex(e => new { e.TaskDefinitionId, e.ConversationTopicId }, "uk_taskdefinitionconversationtopic")
                .IsUnique();

            entity.HasOne(d => d.ConversationTopic)
                .WithMany(p => p.TaskDefinitionConversationTopics)
                .HasForeignKey(d => d.ConversationTopicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_conversationtopic_taskdefinitionconversationtopic_conversationtopicid");

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskDefinitionConversationTopics)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_taskdefinitionconversationtopic_taskdefinitionid");
        });

        modelBuilder.Entity<WFDboTaskDefinitionDisallowedState>(entity =>
        {
            entity.ToTable("TaskDefinitionDisallowedState");

            entity.HasIndex(e => e.DisallowedTaskInstanceStatusId, "ix_taskdefinitiondisallowedstates_disallowedtaskinstancestatusid");

            entity.HasIndex(e => e.TaskDefinitionId, "ix_taskdefinitiondisallowedstates_taskdefinitionid");

            entity.HasOne(d => d.DisallowedTaskInstanceStatus)
                .WithMany(p => p.TaskDefinitionDisallowedStates)
                .HasForeignKey(d => d.DisallowedTaskInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskdefinition_taskdefinitiondisallowedstate_taskinstancestatusid");

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskDefinitionDisallowedStates)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_taskdefinitiondisallowedstate_taskdefinitionid");
        });

        modelBuilder.Entity<WFDboTaskDefinitionFlowSpecificResolution>(entity =>
        {
            entity.ToTable("TaskDefinitionFlowSpecificResolution");

            entity.HasIndex(e => new { e.TaskDefinitionId, e.ProcessDefinitionFlowId }, "uk_taskdefinitionflowspecificresolution_taskdefinitionid_processdefinitionflowid")
                .IsUnique();

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskDefinitionFlowSpecificResolutions)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_taskdefinitionflowspecificresolution");
        });

        modelBuilder.Entity<WFDboTaskDefinitionType>(entity =>
        {
            entity.ToTable("TaskDefinitionType");

            entity.HasIndex(e => e.VersionId, "ix_taskdefinitiontype_versionid");

            entity.HasIndex(e => e.Name, "uk_taskdefinitiontype_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_taskdefinitiontype_uniqueid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<WFDboTaskDefinitionWaitOnCompletion>(entity =>
        {
            entity.ToTable("TaskDefinitionWaitOnCompletion");

            entity.HasIndex(e => new { e.TaskDefinitionId, e.AttemptNumber }, "uk_taskdefinitionwaitoncompletion_taskdefinitionid_attemptnumber")
                .IsUnique();

            entity.Property(e => e.AutomationDeterminedService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.AutomationOpinionService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.CustomConfiguration).IsUnicode(false);

            entity.Property(e => e.ExpirationSecondsCalculator)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskDefinitionWaitOnCompletions)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_taskdefinitionwaitoncompletion");
        });

        modelBuilder.Entity<WFDboTaskInstance>(entity =>
        {
            entity.ToTable("TaskInstance");

            entity.HasIndex(e => e.AssignedToUserId, "ix_taskinstance_assignedtouserid");

            entity.HasIndex(e => e.Id, "ix_taskinstance_id_taskdefinitionid");

            entity.HasIndex(e => e.ParentTaskInstanceId, "ix_taskinstance_parenttaskinstanceid");

            entity.HasIndex(e => e.ProcessDefinitionFlowId, "ix_taskinstance_processdefinitionflowid");

            entity.HasIndex(e => e.ProcessInstanceId, "ix_taskinstance_processinstanceid");

            entity.HasIndex(e => e.TaskDefinitionId, "ix_taskinstance_taskdefinitionid");

            entity.HasIndex(e => new { e.TaskInstanceStatusId, e.TaskDefinitionId }, "ix_taskinstance_taskinstancestatusid");

            entity.HasIndex(e => new { e.TaskInstanceStatusId, e.ExpireTime }, "ix_taskinstance_taskinstancestatusid_expiretime");

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.ProcessDefinitionFlow)
                .WithMany(p => p.TaskInstances)
                .HasForeignKey(d => d.ProcessDefinitionFlowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processdefinitionflow_taskinstance");

            entity.HasOne(d => d.ProcessInstance)
                .WithMany(p => p.TaskInstances)
                .HasForeignKey(d => d.ProcessInstanceId)
                .HasConstraintName("fk_process_taskinstance_processinstanceid");

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskInstances)
                .HasForeignKey(d => d.TaskDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskdefinition_taskinstance_taskdefinitionid");

            entity.HasOne(d => d.TaskInstanceStatus)
                .WithMany(p => p.TaskInstances)
                .HasForeignKey(d => d.TaskInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancestatus_taskinstance");
        });

        modelBuilder.Entity<WFDboTaskInstanceActiveTime>(entity =>
        {
            entity.ToTable("TaskInstanceActiveTime");

            entity.HasIndex(e => e.TaskInstanceId, "ix_taskinstanceactivetime_taskinstanceid");

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.TaskInstanceActiveTimes)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_taskinstance_taskinstanceactivetime_taskinstanceid");
        });

        modelBuilder.Entity<WFDboTaskInstanceBatch>(entity =>
        {
            entity.ToTable("TaskInstanceBatch");

            entity.HasIndex(e => e.TaskInstanceBatchConfigurationId, "ix_taskinstancebatch_taskinstancebatchconfigurationid");

            entity.HasIndex(e => e.TaskInstanceBatchStatusId, "ix_taskinstancebatch_taskinstancebatchstatusid");

            entity.HasIndex(e => e.TaskInstanceGroupId, "ix_taskinstancebatch_taskinstancegroupid");

            entity.HasIndex(e => e.BatchProcessInstanceId, "uk_taskinstancebatch_batchprocessinstanceid")
                .IsUnique();

            entity.HasOne(d => d.BatchProcessInstance)
                .WithOne(p => p.TaskInstanceBatch)
                .HasForeignKey<WFDboTaskInstanceBatch>(d => d.BatchProcessInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processinstance_taskinstancebatch_batchprocessinstanceid");

            entity.HasOne(d => d.TaskInstanceBatchConfiguration)
                .WithMany(p => p.TaskInstanceBatches)
                .HasForeignKey(d => d.TaskInstanceBatchConfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancebatchconfiguration_taskinstancebatch_taskinstancebatchconfigurationid");

            entity.HasOne(d => d.TaskInstanceBatchStatus)
                .WithMany(p => p.TaskInstanceBatches)
                .HasForeignKey(d => d.TaskInstanceBatchStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancebatchstatus_taskinstancebatch_taskinstancebatchstatusid");

            entity.HasOne(d => d.TaskInstanceGroup)
                .WithMany(p => p.TaskInstanceBatches)
                .HasForeignKey(d => d.TaskInstanceGroupId)
                .HasConstraintName("fk_taskinstancegroup_taskinstancebatch_taskinstancegroupid");
        });

        modelBuilder.Entity<WFDboTaskInstanceBatchConfiguration>(entity =>
        {
            entity.ToTable("TaskInstanceBatchConfiguration");

            entity.HasIndex(e => e.BatchProcessDefinitionId, "ix_taskinstancebatchconfiguration_batchprocessdefinitionid");

            entity.HasIndex(e => e.TaskInstanceGroupConfigurationId, "ix_taskinstancebatchconfiguration_taskinstancegroupconfiguration");

            entity.Property(e => e.BatchItemCompleteService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.BatchItemReleaseService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.CustomTimingService)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.TimingInfo).IsUnicode(false);

            entity.HasOne(d => d.BatchProcessDefinition)
                .WithMany(p => p.TaskInstanceBatchConfigurations)
                .HasForeignKey(d => d.BatchProcessDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_processdefinition_taskinstancegroupconfiguration_batchprocessdefinitionid");

            entity.HasOne(d => d.TaskInstanceGroupConfiguration)
                .WithMany(p => p.TaskInstanceBatchConfigurations)
                .HasForeignKey(d => d.TaskInstanceGroupConfigurationId)
                .HasConstraintName("fk_taskinstancegroupconfiguration_taskinstancebatchconfiguration_taskinstancegroupconfigurationid");
        });

        modelBuilder.Entity<WFDboTaskInstanceBatchItem>(entity =>
        {
            entity.ToTable("TaskInstanceBatchItem");

            entity.HasIndex(e => new { e.BatchEnterpriseEntityId, e.BatchEntityId }, "ix_taskinstancebatchitem_batchenterpriseentityid_batchentityid");

            entity.HasIndex(e => e.TaskInstanceBatchId, "ix_taskinstancebatchitem_taskinstancebatchid");

            entity.HasIndex(e => e.TaskInstanceBatchItemStatusId, "ix_taskinstancebatchitem_taskinstancebatchitemstatusid");

            entity.HasIndex(e => e.TaskInstanceGroupItemId, "ix_taskinstancebatchitem_taskinstancegroupitemid");

            entity.Property(e => e.BatchEntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.TaskInstanceBatch)
                .WithMany(p => p.TaskInstanceBatchItems)
                .HasForeignKey(d => d.TaskInstanceBatchId)
                .HasConstraintName("fk_taskinstancebatch_taskinstancebatchitem_taskinstancebatchid");

            entity.HasOne(d => d.TaskInstanceBatchItemStatus)
                .WithMany(p => p.TaskInstanceBatchItems)
                .HasForeignKey(d => d.TaskInstanceBatchItemStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancebatchitemstatus_taskinstancebatchitem_taskinstancebatchitemstatusid");

            entity.HasOne(d => d.TaskInstanceGroupItem)
                .WithMany(p => p.TaskInstanceBatchItems)
                .HasForeignKey(d => d.TaskInstanceGroupItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancegroupitem_taskinstancebatchitem_taskinstancegroupitemid");
        });

        modelBuilder.Entity<WFDboTaskInstanceBatchItemStatus>(entity =>
        {
            entity.ToTable("TaskInstanceBatchItemStatus");

            entity.HasIndex(e => e.Name, "uk_taskinstancebatchitemstatus_name")
                .IsUnique();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboTaskInstanceBatchStatus>(entity =>
        {
            entity.ToTable("TaskInstanceBatchStatus");

            entity.HasIndex(e => e.Name, "uk_taskinstancebatchstatus_name")
                .IsUnique();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboTaskInstanceBatchTiming>(entity =>
        {
            entity.ToTable("TaskInstanceBatchTiming");

            entity.HasIndex(e => e.Name, "uk_taskinstancebatchtiming_name")
                .IsUnique();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboTaskInstanceChangeAssignmentEvent>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceEventId)
                .HasName("pk_taskinstancechangeassignmentevent_taskinstanceeventid");

            entity.ToTable("TaskInstanceChangeAssignmentEvent");

            entity.Property(e => e.TaskInstanceEventId).ValueGeneratedNever();

            entity.HasOne(d => d.TaskInstanceEvent)
                .WithOne(p => p.TaskInstanceChangeAssignmentEvent)
                .HasForeignKey<WFDboTaskInstanceChangeAssignmentEvent>(d => d.TaskInstanceEventId)
                .HasConstraintName("fk_taskinstanceevent_taskinstancechangeassignmentevent_taskinstanceeventid");
        });

        modelBuilder.Entity<WFDboTaskInstanceEvent>(entity =>
        {
            entity.ToTable("TaskInstanceEvent");

            entity.HasIndex(e => new { e.CreatedBy, e.CreatedOn }, "ix_taskinstanceevent_createdby_createdon");

            entity.HasIndex(e => new { e.CreatedOn, e.CreatedBy }, "ix_taskinstanceevent_createdon_createdby");

            entity.HasIndex(e => e.TaskInstanceId, "ix_taskinstanceevent_taskinstanceid");

            entity.HasIndex(e => e.TriggeringEventId, "ix_taskinstanceevent_triggeringeventid");

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.TaskInstanceEvents)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_taskinstance_taskinstanceevent_taskinstanceid");

            entity.HasOne(d => d.TriggeringEvent)
                .WithMany(p => p.TaskInstanceEvents)
                .HasForeignKey(d => d.TriggeringEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_event_taskinstanceevent");
        });

        modelBuilder.Entity<WFDboTaskInstanceGroup>(entity =>
        {
            entity.ToTable("TaskInstanceGroup");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityId }, "ix_taskinstancegroup_enterpriseentityid_entityid");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityId, e.IsClosed }, "ix_taskinstancegroup_enterpriseentityid_entityid_isclosed");

            entity.HasIndex(e => e.TaskInstanceGroupConfigurationId, "ix_taskinstancegroup_taskinstancegroupconfigurationid");

            entity.Property(e => e.EntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.TaskInstanceGroupConfiguration)
                .WithMany(p => p.TaskInstanceGroups)
                .HasForeignKey(d => d.TaskInstanceGroupConfigurationId)
                .HasConstraintName("fk_taskinstancegroupconfiguration_taskinstancegroup_taskinstancegroupconfigurationid");
        });

        modelBuilder.Entity<WFDboTaskInstanceGroupConfiguration>(entity =>
        {
            entity.ToTable("TaskInstanceGroupConfiguration");

            entity.HasIndex(e => e.TaskDefinitionId, "ix_taskinstancegroupconfiguration_taskdefinitionid");

            entity.HasOne(d => d.TaskDefinition)
                .WithMany(p => p.TaskInstanceGroupConfigurations)
                .HasForeignKey(d => d.TaskDefinitionId)
                .HasConstraintName("fk_taskdefinition_taskinstancegroupconfiguration_taskdefinitionid");
        });

        modelBuilder.Entity<WFDboTaskInstanceGroupItem>(entity =>
        {
            entity.ToTable("TaskInstanceGroupItem");

            entity.HasIndex(e => new { e.TaskInstanceId, e.TaskInstanceGroupId }, "ix_taskinstancegroupitem_taskinstanceid_taskinstancegroupid");

            entity.HasIndex(e => new { e.TaskInstanceGroupId, e.TaskInstanceId }, "uk_taskinstancegroupitem_taskinstancegroupid_taskinstanceid")
                .IsUnique();

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.TaskInstanceGroupItems)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_taskinstance_taskinstancegroupitem_taskinstanceid");
        });

        modelBuilder.Entity<WFDboTaskInstanceReferenceEntity>(entity =>
        {
            entity.ToTable("TaskInstanceReferenceEntity");

            entity.HasIndex(e => new { e.EnterpriseEntityId, e.EntityId }, "ix_taskinstancereferenceentity_enterpriseentityid_entityid");

            entity.HasIndex(e => new { e.TaskInstanceId, e.EnterpriseEntityId, e.EntityId }, "uk_taskinstancereferenceentity_taskinstanceid_enterpriseentityid_entityid")
                .IsUnique();

            entity.Property(e => e.EntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.TaskInstanceReferenceEntities)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_taskinstance_taskinstancereferenceentity_taskinstanceid");
        });

        modelBuilder.Entity<WFDboTaskInstanceRoutingBlacklist>(entity =>
        {
            entity.ToTable("TaskInstanceRoutingBlacklist");

            entity.HasIndex(e => e.ConflictingLockId, "ix_taskinstanceroutingblacklist_conflictinglockid");

            entity.HasIndex(e => e.ExpirationHandle, "ix_taskinstanceroutingblacklist_expirationhandle");

            entity.HasIndex(e => e.TaskInstanceId, "ix_taskinstanceroutingblacklist_taskinstanceid");

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.TaskInstanceRoutingBlacklists)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_taskinstance_taskinstanceroutingblacklist");
        });

        modelBuilder.Entity<WFDboTaskInstanceRoutingKey>(entity =>
        {
            entity.ToTable("TaskInstanceRoutingKey");

            entity.HasIndex(e => e.RoutingKey, "ix_taskinstanceroutingkey_routingkey");

            entity.HasIndex(e => new { e.TaskInstanceId, e.RoutingKey }, "uk_taskinstanceroutingkey_taskinstanceid_routingkey")
                .IsUnique();

            entity.HasOne(d => d.TaskInstance)
                .WithMany(p => p.TaskInstanceRoutingKeys)
                .HasForeignKey(d => d.TaskInstanceId)
                .HasConstraintName("fk_activeusertaskinstance_taskinstanceroutingkey_taskinstanceid");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatus>(entity =>
        {
            entity.ToTable("TaskInstanceStatus");

            entity.HasIndex(e => e.TaskInstanceStatusGroupId, "ix_taskinstancestatus_taskinstancestatusgroupid");

            entity.HasIndex(e => e.VersionId, "ix_taskinstancestatus_versionid");

            entity.HasIndex(e => e.Name, "uk_taskinstancestatus_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.TaskInstanceStatusGroup)
                .WithMany(p => p.TaskInstanceStatuses)
                .HasForeignKey(d => d.TaskInstanceStatusGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancestatusgroup_taskinstancestatus_taskinstancestatusgroupid");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusGroup>(entity =>
        {
            entity.ToTable("TaskInstanceStatusGroup");

            entity.HasIndex(e => e.VersionId, "ix_taskinstancestatusgroup_versionid");

            entity.HasIndex(e => e.Name, "uk_taskinstancestatusgroup_name")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEvent>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceEventId)
                .HasName("pk_taskstatustransitionevent_taskinstanceeventid");

            entity.ToTable("TaskInstanceStatusTransitionEvent");

            entity.HasIndex(e => e.PostTransitionTaskInstanceStatusId, "ix_taskinstancestatustransitionevent_posttransitiontaskinstancestatusid");

            entity.HasIndex(e => e.PreTransitionTaskInstanceStatusId, "ix_taskinstancestatustransitionevent_pretransitiontaskinstancestatusid");

            entity.Property(e => e.TaskInstanceEventId).ValueGeneratedNever();

            entity.HasOne(d => d.PostTransitionTaskInstanceStatus)
                .WithMany(p => p.TaskInstanceStatusTransitionEventPostTransitionTaskInstanceStatuses)
                .HasForeignKey(d => d.PostTransitionTaskInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancestatustransitionevent_taskinstancestatus_posttransitiontaskinstancestatusid");

            entity.HasOne(d => d.PreTransitionTaskInstanceStatus)
                .WithMany(p => p.TaskInstanceStatusTransitionEventPreTransitionTaskInstanceStatuses)
                .HasForeignKey(d => d.PreTransitionTaskInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancestatustransitionevent_taskinstancestatus_pretransitiontaskinstancestatusid");

            entity.HasOne(d => d.TaskInstanceEvent)
                .WithOne(p => p.TaskInstanceStatusTransitionEvent)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEvent>(d => d.TaskInstanceEventId)
                .HasConstraintName("fk_taskinstanceevent_taskinstancestatustransitionevent_taskinstanceeventid");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolution>(entity =>
        {
            entity.ToTable("TaskInstanceStatusTransitionEventResolution");

            entity.HasIndex(e => e.InputConfigurationId, "ix_taskinstancestatustransitioneventresolution_inputconfigurationid");

            entity.HasIndex(e => e.TaskInstanceEventId, "ix_taskinstancestatustransitioneventresolution_taskinstanceeventid");

            entity.HasOne(d => d.InputConfiguration)
                .WithMany(p => p.TaskInstanceStatusTransitionEventResolutions)
                .HasForeignKey(d => d.InputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_taskInstancestatustransitioneventresolution_inputconfigurationid");

            entity.HasOne(d => d.TaskInstanceEvent)
                .WithMany(p => p.TaskInstanceStatusTransitionEventResolutions)
                .HasForeignKey(d => d.TaskInstanceEventId)
                .HasConstraintName("fk_taskinstancestatustransitionevent_taskInstancestatustransitioneventresolution_taskinstanceeventid");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionAsync>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceStatusTransitionEventResolutionId)
                .HasName("pk_taskstatustransitioneventresolutionasync_id");

            entity.ToTable("TaskInstanceStatusTransitionEventResolutionAsync");

            entity.Property(e => e.TaskInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.Property(e => e.EventArgs).IsUnicode(false);

            entity.Property(e => e.MessageId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TriggeringMessageId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithOne(p => p.TaskInstanceStatusTransitionEventResolutionAsync)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEventResolutionAsync>(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskInstancestatustransitioneventresolutionasync");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionCancelWait>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceStatusTransitionEventResolutionId)
                .HasName("pk_taskstatustransitioneventresolutioncancelwait_id");

            entity.ToTable("TaskInstanceStatusTransitionEventResolutionCancelWait");

            entity.Property(e => e.TaskInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithOne(p => p.TaskInstanceStatusTransitionEventResolutionCancelWait)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEventResolutionCancelWait>(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskInstancestatustransitioneventresolutioncancelwait");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstance>(entity =>
        {
            entity.ToTable("TaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstance");

            entity.HasIndex(e => e.TaskInstanceStatusTransitionEventResolutionId, "ix_taskstatustransitioneventresolutioncancelwaittaskinstance_taskinstancestatustransitioneventresolutionid");

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithMany(p => p.TaskInstanceStatusTransitionEventResolutionCancelWaitTaskInstances)
                .HasForeignKey(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskstatustransitioneventresolutioncancelwaittaskinstance");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceStatusTransitionEventResolutionId)
                .HasName("pk_taskstatustransitioneventresolutionfinalizeprocessing_id");

            entity.ToTable("TaskInstanceStatusTransitionEventResolutionFinalizeProcessing");

            entity.Property(e => e.TaskInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithOne(p => p.TaskInstanceStatusTransitionEventResolutionFinalizeProcessing)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessing>(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskInstancestatustransitioneventresolutionfinalizeprocessing");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstance>(entity =>
        {
            entity.ToTable("TaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstance");

            entity.HasIndex(e => e.TaskInstanceStatusTransitionEventResolutionId, "ix_taskstatustransitioneventresolutionfinalizeprocessingtaskinstance_taskinstancestatustransitioneventresolutionid");

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithMany(p => p.TaskInstanceStatusTransitionEventResolutionFinalizeProcessingTaskInstances)
                .HasForeignKey(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskstatustransitioneventresolutionfinalizeprocessingtaskinstance");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionFollowup>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceStatusTransitionEventResolutionId)
                .HasName("pk_taskinstancestatustransitioneventresolutionfollowup_taskinstancestatustransitioneventresolutionid");

            entity.ToTable("TaskInstanceStatusTransitionEventResolutionFollowup");

            entity.Property(e => e.TaskInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithOne(p => p.TaskInstanceStatusTransitionEventResolutionFollowup)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEventResolutionFollowup>(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskinstancestatustransitioneventresolutionfollowup");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionOption>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceStatusTransitionEventResolutionId)
                .HasName("pk_taskstatustransitioneventresolutionoption_id");

            entity.ToTable("TaskInstanceStatusTransitionEventResolutionOption");

            entity.Property(e => e.TaskInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithOne(p => p.TaskInstanceStatusTransitionEventResolutionOption)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEventResolutionOption>(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskInstancestatustransitioneventresolutionoption");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionOptionSelection>(entity =>
        {
            entity.ToTable("TaskInstanceStatusTransitionEventResolutionOptionSelection");

            entity.HasIndex(e => e.InputConfigurationOptionItemId, "ix_taskinstancestatustransitioneventresolutionoptionselection_inputconfigurationoptionitemid");

            entity.HasIndex(e => e.TaskInstanceStatusTransitionEventResolutionId, "ix_taskinstancestatustransitioneventresolutionoptionselection_taskinstancestatustransitioneventresolutionid");

            entity.HasOne(d => d.InputConfigurationOptionItem)
                .WithMany(p => p.TaskInstanceStatusTransitionEventResolutionOptionSelections)
                .HasForeignKey(d => d.InputConfigurationOptionItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_inputconfigurationoptionitem_taskInstancestatustransitioneventresolutionoptionselection_inputconfigurationoptionitemid");

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithMany(p => p.TaskInstanceStatusTransitionEventResolutionOptionSelections)
                .HasForeignKey(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolutionoption_taskInstancestatustransitioneventresolutionoptionselection");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionEventResolutionText>(entity =>
        {
            entity.HasKey(e => e.TaskInstanceStatusTransitionEventResolutionId)
                .HasName("pk_taskstatustransitioneventresolutiontext_taskinstancestatustransitioneventresolutionid");

            entity.ToTable("TaskInstanceStatusTransitionEventResolutionText");

            entity.Property(e => e.TaskInstanceStatusTransitionEventResolutionId).ValueGeneratedNever();

            entity.Property(e => e.ResolutionText).IsRequired();

            entity.HasOne(d => d.TaskInstanceStatusTransitionEventResolution)
                .WithOne(p => p.TaskInstanceStatusTransitionEventResolutionText)
                .HasForeignKey<WFDboTaskInstanceStatusTransitionEventResolutionText>(d => d.TaskInstanceStatusTransitionEventResolutionId)
                .HasConstraintName("fk_taskinstancestatustransitioneventresolution_taskInstancestatustransitioneventresolutiontext");
        });

        modelBuilder.Entity<WFDboTaskInstanceStatusTransitionMap>(entity =>
        {
            entity.ToTable("TaskInstanceStatusTransitionMap");

            entity.HasIndex(e => e.CanTransitionToTaskInstanceStatusId, "ix_taskinstancestatustransitionmap_cantransitiontotaskinstancestatusid");

            entity.HasIndex(e => e.RequiredInputConfigurationId, "ix_taskinstancestatustransitionmap_requiredinputconfigurationid");

            entity.HasIndex(e => new { e.TaskInstanceStatusId, e.CanTransitionToTaskInstanceStatusId }, "uk_taskinstancestatustransitionmap_taskinstancestatusid_cantransitiontotaskinstancestatusid")
                .IsUnique();

            entity.Property(e => e.TransitionVerb)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.CanTransitionToTaskInstanceStatus)
                .WithMany(p => p.TaskInstanceStatusTransitionMapCanTransitionToTaskInstanceStatuses)
                .HasForeignKey(d => d.CanTransitionToTaskInstanceStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskinstancestatus_taskinstancestatustransitionmap_cantransitiontotaskinstancestatusid");

            entity.HasOne(d => d.RequiredInputConfiguration)
                .WithMany(p => p.TaskInstanceStatusTransitionMaps)
                .HasForeignKey(d => d.RequiredInputConfigurationId)
                .HasConstraintName("fk_inputconfiguration_taskinstancestatustransitionmap_requiredinputconfiguration");

            entity.HasOne(d => d.TaskInstanceStatus)
                .WithMany(p => p.TaskInstanceStatusTransitionMapTaskInstanceStatuses)
                .HasForeignKey(d => d.TaskInstanceStatusId)
                .HasConstraintName("fk_taskinstancestatus_taskinstancestatustransitionmap_taskinstancestatusid");
        });

        modelBuilder.Entity<WFDboUser>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_users_id")
                .IsClustered(false);

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboVersionedDatum>(entity =>
        {
            entity.HasIndex(e => e.MaxVersionId, "ix_versioneddata_maxversionid");

            entity.HasIndex(e => e.TableName, "ix_versioneddata_tablename");

            entity.HasIndex(e => e.TableName, "uk_versioneddata_tablename")
                .IsUnique();

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasMaxLength(150);
        });

        modelBuilder.Entity<WFDboWorkflowOperation>(entity =>
        {
            entity.ToTable("WorkflowOperation");

            entity.HasIndex(e => e.DefaultImplementationClassName, "uk_workflowoperation_defaultimplementationclassname")
                .IsUnique();

            entity.HasIndex(e => e.Name, "uk_workflowoperation_name")
                .IsUnique();

            entity.Property(e => e.DefaultImplementationClassName).IsRequired();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.IsolationLevel)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<WFDboWorkflowOperationException>(entity =>
        {
            entity.ToTable("WorkflowOperationException");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getutcdate())");

            entity.Property(e => e.ExceptionCallstack).IsUnicode(false);

            entity.Property(e => e.ExceptionMessage).IsUnicode(false);

            entity.Property(e => e.ExceptionPolicy)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ExceptionType).IsUnicode(false);

            entity.Property(e => e.MessageId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.MessageTopic).IsUnicode(false);

            entity.Property(e => e.OperationCallstack).IsUnicode(false);

            entity.Property(e => e.OperationList)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.ServerName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TriggeringMessageId)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.HasSequence("VersionSequence");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
