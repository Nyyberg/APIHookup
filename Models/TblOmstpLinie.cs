using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblOmstpLinie
{
    /// <summary>
    /// StpID
    /// </summary>
    public int StpId { get; set; }

    /// <summary>
    /// PosRevID
    /// </summary>
    public int? PosRevId { get; set; }

    /// <summary>
    /// Stykliste item nummer
    /// </summary>
    public string? UItem { get; set; }

    /// <summary>
    /// Beskrivelse af item
    /// </summary>
    public string? UDesc { get; set; }

    /// <summary>
    /// Materiale oprindeligt
    /// </summary>
    public string? UMatr { get; set; }

    /// <summary>
    /// Charge oprindeligt
    /// </summary>
    public string? UCharge { get; set; }

    public string? FAntal { get; set; }

    public string? FDim1 { get; set; }

    /// <summary>
    /// Materiale omstemplet
    /// </summary>
    public string? NMatr { get; set; }

    /// <summary>
    /// Charge omstemplet
    /// </summary>
    public string? NCharge { get; set; }

    /// <summary>
    /// ST-nr omstemplet
    /// </summary>
    public string? NStnr { get; set; }

    /// <summary>
    /// Omstemplingsmærke
    /// </summary>
    public string? NStp { get; set; }

    public virtual TblOmstpGenerelt? PosRev { get; set; }
}
