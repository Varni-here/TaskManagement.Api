using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class PanelGuest
{
    public long Id { get; set; }

    public long GuestId { get; set; }

    public long TaskPanelId { get; set; }

    public bool? IsLeaved { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User Guest { get; set; } = null!;

    public virtual TaskPanel TaskPanel { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
