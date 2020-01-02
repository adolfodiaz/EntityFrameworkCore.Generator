using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tracker.Data.Mapping
{
    public partial class TaskMap
        : IEntityTypeConfiguration<Tracker.Data.Entities.Task>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tracker.Data.Entities.Task> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task", "public");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("uuid");

            builder.Property(t => t.StatusId)
                .IsRequired()
                .HasColumnName("StatusId")
                .HasColumnType("uuid");

            builder.Property(t => t.PriorityId)
                .HasColumnName("PriorityId")
                .HasColumnType("uuid");

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasColumnType("character varying(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("text");

            builder.Property(t => t.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("timestamp with time zone");

            builder.Property(t => t.DueDate)
                .HasColumnName("DueDate")
                .HasColumnType("timestamp with time zone");

            builder.Property(t => t.CompleteDate)
                .HasColumnName("CompleteDate")
                .HasColumnType("timestamp with time zone");

            builder.Property(t => t.AssignedId)
                .HasColumnName("AssignedId")
                .HasColumnType("uuid");

            builder.Property(t => t.Created)
                .IsRequired()
                .HasColumnName("Created")
                .HasColumnType("timestamp with time zone")
                .HasDefaultValueSql("timezone('utc'::text, now())");

            builder.Property(t => t.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Updated)
                .IsRequired()
                .HasColumnName("Updated")
                .HasColumnType("timestamp with time zone")
                .HasDefaultValueSql("timezone('utc'::text, now())");

            builder.Property(t => t.UpdatedBy)
                .HasColumnName("UpdatedBy")
                .HasColumnType("character varying(100)")
                .HasMaxLength(100);

            builder.Property(t => t.RowVersion)
                .HasColumnName("RowVersion")
                .HasColumnType("bytea");

            // relationships
            builder.HasOne(t => t.Priority)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.PriorityId)
                .HasConstraintName("FK_Task_Priority_PriorityId");

            builder.HasOne(t => t.Status)
                .WithMany(t => t.Tasks)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_Task_Status_StatusId");

            builder.HasOne(t => t.AssignedUser)
                .WithMany(t => t.AssignedTasks)
                .HasForeignKey(d => d.AssignedId)
                .HasConstraintName("FK_Task_User_AssignedId");

            #endregion
        }

    }
}
