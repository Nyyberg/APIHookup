using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Body
{
    public int Id { get; set; }

    public int? HookupBeId { get; set; }

    public string? BodyType { get; set; }

    public string? ParameterName { get; set; }

    public string? SqlQuery { get; set; }

    public virtual HookupBe? HookupBe { get; set; }
}
