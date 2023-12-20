using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblJobliste
{
    public int KlarId { get; set; }

    public int? PosRevId { get; set; }

    public int? PlanLinieId { get; set; }

    public string? ItemPos { get; set; }

    public int? KildeId { get; set; }

    public int? AntalKlar { get; set; }

    public bool? KlarMelding { get; set; }

    public string? Remark { get; set; }

    public string? LagerKontrol { get; set; }

    public int? RekvId { get; set; }

    public float? MatForbrug { get; set; }

    public string? ForbrugEnhed { get; set; }

    public DateTime? KlarMeldingD { get; set; }

    public DateTime? StartD { get; set; }

    public DateTime? SlutD { get; set; }

    public bool? Klippet { get; set; }

    public bool? VasletSvejst { get; set; }

    public bool? NyLinje { get; set; }

    public bool? Afvigelse { get; set; }

    public string? StartKw { get; set; }

    public string? SlutKw { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblKilde? Kilde { get; set; }
}
