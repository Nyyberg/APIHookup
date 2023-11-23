using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class Tblforsp
{
    public int ForspId { get; set; }

    public int? RekvId { get; set; }

    public string? ForspNr { get; set; }

    public int? RekvKundeId { get; set; }

    public float? TilbudsPris { get; set; }

    public DateTime? ForspDato { get; set; }

    public int? KonId { get; set; }

    public bool? Iordre { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Tblhoved? Rekv { get; set; }
}
