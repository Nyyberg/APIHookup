using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblKontakter
{
    public int KontaktId { get; set; }

    public int KundeId { get; set; }

    public string Navn { get; set; } = null!;

    public string? Tlf { get; set; }

    public string? Mail { get; set; }

    public bool? Aktiv { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual TblKunder Kunde { get; set; } = null!;
}
