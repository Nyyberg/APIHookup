using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblTiderEnkelt
{
    public int TilbudId { get; set; }

    public byte? Iprod { get; set; }

    public float? TidBalg { get; set; }

    public float? TidSort { get; set; }

    public string TilbudNr { get; set; } = null!;
}
