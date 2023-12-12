using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblTilbud
{
    public int TilbudId { get; set; }

    public string TilbudNr { get; set; } = null!;

    public int KundeId { get; set; }

    public int KontaktId { get; set; }

    public int DesignerId { get; set; }

    public DateTime? DatoOprettet { get; set; }

    public string? OrdreNr { get; set; }

    public string? TransDato { get; set; }

    public string? ForspNr { get; set; }

    public string? LinkSag { get; set; }

    public string? TransDatoRykket { get; set; }

    public string? EfterKalkNote { get; set; }

    public int? LevId { get; set; }

    public int? LevKonId { get; set; }

    public int? TranId { get; set; }

    public DateTime? TranRealDateRyk { get; set; }

    public int? DnoteFromExternal { get; set; }

    /// <summary>
    /// Ved IKKE blank betaler kunden for transporten
    /// </summary>
    public string? KundeFakturaNr { get; set; }

    /// <summary>
    /// 1 Ja
    /// </summary>
    public int? PrisEkslTransport { get; set; }

    public string? BellowReady { get; set; }

    public string? EkstrasReady { get; set; }

    public DateTime? BellowReadyD { get; set; }

    public DateTime? EkstrasReadyD { get; set; }

    public int? SagFarve { get; set; }

    public bool? SortKlar { get; set; }

    public bool? LockedPlan { get; set; }

    public string? EkstrasStart { get; set; }

    public DateTime? EkstrasStartD { get; set; }

    public string? BellowStart { get; set; }

    public DateTime? BellowStartD { get; set; }

    public bool? Vigtig { get; set; }

    public bool? Planlagt { get; set; }

    public bool? SmartTid { get; set; }

    public float? TimerForbrugTotal { get; set; }

    public float? TimerForbrugBalg { get; set; }

    public float? TimerForbrugSort { get; set; }

    public float? TimerRestTotal { get; set; }

    public float? TimerRestBalg { get; set; }

    public float? TimerRestSort { get; set; }

    public string? Remark { get; set; }

    public bool? SortTilUnderLev { get; set; }

    public string? UnderLevNavn { get; set; }

    public int? UnderLevRekvNr { get; set; }

    public bool? Delevering { get; set; }

    public bool? HalvfabKlar { get; set; }

    public bool? BalgKlar { get; set; }

    public bool? PlanKlar { get; set; }

    public int? AntalPos { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblPositioner> TblPositioners { get; set; } = new List<TblPositioner>();
}
