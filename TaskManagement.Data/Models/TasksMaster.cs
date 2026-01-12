using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class TasksMaster
{
    public long Id { get; set; }

    public string TaskTitle { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public long? ProjectId { get; set; }

    public long? AssignId { get; set; }

    public DateTime? StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public long StatusId { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User? Assign { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ProjectMaster? Project { get; set; }

    public virtual ConfigMaster Status { get; set; } = null!;

    public virtual ICollection<TaskPanelMapping> TaskPanelMappings { get; set; } = new List<TaskPanelMapping>();

    public virtual User? UpdatedByNavigation { get; set; }
}
