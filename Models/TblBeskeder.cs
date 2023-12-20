using System;
using System.Collections.Generic;

namespace apihookup.Models;

public partial class TblBeskeder
{
    public int HejId { get; set; }

    public int? ArbId { get; set; }

    public string? Morg { get; set; }

    public string? Hjem { get; set; }

    public string? LinkPic { get; set; }

    public virtual TblArbejdere? Arb { get; set; }
}
