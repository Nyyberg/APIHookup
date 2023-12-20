using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblVare
{
    public int VareId { get; set; }

    public string? Beskrivelse { get; set; }

    public int? Dn { get; set; }

    public int? Pn { get; set; }

    public float? IndreDiameter { get; set; }

    public float? YdreDiameter { get; set; }

    public float? FixedFl { get; set; }

    public float? LooseFl { get; set; }

    public decimal? Pris { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
