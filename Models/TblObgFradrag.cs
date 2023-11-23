using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblObgFradrag
{
    public int OfraId { get; set; }

    public string? OfraNavn { get; set; }

    public float? OfraVal { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
