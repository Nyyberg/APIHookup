using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblFejlkoder
{
    public int FejlId { get; set; }

    public string? FejlType { get; set; }

    public virtual ICollection<TblTidsreg> TblTidsregs { get; set; } = new List<TblTidsreg>();
}
