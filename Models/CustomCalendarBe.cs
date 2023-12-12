using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class CustomCalendarBe
{
    public int Id { get; set; }

    public bool? IsEveryDay { get; set; }

    public DateTime? TimeOfDay { get; set; }

    public virtual HookupBe? HookupBe { get; set; }
}
