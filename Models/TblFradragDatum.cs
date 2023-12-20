using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblFradragDatum
{
    public int FradragId { get; set; }

    public int? FraId { get; set; }

    public int? LonId { get; set; }

    public int? ArbId { get; set; }

    public float? FraVal { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblArbejdere? Arb { get; set; }

    public virtual TblFradrag? Fra { get; set; }

    public virtual TblLonperiode? Lon { get; set; }
}
