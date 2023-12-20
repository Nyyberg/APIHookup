using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblAltReg
{
    public int AltId { get; set; }

    public string? AltNavn { get; set; }

    public int? AltColorIndex { get; set; }

    public string? AltColorRgb { get; set; }

    public bool? AltErAktiv { get; set; }

    public bool? AltErAfdeling { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblTidsreg> TblTidsregs { get; set; } = new List<TblTidsreg>();
}
