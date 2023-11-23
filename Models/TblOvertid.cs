using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblOvertid
{
    public int OvtId { get; set; }

    public int? LonId { get; set; }

    public int? ArbId { get; set; }

    public float? OvtTilg { get; set; }

    public float? OvtInd { get; set; }

    public float? OvtUd { get; set; }

    public float? OvtRest { get; set; }

    public float? OvtKor { get; set; }

    public float? OvtAfsp { get; set; }

    public float? OvtPlanUd { get; set; }

    public float? OvtPlanKor { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblArbejdere? Arb { get; set; }

    public virtual TblLonperiode? Lon { get; set; }
}
