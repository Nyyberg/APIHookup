using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblPakkeListe
{
    public int PakkeId { get; set; }

    public string? TilbudNr { get; set; }

    public string? PosNr { get; set; }

    public int? Antal { get; set; }

    public int? Dn { get; set; }

    public double? Mass { get; set; }

    public int? Length { get; set; }

    public string? Ktype { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;
}
