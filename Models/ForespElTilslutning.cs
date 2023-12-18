using System;
using System.Collections.Generic;

namespace ApiHookup.Models;

public partial class ForespElTilslutning
{
    public string LinieNr { get; set; } = null!;

    public string? Tekst { get; set; }

    public string? FabNavn { get; set; }

    public float? Effekt { get; set; }

    public string? Spænding { get; set; }

    public float? Strøm { get; set; }

    public int? Forsikring { get; set; }

    public int? Tilslutning { get; set; }

    public string? HjælpeFelt { get; set; }

    public string? BeskrivbelseElTilslut { get; set; }

    public string? Beskrivelse { get; set; }
}
