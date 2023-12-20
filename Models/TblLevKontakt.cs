using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblLevKontakt
{
    public int LevKonId { get; set; }

    public int? LevId { get; set; }

    public string? Navn { get; set; }

    public virtual TblLevFirma? Lev { get; set; }
}
