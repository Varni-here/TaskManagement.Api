using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class ConfigMaster
{
    public long Id { get; set; }

    public string ConfigKey { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;

    public virtual ICollection<AttachmentMaster> AttachmentMasters { get; set; } = new List<AttachmentMaster>();

    public virtual ICollection<ProjectMaster> ProjectMasters { get; set; } = new List<ProjectMaster>();

    public virtual ICollection<TaskPanelInvitation> TaskPanelInvitations { get; set; } = new List<TaskPanelInvitation>();

    public virtual ICollection<TasksMaster> TasksMasters { get; set; } = new List<TasksMaster>();
}
