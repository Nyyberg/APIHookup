using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblExOmkost
{
    public int ExId { get; set; }

    public int? TilbudId { get; set; }

    public string? ExDesc { get; set; }

    public decimal? ExPris { get; set; }

    public string? ExValuta { get; set; }
}
