using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class ForespMerkeplade
{
    public string? Maskinnr { get; set; }

    public string LinieNr { get; set; } = null!;

    public string? FabNavn { get; set; }

    public string? Type { get; set; }

    public string? Tekst { get; set; }

    public string? År { get; set; }
}
