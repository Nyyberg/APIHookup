using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblKontaktLev
{
    public int KonId { get; set; }

    public int? RekvKundeId { get; set; }

    public string? KonNavn { get; set; }

    public string? KonMail { get; set; }

    public string? KonTlf { get; set; }

    public virtual Tblkunde? RekvKunde { get; set; }

    public virtual ICollection<Tblhoved> Tblhoveds { get; set; } = new List<Tblhoved>();
}
