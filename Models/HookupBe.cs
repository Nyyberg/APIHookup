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

    public virtual ICollection<Body> BodyHookupAsParameterNavigations { get; set; } = new List<Body>();

    public virtual ICollection<Body> BodyHookupBes { get; set; } = new List<Body>();

    public virtual ICollection<CustomCalendarBe> CustomCalendarBes { get; set; } = new List<CustomCalendarBe>();

    public virtual ICollection<Header> HeaderHookupAsParameterNavigations { get; set; } = new List<Header>();

    public virtual ICollection<Header> HeaderHookupBes { get; set; } = new List<Header>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();
}
