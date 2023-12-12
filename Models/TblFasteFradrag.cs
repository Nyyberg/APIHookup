using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblFasteFradrag
{
    public int FfraId { get; set; }

    public int? FraId { get; set; }

    public int? ArbId { get; set; }

    public float? FastFraVal { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
