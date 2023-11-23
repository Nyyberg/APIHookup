using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class QHentProjekter
{
    public int TilbudId { get; set; }

    public string TilbudNr { get; set; } = null!;

    public string Firma { get; set; } = null!;

    public string Initialer { get; set; } = null!;

    public string? OrdreNr { get; set; }

    public string? Ktype { get; set; }

    public DateTime? OrdreDato { get; set; }
}
