using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblFasteTillaeg
{
    public int FtilId { get; set; }

    public int? TilId { get; set; }

    public int? ArbId { get; set; }

    public float? FastTilVal { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
