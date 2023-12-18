using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class TblEmneTyper
{
    public int EmneId { get; set; }

    public string? EmneKort { get; set; }

    public string? EmneDesc { get; set; }

    public int? EnhedId { get; set; }

    public string? EnhedDesc { get; set; }
}
