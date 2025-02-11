﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample.Components;

#nullable disable

namespace Sample.Api.SqlServer.Migrations
{
    [DbContext(typeof(SampleDbContext))]
    partial class SampleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("sample")
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MassTransit.EntityFrameworkCoreIntegration.InboxState", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("Consumed")
                        .HasColumnType("datetime2")
                        .HasColumnName("consumed");

                    b.Property<Guid>("ConsumerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("consumer_id");

                    b.Property<DateTime?>("Delivered")
                        .HasColumnType("datetime2")
                        .HasColumnName("delivered");

                    b.Property<DateTime?>("ExpirationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("expiration_time");

                    b.Property<long?>("LastSequenceNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("last_sequence_number");

                    b.Property<Guid>("LockId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lock_id");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("message_id");

                    b.Property<int>("ReceiveCount")
                        .HasColumnType("int")
                        .HasColumnName("receive_count");

                    b.Property<DateTime>("Received")
                        .HasColumnType("datetime2")
                        .HasColumnName("received");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("row_version");

                    b.HasKey("Id");

                    b.HasIndex("Delivered");

                    b.ToTable("inbox_state", "sample");
                });

            modelBuilder.Entity("MassTransit.EntityFrameworkCoreIntegration.OutboxMessage", b =>
                {
                    b.Property<long>("SequenceNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("sequence_number");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SequenceNumber"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("body");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("content_type");

                    b.Property<Guid?>("ConversationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("conversation_id");

                    b.Property<Guid?>("CorrelationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("correlation_id");

                    b.Property<string>("DestinationAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("destination_address");

                    b.Property<DateTime?>("EnqueueTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("enqueue_time");

                    b.Property<DateTime?>("ExpirationTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("expiration_time");

                    b.Property<string>("FaultAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("fault_address");

                    b.Property<string>("Headers")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("headers");

                    b.Property<Guid?>("InboxConsumerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("inbox_consumer_id");

                    b.Property<Guid?>("InboxMessageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("inbox_message_id");

                    b.Property<Guid?>("InitiatorId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("initiator_id");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("message_id");

                    b.Property<string>("MessageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("message_type");

                    b.Property<Guid?>("OutboxId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("outbox_id");

                    b.Property<string>("Properties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("properties");

                    b.Property<Guid?>("RequestId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("request_id");

                    b.Property<string>("ResponseAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("response_address");

                    b.Property<DateTime>("SentTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("sent_time");

                    b.Property<string>("SourceAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("source_address");

                    b.HasKey("SequenceNumber");

                    b.HasIndex("EnqueueTime");

                    b.HasIndex("ExpirationTime");

                    b.HasIndex("OutboxId", "SequenceNumber")
                        .IsUnique()
                        .HasFilter("[outbox_id] IS NOT NULL");

                    b.HasIndex("InboxMessageId", "InboxConsumerId", "SequenceNumber")
                        .IsUnique()
                        .HasFilter("[inbox_message_id] IS NOT NULL AND [inbox_consumer_id] IS NOT NULL");

                    b.ToTable("outbox_message", "sample");
                });

            modelBuilder.Entity("MassTransit.EntityFrameworkCoreIntegration.OutboxState", b =>
                {
                    b.Property<Guid>("OutboxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("outbox_id");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2")
                        .HasColumnName("created");

                    b.Property<DateTime?>("Delivered")
                        .HasColumnType("datetime2")
                        .HasColumnName("delivered");

                    b.Property<long?>("LastSequenceNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("last_sequence_number");

                    b.Property<Guid>("LockId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("lock_id");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion")
                        .HasColumnName("row_version");

                    b.HasKey("OutboxId");

                    b.HasIndex("Created");

                    b.ToTable("outbox_state", "sample");
                });

            modelBuilder.Entity("MassTransit.JobAttemptSaga", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("correlation_id");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int")
                        .HasColumnName("current_state");

                    b.Property<DateTime?>("Faulted")
                        .HasColumnType("datetime2")
                        .HasColumnName("faulted");

                    b.Property<string>("InstanceAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("instance_address");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("job_id");

                    b.Property<int>("RetryAttempt")
                        .HasColumnType("int")
                        .HasColumnName("retry_attempt");

                    b.Property<string>("ServiceAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("service_address");

                    b.Property<DateTime?>("Started")
                        .HasColumnType("datetime2")
                        .HasColumnName("started");

                    b.Property<Guid?>("StatusCheckTokenId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("status_check_token_id");

                    b.HasKey("CorrelationId");

                    b.HasIndex("JobId", "RetryAttempt")
                        .IsUnique();

                    b.ToTable("job_attempt_saga", "sample");
                });

            modelBuilder.Entity("MassTransit.JobSaga", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("correlation_id");

                    b.Property<Guid>("AttemptId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("attempt_id");

                    b.Property<DateTime?>("Completed")
                        .HasColumnType("datetime2")
                        .HasColumnName("completed");

                    b.Property<string>("CronExpression")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cron_expression");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int")
                        .HasColumnName("current_state");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time")
                        .HasColumnName("duration");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("end_date");

                    b.Property<DateTime?>("Faulted")
                        .HasColumnType("datetime2")
                        .HasColumnName("faulted");

                    b.Property<string>("IncompleteAttempts")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("incomplete_attempts");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("job");

                    b.Property<string>("JobProperties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("job_properties");

                    b.Property<Guid?>("JobRetryDelayToken")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("job_retry_delay_token");

                    b.Property<Guid?>("JobSlotWaitToken")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("job_slot_wait_token");

                    b.Property<string>("JobState")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("job_state");

                    b.Property<TimeSpan?>("JobTimeout")
                        .HasColumnType("time")
                        .HasColumnName("job_timeout");

                    b.Property<Guid>("JobTypeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("job_type_id");

                    b.Property<long?>("LastProgressLimit")
                        .HasColumnType("bigint")
                        .HasColumnName("last_progress_limit");

                    b.Property<long?>("LastProgressSequenceNumber")
                        .HasColumnType("bigint")
                        .HasColumnName("last_progress_sequence_number");

                    b.Property<long?>("LastProgressValue")
                        .HasColumnType("bigint")
                        .HasColumnName("last_progress_value");

                    b.Property<DateTimeOffset?>("NextStartDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("next_start_date");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reason");

                    b.Property<int>("RetryAttempt")
                        .HasColumnType("int")
                        .HasColumnName("retry_attempt");

                    b.Property<string>("ServiceAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("service_address");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("start_date");

                    b.Property<DateTime?>("Started")
                        .HasColumnType("datetime2")
                        .HasColumnName("started");

                    b.Property<DateTime?>("Submitted")
                        .HasColumnType("datetime2")
                        .HasColumnName("submitted");

                    b.Property<string>("TimeZoneId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("time_zone_id");

                    b.HasKey("CorrelationId");

                    b.ToTable("job_saga", "sample");
                });

            modelBuilder.Entity("MassTransit.JobTypeSaga", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("correlation_id");

                    b.Property<int>("ActiveJobCount")
                        .HasColumnType("int")
                        .HasColumnName("active_job_count");

                    b.Property<string>("ActiveJobs")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("active_jobs");

                    b.Property<int>("ConcurrentJobLimit")
                        .HasColumnType("int")
                        .HasColumnName("concurrent_job_limit");

                    b.Property<int>("CurrentState")
                        .HasColumnType("int")
                        .HasColumnName("current_state");

                    b.Property<int?>("GlobalConcurrentJobLimit")
                        .HasColumnType("int")
                        .HasColumnName("global_concurrent_job_limit");

                    b.Property<string>("Instances")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("instances");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int?>("OverrideJobLimit")
                        .HasColumnType("int")
                        .HasColumnName("override_job_limit");

                    b.Property<DateTime?>("OverrideLimitExpiration")
                        .HasColumnType("datetime2")
                        .HasColumnName("override_limit_expiration");

                    b.Property<string>("Properties")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("properties");

                    b.HasKey("CorrelationId");

                    b.ToTable("job_type_saga", "sample");
                });

            modelBuilder.Entity("Sample.Components.StateMachines.RegistrationState", b =>
                {
                    b.Property<Guid>("CorrelationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("correlation_id");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("card_number");

                    b.Property<string>("CurrentState")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("current_state");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("event_id");

                    b.Property<string>("ParticipantCategory")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("participant_category");

                    b.Property<string>("ParticipantEmailAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("participant_email_address");

                    b.Property<DateTime?>("ParticipantLicenseExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("participant_license_expiration_date");

                    b.Property<string>("ParticipantLicenseNumber")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("participant_license_number");

                    b.Property<string>("RaceId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("race_id");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reason");

                    b.Property<Guid?>("RegistrationId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("registration_id");

                    b.Property<int?>("RetryAttempt")
                        .HasColumnType("int")
                        .HasColumnName("retry_attempt");

                    b.Property<Guid?>("ScheduleRetryToken")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("schedule_retry_token");

                    b.HasKey("CorrelationId");

                    b.ToTable("registration_state", "sample");
                });

            modelBuilder.Entity("MassTransit.EntityFrameworkCoreIntegration.OutboxMessage", b =>
                {
                    b.HasOne("MassTransit.EntityFrameworkCoreIntegration.OutboxState", null)
                        .WithMany()
                        .HasForeignKey("OutboxId");

                    b.HasOne("MassTransit.EntityFrameworkCoreIntegration.InboxState", null)
                        .WithMany()
                        .HasForeignKey("InboxMessageId", "InboxConsumerId")
                        .HasPrincipalKey("MessageId", "ConsumerId");
                });

            modelBuilder.Entity("MassTransit.JobAttemptSaga", b =>
                {
                    b.HasOne("MassTransit.JobSaga", null)
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
