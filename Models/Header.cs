using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Header
{
    public int Id { get; set; }

    public int? HookupBeId { get; set; }

    public string? HeaderKey { get; set; }

    public string? HeaderValue { get; set; }

    public string? Valuetpe { get; set; }

    public string? SqlQuery { get; set; }

    public int? HookupAsParameter { get; set; }

    public virtual HookupBe? HookupAsParameterNavigation { get; set; }

    public virtual HookupBe? HookupBe { get; set; }
}
