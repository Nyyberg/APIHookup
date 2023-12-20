using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblKontaktLev
{
    public int KonId { get; set; }

    public int? RekvKundeId { get; set; }

    public string? KonNavn { get; set; }

    public string? KonMail { get; set; }

    public string? KonTlf { get; set; }

    public virtual Tblkunde? RekvKunde { get; set; }
}
