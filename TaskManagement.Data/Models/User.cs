using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class User
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string? ContactNo { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? EmailVerified { get; set; }

    public virtual ICollection<AttachmentMaster> AttachmentMasterCreatedByNavigations { get; set; } = new List<AttachmentMaster>();

    public virtual ICollection<AttachmentMaster> AttachmentMasterUpdatedByNavigations { get; set; } = new List<AttachmentMaster>();

    public virtual ICollection<PanelGuest> PanelGuestCreatedByNavigations { get; set; } = new List<PanelGuest>();

    public virtual ICollection<PanelGuest> PanelGuestGuests { get; set; } = new List<PanelGuest>();

    public virtual ICollection<PanelGuest> PanelGuestUpdatedByNavigations { get; set; } = new List<PanelGuest>();

    public virtual ICollection<ProjectMaster> ProjectMasterCreatedByNavigations { get; set; } = new List<ProjectMaster>();

    public virtual ICollection<ProjectMaster> ProjectMasterUpdatedByNavigations { get; set; } = new List<ProjectMaster>();

    public virtual ICollection<TaskDiscussion> TaskDiscussionCreatedByNavigations { get; set; } = new List<TaskDiscussion>();

    public virtual ICollection<TaskDiscussion> TaskDiscussionUpdatedByNavigations { get; set; } = new List<TaskDiscussion>();

    public virtual ICollection<TaskPanel> TaskPanelCreatedByNavigations { get; set; } = new List<TaskPanel>();

    public virtual ICollection<TaskPanelInvitation> TaskPanelInvitationCreatedByNavigations { get; set; } = new List<TaskPanelInvitation>();

    public virtual ICollection<TaskPanelInvitation> TaskPanelInvitationUpdatedByNavigations { get; set; } = new List<TaskPanelInvitation>();

    public virtual ICollection<TaskPanelMapping> TaskPanelMappingCreatedByNavigations { get; set; } = new List<TaskPanelMapping>();

    public virtual ICollection<TaskPanelMapping> TaskPanelMappingUpdatedByNavigations { get; set; } = new List<TaskPanelMapping>();

    public virtual ICollection<TaskPanel> TaskPanelOwners { get; set; } = new List<TaskPanel>();

    public virtual ICollection<TaskPanel> TaskPanelUpdatedByNavigations { get; set; } = new List<TaskPanel>();

    public virtual ICollection<TasksMaster> TasksMasterAssigns { get; set; } = new List<TasksMaster>();

    public virtual ICollection<TasksMaster> TasksMasterCreatedByNavigations { get; set; } = new List<TasksMaster>();

    public virtual ICollection<TasksMaster> TasksMasterUpdatedByNavigations { get; set; } = new List<TasksMaster>();

    public virtual ICollection<UserExternalLogin> UserExternalLogins { get; set; } = new List<UserExternalLogin>();
}
