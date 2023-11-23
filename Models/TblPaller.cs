using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblPaller
{
    public int PalleId { get; set; }

    public int? RekvId { get; set; }

    public string? PalleDesc { get; set; }

    public int? PalleAntal { get; set; }

    public float? PalleKg { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Tblhoved? Rekv { get; set; }
}
