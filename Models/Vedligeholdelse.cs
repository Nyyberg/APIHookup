using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Vedligeholdelse
{
    public int VedligehNr { get; set; }

    public string? LinieNr { get; set; }

    public int? Interval { get; set; }

    public DateTime? DatoStart { get; set; }

    public DateTime? DatoUdført { get; set; }

    public string? Tekst { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
