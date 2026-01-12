using System;
using System.Collections.Generic;

namespace TaskManagement.Data.Models;

public partial class EmailOtpRecord
{
    public long Id { get; set; }

    public string Email { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public bool? IsUsed { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }
}
