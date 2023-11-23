using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblFradrag
{
    public int FraId { get; set; }

    public string? FraNavn { get; set; }

    public int? StdVal { get; set; }

    public virtual ICollection<TblFradragDatum> TblFradragData { get; set; } = new List<TblFradragDatum>();
}
