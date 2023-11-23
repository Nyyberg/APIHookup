using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblAftraek
{
    public int AftraekId { get; set; }

    public int? TilbudId { get; set; }

    public int? PosRevId { get; set; }

    public int? MatId { get; set; }

    public string? Stnr { get; set; }

    public string? ItemPos { get; set; }

    public float? Aftraek { get; set; }

    public int? ArbId { get; set; }

    public DateTime? AftraekD { get; set; }

    public float? AfMasse { get; set; }

    public bool? AfStumper { get; set; }

    public float? TilStumper { get; set; }

    public int? ResterValg { get; set; }

    public string? AftraekEnhed { get; set; }

    public float? ForbrugMasse { get; set; }

    public string? ForbrugEnhed { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblMaterialer? Mat { get; set; }
}
