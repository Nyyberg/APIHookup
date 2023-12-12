using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblLonperiode
{
    public int LonId { get; set; }

    public int? UgeStart { get; set; }

    public int? YearLon { get; set; }

    public float? OvtGraense { get; set; }

    public float? OvtTillaeg { get; set; }

    public int? Godkendt { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblFradragDatum> TblFradragData { get; set; } = new List<TblFradragDatum>();

    public virtual ICollection<TblOvertid> TblOvertids { get; set; } = new List<TblOvertid>();

    public virtual ICollection<TblTillaegDatum> TblTillaegData { get; set; } = new List<TblTillaegDatum>();
}
