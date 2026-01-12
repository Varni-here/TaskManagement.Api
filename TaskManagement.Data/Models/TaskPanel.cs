using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class TaskPanel
{
    public long Id { get; set; }

    public string TaskPanelName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long OwnerId { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User Owner { get; set; } = null!;

    public virtual ICollection<PanelGuest> PanelGuests { get; set; } = new List<PanelGuest>();

    public virtual User? UpdatedByNavigation { get; set; }
}
