using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblMatricerTilPunch
{
    public int MatriceId { get; set; }

    public float? Dn { get; set; }

    public float? Tykkelse { get; set; }

    public float? Vandring { get; set; }

    public int? HovedId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblMatriceHoveder? Hoved { get; set; }
}
