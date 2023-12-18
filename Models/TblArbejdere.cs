using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblArbejdere
{
    public int ArbId { get; set; }

    public string? Login { get; set; }

    public string? Fornavn { get; set; }

    public string? Efternavn { get; set; }

    public string? AfdId { get; set; }

    public int? Aktiv { get; set; }

    public float? TimeLon { get; set; }

    public DateTime? AnsatDato { get; set; }

    public int? VareModtagelse { get; set; }

    public int? Faktor { get; set; }

    public int? Ipoandel { get; set; }

    public float? Tillaeg { get; set; }

    public int? AfdelingId { get; set; }

    public byte[] SsmaTimeStamp { get; set; } = null!;

    public virtual ICollection<TblBeskeder> TblBeskeders { get; set; } = new List<TblBeskeder>();

    public virtual ICollection<TblFradragDatum> TblFradragData { get; set; } = new List<TblFradragDatum>();

    public virtual ICollection<TblOvertid> TblOvertids { get; set; } = new List<TblOvertid>();

    public virtual ICollection<TblTidsreg> TblTidsregs { get; set; } = new List<TblTidsreg>();

    public virtual ICollection<TblTillaegDatum> TblTillaegData { get; set; } = new List<TblTillaegDatum>();
}
