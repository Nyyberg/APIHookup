using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Header
{
    public int? HookupBeId { get; set; }

    public string? HeaderKey { get; set; }

    public string? Data { get; set; }

    public virtual HookupBe? HookupBe { get; set; }
}
