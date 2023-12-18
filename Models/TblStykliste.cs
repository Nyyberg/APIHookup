using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblStykliste
{
    public int StkId { get; set; }

    public int? PosRevId { get; set; }

    public string? ItemPos { get; set; }

    public string? Desc { get; set; }

    public string? Dimension { get; set; }

    public string? Matr { get; set; }

    public string? Cert { get; set; }

    public string? ChargeNr { get; set; }

    public int? Antal { get; set; }

    public float? MassStk { get; set; }

    public string? NdtI { get; set; }

    public string? NdtQ { get; set; }

    public string? NdtE { get; set; }

    public string? Omstempling { get; set; }

    public string? OfBeh { get; set; }

    public int? KildeId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblPositioner? PosRev { get; set; }
}
