using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblChargeNr
{
    public int ChargeId { get; set; }

    public int? CertId { get; set; }

    public string? ChargeNr { get; set; }

    public int? LinieId { get; set; }

    public int? RekvId { get; set; }

    public virtual Tblcertifikater? Cert { get; set; }

    public virtual Tblhoved? Rekv { get; set; }

    public virtual ICollection<Tbllinie> Tbllinies { get; set; } = new List<Tbllinie>();
}
