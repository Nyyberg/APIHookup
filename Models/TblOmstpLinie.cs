using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblOmstpLinie
{
    public int StpId { get; set; }

    public int? PosRevId { get; set; }

    public string? UItem { get; set; }

    public string? UDesc { get; set; }

    public string? UMatr { get; set; }

    public string? UCharge { get; set; }

    public string? FAntal { get; set; }

    public string? FDim1 { get; set; }

    public string? NMatr { get; set; }

    public string? NCharge { get; set; }

    public string? NStnr { get; set; }

    public string? NStp { get; set; }

    public virtual TblOmstpGenerelt? PosRev { get; set; }
}
