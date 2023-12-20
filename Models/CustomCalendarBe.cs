using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class CustomCalendarBe
{
    public int Id { get; set; }

    public int? HookupBeId { get; set; }

    public DateTime? HookupDateTime { get; set; }

    public virtual HookupBe? HookupBe { get; set; }
}
