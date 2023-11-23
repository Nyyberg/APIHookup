using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblTidsreg
{
    public int RegId { get; set; }

    public int? ArbId { get; set; }

    public int? AfdId { get; set; }

    public int? OrdreId { get; set; }

    public string? OrdreNavn { get; set; }

    public DateTime? TidInd { get; set; }

    public DateTime? TidUd { get; set; }

    public int? FejlId { get; set; }

    public int? Ipoid { get; set; }

    public int? AltId { get; set; }

    public int? MasId { get; set; }

    public int? AfdNyId { get; set; }

    public virtual TblAfdelinger? Afd { get; set; }

    public virtual TblAltReg? Alt { get; set; }

    public virtual TblArbejdere? Arb { get; set; }

    public virtual TblFejlkoder? Fejl { get; set; }

    public virtual TblIpo? Ipo { get; set; }

    public virtual ICollection<TblChange> TblChanges { get; set; } = new List<TblChange>();
}
