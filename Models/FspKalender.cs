using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class FspKalender
{
    public int DagId { get; set; }

    public int? ArbId { get; set; }

    public float? ColKal { get; set; }

    public DateTime? DagDato { get; set; }

    public int KalId { get; set; }
}
