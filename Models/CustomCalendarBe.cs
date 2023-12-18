using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class CustomCalendarBe
{
    public int Id { get; set; }

    public DateTime? TimeOfDay { get; set; }

    public virtual ICollection<HookupBe> HookupBes { get; set; } = new List<HookupBe>();
}
