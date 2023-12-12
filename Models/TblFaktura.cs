using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblFaktura
{
    public int FakId { get; set; }

    public int? RekvId { get; set; }

    public string? FilePath { get; set; }

    public float? Pris { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Tblhoved? Rekv { get; set; }
}
