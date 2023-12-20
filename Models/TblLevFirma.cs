using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblLevFirma
{
    public int LevId { get; set; }

    public int? KundeId { get; set; }

    public string? LevFirma { get; set; }

    public string? LevAdr { get; set; }

    public string? LevPostnr { get; set; }

    public virtual TblKunder? Kunde { get; set; }

    public virtual ICollection<TblLevKontakt> TblLevKontakts { get; set; } = new List<TblLevKontakt>();
}
