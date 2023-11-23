using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class LinienrForesp
{
    public string LinieNr { get; set; } = null!;

    public string? Tekst { get; set; }

    public string? LinieNrAndet { get; set; }

    public bool? LinieNrDrift { get; set; }

    public string? Plasering { get; set; }

    public string? LinieNrAndet2 { get; set; }

    public string? SerieNr { get; set; }

    public bool? LinieNrDrift3 { get; set; }
}
