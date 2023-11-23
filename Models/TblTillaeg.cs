using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblTillaeg
{
    public int TilId { get; set; }

    public string? TilNavn { get; set; }

    public float? StdVal { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblTillaegDatum> TblTillaegData { get; set; } = new List<TblTillaegDatum>();
}
