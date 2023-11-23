using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblPressuretest
{
    public int Pt20id { get; set; }

    public int? PosRevId { get; set; }

    public bool? Pt20 { get; set; }

    public bool? Lt20 { get; set; }

    public string? TestPressure { get; set; }

    public string? TestPressureLt { get; set; }

    public string? HoldeTid { get; set; }

    public string? HoldeTidLt { get; set; }

    public string? ManoMeter { get; set; }

    public string? Accepted { get; set; }

    public string? AcceptedLt { get; set; }

    public string? TestMedia { get; set; }

    public DateTime? DateFixed { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
