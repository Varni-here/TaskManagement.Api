using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class AttachmentMaster
{
    public long Id { get; set; }

    public long AttachmentTypeId { get; set; }

    public long ParentId { get; set; }

    public string AttachmentPath { get; set; } = null!;

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual ConfigMaster AttachmentType { get; set; } = null!;

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual User? UpdatedByNavigation { get; set; }
}
