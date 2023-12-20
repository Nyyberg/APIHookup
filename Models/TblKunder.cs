using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblKunder
{
    public int KundeId { get; set; }

    public string FirmaKode { get; set; } = null!;

    public string Firma { get; set; } = null!;

    public string Adresse { get; set; } = null!;

    public string Postnr { get; set; } = null!;

    public string LevAdresse { get; set; } = null!;

    public string LevPostnr { get; set; } = null!;

    public string Landekode { get; set; } = null!;

    public string? FirmaNavn { get; set; }

    public string? DokuMail { get; set; }

    public string? DokuMailCc { get; set; }

    public bool? Aktiv { get; set; }

    public string? MomsKode { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblKontakter> TblKontakters { get; set; } = new List<TblKontakter>();

    public virtual ICollection<TblKundeDatum> TblKundeData { get; set; } = new List<TblKundeDatum>();

    public virtual ICollection<TblLevFirma> TblLevFirmas { get; set; } = new List<TblLevFirma>();
}
