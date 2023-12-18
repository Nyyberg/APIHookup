using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class HookupBe
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public string? MethodType { get; set; }

    public bool? IntervalIsEveryDay { get; set; }

    public bool? IntervalIsEveryWeek { get; set; }

    public bool? IntervalIsEveryMonth { get; set; }

    public DateTime? IntervalTimeOfDay { get; set; }

    public int? CustomCalendarBeId { get; set; }

    public virtual ICollection<Body> Bodies { get; set; } = new List<Body>();

    public virtual CustomCalendarBe? CustomCalendarBe { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
