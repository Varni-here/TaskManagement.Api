using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class TaskPanelInvitation
{
    public long Id { get; set; }

    public string Email { get; set; } = null!;

    public long TaskPanelId { get; set; }

    public long? StatusId { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ConfigMaster? Status { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }
}
