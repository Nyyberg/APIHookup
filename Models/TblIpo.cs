using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblIpo
{
    public int Ipoid { get; set; }

    public string? Ipotype { get; set; }

    public virtual ICollection<TblTidsreg> TblTidsregs { get; set; } = new List<TblTidsreg>();
}
