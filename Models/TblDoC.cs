using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblDoC
{
    public int DocId { get; set; }

    public int? PosRevId { get; set; }

    public string? FluidGrp { get; set; }

    public string? Category { get; set; }

    public string? Modul { get; set; }

    public string? Standard { get; set; }

    public string? NoBo { get; set; }

    public bool? Vt { get; set; }

    public bool? Pt { get; set; }

    public bool? Lt { get; set; }

    public bool? Pt20 { get; set; }

    public bool? Rt { get; set; }

    public bool? Mt { get; set; }

    public string? TestPressure { get; set; }

    public DateTime? DateFixed { get; set; }

    public string? Remark { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
