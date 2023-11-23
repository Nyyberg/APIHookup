using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblOmstpGenerelt
{
    /// <summary>
    /// PosRevID
    /// </summary>
    public int PosRevId { get; set; }

    /// <summary>
    /// Dokument version
    /// </summary>
    public string? DokuVer { get; set; }

    /// <summary>
    /// Intern jobnummer
    /// </summary>
    public string? TilbudsNr { get; set; }

    /// <summary>
    /// Kundens ordrenummer
    /// </summary>
    public string? OrdreNr { get; set; }

    /// <summary>
    /// Kunde firma
    /// </summary>
    public string? Kunde { get; set; }

    /// <summary>
    /// Serie nummer
    /// </summary>
    public string? SerieNr { get; set; }

    /// <summary>
    /// Kompensator typenr
    /// </summary>
    public string? TypeNr { get; set; }

    /// <summary>
    /// DN
    /// </summary>
    public string? Dn { get; set; }

    /// <summary>
    /// Tegningsnummer
    /// </summary>
    public string? TegningNr { get; set; }

    /// <summary>
    /// Positionummer
    /// </summary>
    public string? PosNr { get; set; }

    /// <summary>
    /// Revisionsnummer
    /// </summary>
    public string? RevNr { get; set; }

    /// <summary>
    /// Underskrift omstemplingsansvarlig
    /// </summary>
    public string? Sign { get; set; }

    public DateTime? DateFixed { get; set; }

    public virtual ICollection<TblOmstpLinie> TblOmstpLinies { get; set; } = new List<TblOmstpLinie>();
}
