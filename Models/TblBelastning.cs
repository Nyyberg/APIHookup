using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblBelastning
{
    public int LinieId { get; set; }

    public int? DagId { get; set; }

    public int? TilbudsId { get; set; }

    public float? TidSort { get; set; }

    public float? TidRust { get; set; }

    public int? ColorSort { get; set; }

    public int? ColorRust { get; set; }

    public float? TidHal1 { get; set; }

    public float? TidHal2 { get; set; }

    public float? TidBalgrum { get; set; }

    public float? TidHydro { get; set; }

    public float? TidHalvfab { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblDage? Dag { get; set; }
}
