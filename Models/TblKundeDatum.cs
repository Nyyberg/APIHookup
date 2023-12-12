using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblKundeDatum
{
    public int DataId { get; set; }

    public int? KundeId { get; set; }

    public string? IndstillingNavn { get; set; }

    public string? Sprog { get; set; }

    /// <summary>
    /// Dage
    /// </summary>
    public string? BetalingsTid { get; set; }

    public string? PrisGyldighed { get; set; }

    /// <summary>
    /// Dage
    /// </summary>
    public string? LeveringsTid { get; set; }

    public string? LeveringsBetingelser { get; set; }

    public float? Provision { get; set; }

    public float? Rabat { get; set; }

    public string? OfBehSort { get; set; }

    public string? OfBehRustfri { get; set; }

    public string? OfBehSortFarve { get; set; }

    public string? OfBehRustfriFarve { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblKunder? Kunde { get; set; }
}
