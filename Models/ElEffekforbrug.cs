using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class ElEffekforbrug
{
    public string LinieNr { get; set; } = null!;

    public string? Tekst { get; set; }

    public float? Effekt { get; set; }

    public string? Spænding { get; set; }

    public float? Strøm { get; set; }

    public int? Tilslutning { get; set; }

    public int? TilslutningTavle { get; set; }

    public float? Luftmængde { get; set; }

    public string? BeskrivbelseElTilslut { get; set; }

    public string? Beskrivelse { get; set; }
}
