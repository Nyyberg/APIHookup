using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblPlanAktivitet
{
    public int Id { get; set; }

    public int? TilbudId { get; set; }

    public int? PosRevId { get; set; }
}
