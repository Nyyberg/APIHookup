using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblForbrug
{
    public int ForbrugId { get; set; }

    public int? PosRevId { get; set; }

    public int? MatId { get; set; }

    public string? ItemNr { get; set; }

    public string? Desc { get; set; }

    public string? Dim { get; set; }

    public string? Mat { get; set; }

    public string? Cert { get; set; }

    public float? Styk { get; set; }

    public float? Masse { get; set; }

    public string? Stnr { get; set; }

    public string? ChargeNr { get; set; }

    public int? Length { get; set; }

    public string? Omstempling { get; set; }

    public int? KildeId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblMaterialer? MatNavigation { get; set; }
}
