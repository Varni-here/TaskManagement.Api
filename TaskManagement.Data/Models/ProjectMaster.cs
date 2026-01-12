using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class ProjectMaster
{
    public long Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public string? ProjectDescription { get; set; }

    public long StatusId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ConfigMaster Status { get; set; } = null!;

    public virtual ICollection<TasksMaster> TasksMasters { get; set; } = new List<TasksMaster>();

    public virtual User? UpdatedByNavigation { get; set; }
}
