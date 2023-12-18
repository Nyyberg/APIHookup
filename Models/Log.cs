using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Log
{
    public int Id { get; set; }

    public int? HookupBeId { get; set; }

    public DateTime? Timestamp { get; set; }

    public bool? IsSuccessful { get; set; }

    public string? ErrorMessage { get; set; }

    public virtual HookupBe? HookupBe { get; set; }
}
