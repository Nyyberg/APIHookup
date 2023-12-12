using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblRingeTilBalge
{
    public int RingId { get; set; }

    public float? YdreDia { get; set; }

    public float? IndreDia { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
