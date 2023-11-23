using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblLonDatum
{
    public int GemtId { get; set; }

    public int? LonId { get; set; }

    public int? ArbId { get; set; }

    public float? TimeLon { get; set; }

    public float? Ntimer { get; set; }

    public float? Otimer { get; set; }

    public float? Ttimer { get; set; }

    public float? LonIalt { get; set; }

    public float? LonUdbetalt { get; set; }

    public float? SygSelv { get; set; }

    public float? SygBarn { get; set; }

    public float? Afspadsering { get; set; }

    public float? Skole { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
