using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class UserExternalLogin
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Provider { get; set; } = null!;

    public string ProviderUserId { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public virtual User User { get; set; } = null!;
}
