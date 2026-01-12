using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class TaskDiscussion
{
    public long Id { get; set; }

    public long TaskId { get; set; }

    public string DiscussionText { get; set; } = null!;

    public long? ReplyOfDiscussionId { get; set; }

    public long CreatedBy { get; set; }

    public long? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual User CreatedByNavigation { get; set; } = null!;

    public virtual ICollection<TaskDiscussion> InverseReplyOfDiscussion { get; set; } = new List<TaskDiscussion>();

    public virtual TaskDiscussion? ReplyOfDiscussion { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }
}
