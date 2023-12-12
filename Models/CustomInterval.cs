using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class CustomInterval
{
    public int? CustomCalendarBeId { get; set; }

    public DateTime? IntervalDateTime { get; set; }

    public virtual CustomCalendarBe? CustomCalendarBe { get; set; }
}
