using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class TaskPanelMapping
{
    public long Id { get; set; }

    public long TaskId { get; set; }

    public long TaskPanelId { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<TaskPanelMapping> InverseTaskPanel { get; set; } = new List<TaskPanelMapping>();

    public virtual TasksMaster Task { get; set; } = null!;

    public virtual TaskPanelMapping TaskPanel { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
