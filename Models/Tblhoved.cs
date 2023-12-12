using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class Tblhoved
{
    /// <summary>
    /// a
    /// </summary>
    public int RekvId { get; set; }

    public int? RekvKundeId { get; set; }

    public string? Rekvirent { get; set; }

    public DateTime? OpretDato { get; set; }

    public string? Sag { get; set; }

    public DateTime? LevDato { get; set; }

    public DateTime? LevTid { get; set; }

    public string? Bemærkninger { get; set; }

    public string? AfhentAdr { get; set; }

    public DateTime? AfhentDato { get; set; }

    public DateTime? AfhentTid { get; set; }

    public string? AfhentPostnr { get; set; }

    public string? LevPostnr { get; set; }

    public string? LevAdr { get; set; }

    public string? RekvKat { get; set; }

    public string? Modtager { get; set; }

    public string? AfhentFirma { get; set; }

    public string? LevFirma { get; set; }

    public DateTime? OrdreBekDato { get; set; }

    public int? KonId { get; set; }

    public int? RekvIordre { get; set; }

    public DateTime? LevDatoRykket { get; set; }

    public string? Valuta { get; set; }

    public float? Pris { get; set; }

    public int? LevKundeId { get; set; }

    public bool? FakturaTransportModtaget { get; set; }

    public bool? Ops { get; set; }

    public bool? Efterbehandling { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual Tblkunde? RekvKunde { get; set; }

    public virtual ICollection<TblChargeNr> TblChargeNrs { get; set; } = new List<TblChargeNr>();

    public virtual ICollection<TblFaktura> TblFakturas { get; set; } = new List<TblFaktura>();

    public virtual ICollection<TblPaller> TblPallers { get; set; } = new List<TblPaller>();

    public virtual ICollection<Tblcertifikater> Tblcertifikaters { get; set; } = new List<Tblcertifikater>();

    public virtual ICollection<Tblforsp> Tblforsps { get; set; } = new List<Tblforsp>();
}
