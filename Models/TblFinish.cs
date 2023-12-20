using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblFinish
{
    public string Finish { get; set; } = null!;

    public int OvId { get; set; }

    public int? KatId { get; set; }

    public string? FinishDesc { get; set; }

    public string? Remark { get; set; }

    public int? HotOrCold { get; set; }
}
