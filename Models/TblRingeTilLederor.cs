using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblRingeTilLederor
{
    public int RingId { get; set; }

    public float? YdreDia { get; set; }

    public float? IndreDia { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
