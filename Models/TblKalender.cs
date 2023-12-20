using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblKalender
{
    public int KalId { get; set; }

    public int? DagId { get; set; }

    public int? ArbId { get; set; }

    public float? ColKal { get; set; }

    public int? AltId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblDage? Dag { get; set; }
}
