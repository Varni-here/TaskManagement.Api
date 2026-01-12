using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AttachmentMaster> AttachmentMasters { get; set; }

    public virtual DbSet<ConfigMaster> ConfigMasters { get; set; }

    public virtual DbSet<EmailOtpRecord> EmailOtpRecords { get; set; }

    public virtual DbSet<PanelGuest> PanelGuests { get; set; }

    public virtual DbSet<ProjectMaster> ProjectMasters { get; set; }

    public virtual DbSet<TaskDiscussion> TaskDiscussions { get; set; }

    public virtual DbSet<TaskPanel> TaskPanels { get; set; }

    public virtual DbSet<TaskPanelInvitation> TaskPanelInvitations { get; set; }

    public virtual DbSet<TaskPanelMapping> TaskPanelMappings { get; set; }

    public virtual DbSet<TasksMaster> TasksMasters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserExternalLogin> UserExternalLogins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AttachmentMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Attachme__3213E83F030C8E5B");

            entity.ToTable("AttachmentMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttachmentPath)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("attachmentPath");
            entity.Property(e => e.AttachmentTypeId).HasColumnName("attachmentTypeId");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ParentId).HasColumnName("parentId");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.AttachmentType).WithMany(p => p.AttachmentMasters)
                .HasForeignKey(d => d.AttachmentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Attachmen__attac__2A164134");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.AttachmentMasterCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Attachmen__creat__282DF8C2");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.AttachmentMasterUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__Attachmen__updat__29221CFB");
        });

        modelBuilder.Entity<ConfigMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ConfigMa__3213E83F374D0DE7");

            entity.ToTable("ConfigMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ConfigKey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("configKey");
            entity.Property(e => e.ConfigValue)
                .IsUnicode(false)
                .HasColumnName("configValue");
        });

        modelBuilder.Entity<EmailOtpRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmailOtp__3213E83FEDF414AB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.IsUsed)
                .HasDefaultValue(false)
                .HasColumnName("isUsed");
            entity.Property(e => e.Otp)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("otp");
        });

        modelBuilder.Entity<PanelGuest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PanelGue__3213E83F88C4AF09");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.GuestId).HasColumnName("guestId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsLeaved).HasColumnName("isLeaved");
            entity.Property(e => e.TaskPanelId).HasColumnName("taskPanelId");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PanelGuestCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PanelGues__creat__18EBB532");

            entity.HasOne(d => d.Guest).WithMany(p => p.PanelGuestGuests)
                .HasForeignKey(d => d.GuestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PanelGues__guest__1AD3FDA4");

            entity.HasOne(d => d.TaskPanel).WithMany(p => p.PanelGuests)
                .HasForeignKey(d => d.TaskPanelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PanelGues__taskP__1BC821DD");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.PanelGuestUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__PanelGues__updat__19DFD96B");
        });

        modelBuilder.Entity<ProjectMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProjectM__3213E83FBA5986AA");

            entity.ToTable("ProjectMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ProjectDescription)
                .IsUnicode(false)
                .HasColumnName("projectDescription");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("projectName");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.ProjectMasterCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProjectMa__creat__07C12930");

            entity.HasOne(d => d.Status).WithMany(p => p.ProjectMasters)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProjectMa__statu__09A971A2");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.ProjectMasterUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__ProjectMa__updat__08B54D69");
        });

        modelBuilder.Entity<TaskDiscussion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskDisc__3213E83F61320054");

            entity.ToTable("TaskDiscussion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.DiscussionText)
                .IsUnicode(false)
                .HasColumnName("discussionText");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ReplyOfDiscussionId).HasColumnName("replyOfDiscussionId");
            entity.Property(e => e.TaskId).HasColumnName("taskId");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskDiscussionCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskDiscu__creat__236943A5");

            entity.HasOne(d => d.ReplyOfDiscussion).WithMany(p => p.InverseReplyOfDiscussion)
                .HasForeignKey(d => d.ReplyOfDiscussionId)
                .HasConstraintName("FK__TaskDiscu__reply__25518C17");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskDiscussionUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TaskDiscu__updat__245D67DE");
        });

        modelBuilder.Entity<TaskPanel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskPane__3213E83F24D0F604");

            entity.ToTable("TaskPanel");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.OwnerId).HasColumnName("ownerId");
            entity.Property(e => e.TaskPanelName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("taskPanelName");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskPanelCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskPanel__creat__03F0984C");

            entity.HasOne(d => d.Owner).WithMany(p => p.TaskPanelOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskPanel__owner__02FC7413");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskPanelUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TaskPanel__updat__04E4BC85");
        });

        modelBuilder.Entity<TaskPanelInvitation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskPane__3213E83F897C8A5C");

            entity.ToTable("TaskPanelInvitation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.TaskPanelId).HasColumnName("taskPanelId");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskPanelInvitationCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskPanel__creat__1EA48E88");

            entity.HasOne(d => d.Status).WithMany(p => p.TaskPanelInvitations)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__TaskPanel__statu__208CD6FA");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskPanelInvitationUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TaskPanel__updat__1F98B2C1");
        });

        modelBuilder.Entity<TaskPanelMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TaskPane__3213E83F999628AF");

            entity.ToTable("TaskPanelMapping");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.TaskId).HasColumnName("taskId");
            entity.Property(e => e.TaskPanelId).HasColumnName("taskPanelId");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TaskPanelMappingCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskPanel__creat__14270015");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskPanelMappings)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskPanel__taskI__1332DBDC");

            entity.HasOne(d => d.TaskPanel).WithMany(p => p.InverseTaskPanel)
                .HasForeignKey(d => d.TaskPanelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TaskPanel__taskP__160F4887");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TaskPanelMappingUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TaskPanel__updat__151B244E");
        });

        modelBuilder.Entity<TasksMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TasksMas__3213E83F4F479D57");

            entity.ToTable("TasksMaster");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignId).HasColumnName("assignId");
            entity.Property(e => e.CreatedBy).HasColumnName("createdBy");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.EndDateTime)
                .HasColumnType("datetime")
                .HasColumnName("endDateTime");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.ProjectId).HasColumnName("projectId");
            entity.Property(e => e.StartDateTime)
                .HasColumnType("datetime")
                .HasColumnName("startDateTime");
            entity.Property(e => e.StatusId).HasColumnName("statusId");
            entity.Property(e => e.TaskDescription)
                .IsUnicode(false)
                .HasColumnName("taskDescription");
            entity.Property(e => e.TaskTitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("taskTitle");
            entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");

            entity.HasOne(d => d.Assign).WithMany(p => p.TasksMasterAssigns)
                .HasForeignKey(d => d.AssignId)
                .HasConstraintName("FK__TasksMast__assig__0E6E26BF");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.TasksMasterCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TasksMast__creat__0C85DE4D");

            entity.HasOne(d => d.Project).WithMany(p => p.TasksMasters)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__TasksMast__proje__0F624AF8");

            entity.HasOne(d => d.Status).WithMany(p => p.TasksMasters)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TasksMast__statu__10566F31");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.TasksMasterUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK__TasksMast__updat__0D7A0286");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3213E83F955453B5");

            entity.HasIndex(e => e.UserName, "UQ__Users__66DCF95C2D063A4A").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E6164A802183D").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("contactNo");
            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerified)
                .HasDefaultValue(false)
                .HasColumnName("emailVerified");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("isActive");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("middleName");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updatedDate");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<UserExternalLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserExte__3213E83FA31071FB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdDate");
            entity.Property(e => e.Provider)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("provider");
            entity.Property(e => e.ProviderUserId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("providerUserId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.UserExternalLogins)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserExter__userI__30C33EC3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
