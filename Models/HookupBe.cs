using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class HookupBe
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public bool? IntervalIsEveryDay { get; set; }

    public DateTime? IntervalTimeOfDay { get; set; }

    public virtual CustomCalendarBe IdNavigation { get; set; } = null!;

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
