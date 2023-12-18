using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblTiderSum
{
    public int TilbudId { get; set; }

    public double? SumOfTidBalg { get; set; }

    public double? SumOfTidSort { get; set; }

    public string TilbudNr { get; set; } = null!;
}
