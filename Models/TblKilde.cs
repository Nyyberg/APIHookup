using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblKilde
{
    public int KildeId { get; set; }

    public string? KildeNavn { get; set; }

    public virtual ICollection<TblJobliste> TblJoblistes { get; set; } = new List<TblJobliste>();
}
