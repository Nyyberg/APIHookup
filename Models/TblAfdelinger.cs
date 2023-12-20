using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblAfdelinger
{
    public int AfdId { get; set; }

    public string? AfdNavn { get; set; }

    public virtual ICollection<TblTidsreg> TblTidsregs { get; set; } = new List<TblTidsreg>();
}
