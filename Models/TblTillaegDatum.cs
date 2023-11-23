using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblTillaegDatum
{
    public int TillaegId { get; set; }

    public int? TilId { get; set; }

    public float? TilVal { get; set; }

    public int? LonId { get; set; }

    public int? ArbId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblArbejdere? Arb { get; set; }

    public virtual TblLonperiode? Lon { get; set; }

    public virtual TblTillaeg? Til { get; set; }
}
